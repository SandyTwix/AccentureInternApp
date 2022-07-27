
namespace Accenture
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButtonReports = new FontAwesome.Sharp.IconButton();
            this.iconButtonTables = new FontAwesome.Sharp.IconButton();
            this.panelName = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelName.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.iconButtonReports);
            this.panelMenu.Controls.Add(this.iconButtonTables);
            this.panelMenu.Controls.Add(this.panelName);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 606);
            this.panelMenu.TabIndex = 10;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::Accenture.Properties.Resources.Разделители1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 528);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 33);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Accenture.Properties.Resources.Кнопка_выхода;
            this.button1.Location = new System.Drawing.Point(0, 561);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButtonReports
            // 
            this.iconButtonReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReports.FlatAppearance.BorderSize = 0;
            this.iconButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonReports.ForeColor = System.Drawing.Color.White;
            this.iconButtonReports.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.iconButtonReports.IconColor = System.Drawing.Color.White;
            this.iconButtonReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReports.IconSize = 43;
            this.iconButtonReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.Location = new System.Drawing.Point(0, 140);
            this.iconButtonReports.Name = "iconButtonReports";
            this.iconButtonReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonReports.Size = new System.Drawing.Size(200, 60);
            this.iconButtonReports.TabIndex = 16;
            this.iconButtonReports.Text = "   Отчёты";
            this.iconButtonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReports.UseVisualStyleBackColor = true;
            this.iconButtonReports.Click += new System.EventHandler(this.iconButtonReports_Click);
            // 
            // iconButtonTables
            // 
            this.iconButtonTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonTables.FlatAppearance.BorderSize = 0;
            this.iconButtonTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonTables.ForeColor = System.Drawing.Color.White;
            this.iconButtonTables.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButtonTables.IconColor = System.Drawing.Color.White;
            this.iconButtonTables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTables.IconSize = 43;
            this.iconButtonTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTables.Location = new System.Drawing.Point(0, 80);
            this.iconButtonTables.Name = "iconButtonTables";
            this.iconButtonTables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonTables.Size = new System.Drawing.Size(200, 60);
            this.iconButtonTables.TabIndex = 15;
            this.iconButtonTables.Text = "   Таблицы";
            this.iconButtonTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTables.UseVisualStyleBackColor = true;
            this.iconButtonTables.Click += new System.EventHandler(this.iconButtonTables_Click);
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelName.Controls.Add(this.label2);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(200, 80);
            this.panelName.TabIndex = 11;
            this.panelName.Paint += new System.Windows.Forms.PaintEventHandler(this.panelName_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "БАЗА ДАННЫХ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(811, 80);
            this.panelTitle.TabIndex = 11;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(355, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(148, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "МАГАЗИНЫ";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 526);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Accenture.Properties.Resources.Асенче1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "База Данных Магазины";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonReports;
        private FontAwesome.Sharp.IconButton iconButtonTables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

