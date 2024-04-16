namespace MeetingApp.Models{
    public static class Repository {
        private static List<UserInfo> _users = new();


        static Repository() {
            _users.Add(new UserInfo() {Id = 1, Name = "Çağdaş", Email = "cagdas@cagdas.com", Phone = "111111", WillAttend = true});
            _users.Add(new UserInfo() {Id = 2, Name = "Çağatay", Email = "cagatay@cagatay.com", Phone = "222222", WillAttend = false});
            _users.Add(new UserInfo() {Id = 3, Name = "Umut", Email = "umut@umut.com", Phone = "333333", WillAttend = true});
        }


        public static List<UserInfo> Users { 
            get {
                return _users;
            }
        }


        public static void AddUser(UserInfo user) {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }


        public static UserInfo? GetById(int id) {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}