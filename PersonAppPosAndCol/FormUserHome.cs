using PersonAppPosAndCol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppPosAndCol
{
    public partial class FormUserHome : Form
    {
        Person _person;
      
        public FormUserHome(Person person)
        {
            InitializeComponent();
            _person = person;
        }

        private void FormUserHome_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(_person.Color);
        }
    }
}
