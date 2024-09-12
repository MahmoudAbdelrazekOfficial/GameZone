namespace GameZone.Models
{
    public class GameDevice
    {
        public int GameId { get; set; }

        //Navigation Prop
        public Game Game { get; set; } = default!;
        

        public int DeviceId { get; set; }

        //Navigation Prop
        public Device Device { get; set; } = default!;


    }
}
