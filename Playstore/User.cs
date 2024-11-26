using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    public class User:IUser
    {
        // class Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
        private int UserKey { get; set; } = 123;

        public void AddUser()
        {
            throw new NotImplementedException();
        }

        //Functions
        //Syntax: public return/no-return-type or MethodName() { }
        public void CreateUser()
        {
            Console.WriteLine("User Key" + UserKey);
            Console.WriteLine("User Registraion");
            // How to read input from keyboard
            //Name = "Raj";//we can assign names like this also
            Console.Write("Enter name: ");
            Name = Console.ReadLine(); //read input
            Console.Write("Enter mobile: ");
            Mobile = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome," + Name);
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
