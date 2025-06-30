using Microsoft.EntityFrameworkCore;
using MusicSchool.Domain.Entities;

namespace MusicSchool.Infrastructure.Context
{
    public class MusicSchoolDbContext : DbContext
    {
        public MusicSchoolDbContext(DbContextOptions<MusicSchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<AlumnoProfesor> AlumnoProfesores { get; set; }
        public DbSet<AlumnoEscuela> AlumnoEscuelas { get; set; }
        public DbSet<ProfesorEscuela> ProfesorEscuelas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración opcional si usas relaciones explícitas
            modelBuilder.Entity<Escuela>().ToTable("Escuelas");
            modelBuilder.Entity<Alumno>().ToTable("Alumnos");
            modelBuilder.Entity<Profesor>().ToTable("Profesores");

            modelBuilder.Entity<AlumnoProfesor>()
                .HasKey(ap => new { ap.AlumnoId, ap.ProfesorId });

            modelBuilder.Entity<AlumnoEscuela>()
                .HasKey(ae => new { ae.AlumnoId, ae.EscuelaId });

            modelBuilder.Entity<ProfesorEscuela>()
                .HasKey(pe => new { pe.ProfesorId, pe.EscuelaId });

        }
    }
}
