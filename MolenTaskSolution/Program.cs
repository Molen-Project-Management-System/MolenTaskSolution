using MolenTaskSolution.Auth;

namespace MolenTaskSolution
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
            //ApplicationConfiguration.Initialize();
            //Frm_Login login_frm = new Frm_Login();
            //DialogResult dr = login_frm.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
            //    Application.Run(new Frm_Main());
            //}        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}