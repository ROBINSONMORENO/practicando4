using Microsoft.EntityFrameworkCore;

namespace apppracticando.Models
{
    public class apppracticandoContext : DbContext
    {
     
       public DbSet<Fails> Failss{ get; set;} 
       public  apppracticandoContext(DbContextOptions dco) : base(dco) {

        }  

                              
    }
}