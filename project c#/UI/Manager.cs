using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public enum Type{ Customers,Products ,Sales};
    public partial class Manager : Form
    {
        public Type type;
        public Manager(Type type)
        { 
            this.type = type;
            InitializeComponent();


        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
