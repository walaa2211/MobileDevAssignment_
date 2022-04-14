using Mobile3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile3.Views
{
    public class View
    {
        ModelView users = new ModelView();
        public void print()
        {
            ModelView users = new ModelView();

           
                int operationOfUsers = Convert.ToInt32(Console.ReadLine());
                OperationsChoiceOfUser(operationOfUsers);
            }
            void OperationsChoiceOfUser(int operationOfUsers)
            {
                if (operationOfUsers == 1)
                {
                    Console.WriteLine("Enter the number of users you want to add");

                    int numrouter = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numrouter; i++)
                    {
                        users.AddUsers(new User());

                    }
                }
                if (operationOfUsers == 7)
                {
                    Console.WriteLine("Enter the index of users you want to delete");
                    int numrouter = int.Parse(Console.ReadLine());
                    users.RemoveUsersInfo(numrouter);


                }
                if (operationOfUsers == 4)
                {
                    Console.WriteLine("Enter the index of users you want to delete");

                    int numrouter = int.Parse(Console.ReadLine());
                    int id = int.Parse(Console.ReadLine());
                    int age = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    users.UpdateUsersInfo(numrouter, id, age, name);
                }


            }

        }
    }


