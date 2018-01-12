using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Sdelka". При необходимости она может быть перемещена или удалена.
            this.sdelkaTableAdapter.Fill(this.bondarevDataSet.Sdelka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Usluga". При необходимости она может быть перемещена или удалена.
            this.uslugaTableAdapter.Fill(this.bondarevDataSet.Usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Skidka". При необходимости она может быть перемещена или удалена.
            this.skidkaTableAdapter.Fill(this.bondarevDataSet.Skidka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bondarevDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.bondarevDataSet.Klient);

        }
    }
}
