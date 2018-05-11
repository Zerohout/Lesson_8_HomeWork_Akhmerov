using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Akhmerov
{
    public partial class fMain : Form
    {
        private DataBase dataBase;
        public fMain()
        {
            InitializeComponent();
        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new DataBase(sfd.FileName);
                dataBase.Add("Правда ли, что это самый первый вопрос в этом редакторе?", true);
                dataBase.Save();
                nudNumQuest.Minimum = 1;
                nudNumQuest.Maximum = 1;
                nudNumQuest.Value = 1;
            }
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            dataBase.Save();
        }

        private void tsmLoad_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new DataBase(sfd.FileName);
            }

            nudNumQuest.Minimum = 1;
            nudNumQuest.Maximum = dataBase.Count;
            nudNumQuest.Value = 1;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Сохранить данные перед выходом?", "Sepo", MessageBoxButtons.YesNo).;
            
            var sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            Application.Exit();
        }
    }
}
