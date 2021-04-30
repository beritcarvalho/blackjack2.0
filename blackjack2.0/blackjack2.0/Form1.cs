using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace blackjack2._0
{
    public partial class Form1 : Form
    {
        Thread varThread;   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.Close();
            varThread = new Thread(novoForm);
            varThread.SetApartmentState(ApartmentState.STA);
            varThread.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }
    }   
}
