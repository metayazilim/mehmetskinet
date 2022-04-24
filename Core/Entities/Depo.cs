using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Depo
    {
        [Key]
        public Guid dep_Guid { get; set; }
   
        public string dep_adi { get; set; }
    }
}