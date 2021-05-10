using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamTraining2
{
    public partial class MainManu : Form
    {
        public MainManu()
        {
            InitializeComponent();
            get_Info(listView1);
        }

        private void MainManu_Load(object sender, EventArgs e)
        {

        }
        void get_Info(ListView List)
        {
            listView1.Items.Clear();
        }
        
    }

}
