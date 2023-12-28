namespace Tyuiu.ShustovTS.Sprint7.Project.V12
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.saveFileDialog_STS = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_STS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_STS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonStat_STS = new System.Windows.Forms.Button();
            this.buttonFirma_STS = new System.Windows.Forms.Button();
            this.buttonSortAlp_STS = new System.Windows.Forms.Button();
            this.buttonSortData_STS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFind_STS = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonSave_STS = new System.Windows.Forms.Button();
            this.buttonOpen_STS = new System.Windows.Forms.Button();
            this.buttonInfo_STS = new System.Windows.Forms.Button();
            this.groupBoxIn_STS = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_STS = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupBoxIn_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_STS)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_STS
            // 
            this.openFileDialog_STS.FileName = "openFileDialog1";
            // 
            // buttonStat_STS
            // 
            this.buttonStat_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStat_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonStat_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStat_STS.Enabled = false;
            this.buttonStat_STS.Location = new System.Drawing.Point(421, 7);
            this.buttonStat_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStat_STS.Name = "buttonStat_STS";
            this.buttonStat_STS.Size = new System.Drawing.Size(98, 37);
            this.buttonStat_STS.TabIndex = 2;
            this.buttonStat_STS.Text = "Статистика";
            this.toolTip_STS.SetToolTip(this.buttonStat_STS, "Открыть окно со статистикой");
            this.buttonStat_STS.UseVisualStyleBackColor = false;
            this.buttonStat_STS.Click += new System.EventHandler(this.buttonStat_STS_Click);
            // 
            // buttonFirma_STS
            // 
            this.buttonFirma_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonFirma_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirma_STS.Location = new System.Drawing.Point(149, 7);
            this.buttonFirma_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirma_STS.Name = "buttonFirma_STS";
            this.buttonFirma_STS.Size = new System.Drawing.Size(122, 37);
            this.buttonFirma_STS.TabIndex = 3;
            this.buttonFirma_STS.Text = "Открыть фирмы";
            this.toolTip_STS.SetToolTip(this.buttonFirma_STS, "Открыть окно с фирмами");
            this.buttonFirma_STS.UseVisualStyleBackColor = false;
            this.buttonFirma_STS.Click += new System.EventHandler(this.buttonFirma_STS_Click);
            // 
            // buttonSortAlp_STS
            // 
            this.buttonSortAlp_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortAlp_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortAlp_STS.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.buttonSortAlp_STS.Enabled = false;
            this.buttonSortAlp_STS.Location = new System.Drawing.Point(523, 7);
            this.buttonSortAlp_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortAlp_STS.Name = "buttonSortAlp_STS";
            this.buttonSortAlp_STS.Size = new System.Drawing.Size(98, 37);
            this.buttonSortAlp_STS.TabIndex = 3;
            this.buttonSortAlp_STS.Text = "Отсортировать по алфавиту";
            this.buttonSortAlp_STS.UseVisualStyleBackColor = false;
            this.buttonSortAlp_STS.Click += new System.EventHandler(this.buttonSortAlp_STS_Click);
            // 
            // buttonSortData_STS
            // 
            this.buttonSortData_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortData_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortData_STS.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.buttonSortData_STS.Enabled = false;
            this.buttonSortData_STS.Location = new System.Drawing.Point(625, 7);
            this.buttonSortData_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSortData_STS.Name = "buttonSortData_STS";
            this.buttonSortData_STS.Size = new System.Drawing.Size(98, 37);
            this.buttonSortData_STS.TabIndex = 4;
            this.buttonSortData_STS.Text = "Отсортировать по году выпуска";
            this.buttonSortData_STS.UseVisualStyleBackColor = false;
            this.buttonSortData_STS.Click += new System.EventHandler(this.buttonSortData_STS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFind_STS);
            this.groupBox1.Location = new System.Drawing.Point(275, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(142, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск по названию";
            // 
            // textBoxFind_STS
            // 
            this.textBoxFind_STS.Location = new System.Drawing.Point(4, 17);
            this.textBoxFind_STS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFind_STS.Name = "textBoxFind_STS";
            this.textBoxFind_STS.Size = new System.Drawing.Size(134, 20);
            this.textBoxFind_STS.TabIndex = 0;
            this.textBoxFind_STS.TextChanged += new System.EventHandler(this.textBoxFind_STS_TextChanged);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTop.Controls.Add(this.buttonFirma_STS);
            this.panelTop.Controls.Add(this.buttonSortData_STS);
            this.panelTop.Controls.Add(this.buttonSave_STS);
            this.panelTop.Controls.Add(this.buttonSortAlp_STS);
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.buttonStat_STS);
            this.panelTop.Controls.Add(this.buttonOpen_STS);
            this.panelTop.Controls.Add(this.buttonInfo_STS);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(836, 49);
            this.panelTop.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonSave_STS
            // 
            this.buttonSave_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_STS.Enabled = false;
            this.buttonSave_STS.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_STS.Image = global::Tyuiu.ShustovTS.Sprint7.Project.V12.Properties.Resources.disk;
            this.buttonSave_STS.Location = new System.Drawing.Point(80, 7);
            this.buttonSave_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_STS.Name = "buttonSave_STS";
            this.buttonSave_STS.Size = new System.Drawing.Size(65, 37);
            this.buttonSave_STS.TabIndex = 5;
            this.toolTip_STS.SetToolTip(this.buttonSave_STS, "Сохранить измененный csv файл");
            this.buttonSave_STS.UseVisualStyleBackColor = false;
            this.buttonSave_STS.Click += new System.EventHandler(this.buttonSave_STS_Click);
            // 
            // buttonOpen_STS
            // 
            this.buttonOpen_STS.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpen_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_STS.ForeColor = System.Drawing.Color.White;
            this.buttonOpen_STS.Image = global::Tyuiu.ShustovTS.Sprint7.Project.V12.Properties.Resources.folder_add;
            this.buttonOpen_STS.Location = new System.Drawing.Point(11, 7);
            this.buttonOpen_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_STS.Name = "buttonOpen_STS";
            this.buttonOpen_STS.Size = new System.Drawing.Size(65, 37);
            this.buttonOpen_STS.TabIndex = 1;
            this.toolTip_STS.SetToolTip(this.buttonOpen_STS, "Открыть файл");
            this.buttonOpen_STS.UseVisualStyleBackColor = false;
            this.buttonOpen_STS.Click += new System.EventHandler(this.buttonOpen_STS_Click);
            this.buttonOpen_STS.MouseEnter += new System.EventHandler(this.buttonOpen_STS_MouseEnter);
            // 
            // buttonInfo_STS
            // 
            this.buttonInfo_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_STS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonInfo_STS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_STS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_STS.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_STS.Image = global::Tyuiu.ShustovTS.Sprint7.Project.V12.Properties.Resources.information;
            this.buttonInfo_STS.Location = new System.Drawing.Point(771, 6);
            this.buttonInfo_STS.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_STS.Name = "buttonInfo_STS";
            this.buttonInfo_STS.Size = new System.Drawing.Size(56, 37);
            this.buttonInfo_STS.TabIndex = 0;
            this.toolTip_STS.SetToolTip(this.buttonInfo_STS, "Информация о программе");
            this.buttonInfo_STS.UseVisualStyleBackColor = false;
            this.buttonInfo_STS.Click += new System.EventHandler(this.buttonInfo_STS_Click);
            this.buttonInfo_STS.MouseEnter += new System.EventHandler(this.buttonInfo_STS_MouseEnter);
            // 
            // groupBoxIn_STS
            // 
            this.groupBoxIn_STS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxIn_STS.Controls.Add(this.dataGridViewIn_STS);
            this.groupBoxIn_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_STS.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxIn_STS.Name = "groupBoxIn_STS";
            this.groupBoxIn_STS.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxIn_STS.Size = new System.Drawing.Size(836, 454);
            this.groupBoxIn_STS.TabIndex = 0;
            this.groupBoxIn_STS.TabStop = false;
            this.groupBoxIn_STS.Text = "Ввод данных";
            // 
            // dataGridViewIn_STS
            // 
            this.dataGridViewIn_STS.AllowDrop = true;
            this.dataGridViewIn_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_STS.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewIn_STS.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewIn_STS.Name = "dataGridViewIn_STS";
            this.dataGridViewIn_STS.RowHeadersWidth = 51;
            this.dataGridViewIn_STS.RowTemplate.Height = 24;
            this.dataGridViewIn_STS.Size = new System.Drawing.Size(832, 437);
            this.dataGridViewIn_STS.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxIn_STS);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(836, 454);
            this.panelLeft.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 503);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт ЭВМ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.groupBoxIn_STS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_STS)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog_STS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_STS;
        private System.Windows.Forms.ToolTip toolTip_STS;
        private System.Windows.Forms.Button buttonStat_STS;
        private System.Windows.Forms.Button buttonSortAlp_STS;
        private System.Windows.Forms.Button buttonSortData_STS;
        private System.Windows.Forms.Button buttonSave_STS;
        private System.Windows.Forms.Button buttonInfo_STS;
        private System.Windows.Forms.Button buttonOpen_STS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFind_STS;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonFirma_STS;
        private System.Windows.Forms.GroupBox groupBoxIn_STS;
        private System.Windows.Forms.DataGridView dataGridViewIn_STS;
        private System.Windows.Forms.Panel panelLeft;
    }
}

