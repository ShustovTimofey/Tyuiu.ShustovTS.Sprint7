
namespace Tyuiu.ShustovTS.Sprint7.Project.V12
{
    partial class FormStat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft_STS = new System.Windows.Forms.Panel();
            this.textBoxYadra_STS = new System.Windows.Forms.TextBox();
            this.buttonBigYadra_STS = new System.Windows.Forms.Button();
            this.buttonDiag_STS = new System.Windows.Forms.Button();
            this.textBoxSredOZU_STS = new System.Windows.Forms.TextBox();
            this.buttonAvgRAM_STS = new System.Windows.Forms.Button();
            this.chartDiag_STS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogStat_STS = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewInStat_STS = new System.Windows.Forms.DataGridView();
            this.panelLeft_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_STS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStat_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft_STS
            // 
            this.panelLeft_STS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelLeft_STS.Controls.Add(this.textBoxYadra_STS);
            this.panelLeft_STS.Controls.Add(this.buttonBigYadra_STS);
            this.panelLeft_STS.Controls.Add(this.buttonDiag_STS);
            this.panelLeft_STS.Controls.Add(this.textBoxSredOZU_STS);
            this.panelLeft_STS.Controls.Add(this.buttonAvgRAM_STS);
            this.panelLeft_STS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_STS.Location = new System.Drawing.Point(0, 0);
            this.panelLeft_STS.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft_STS.Name = "panelLeft_STS";
            this.panelLeft_STS.Size = new System.Drawing.Size(100, 367);
            this.panelLeft_STS.TabIndex = 0;
            // 
            // textBoxYadra_STS
            // 
            this.textBoxYadra_STS.BackColor = System.Drawing.Color.White;
            this.textBoxYadra_STS.Location = new System.Drawing.Point(9, 226);
            this.textBoxYadra_STS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYadra_STS.Name = "textBoxYadra_STS";
            this.textBoxYadra_STS.ReadOnly = true;
            this.textBoxYadra_STS.Size = new System.Drawing.Size(79, 20);
            this.textBoxYadra_STS.TabIndex = 4;
            // 
            // buttonBigYadra_STS
            // 
            this.buttonBigYadra_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonBigYadra_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBigYadra_STS.Location = new System.Drawing.Point(9, 142);
            this.buttonBigYadra_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBigYadra_STS.Name = "buttonBigYadra_STS";
            this.buttonBigYadra_STS.Size = new System.Drawing.Size(79, 80);
            this.buttonBigYadra_STS.TabIndex = 2;
            this.buttonBigYadra_STS.Text = "Самое большое количество ядер";
            this.buttonBigYadra_STS.UseVisualStyleBackColor = false;
            this.buttonBigYadra_STS.Click += new System.EventHandler(this.buttonBigYadra_STS_Click);
            // 
            // buttonDiag_STS
            // 
            this.buttonDiag_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDiag_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonDiag_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiag_STS.Location = new System.Drawing.Point(9, 280);
            this.buttonDiag_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDiag_STS.Name = "buttonDiag_STS";
            this.buttonDiag_STS.Size = new System.Drawing.Size(79, 76);
            this.buttonDiag_STS.TabIndex = 1;
            this.buttonDiag_STS.Text = "Диагонали ЭВМ";
            this.buttonDiag_STS.UseVisualStyleBackColor = false;
            this.buttonDiag_STS.Click += new System.EventHandler(this.buttonDiag_STS_Click);
            // 
            // textBoxSredOZU_STS
            // 
            this.textBoxSredOZU_STS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSredOZU_STS.Location = new System.Drawing.Point(9, 90);
            this.textBoxSredOZU_STS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSredOZU_STS.Name = "textBoxSredOZU_STS";
            this.textBoxSredOZU_STS.ReadOnly = true;
            this.textBoxSredOZU_STS.Size = new System.Drawing.Size(79, 20);
            this.textBoxSredOZU_STS.TabIndex = 1;
            // 
            // buttonAvgRAM_STS
            // 
            this.buttonAvgRAM_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonAvgRAM_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAvgRAM_STS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvgRAM_STS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAvgRAM_STS.Location = new System.Drawing.Point(9, 10);
            this.buttonAvgRAM_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAvgRAM_STS.Name = "buttonAvgRAM_STS";
            this.buttonAvgRAM_STS.Size = new System.Drawing.Size(79, 76);
            this.buttonAvgRAM_STS.TabIndex = 0;
            this.buttonAvgRAM_STS.Text = "Среднее значение объема памяти";
            this.buttonAvgRAM_STS.UseVisualStyleBackColor = false;
            this.buttonAvgRAM_STS.Click += new System.EventHandler(this.buttonSredOZU_STS_Click);
            // 
            // chartDiag_STS
            // 
            this.chartDiag_STS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            this.chartDiag_STS.ChartAreas.Add(chartArea1);
            this.chartDiag_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_STS.Legends.Add(legend1);
            this.chartDiag_STS.Location = new System.Drawing.Point(100, 0);
            this.chartDiag_STS.Margin = new System.Windows.Forms.Padding(2);
            this.chartDiag_STS.Name = "chartDiag_STS";
            this.chartDiag_STS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_STS.Series.Add(series1);
            this.chartDiag_STS.Size = new System.Drawing.Size(552, 367);
            this.chartDiag_STS.TabIndex = 2;
            // 
            // openFileDialogStat_STS
            // 
            this.openFileDialogStat_STS.FileName = "openFileDialog1";
            // 
            // dataGridViewInStat_STS
            // 
            this.dataGridViewInStat_STS.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewInStat_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInStat_STS.Location = new System.Drawing.Point(867, 482);
            this.dataGridViewInStat_STS.Name = "dataGridViewInStat_STS";
            this.dataGridViewInStat_STS.Size = new System.Drawing.Size(0, 0);
            this.dataGridViewInStat_STS.TabIndex = 3;
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 367);
            this.Controls.Add(this.dataGridViewInStat_STS);
            this.Controls.Add(this.chartDiag_STS);
            this.Controls.Add(this.panelLeft_STS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистические данные";
            this.panelLeft_STS.ResumeLayout(false);
            this.panelLeft_STS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_STS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStat_STS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft_STS;
        private System.Windows.Forms.Button buttonAvgRAM_STS;
        private System.Windows.Forms.TextBox textBoxSredOZU_STS;
        private System.Windows.Forms.Button buttonDiag_STS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_STS;
        private System.Windows.Forms.OpenFileDialog openFileDialogStat_STS;
        private System.Windows.Forms.Button buttonBigYadra_STS;
        private System.Windows.Forms.TextBox textBoxYadra_STS;
        private System.Windows.Forms.DataGridView dataGridViewInStat_STS;
    }
}