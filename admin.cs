using System;
using System.Runtime.InteropServices;
using IO;

namespace Admin
{
    class AdminControl
    {
        // MEMBER VARIABLE //
        private string userName = "KHUBAIB";
        private string password = "KHUBAIB";

        // OBJECT //
        InputOutput io = new InputOutput();



        // METHODS AND POPERTY //
        public void adminLogin()
        {
            string username;
            string pass;

            while (true)
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine()!;
                Console.Write("Enter password: ");
                pass = Console.ReadLine()!;

                if (userName == username && password == pass)
                {
                    adminDispalyContent();
                }
                else
                {
                    Console.WriteLine("Wrong Username or password");
                }

                io.check();
            }

        }

        public void adminDispalyContent()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("WELCOME TO UNIVERSITY MANAGEMENT SYSTEM");
                Console.WriteLine("Enter 1 for Studnet Management");
                Console.WriteLine("Enter 2 for Teacher Management");
                Console.WriteLine("Enter 3 for Account Management");
                Console.WriteLine("Enter 0 for Logout");
                choice = Console.ReadLine()!;
                switch (choice)
                {
                    case "0":
                        adminLogin();
                        break;

                    case "1":
                        //code//
                        break;

                    case "2":
                        //code//
                        break;

                    case "3":
                        //code//
                        break;

                    default:
                        Console.WriteLine("Wrong Input Try again");
                        break;
                }
            }
        }


    }
}






