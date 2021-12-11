using System.ComponentModel.DataAnnotations.Schema;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    [Table("Photos")]
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
   
    }
}