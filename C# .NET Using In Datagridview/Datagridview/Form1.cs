using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Datagridview
{
    public partial class Form1 : Form
    {

        public OleDbConnection conn { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'depDataSet.dep' table. You can move, or remove it, as needed.
            this.depTableAdapter.Fill(this.depDataSet.dep);

        }

     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         try
    {
        depTableAdapter.Insert(
            int.Parse(textBox1.Text),   // did
            textBox2.Text,              // dname
            textBox3.Text               // djob
        );

        // Refresh DataGridView
        depTableAdapter.Fill(depDataSet.Dep);

        MessageBox.Show("Record Inserted Successfully!");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Insert Error: " + ex.Message);
    }
   }

  }
}

    
    


       
      

