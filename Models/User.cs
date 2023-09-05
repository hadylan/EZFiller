namespace EZFiller.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "dylan_admin", Password = "Hell0W0rld", Email = "dylan@H.com", Address = "none", Phone = "12345" },
            new UserModel() { Username = "alex_admin", Password = "Hell0W0rld", Email = "alex@P.com", Address = "none", Phone = "12345" },
            new UserModel() { Username = "simon_admin", Password = "Hell0W0rld", Email = "simon@B.com", Address = "none", Phone = "12345" },
        };
    }
}
