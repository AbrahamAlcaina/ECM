namespace ECM.Domain.Entities
{
    public class Alias
    {
        public string Name { get; set; }
        public Client Client { get; set; }
        public Partner Partner { get; set; }
    }
}