using Eduxapi.Domain.Entities;
using Eduxapi.Domain.Services.Hash;
using Eduxapi.Infra.Context;
using Eduxapi.Infra.Repositories.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Services
{
    public class SignUp
    {
        Eduxcontext con = new Eduxcontext();
        public bool Cadastro(Usuario user)
        {
            var userSearch = con.usuarios.FirstOrDefault(e => e.Nickname == user.Nickname || e.email == user.email);
            if(userSearch != null) return false;

            var newUser = new Usuario();
            newUser.email = user.email;
            newUser.senha = HashAuth.GenerateHash(user.senha,user.email);
            newUser.Nickname = user.Nickname;
            if (user.isAluno)
            {
                newUser.isAluno = true;
                var newAluno = new Aluno();
                newAluno.Nickname = user.Nickname;
                con.alunos.Add(newAluno);
                con.SaveChanges();
            }
            if (user.isProfessor)
            {
                newUser.isProfessor = true;
                var newP = new Professor();
                newP.Nickname = user.Nickname;
                con.professores.Add(newP);
                con.SaveChanges();
            }
            if (user.isInstituicao)
            {
                newUser.isInstituicao = true;
                var newI = new Instituicao();
                newI.Nickname = user.Nickname;
                con.instituicaos.Add(newI);
                con.SaveChanges();
            }
            con.usuarios.Add(newUser);
            con.SaveChanges();
            return true;

            
        }
    }
}
