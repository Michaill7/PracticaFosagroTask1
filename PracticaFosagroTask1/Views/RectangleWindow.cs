using PracticaFosagroTask1.Model;
using System;
using System.Windows.Forms;

namespace PracticaFosagroTask1.Views
{
    public partial class RectangleWindow : Form
    {
        public RectangleWindow()
        {
            InitializeComponent();
        }

        private void AddRectangle_Click(object sender, EventArgs e)
        {
            ObjectLists.RectangleList.Add
                (
                    new Rectangle
                    (
                        Convert.ToDouble(RecA.Text),
                        Convert.ToDouble(RecB.Text),
                        Convert.ToDouble(RecH.Text),
                        Convert.ToDouble(RecA.Text) * Convert.ToDouble(RecB.Text) * Convert.ToDouble(RecH.Text)
                    )
                );
            MessageBox.Show(ObjectLists.RectangleList[0].V.ToString());
        }
    }
}
