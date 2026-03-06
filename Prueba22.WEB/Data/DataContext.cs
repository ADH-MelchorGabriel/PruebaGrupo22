using Microsoft.EntityFrameworkCore;
using Prueba22.WEB.Models;

namespace Prueba22.WEB.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<TareaEntity> Tareas { get; set; }
    }
}
