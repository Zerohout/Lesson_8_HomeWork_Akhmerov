namespace HomeWork_Akhmerov
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbTrueFalse = new System.Windows.Forms.CheckBox();
            this.nudNumQuest = new System.Windows.Forms.NumericUpDown();
            this.tbQuestions = new System.Windows.Forms.TextBox();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNew,
            this.tsmSave,
            this.tsmLoad,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(48, 20);
            this.tsmFile.Text = "Файл";
            // 
            // tsmNew
            // 
            this.tsmNew.Name = "tsmNew";
            this.tsmNew.Size = new System.Drawing.Size(180, 22);
            this.tsmNew.Text = "Новый";
            this.tsmNew.Click += new System.EventHandler(this.tsmNew_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(180, 22);
            this.tsmSave.Text = "Сохранить";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmLoad
            // 
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(180, 22);
            this.tsmLoad.Text = "Загрузить";
            this.tsmLoad.Click += new System.EventHandler(this.tsmLoad_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(180, 22);
            this.tsmExit.Text = "Выход";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(174, 305);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // cbTrueFalse
            // 
            this.cbTrueFalse.AutoSize = true;
            this.cbTrueFalse.Location = new System.Drawing.Point(472, 309);
            this.cbTrueFalse.Name = "cbTrueFalse";
            this.cbTrueFalse.Size = new System.Drawing.Size(64, 17);
            this.cbTrueFalse.TabIndex = 8;
            this.cbTrueFalse.Text = "Правда";
            this.cbTrueFalse.UseVisualStyleBackColor = true;
            // 
            // nudNumQuest
            // 
            this.nudNumQuest.Location = new System.Drawing.Point(337, 305);
            this.nudNumQuest.Name = "nudNumQuest";
            this.nudNumQuest.Size = new System.Drawing.Size(120, 20);
            this.nudNumQuest.TabIndex = 7;
            // 
            // tbQuestions
            // 
            this.tbQuestions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbQuestions.Location = new System.Drawing.Point(0, 24);
            this.tbQuestions.Multiline = true;
            this.tbQuestions.Name = "tbQuestions";
            this.tbQuestions.Size = new System.Drawing.Size(800, 275);
            this.tbQuestions.TabIndex = 9;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.tbQuestions);
            this.Controls.Add(this.cbTrueFalse);
            this.Controls.Add(this.nudNumQuest);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "fMain";
            this.Text = "Редактор вопросов";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmNew;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbTrueFalse;
        private System.Windows.Forms.NumericUpDown nudNumQuest;
        private System.Windows.Forms.TextBox tbQuestions;
    }
}

