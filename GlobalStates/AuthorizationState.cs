using CPProject.types;

namespace CPProject.GlobalStates
{
    public class AuthorizationState
    {
        private static readonly AuthorizationState instance = new AuthorizationState();
        private AuthorizationState()
        {
            UsersType = EUsersType.Guest;
        }
        public static AuthorizationState Instance
        {
            get
            {
                return instance;
            }
        }
        private EUsersType usersType;
        public EUsersType UsersType
        {
            get
            {
                return usersType;
            }
            private set
            {
                usersType = value;
                OnUserTypeChanged();
            }
        }
        public delegate void UserTypeChange(EUsersType newUserType);
        private event UserTypeChange OnChangeUserType;
        private void OnUserTypeChanged()
        {
            OnChangeUserType?.Invoke(UsersType);
        }
        public void subscribeOnChange(UserTypeChange subscribeEvent)
        {
            OnChangeUserType += subscribeEvent;
        }
        public void unsubscribeOnChange(UserTypeChange sevent)
        {
                OnChangeUserType -= sevent;
        }
        public UserTypeChange subscribe
        {
            set
            {
                OnChangeUserType += value;
            }
            get { return OnChangeUserType; }
        }
        public UserTypeChange unsubscribe
        {
            set
            {
                OnChangeUserType -= value;
            }
            get { return OnChangeUserType; }
        }
        public bool logIn(string username, string password,
            EUsersType wishfulUsersType = EUsersType.Customer)
        {
            if (true)
            {
                if (username == "a")
                {
                    UsersType = EUsersType.Administrator;
                    return true;
                }
                UsersType = wishfulUsersType;
                return true;
            }
            return false;
        }
        public bool logOut()
        {
            UsersType = EUsersType.Guest;
            return true;
        }
    }
}
