using System;

namespace Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            IConnection connection = new MySQLConnection();
            PasswordReminder reminder = new PasswordReminder(connection);
        }
    }
}
