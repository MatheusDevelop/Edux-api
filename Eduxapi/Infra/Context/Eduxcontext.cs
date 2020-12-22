using Eduxapi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Eduxapi.Infra.Context
{
    public partial class Eduxcontext : DbContext
    {
        public DbSet<AlunoTurma> alunoTurmas { get; set; }
        public DbSet<ProfessorTurma> professorTurmas { get; set; }
        public DbSet<Turma> turmas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Professor> professores { get; set; }
        public DbSet<Aluno> alunos { get; set; }
        public DbSet<AlunoInstituicao> alunoInstituicao { get; set; }
        public DbSet<ProfessorInstituicao> professorInstituicao { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Instituicao> instituicaos { get; set; }
        public DbSet<Objetivo> objetivos { get; set; }
        public DbSet<ObjetivoConcluido> objetivosConcluido { get; set; }
        public DbSet<ObjetivoAtribuido> objetivosAtribuidos { get; set; }
        public DbSet<Segredos> segredos { get; set; }
        public DbSet<SegredoUsuario> segredousuario { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<Curtida> curtidas { get; set; }
        public Eduxcontext()
        {
        }

        public Eduxcontext(DbContextOptions<Eduxcontext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=WILLIAM\\SQLEXPRESS; Initial Catalog= Eduxdata; User Id=sa; Password=sa132");
            }
        }

    }
}
