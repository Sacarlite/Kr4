
using Autofac;
using Kr4.Presenter;


namespace Kr4
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
            AutofacManager.RegisterDependencies();
            using (var scope = AutofacManager.Container!.BeginLifetimeScope())
            {
                var mainPresenter = scope.Resolve<MainPresenter>();
                mainPresenter.OpenMainForm();
            }
           
               


        }
    }
}