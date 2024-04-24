using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialogCargo.ShowDialog() == DialogResult.OK)
            {
                CargoRepository.Path = openFileDialogCargo.FileName;
                dataGridViewCargo.DataSource = CargoRepository.FindAll();
                Text = $"Cargo - {openFileDialogCargo.FileName}";
            }
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo()
            {
                Date = DateTime.Parse(textBoxDate.Text),
                DeparturePlanet = textBoxDeparture.Text,
                Destination = textBoxDestination.Text,
                Goods = comboBoxGoods.Text,
                Quantity = int.Parse(textBoxQuantity.Text)
            };

            CargoRepository.Save(cargo);
            dataGridViewCargo.DataSource = CargoRepository.FindAll();
            MessageBox.Show("Új objektum hozzáadva");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGoods.Text = "Nyersanyagok";
        }
    }
}
