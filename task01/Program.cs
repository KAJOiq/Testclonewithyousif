// See https://aka.ms/new-console-template for more information
using static System.Net.WebRequestMethods;

const string USERNAME = "username";
const string PASSWORD = "password";
string username_input = "", password_input = "",otp_input = "",otp_code="";
static string otp_code_generator() {
    string otp_code = "";
    Random rand = new Random();
    for (int i = 0; i < 6; i++)
    {
        otp_code += rand.Next(0,10).ToString();
    }

    Console.WriteLine($"Here is your code: {otp_code}");
    return otp_code;
}
Console.WriteLine("Welcome to the Simple Login System!");
while (true) {
    Console.WriteLine("enter your username :");
     username_input = Console.ReadLine();
    Console.WriteLine("enter your password :");
     password_input = Console.ReadLine();
    if (username_input != "" && password_input != "")
    {
        if (USERNAME == username_input && PASSWORD == password_input)
        {
           otp_code= otp_code_generator();
            Console.WriteLine("enter your otp code please :");
            otp_input = Console.ReadLine();
            if (otp_input != "" && otp_code == otp_input)
            {
                Console.WriteLine("Success! You are logged in.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid OTP.Access denied.");
                Environment.Exit(0);
            }
        }
        else { 
            Console.WriteLine("Invalid username or password. Access denied.");
            Environment.Exit(0);
        }
    }
    else
        Console.WriteLine("Username or password cannot be empty.");
}
