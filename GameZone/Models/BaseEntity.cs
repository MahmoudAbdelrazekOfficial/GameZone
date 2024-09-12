using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;
    }
}
