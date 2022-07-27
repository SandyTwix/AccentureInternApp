using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace Accenture
{
    public partial class OstatokNaSklade : Form
    {
        public static string ConnectionString = MainForm.ConnectionString;// строка подключения к базе данных
        public static OleDbConnection Connection = new OleDbConnection(ConnectionString);// подключение к базе данных
        public static string queryText = "SELECT * FROM ОстатокНаСкладе";// запрос на все столбцы таблицы ОстатокНаСкладе
        public static DataSet dataSet;
        public static OleDbDataAdapter adapter;
        public OstatokNaSklade()
        {
            InitializeComponent();
            Connection.Open(); // открываем подключение
            dataSet = new DataSet();// инициализация объекта набора данных
            adapter = new OleDbDataAdapter(queryText, Connection);// инициализация адаптера данных
            OutputDataGridView(); // выводим содержание запроса в DataGridView
        }

        private void OutputDataGridView()
        {
            adapter.Fill(dataSet);// заполняем DataSet
            dataGridView2.DataSource = dataSet.Tables[0];// Отображение таблицы на форме
            dataGridView2.ColumnHeadersHeight = 40;// названия столбцов
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14);
            dataGridView2.Columns[0].Width = 150;
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 120;
            dataGridView2.Columns[3].Width = 130;
            dataGridView2.Columns[4].Width = 100;
            //динамическое расширение ячейки
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        // Добавить запись
        private void button8_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables[0].NewRow();
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
            dataSet.Tables[0].Rows.Add(row);
        }

        // Удалить запись
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                dataGridView2.Rows.Remove(row);
        }

        // Сохранить данные
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(adapter);
                adapter.Update(dataSet);
                commandBuilder.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        // Напечатать отчёт
        private void button5_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView2.Rows.Count; //кол-во строк таблицы
            int columnCount = dataGridView2.Columns.Count; //кол-во столбцов таблицы

            Word.Document wordDoc; // создаем документ ворд
            Word.Application wordApp = new Word.Application // создаем и инициализируем приложение Word
            {
                Caption = "Отчет по таблице \"Остаток на складе\"",
                Visible = true
            };

            object template = Type.Missing;// шаблон
            object newTemplate = false;
            object documentType = Word.WdNewDocumentType.wdNewBlankDocument;// тип документа
            object visible = true;// видимость

            wordDoc = wordApp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);

            //Вывод времении
            object start = 0;
            object end = 0;
            Word.Range wordRange1 = wordDoc.Range(ref start, ref end);
            wordRange1.Text = DateTime.Now.ToString();
            Word.Range wordRange2 = wordDoc.Range(ref start, ref end);

            //Вывод заголовка
            object defaultTableBehavior = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            object autoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitWindow;

            Word.Table wordTable = wordDoc.Tables.Add(wordRange2, rowCount + 1, columnCount, ref defaultTableBehavior, ref autoFitBehavior);
            wordTable = wordDoc.Tables[1];

            foreach (Section section in wordTable.Application.ActiveDocument.Sections)
            {
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.Bold = 10;
                headerRange.Font.Name = "Times New Roman";
                headerRange.Font.Size = 18;
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Text = "Отчет по таблице \"Остаток на складе\"";
            }

            wordTable.ApplyStyleFirstColumn = true;
            wordTable.ApplyStyleHeadingRows = true;
            wordTable.ApplyStyleLastRow = false;
            wordTable.ApplyStyleLastColumn = false;

            //Вывод заголовков из таблицы
            Word.Range wordCellRange = wordDoc.Tables[1].Range;
            for (int i = 0; i < columnCount; i++)
            {
                wordCellRange = wordTable.Cell(1, i + 1).Range;
                wordCellRange.Tables[1].Cell(1, i + 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                wordCellRange.Tables[1].Cell(1, i + 1).Range.Bold = 10;// полужирность
                wordCellRange.Tables[1].Cell(1, i + 1).Range.Italic = 10;// курсив
                wordCellRange.Tables[1].Cell(1, i + 1).Range.Font.Name = "Times New Roman";
                wordCellRange.Tables[1].Cell(1, i + 1).Range.Font.Size = 12;
                wordCellRange.Text = Convert.ToString(dataGridView2.Columns[i].HeaderText) + "\t";
            }

            //Заполнение массива значениями из таблицы
            object[,] DataArray = new object[rowCount + 1, columnCount + 1];
            for (int j = 0; j < columnCount; j++)
            {
                for (int i = 0; i < rowCount; i++)
                    DataArray[i, j] = dataGridView2.Rows[i].Cells[j].Value;
            }

            //Вывод данных из таблицы
            //i - счетчик для ячеек таблицы
            //k - счетчик для элементов массива
            for (int i = 1, k = 0; i < rowCount + 1; i++, k++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    wordCellRange = wordTable.Cell(i + 1, j + 1).Range;
                    wordCellRange.Text = DataArray[k, j] + "\t";
                }
            }
        }

        // Клавиша "назад"
        private void iconBack_Click(object sender, EventArgs e)
        {
            Table Table = new Table(); //Находим и присваиваем ссылку на форму
            adapter.Dispose(); // очищаем адаптер
            Connection.Close(); // закрываем подключение
            Close(); // закрытие текущей формы
            Table.Show(); // открываем меню для таблиц
        }
    }
}
