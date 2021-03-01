using System;
using Microsoft.EntityFrameworkCore;
using myfirstconection.Data.map;
using myfirstconection.domain;
using myfirstconection.domain.Model;

namespace myfirstconection.Data
{
    public class Contexto : DbContext 
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-KEM6M2PH\\SQLEXPRESS; DataBase=myfirstconection; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new ProfessorMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
