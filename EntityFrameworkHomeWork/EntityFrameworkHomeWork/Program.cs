using System;


namespace EntityFrameworkHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            int UserAnswer;
            do
            {
                methods.MainMenu();
                UserAnswer = Convert.ToInt32(Console.ReadLine());
                methods.directToAction(UserAnswer);

            } while (UserAnswer!=5);
            return;
        }
        
    }
}
