using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_TP_Final
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void criar_usuario_btn_Click(object sender, EventArgs e)
        {
            var criar = new FormCriar();
            criar.Show();
        }

        private void gerenciar_btn_Click(object sender, EventArgs e)
        {
            var criar = new FormGerenciar();
            criar.Show();
        }
    }
}
