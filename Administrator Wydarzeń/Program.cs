using Administrator_Wydarzeń.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator_Wydarzeń
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new View.Form1();
            var model = new Model.EventModel();
            var presenter = new Presenter.MainPresenter(view, model);
            Application.Run(view);
        }
    }
}
