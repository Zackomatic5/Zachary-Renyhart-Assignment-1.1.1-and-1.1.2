namespace Zachary_Renyhart_Assignment_4._1._1_WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            var personName = new Dictionary<string, Person>();
            {
                { new Person { FirstName = "Zack", LastName = "Renyhart", MobilePhone = "9803280987", WorkPhone = "7048217846", Address = "2001 Bridleside Drive"}; }


            }
            
                
            
        }
    }
}