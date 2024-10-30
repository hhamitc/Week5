namespace Week5_06_Final_CarProducing
{
    public class Cars
    {

        public DateTime ProduceDate { get; protected set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public byte DoorCount { get; set; }

        public Cars()
        {
            ProduceDate = DateTime.Now;
        }












    }
}
