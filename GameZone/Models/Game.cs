namespace GameZone.Models
{
    public class Game : BaseEntity
    {
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Cover { get; set; } = string.Empty;


        public int CategoryId { get; set; }
        //Navigation Prop
        public Category Category { get; set; } = default!;
        
        //Relation GameDevices
        public ICollection<GameDevice> Devices { get; set; } = new List<GameDevice>();
    }
}
