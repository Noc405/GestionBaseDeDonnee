using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_base_de_donnée
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //View
            ViewConnexion aView = new ViewConnexion();

            //Model
            Model aModel = new Model();

            //Controler
            Controler aControler = new Controler(aView, aModel);

            Application.Run(aView);
        }
    }
}
