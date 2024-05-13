using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pOSTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postsDatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'postsDatabaseDataSet.POST' Puede moverla o quitarla según sea necesario.
            this.pOSTTableAdapter.Fill(this.postsDatabaseDataSet.POST);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pOSTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postsDatabaseDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
