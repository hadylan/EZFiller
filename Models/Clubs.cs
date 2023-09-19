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
            new ClubsModel() { Clubname = "dylan_admin", Country = "Hell0W0rld", League = "dylan@H.com" },
            new ClubsModel() { Clubname = "alex_admin", Country = "Hell0W0rld", League = "alex@P.com" },
            new ClubsModel() { Clubname = "simon_admin", Country = "Hell0W0rld", League = "simon@B.com" },
        };
    }
}
