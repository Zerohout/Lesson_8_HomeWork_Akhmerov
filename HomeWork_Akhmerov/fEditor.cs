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
    public partial class fEditor : Form
    {
        private DataBase dataBase;
        public fEditor()
        {
            InitializeComponent();
        }

        private void tsmNew_Click(object sender, EventArgs e) // Новый
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new DataBase(sfd.FileName);
                dataBase.Add("Правда ли, что это самый первый создаваемый вопрос редакторе?", true);
                dataBase.Save();
                nudNumQuest.Minimum = 1;
                nudNumQuest.Maximum = 1;
                nudNumQuest.Value = 1;
            }
        }

        private void tsmSave_Click(object sender, EventArgs e) // Сохранить
        {
            dataBase.Save();
        }

        private void tsmLoad_Click(object sender, EventArgs e) // Загрузить
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dataBase = new DataBase(ofd.FileName);
                dataBase.GetList = dataBase.Load();
            }

            nudNumQuest.Minimum = 1;
            nudNumQuest.Maximum = dataBase.Count;
            nudNumQuest.Value = 1;
        }

        private void tsmExit_Click(object sender, EventArgs e) // Выход
        {


            if (MessageBox.Show("Сохранить данные перед выходом?", "Sepo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                dataBase.Save();
            }

            var fm = new fMain();
            Hide();
            fm.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e) // Новый
        {
            if (dataBase == null)
            {
                MessageBox.Show("Создайте новый файл", "Sepo");
                return;
            }
            tbQuestions.Clear();
            nudNumQuest.Maximum = dataBase.Count + 1;
            nudNumQuest.Value = dataBase.Count + 1;
        }

        private void btnSave_Click(object sender, EventArgs e) // Добавить
        {
            if (dataBase == null)
            {
                MessageBox.Show("Создайте новый файл", "Sepo");
                return;
            }

            if (tbQuestions.Text.Length == 0)
            {
                MessageBox.Show("Введите вопрос.", "Sepo");
            }
            else
            {
                dataBase[(int)nudNumQuest.Value - 1].Text = tbQuestions.Text;
                dataBase[(int)nudNumQuest.Value - 1].IsTrue = cbIsTrue.Checked;
            }
        }

        private void nudNumQuest_ValueChanged(object sender, EventArgs e) // Изменение счетчика
        {
            var elem = new Questions();

            if (dataBase == null)
            {
                nudNumQuest.Value = 1;
                return;
            }

            if (dataBase.Count < nudNumQuest.Value)
            {
                dataBase.Add("", false);
            }
            else
            {
                elem = dataBase[(int)nudNumQuest.Value - 1];
                tbQuestions.Text = elem.Text;
                cbIsTrue.Checked = elem.IsTrue;
            }


        }

        private void btnRemove_Click(object sender, EventArgs e) // Удалить
        {
            if (nudNumQuest.Maximum == 1 || dataBase == null)
            {
                MessageBox.Show("Нельзя удалить единственный оставшийся вопрос", "Sepo");
                return;
            }

            if (tbQuestions.Text.Length == 0)
            {
                nudNumQuest.Value = nudNumQuest.Value - 1;
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить вопрос?", "Sepo", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                dataBase.Remove((int)nudNumQuest.Value);
                tbQuestions.Clear();

                if (nudNumQuest.Value == dataBase.Count)
                {
                    var elem = dataBase[(int)nudNumQuest.Value - 1];
                    tbQuestions.Text = elem.Text;
                    cbIsTrue.Checked = elem.IsTrue;
                }
                else
                {
                    nudNumQuest.Value = dataBase.Count;
                }
            }
            else
            {
                return;
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа создана Ахмеровым Фаритом,\nпри содействии учителя портала GeekBrains Антона Другова.\nВсе права (надеюсь) сохранены.",
                "Sepo");
        }
    }
}
