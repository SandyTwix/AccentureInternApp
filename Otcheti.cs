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
using FontAwesome.Sharp;

namespace Accenture
{
    public partial class Otcheti : Form
    {
        static string ConnectionString = MainForm.ConnectionString;
        public Otcheti()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OutputReportOc();//Вызываем метода печати отчета 1
        }

        /// <summary>
        /// Печать отчета
        /// </summary>
        void OutputReportOc()
        {
            string QueryText = "SELECT Экспедиторы.Код_экспедитора, Экспедиторы.ФИО_экспедитора FROM Модели";
            ///предоставление открытого подключения к источнику данных
            OleDbConnection Connection = new OleDbConnection(ConnectionString);
            ///создаем объек набора данных
            DataSet dataSet = new DataSet();
            ///создание адаптера данных
            OleDbDataAdapter adapter = new OleDbDataAdapter(QueryText, ConnectionString);
            ///заполнение объекта dataset данными из адаптера
            adapter.Fill(dataSet);
            ///создание компонента dataGridView1
            DataGridView dataGridView1 = new DataGridView();
            Controls.Add(dataGridView1);
            ///указание таблице источника данных
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Top = 300;
            ///подсчет строк
            int RowCount = dataGridView1.Rows.Count;
            ///подсчет столбцов
            int ColumnCount = dataGridView1.Columns.Count;

            Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

            int i = 0;
            for (int j = 0; j <= ColumnCount - 1; j++)
            {
                for (i = 0; i <= RowCount - 1; i++)
                    DataArray[i, j] = dataGridView1.Rows[i].Cells[j].Value;///помещение значений ячеек таблицы в двумерный массив
            }
            ///создание объекта Application
            Word.Application application = new Word.Application();
            ///делаем объект видимым
            application.Visible = true;
            ///создание объекта Document (видимый)
            Document doc = application.Documents.Add(Visible: true);
            string oTemp = "";
            dynamic oRange = doc.Content.Application.Selection.Range;

            application.ActiveDocument.PageSetup.BottomMargin = 40f;///задаём верхний отступ
            application.ActiveDocument.PageSetup.TopMargin = 40f;///задаём нижний отступ
            application.ActiveDocument.PageSetup.LeftMargin = 20f;///задаём левый отступ
            application.ActiveDocument.PageSetup.RightMargin = 20f;///задаём правый отступ

            ///настройка текста для шапки файла
            foreach (Section section in doc.Application.ActiveDocument.Sections)
            {
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                headerRange.Text = "Отчет 'Экспедиторы'";
                headerRange.Font.Size = 16;
                headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            }

            for (i = 0; i <= RowCount - 1; i++)
                for (int j = 0; j <= ColumnCount - 1; j++)
                    oTemp = oTemp + DataArray[i, j] + "\t";///помещение в строковую переменную двумерного массива

            oRange.Text = oTemp;
            object Separator = WdTableFieldSeparator.wdSeparateByTabs;
            object ApplyBorders = true;
            object AutoFit = true;
            object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;
            oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                Type.Missing, Type.Missing, ref ApplyBorders,
                Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
            oRange.Select();

            doc.Tables[1].Cell(1, 1).Range.Text = "ФИО";
            doc.Tables[1].Cell(1, 1).Range.Bold = 1;
            doc.Tables[1].Cell(1, 1).Range.Font.Size = 12;
            doc.Tables[1].Cell(1, 2).Range.Text = "Код экспедитора";
            doc.Tables[1].Cell(1, 2).Range.Bold = 1;


            ///ширинастолбцов
            doc.Application.Selection.Tables[1].Columns[1].SetWidth(100f, WdRulerStyle.wdAdjustNone);
            doc.Application.Selection.Tables[1].Columns[2].SetWidth(95f, WdRulerStyle.wdAdjustNone);

            try
            {
                doc.Close();///закрытие объекта Document
                application.Quit();///закрытиеобъекта Application
            }
            catch (Exception) { }
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            MainForm Main_Form = new MainForm();
            Close();
            Main_Form.Show();
            iconBack.IconChar = IconChar.Home;
            iconBack.IconColor = Color.MediumPurple;
        }
    }
}
