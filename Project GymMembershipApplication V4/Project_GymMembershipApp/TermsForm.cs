using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GymMembershipApp
{
    public partial class TermsForm : Form
    {
        /// <summary>
        /// New terms object
        /// </summary>
        private Terms trm = new Terms();
        /// <summary>
        /// Initialize
        /// </summary>
        public TermsForm()
        {
            InitializeComponent();
            InitializeTermsText();
        }
        /// <summary>
        /// Put terms text in label
        /// </summary>
        private void InitializeTermsText()
        {
            lblTermsOut.Text = trm.TermsOut;
        }
        /// <summary>
        /// Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Print document method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.BudgetGymLogo;
            Image newImage = bmp;

            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(lblTermsOut.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100,100));

        }
        /// <summary>
        /// Print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
