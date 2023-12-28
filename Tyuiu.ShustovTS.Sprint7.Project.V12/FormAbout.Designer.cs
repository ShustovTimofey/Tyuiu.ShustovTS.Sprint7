
namespace Tyuiu.ShustovTS.Sprint7.Project.V12
{
    partial class FormAbout
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
            this.label_STS = new System.Windows.Forms.Label();
            this.buttonClose_STS = new System.Windows.Forms.Button();
            this.pictureBoxAutor_STS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // label_STS
            // 
            this.label_STS.AutoSize = true;
            this.label_STS.Location = new System.Drawing.Point(112, 10);
            this.label_STS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_STS.Name = "label_STS";
            this.label_STS.Size = new System.Drawing.Size(284, 91);
            this.label_STS.TabIndex = 2;
            this.label_STS.Text = "Разработчик: Шустов Т. С.\r\nгруппа АСОиУб-23-2\r\n\r\nПрограмма разработана в рамках и" +
    "зучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа " +
    "цифровых технологий (с) 2023\r\n";
            // 
            // buttonClose_STS
            // 
            this.buttonClose_STS.Location = new System.Drawing.Point(324, 130);
            this.buttonClose_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose_STS.Name = "buttonClose_STS";
            this.buttonClose_STS.Size = new System.Drawing.Size(59, 22);
            this.buttonClose_STS.TabIndex = 4;
            this.buttonClose_STS.Text = "OK";
            this.buttonClose_STS.UseVisualStyleBackColor = true;
            this.buttonClose_STS.Click += new System.EventHandler(this.buttonClose_STS_Click);
            // 
            // pictureBoxAutor_STS
            // 
            this.pictureBoxAutor_STS.Image = global::Tyuiu.ShustovTS.Sprint7.Project.V12.Properties.Resources.autor;
            this.pictureBoxAutor_STS.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxAutor_STS.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAutor_STS.Name = "pictureBoxAutor_STS";
            this.pictureBoxAutor_STS.Size = new System.Drawing.Size(99, 144);
            this.pictureBoxAutor_STS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAutor_STS.TabIndex = 3;
            this.pictureBoxAutor_STS.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(394, 163);
            this.Controls.Add(this.buttonClose_STS);
            this.Controls.Add(this.pictureBoxAutor_STS);
            this.Controls.Add(this.label_STS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_STS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_STS;
        private System.Windows.Forms.PictureBox pictureBoxAutor_STS;
        private System.Windows.Forms.Button buttonClose_STS;
    }
}