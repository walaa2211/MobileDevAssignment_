using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mobile3.Model
{
    // I have a user which have (id, name, age)
    public class User :Object
    {
        public int id, age;
        public string name;
        public delegate void DispalyUserDel(string type);

        public DispalyUserDel _DispalyUserDel;
        private int userId;
        private int userAge;
        private string userName;

        public User()
        {
            id = 0;
            name = "";
            age = 0;

        }
        public User(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public User(int userId, int userAge, string userName)
        {
            this.userId = userId;
            this.userAge = userAge;
            this.userName = userName;
        }

        public int Id
        {
            get 
            { 
                return id; 
            }
            set 
            { 
                id = value;
            }
        }
        public int Age
        {
            get
            { 
                 return age;
            }
            set 
            { 
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name; 
            }
            set 
            { 
                name = value;
            }
        }
        public override string ToString()
        {
            return $"id:{ this.id } - name:{this.name} - age:{this.age}";
        }
        public override bool Equals(object Ob)
        {
            if (!(Ob is User))
            {
                return false;
            }
            if (Ob == null)
            {
                return false;
            }

            return
                (this.id == ((User)Ob).id)
                && (this.name == ((User)Ob).name)
                && (this.age == ((User)Ob).age);
        }



    }


}
