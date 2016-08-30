using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        private object openFileDialog;
     
        public Form1()
        {
            InitializeComponent();
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog t_data = new OpenFileDialog();
            t_data.Title = "Enter Your Treaining Data";
            t_data.InitialDirectory = @"c:\";
            t_data.Filter = "CSV Documents (.csv)|*.csv|TSV Documents (.tsv)|*.tsv";
            t_data.FilterIndex = 2;
            t_data.RestoreDirectory = true;
            if (t_data.ShowDialog() == DialogResult.OK)
            {
                training_data.Text = t_data.FileName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void predict_CheckedChanged(object sender, EventArgs e)
        {
            if (predict.Checked == true)
            {
                test_data.Visible = true;
                button2.Visible = true;
            }
            else {
                test_data.Visible = false;
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog tst_data = new OpenFileDialog();
            tst_data.Title = "Enter Your Test Data";
            tst_data.InitialDirectory = @"c:\";
            tst_data.Filter = "CSV Documents (.csv)|*.csv|TSV Documents (.tsv)|*.tsv";
            tst_data.FilterIndex = 2;
            tst_data.RestoreDirectory = true;
            if (tst_data.ShowDialog() == DialogResult.OK)
            {
                test_data.Text = tst_data.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void discrete_CheckedChanged(object sender, EventArgs e)
        {
            if (discrete.Checked == true)
            {
                binary.Visible = true;
                multi_class.Visible = true;
            }
            else {
                binary.Visible = false;
                multi_class.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var trng_data = training_data.Text;
            Form2 secondform = new Form2(trng_data);
            secondform.Show();
        }

        private void training_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
