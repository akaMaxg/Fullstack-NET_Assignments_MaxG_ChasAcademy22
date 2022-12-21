using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack_NET_MaxG_ChasAcademy22
{
    public class Workshop11_Login
    {
        public static void Login()
        {
            {
                Console.WriteLine("Welcome to the mock-bank Program!"); //Greetings

                User user1 = new User("Franke", "password1"); //New instances of user with 2 parameters username/password
                User user2 = new User("Gilgamesh", "password2");
                bool runProgram = true; //Runs program until exited by user

                while (runProgram)
                {

                    // Prompt the user to log in
                    Console.WriteLine("Please log in to continue.");
                    Console.Write("Username: ");
                    string username = Console.ReadLine().ToLower(); //Ensures name is not case-sensative
                    Console.Write("Password: ");
                    string password = Console.ReadLine(); //Password remains case-sensative

                    // Check if the username and password match one of the users
                    User currentUser = null; //Declare a variable of type User to be able to set a specific user to context
                    if (user1.username == username && user1.password == password) //Check to see which user logged in and sets it as the current user
                    {
                        currentUser = user1;
                    }
                    else if (user2.username == username && user2.password == password)
                    {
                        currentUser = user2;
                    }
                    else
                    {
                        Console.WriteLine("Login not successfull. Please try again."); //If no match
                    }

                    string usernameFirst = currentUser.username[0].ToString(); //Extracts first character of name
                    usernameFirst = usernameFirst.ToUpper(); //Makes it uppcase


                    // If the login is successful, present the user with a menu
                    if (currentUser != null)
                    {
                        Console.WriteLine("Login succeeded. Welcome, " + usernameFirst + currentUser.username.Substring(1) + "."); //Presents the name with a capital first letter
                        Console.WriteLine("Please choose an option from the menu below:"); //Presents the menu
                        Console.WriteLine("1. Change password");
                        Console.WriteLine("2. Log out");

                        // Read the user's menu selection
                        int menuOption = int.Parse(Console.ReadLine());

                        // Handle the user's menu selection
                        switch (menuOption)
                        {
                            case 1: //New password
                                Console.Write("Enter your new password: ");
                                string newPassword = Console.ReadLine(); //Accepts new password
                                currentUser.password = newPassword; //Sets it to the current users password
                                Console.WriteLine("Password changed.");
                                break;
                            case 2: //Logging out
                                Console.WriteLine("Logging out: " + usernameFirst + currentUser.username.Substring(1) + "."); //Farewell message
                                runProgram = false; //sets bool to false and exists while loop
                                break;
                        }
                    }
                }
            }
        }
        public class User  // Define the User class with 2 properties: a username and password
        {
            public string username { get; set; }
            public string password { get; set; }

            public User(string username, string password) //Constructor that takes two parameters.
            {
                this.username = username;
                this.password = password;
            }
        }
    }
}

