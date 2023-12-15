using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model();
            Controller controller = new Controller();
            TaskManager view = new TaskManager();

            view.Controller = controller;
            model.Controller = controller;

            controller.View = view;
            controller.Model = model;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TaskManager());
        }
    }
}
