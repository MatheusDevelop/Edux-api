using Eduxapi.Domain.Entities;
using Eduxapi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduxapi.Domain.Services
{
    public class RankAtt
    {
        Eduxcontext con = new Eduxcontext();
        public void RankAt(Guid id)
        {
            var notaCount = con.objetivosConcluido.Where(e => e.aluno.alunoid == id && e.nota == 10).Count();
            var objetivoCount = con.objetivosConcluido.Where(e => e.aluno.alunoid == id).Count();

            var searchRank = con.Rank.FirstOrDefault(e => e.alunoid == id);
            if (searchRank != null)
            {
                searchRank.pontos = notaCount + objetivoCount;
                con.Rank.Update(searchRank);
                con.SaveChanges();
            }
            else
            {
                var newRank = new Rank();
                newRank.pontos = notaCount + objetivoCount;
                newRank.alunoid = id;
                con.Rank.Add(newRank);
                con.SaveChanges();
            }

        }
    }
}
