namespace OOPFinalProrect
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
         
            bool createdNew = false;
            using (var mutex = new System.Threading.Mutex(true, "OOPFinalProrect_Singleton_Mutex", out createdNew))
            {
                if (!createdNew)
                {
                    
                    MessageBox.Show("Another instance is already running.", "Already running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                 https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        }
    }
}