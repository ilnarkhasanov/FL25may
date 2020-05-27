namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegulations = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonDifficult = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(16, 442);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 38);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRegulations
            // 
            this.buttonRegulations.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegulations.Location = new System.Drawing.Point(16, 390);
            this.buttonRegulations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegulations.Name = "buttonRegulations";
            this.buttonRegulations.Size = new System.Drawing.Size(175, 38);
            this.buttonRegulations.TabIndex = 6;
            this.buttonRegulations.Text = "Правила";
            this.buttonRegulations.UseVisualStyleBackColor = true;
            this.buttonRegulations.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.ForeColor = System.Drawing.Color.Yellow;
            this.labelMenu.Location = new System.Drawing.Point(16, 198);
            this.labelMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(110, 38);
            this.labelMenu.TabIndex = 5;
            this.labelMenu.Text = "Меню";
            this.labelMenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(16, 277);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(175, 38);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Играть";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.radioButtonEasy.Location = new System.Drawing.Point(16, 332);
            this.radioButtonEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(175, 42);
            this.radioButtonEasy.TabIndex = 8;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Легко";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.radioButtonNormal.Location = new System.Drawing.Point(199, 332);
            this.radioButtonNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(175, 42);
            this.radioButtonNormal.TabIndex = 8;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Нормально";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonDifficult
            // 
            this.radioButtonDifficult.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.radioButtonDifficult.Location = new System.Drawing.Point(381, 332);
            this.radioButtonDifficult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDifficult.Name = "radioButtonDifficult";
            this.radioButtonDifficult.Size = new System.Drawing.Size(175, 42);
            this.radioButtonDifficult.TabIndex = 8;
            this.radioButtonDifficult.TabStop = true;
            this.radioButtonDifficult.Text = "Сложно";
            this.radioButtonDifficult.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 503);
            this.Controls.Add(this.radioButtonDifficult);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.radioButtonEasy);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegulations);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonPlay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.Text = "Кроссворд";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegulations;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonDifficult;
    }
}

