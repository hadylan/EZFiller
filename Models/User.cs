namespace EZFiller.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Name = "Smith", FirstName = "John", Email = "john@example.com", Address = "123 Main St, Cityville", Phone = "555-1234" },
            new UserModel() { Name = "Johnson", FirstName = "Emily", Email = "emily@example.com", Address = "456 Elm St, Townsville", Phone = "555-5678" },
            new UserModel() { Name = "Williams", FirstName = "Michael", Email = "michael@example.com", Address = "789 Oak St, Villagetown", Phone = "555-9876" },
        };
    }
}
