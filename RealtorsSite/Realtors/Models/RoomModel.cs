namespace Realtors.Models
{
    public class RoomModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressArea { get; set; }
        public long? CountRooms { get; set; }
        public long? FooterCountHome { get; set; }
        public double? FooterMeters { get; set; }
        public long? FooterNumber { get; set; }
        public decimal? Price { get; set; }
        public string[] Image { get; set; }
        public string Description { get; set; }


        public long? TabNumber { get; set; }
    }
}