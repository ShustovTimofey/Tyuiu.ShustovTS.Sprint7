
namespace Tyuiu.ShustovTS.Sprint7.Project.V12
{
    partial class FormFirma
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
            this.dataGridViewInFirma_STS = new System.Windows.Forms.DataGridView();
            this.buttonClose_STS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInFirma_STS
            // 
            this.dataGridViewInFirma_STS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewInFirma_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInFirma_STS.Location = new System.Drawing.Point(9, 11);
            this.dataGridViewInFirma_STS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInFirma_STS.Name = "dataGridViewInFirma_STS";
            this.dataGridViewInFirma_STS.RowHeadersWidth = 51;
            this.dataGridViewInFirma_STS.RowTemplate.Height = 24;
            this.dataGridViewInFirma_STS.Size = new System.Drawing.Size(480, 275);
            this.dataGridViewInFirma_STS.TabIndex = 0;
            // 
            // buttonClose_STS
            // 
            this.buttonClose_STS.Location = new System.Drawing.Point(421, 290);
            this.buttonClose_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose_STS.Name = "buttonClose_STS";
            this.buttonClose_STS.Size = new System.Drawing.Size(68, 34);
            this.buttonClose_STS.TabIndex = 2;
            this.buttonClose_STS.Text = "Закрыть";
            this.buttonClose_STS.UseVisualStyleBackColor = true;
            this.buttonClose_STS.Click += new System.EventHandler(this.buttonClose_STS_Click);
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 335);
            this.Controls.Add(this.buttonClose_STS);
            this.Controls.Add(this.dataGridViewInFirma_STS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_STS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInFirma_STS;
        private System.Windows.Forms.Button buttonClose_STS;
    }
}