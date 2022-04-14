using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3.Model
{
    public class StaffUser : User
    {
        public enum Role { firstRole, secondRole, thirdRole };
        public delegate void PrintStaffDel(string type);

        public PrintStaffDel _PrintStaffDel;
        private int userId;
        private int userAge;
        private string userName;

        public StaffUser()
        {
            id = 0;
            name = "";
            age = 0;

        }
        public StaffUser(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;

        }

        public StaffUser(int userId, int userAge, string userName)
        {
            this.userId = userId;
            this.userAge = userAge;
            this.userName = userName;
        }

        public Role _Role
        {
            get { return _Role; }
            set { _Role = value; }
        }
        public override string ToString()
        {
            return " Id:" + id + " Name:" + name + "  Age:" + age
            + "  User Roles = {" + Role.firstRole + "," + Role.secondRole + "," + Role.thirdRole + " }";
        }
        public override bool Equals(Object obj)
        {
            if (GetType() != obj.GetType() || obj == null)
                return false;

            StaffUser _StaffUser = (StaffUser)obj;
            //هون بدي اشوف اذا الاوبجكت المحدد بساوي الاوبجكت اللي انا هلأ عنده ولا لا؟ 
            if ( _StaffUser != obj)
            {
                return false;
            }
            else
            {
                return (name == _StaffUser.name) && (age == _StaffUser.age) && (id == _StaffUser.id) && (_Role == _StaffUser._Role);
            }
        }


    }

}