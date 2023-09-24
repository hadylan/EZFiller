namespace EZFiller.Models
{
    public class ClubsModel
    {
        public long Id { get; set; }
        public string Clubname { get; set; }
        public string Country { get; set; }
        public string League { get; set; }
    }

    public class ClubsConstants
    {
        public static List<ClubsModel> Users = new List<ClubsModel>()
        {
            new ClubsModel() { Clubname = "Toulouse FC", Country = "France", League = "L1" },
            new ClubsModel() { Clubname = "Olympique de Marseille ", Country = "France", League = "L1" },
            new ClubsModel() { Clubname = "Paris Saint-Germain", Country = "France", League = "L1" },
        };
    }
}
