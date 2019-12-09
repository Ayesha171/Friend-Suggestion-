using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mutual_frnds
{
    public partial class Form1 : Form
    {
        int numberOfPerson = -1;
        List<person> personStore = new List<person>();
        public Form1()
        {
            InitializeComponent();
        }
        private List<person>  xyz( person a)
        {
            List<person> test = new List<person>();
            foreach (person x in personStore )
            {
                if (x.Age == a.Age || x.City == a.City || x.Name == a.Name || x.Uni == a.Uni)
                    test.Add(x);
            }
            return test;
        }
    }
}
    
       


