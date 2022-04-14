using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3.Model
{
    public class AdminUser : User
    {

        private List<StaffUser> StaffUserList;
        public delegate void DisplayAdminDel(string type);

        public DisplayAdminDel _DisplayAdminDel;
        private int userId;
        private int userAge;
        private string userName;
        private List<StaffUser> listOfStaff;

        public AdminUser()
        {
            id = 0;
            name = "";

            age = 0;      
                StaffUserList = new List<StaffUser>();
        }
        public AdminUser(int id, string name, int age, List<StaffUser> StaffUserList)
        {
            this.id = id;
            this.name = name;

            this.age = age;
                this.StaffUserList = StaffUserList;
        }

        public AdminUser(int userId, int userAge, string userName, List<StaffUser> listOfStaff)
        {
            this.userId = userId;
            this.userAge = userAge;
            this.userName = userName;
            this.listOfStaff = listOfStaff;
        }

        public List<StaffUser> staffUserList
        {
            get 
            { 
                return StaffUserList; 
            }
            set { 
                StaffUserList = value;
            }
        }
        public override string ToString()
        {
            string StaffUsersList = "List of staff : \n";
            for (int i = 0; i < StaffUserList.Count; i++)
            {
                StaffUsersList += 
                    $"staff {i + 1}: " 
                    +
                    StaffUserList[i].ToString();
            }
            return 
                " Name:" + name + 
                " Age:" + age +
                "  Id:" + id 
                + StaffUsersList ;
        }
       
        public override bool Equals(Object Obj)
        {
            if (Obj == null || GetType() != Obj.GetType())
                return false;

            AdminUser adminUser = (AdminUser)Obj;
            if (adminUser != Obj)
                return false;

            return
                (name == adminUser.name) && 
                (age == adminUser.age) && 
                (id == adminUser.id) && 
                isEqualLists(staffUserList, adminUser.StaffUserList);
        }

        private bool isEqualLists(List<StaffUser> listOfStaffUser1, List<StaffUser> listOfStaffUser2)
        {
            throw new NotImplementedException();
        }
    }

}