using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.OleDb;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace Accenture
{
    public partial class Table : Form
    {
        private Button currentBtn;
        private Panel leftBorderBtn;

        public Table()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Настройки формы
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
       
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Кнопка
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Линия слева кнопки
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new System.Drawing.Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Таблица Завод
        private void button11_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Завод Zavod = new Завод();
            Close();
            Zavod.Show();
        }

        //Таблица товары
        private void button12_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Tovary Tovary = new Tovary();
            Close();
            Tovary.Show();
        }

        // Таблица СкладЗавода
        private void button13_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            СкладЗавода SkladZavoda = new СкладЗавода();
            Close();
            SkladZavoda.Show();
        }

        // Таблица ОстатокНаСкладе
        private void button14_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OstatokNaSklade OstatokNaSklade = new OstatokNaSklade();
            Close();
            OstatokNaSklade.Show();
        }

        // Таблица Поставки
        private void button15_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Postavki Postavki = new Postavki();
            Close();
            Postavki.Show();
        }

        // Таблица Склад Магазина
        private void button16_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            SkladMagazina SkladMagazina = new SkladMagazina();
            Close();
            SkladMagazina.Show();
        }

        // Таблица Модели
        private void button17_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            Modeli Modeli = new Modeli();
            Close();
            Modeli.Show();
        }

        // Таблица Магазины
        private void button18_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Magaziny Magaziny = new Magaziny();
            Close();
            Magaziny.Show();
        }

        private void iconBack_Click(object sender, EventArgs e)
        {
            MainForm Main_Form = new MainForm();
            Close();
            Main_Form.Show();
            iconBack.IconChar = IconChar.Home;
            iconBack.IconColor = Color.MediumPurple;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
