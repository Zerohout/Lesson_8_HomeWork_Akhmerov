using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_Akhmerov
{
    public partial class fGame : Form
    {
        static List<int> questCount = new List<int>();
        static List<Questions> lq = new List<Questions>();
        static DataBase db = new DataBase("defaultQuestions");
        private static bool questValue;
        private static int correctAnswers;
        private static int incorrectAnswers;
        static Random rnd = new Random();
        static int count;


        public fGame()
        {
            InitializeComponent();
        }

        private void fGame_Load(object sender, EventArgs e)
        {
            btnFalse.Hide();
            btnTrue.Hide();
            tbQuestion.Hide();
            btnStartAgain.Text = "Начать";
            if (!File.Exists("tasks"))
            {
                db = new DataBase("defaultQuestions");

                foreach (var s in taskList)
                {
                    var tempTask = s.Split('|');
                    db.Add(tempTask[0], tempTask[1] == "Да");
                }
                db.Save();
            }
        }

        private void btnStartAgain_Click(object sender, EventArgs e)
        {

            if (btnStartAgain.Text == "Начать")
            {
                if (MessageBox.Show("Желаете загрузить свои вопросы?", "Sepo", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    var ofd = new OpenFileDialog();
                    db = new DataBase(ofd.FileName);
                    lq = db.Load();
                }
                else
                {
                    if (MessageBox.Show("Вы точно хотите начать сначала?", "Sepo", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        db = new DataBase("defaultQuestions");
                        lq = db.Load();
                    }
                    else
                    {
                        return;
                    }
                }
                btnStartAgain.Text = "Сначала";
                btnFalse.Show();
                btnTrue.Show();
                tbQuestion.Show();
                }
            else
            {
                questCount.Clear();
            }

            questCount.Add(rnd.Next(0, db.Count));
            tbQuestion.Text = lq[questCount.Last()].Text;
            questValue = lq[questCount.Last()].IsTrue;
            correctAnswers = 0;
            incorrectAnswers = 0;
            count = 0;
        }

        private string[] taskList =
              {
                "В Японии ученики на доске пишут кисточкой с цветными чернилами?|Да",
                "В Австралии практикуется применение одноразовых школьных досок?|Нет",
                "Авторучка была изобретена еще в Древнем Египте?|Да",
                "Шариковая ручка сначала применялась только военными летчиками?|Да",
                "В Африке выпускаются витаминизированные карандаши для детей, имеющих обыкновение грызть что попало?|Да",
                "В некоторые виды цветных карандашей добавляется экстракт моркови для большей прочности грифеля?|Нет",
                "Римляне носили штаны?|Нет",
                "Если пчела ужалит кого-либо, то она погибнет?|Да",
                "Правда ли что, пауки питаются собственной паутиной?|Да",
                "В одном корейском цирке двух крокодилов научили танцевать вальс.|Нет",
                "На зиму пингвины улетают на север?|Нет",
                "Если камбалу положить на шахматную доску, она тоже станет клетчатой.|Да",
                "Спартанские воины перед битвой опрыскивали волосы духами.|Да",
                "Мыши подрастая становятся крысами?|Нет",
                "Некоторые лягушки умеют летать?|Да",
                "Дети могут слышать более высокие звуки, чем взрослые?|Да",
                "Глаз наполнен воздухом?|Нет",
                "Утром вы выше ростом, чем вечером?|Да",
                "В некоторых местах люди по-прежнему моются с помощью оливкового масла?|Да",
                "Летучие мыши могут принимать радиосигналы?|Нет",
                "Совы не могут вращать глазами?|Да",
                "Лось является разновидностью оленя?|Да",
                "Жирафы по ночам отыскивают с помощью эха листья, которыми питаются?|Нет",
                "Дельфины — это маленькие киты?|Да",
                "Рог носорога обладает магической силой?|Нет",
                "В некоторых странах жуков-светляков используют в качестве осветительных приборов?|Да",
                "Мартышка обычно бывает размером с котенка?|Да",
                "Счастливая монета Скруджа была достоинством в 10 центов?|Да",
                "Дуремар занимался продажей лягушек?|Нет",
                "Мойву эскимосы сушат и едят вместо хлеба?|Да",
                "Радугу можно увидеть и в полночь?|Да",
                "Больше всего репы выращивают в России?|Нет",
                "Слон, встречаясь с незнакомым сородичем, здоровается следующим образом — кладет ему хобот в рот?|Да",
                "Настоящее имя Ганса Христиана Андерсена было Свенсен?|Нет",
                "В медицине диагноз «синдром Мюнхгаузена» ставится пациенту, который много врет?|Нет",
                "Рост Конька — Горбунка составляет два вершка?|Нет",
                "Первое место среди причин гибели от несчастных случаев в Японии в 1995г. заняли туфли на высоком каблуке?|Да"
            };

        private void btnTrue_Click(object sender, EventArgs e) // Кнопки Верю и Не верю
        {
            if (sender as Button == btnTrue && questValue)
            {
                correctAnswers++;
            }
            else
            {
                incorrectAnswers++;
            }

            var finish = false;
            
            while (true)
            {
                var temp = rnd.Next(0, db.Count);
                if (questCount.Contains(temp))
                {
                    if (questCount.Count == db.Count)
                    {
                        finish = true;
                        break;
                    }
                    continue;
                }
                else
                {
                    if (count == 10)
                    {
                        finish = true;
                        break;
                    }
                    tbQuestion.Text = lq[temp].Text;
                    questValue = lq[temp].IsTrue;
                    questCount.Add(temp);
                    count++;
                    break;
                }
            }

            if (finish)
            {
                MessageBox.Show(
                    $"Игра окончена! Правильных ответов: {correctAnswers}, не правильных: {incorrectAnswers}.");
                btnFalse.Hide();
                btnTrue.Hide();
                tbQuestion.Hide();
                btnStartAgain.Text = "Начать";
            }
        }

        private void fGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти из игры?", "Sepo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                var fm = new fMain();
                fm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
