namespace WindowsFormsApp1
{
    partial class FormRegulations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegulations));
            this.labelRegulations = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegulations
            // 
            this.labelRegulations.BackColor = System.Drawing.Color.Transparent;
            this.labelRegulations.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelRegulations.ForeColor = System.Drawing.Color.Yellow;
            this.labelRegulations.Location = new System.Drawing.Point(16, 11);
            this.labelRegulations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegulations.Name = "labelRegulations";
            this.labelRegulations.Size = new System.Drawing.Size(712, 39);
            this.labelRegulations.TabIndex = 0;
            this.labelRegulations.Text = "Правила";
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(553, 436);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(175, 38);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "В главное меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 354);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FormRegulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelRegulations);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRegulations";
            this.Text = "Крассворд";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRegulations;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Label label1;
    }
}