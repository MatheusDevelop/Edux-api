using Eduxapi.Domain.Entities;
using Eduxapi.Domain.Services.Hash;
using Eduxapi.Infra.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Services
{
    public class LoginService
    {
        Eduxcontext con = new Eduxcontext();

        private IConfiguration _config;
        public LoginService(IConfiguration config)
        {
            _config = config;
        }
        RankAtt rank = new RankAtt();



        public dynamic Login(Usuario user)
        {
            user.senha = HashAuth.GenerateHash(user.senha, user.email);
            var searchUser = con.usuarios.FirstOrDefault(e => e.email == user.email && e.senha == user.senha);

            if (searchUser == null) return false;

            if (searchUser.isAluno)
            {
                var userSearch =con.alunos.FirstOrDefault(e => e.Nickname == searchUser.Nickname);
                rank.RankAt(userSearch.id);
                return GenerateJSONWebToken(userSearch.id,searchUser.id, "Aluno",userSearch.Nickname);
            }
            if (searchUser.isProfessor)
            {
                var userSearch =  con.professores.FirstOrDefault(e => e.Nickname == searchUser.Nickname);
                return GenerateJSONWebToken(userSearch.id,searchUser.id, "Professor",userSearch.Nickname);
            }
            if (searchUser.isInstituicao)
            {
                var userSearch= con.instituicaos.FirstOrDefault(e => e.Nickname == searchUser.Nickname);
                return GenerateJSONWebToken(userSearch.id,searchUser.id, "Instituicao",userSearch.Nickname);
            }

            return true;
        }

        private string GenerateJSONWebToken(Guid id,Guid idUser,string role,string nome)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            
            var claims = new[] {                
                new Claim(JwtRegisteredClaimNames.NameId, id.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, idUser.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName,nome),
                new Claim(JwtRegisteredClaimNames.GivenName, role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(ClaimTypes.Role, role)
            };
            

            var token = new JwtSecurityToken
                (
                    _config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
