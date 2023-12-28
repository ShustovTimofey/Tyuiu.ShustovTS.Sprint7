﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShustovTS.Sprint7.Project.V12.Lib;
using System.IO;

namespace Tyuiu.ShustovTS.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        //метод чтения данных из файла
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }

            return arrayValues;
        }
        private void LoadDataIntoDataGridView(string filePath)
        {
            // загружаем данные из файла с помощью метода LoadFromFileData
            string[,] dataArray = LoadFromFileData(filePath);

            // очищаем DataGridView перед загрузкой новых данных
            dataGridViewIn_STS.Rows.Clear();
            dataGridViewIn_STS.Columns.Clear();

            // добавляем столбцы в DataGridView
            for (int i = 0; i < dataArray.GetLength(1); i++)
            {
                dataGridViewIn_STS.Columns.Add("", dataArray[0, i]);
            }

            // добавляем строки с данными из CSV файла
            for (int i = 1; i < dataArray.GetLength(0); i++)
            {
                List<string> rowData = new List<string>();
                for (int j = 0; j < dataArray.GetLength(1); j++)
                {
                    rowData.Add(dataArray[i, j]);
                }
                dataGridViewIn_STS.Rows.Add(rowData.ToArray());
            }
        }
        private void buttonOpen_STS_Click(object sender, EventArgs e)
        {
            // получаем путь к файлу с помощью окна
            OpenFileDialog openFileDialog_STS = new OpenFileDialog();
            openFileDialog_STS.Filter = "csv Files|*.csv"; // фильтр для отображения только csv файлов
            if (openFileDialog_STS.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog_STS.FileName;

                // загружаем данные в DataGridView с помощью метода LoadDataIntoDataGridView
                LoadDataIntoDataGridView(filePath);
            }
            buttonSortData_STS.Enabled = true;
            buttonSave_STS.Enabled = true;
            buttonStat_STS.Enabled = true;
            buttonSortAlp_STS.Enabled = true;
        }

        private void buttonInfo_STS_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
        

        //поиск по таблице
        private void textBoxFind_STS_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxFind_STS.Text.ToLower(); //регистронезависимость

            foreach (DataGridViewRow row in dataGridViewIn_STS.Rows)
            {
                if (row.IsNewRow) continue; // проверка добавленных строк

                bool found = false;

                for (int j = 0; j < dataGridViewIn_STS.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found; // видимость\невидимость строк
            }
        }

        private void buttonStat_STS_Click(object sender, EventArgs e)
        {
            FormStat formstat = new FormStat();
            formstat.ShowDialog();
        }

        private void buttonSortAlp_STS_Click(object sender, EventArgs e)
        {
            dataGridViewIn_STS.Sort(dataGridViewIn_STS.Columns[0], ListSortDirection.Ascending); //сортировка названий
        }

        private void buttonSortData_STS_Click(object sender, EventArgs e)
        {
            dataGridViewIn_STS.Sort(dataGridViewIn_STS.Columns[6], ListSortDirection.Ascending); //сортировка по году
        }
        private void buttonInfo_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Справка";
        }
        private void buttonOpen_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Открыть файл";
        }

        //сохранение файла
        private void buttonSave_STS_Click(object sender, EventArgs e)
        {
            saveFileDialog_STS.FileName = "OutPutIVM.csv";
            saveFileDialog_STS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_STS.ShowDialog();

            string path = saveFileDialog_STS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewIn_STS.RowCount;
            int columns = dataGridViewIn_STS.ColumnCount;

            string str = "Название;Фирма;Процессор;Количество ядер;Объем ОЗУ (ГБ);Диагональ;Дата выпуска\n";
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewIn_STS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewIn_STS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

            DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogres == DialogResult.Yes) //открытие файла
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonFirma_STS_Click(object sender, EventArgs e)
        {
            FormFirma formfirma = new FormFirma();
            formfirma.ShowDialog();
        }
    }
}
