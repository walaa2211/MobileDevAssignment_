using Mobile3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3
{
    public class ModelView
    {

        private List<User> UsersList;
        private List<StaffUser> StaffsList;
        private List<AdminUser> AdminsList;
        public ModelView()
        {
            UsersList = new List<User>();
            StaffsList = new List<StaffUser>();
            AdminsList = new List<AdminUser>();
        }

        public List<User> _UsersList
        {
            get
            {
                return UsersList;
            }
            set
            {
                UsersList = value;
            }
        }
        public List<StaffUser> _StaffsList
        {
            get
            {
                return StaffsList;
            }
            set
            {
                StaffsList = value;
            }
        }

        internal void AddUsers(User user)
        {
            throw new NotImplementedException();
        }

        public List<AdminUser> _AdminsList
        {
            get
            {
                return AdminsList;
            }
            set
            {
                AdminsList = value;
            }
        }

        internal void RemoveUsersInfo(int numrouter)
        {
            throw new NotImplementedException();
        }

        public List<User> _User = null;
        public List<StaffUser> _StaffUser = null;
        public List<AdminUser> _AdminUser = null;

        public void AddUsers(string userType, int userId, string userName, int userAge, List<StaffUser> listOfStaff)
        {
            if (userType == "user")
            {
                UsersList.Add(new User(userId, userAge, userName));
            }
            else if (userType == "staff")
            {
                StaffsList.Add(new StaffUser(userId, userAge, userName));
            }
            else if (userType == "admin")
            {
                AdminsList.Add(new AdminUser(userId, userAge, userName, listOfStaff));
            }

        }

        internal void UpdateUsersInfo(int numrouter, int id, int age, string? name)
        {
            throw new NotImplementedException();
        }

        public void UpdateUsersInfo(string userType, int userId, User user, StaffUser staffUser, AdminUser adminUser)
        {
            if (userType == "user")
            {
                for (int i = 0; i < UsersList.Count; i++)
                {
                    if (UsersList[i].Id == userId)
                    {
                        UsersList[i] = user;
                    }
                }
            }
            else if (userType == "staff")
            {
                for (int i = 0; i < StaffsList.Count; i++)
                {
                    if (StaffsList[i].Id == userId)
                    {
                        StaffsList[i] = staffUser;
                    }
                }
            }
            else if (userType == "admin")
            {
                for (int i = 0; i < AdminsList.Count; i++)
                {
                    if (AdminsList[i].Id == userId)
                    {
                        AdminsList[i] = adminUser;
                    }
                }
            }
        }


        public void RemoveUsersInfo(string userType, int userId)
        {
            if (userType == "user")
            {
                for (int i = 0; i < UsersList.Count; i++)
                {
                    if (UsersList[i].Id == userId)
                    {
                        UsersList.RemoveAt(i);
                    }
                }
            }
            else if (userType == "staff")
            {
                for (int i = 0; i < StaffsList.Count; i++)
                {
                    if (StaffsList[i].Id == userId)
                    {
                        StaffsList.RemoveAt(i);
                    }
                }
            }
            else if (userType == "admin")
            {
                for (int i = 0; i < AdminsList.Count; i++)
                {
                    if (AdminsList[i].Id == userId)
                    {
                        AdminsList.RemoveAt(i);
                    }
                }
            }
        }
    }
}

