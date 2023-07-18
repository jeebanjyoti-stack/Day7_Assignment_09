using System;


namespace Assignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Name;
                string Email;
                string Password;
                Console.WriteLine("Enter Your Name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Your Email: ");
                Email = Console.ReadLine();
                Console.WriteLine("Enter Your Password: ");
                Password = Console.ReadLine();

                if (Name.Length < 6)
                {
                    throw new ValidationException("Name must have at least 6 characters");
                }
                else if (Password.Length < 8)
                {
                    throw new ValidationException("Password must have at least 8 character ");
                }
                else
                {
                    Console.WriteLine("User Registration Success");
                    Console.WriteLine($"Name: {Name} \nEmail: {Email} \nPassword: {Password}");
                }
            }
            catch (ValidationException ve)
            {
                Console.WriteLine("Validation Exception!! " + ve.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("***  End of Registration  ***");
                Console.ReadKey();
            }
        }
    }
}