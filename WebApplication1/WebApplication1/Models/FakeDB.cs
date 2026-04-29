namespace WebApplication1.Models
{
    public class FakeDB
    {
        public List<User> allUser { get; set; }
        public FakeDB()
        {
            allUser = new List<User>()
            {
                new User() {ID = 1, Fname = "Amr", Lname = "Ashraf", Email = "O@gmail.com", Gender = "Male"},
                new User() {ID = 2, Fname = "Amr", Lname = "Ashraf", Email = "O@gmail.com", Gender = "Male"},
                new User() {ID = 3, Fname = "Amr", Lname = "Ashraf", Email = "O@gmail.com", Gender = "Male"}
            };
        }

        public List<User> GetUsers()
        {
            return allUser;
        }

        public void AddUser(User u)
        {
            allUser.Add(u);
        }

        public User GetUserInfo(int id)
        {
            return allUser.SingleOrDefault(a => a.ID == id);
        }

        public void UpdateUserInfo(User UpdatedUser)
        {
            User u = GetUserInfo(UpdatedUser.ID);
            u.Fname= UpdatedUser.Fname;
            u.Lname= UpdatedUser.Lname;
            u.Email= UpdatedUser.Email;
            u.Gender= UpdatedUser.Gender;
        }

        public void DeleteUser(User u)
        {
            allUser.Remove(GetUserInfo(u.ID));
        }
    }
}
