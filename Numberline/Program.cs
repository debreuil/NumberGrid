using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDW.Numberline
{
    class Program
    {
        public static Form1 form;
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            form.Numberline = new Numberline();
            form.ShowDefault();
            Application.Run(form);            
        }
    }
}
