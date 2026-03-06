using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prueba22.WEB.Models
{
    [Table("Tareas")]
    public class TareaEntity
    {
        [Key]public int Id { get; set; }
        [Required,StringLength(40)]public string Tarea { get; set; } = "";
        [Required,StringLength(120)]public string Descripcion { get; set; } = "";
        public bool Estatus { get; set; }
        public DateTime? FechaElaboracion { get; set; }
        public DateTime? FechaTerminacion { get; set; }  

    }
}
