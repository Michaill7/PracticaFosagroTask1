using PracticaFosagroTask1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFosagroTask1
{
    public partial class Form1 : Form
    {
        private List<String> DetailsList = new List<string>() { "Квадрат", "Круг" };
        public Form1()
        {
            InitializeComponent();
            DetailsListBox.DataSource = DetailsList;
        }

        private void ChoseButton_Click(object sender, EventArgs e)
        {
            if (DetailsListBox.SelectedItem.ToString() == "Квадрат") 
            {
                var Form = new RectangleWindow();
                Form.Show();
            }
        }
    }
}
