using COMP123_S2019_A5_SectionAExample.Models;
using COMP123_S2019_A5_SectionAExample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_SectionAExample
{
    public static class Program
    {
        //static members
        public static StartForm startForm;
        public static SplashForm splashForm;
        public static Selectform selectForm;
        public static ProductinfoForm productInfoForm;
        public static AboutForm aboutForm;
        public static OrderForm orderForm;
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Intialise all forms here

            startForm = new StartForm();
            splashForm = new SplashForm();
            selectForm = new Selectform();
            productInfoForm = new ProductinfoForm();
            aboutForm = new AboutForm();
            orderForm = new OrderForm();
            productInfoForm = new ProductinfoForm();
            product = new Product();

            Application.Run(new Selectform());
        }
    }
}
