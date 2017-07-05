using Consultorio.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio.View.Lista
{
    public partial class ListaProntuario : Form
    {
        public ListaProntuario()
        {
            InitializeComponent();
        }

        private void ListaProntuario_Load(object sender, EventArgs e)
        {
            objectListView1.SetObjects(ProntuarioController.ProntuarioC.Prontuarios);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
