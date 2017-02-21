using System;
using System.Text;
using System.Windows.Forms;

namespace PCBConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new UI());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
