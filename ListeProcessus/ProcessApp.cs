using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeProcessus

{
    public partial class ProcessApp : Form
    {


        public ProcessApp()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProcess();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ShowProcess();
        }

        private void ShowProcess()
        {
            listView1.Items.Clear(); //nettoyer la list d'item
            var process = Process.GetProcesses();
            foreach (var p in process)
            {
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    p.Id.ToString(),
                    p.ProcessName
                }
                ));
            }
        }

        private void btnActualiser_MouseEnter(object sender, EventArgs e)
        {
            btnActualiser.ForeColor = Color.Red;
        }

        private void btnActualiser_MouseLeave(object sender, EventArgs e)
        {
            btnActualiser.ForeColor = Color.Black ;
        }

        //S'active quand on change d'index
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //S'active au double click sur une ligne
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                //On cherche le process et une fois trouvé il est kill
                var finded = Process.GetProcessById(int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                if(finded != null)
                {
                    finded.Kill();
                    Thread.Sleep(500);
                    ShowProcess();
                }

            }
        }
         
        private void btnCount_MouseEnter(object sender, EventArgs e)
        {
            btnCount.ForeColor = Color.Red;
        }

        private void btnCount_MouseLeave(object sender, EventArgs e)
        {
            btnCount.ForeColor = Color.Black;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.Items.Count.ToString());
        }

        private void tbRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            FilterProcesses(tbRecherche.Text);
        }

        private void FilterProcesses(string filterText)
        {
            listView1.Items.Clear();
            var processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                if (p.ProcessName.ToLower().Contains(filterText.ToLower()) || p.Id.ToString().Contains(filterText))
                {
                    listView1.Items.Add(new ListViewItem(new string[] { p.Id.ToString(), p.ProcessName }));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRecherche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
