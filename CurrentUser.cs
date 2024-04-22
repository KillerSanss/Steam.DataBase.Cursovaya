using steam.Infrastructure.Entities;

namespace steam
{
    public static class CurrentUser
    {
        public static User LoggedInUser { get; private set; }

        public static void Login(User user)
        {
            LoggedInUser = user;
        }

        public static void Logout()
        {
            LoggedInUser = null;
        }
    }
}
