namespace EZFiller.Models
{
    public class PlayersModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
    }

    public class PlayersConstants
    {
        public static List<PlayersModel> Users = new List<PlayersModel>()
        {
            new PlayersModel() { Id = 1, Name = "Marcus Rashford", Country = "England", Team = "Manchester United", Position = "Stricker" },
            new PlayersModel() { Id = 2, Name = "Jadon Sancho", Country = "England", Team = "Manchester United", Position = "LW" },
        };
    }
}
