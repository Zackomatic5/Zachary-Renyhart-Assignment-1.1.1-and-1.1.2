namespace Zachary_Renyhart_Assignment_4._2
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        //This is the MAIN METHOD!!! (Global Scope)
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
        //This must be outside the main method
        //This is creating a student list named "StudentList" I can use to hoild the "newStudent" values!!
        internal static List<Student> StudentList = new List<Student>();
    }
}