using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace _3ilApi.Models
{
    public class EtudiantContext:DbContext
    {
        public EtudiantContext(DbContextOptions<EtudiantContext> options)
           : base(options)
        {
        }

        public DbSet<Etudiant> Etudiants { get; set; } = null!;
    }
}
