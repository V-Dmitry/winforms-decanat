namespace Kursovik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Data = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиВДругоеОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиВЗаочноеОтдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевестиВДистанционноеОтдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЖурналсериализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьЖурналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчислитьДобавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИзБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчислитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеОСтудентеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дневноеОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заочноеОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дистанционноеОтделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическоеЗаполнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameSearchBox = new System.Windows.Forms.TextBox();
            this.biletSearchBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.JournalBook = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonNameSearch = new System.Windows.Forms.Button();
            this.buttonBiletSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.AllowUserToDeleteRows = false;
            this.Data.AllowUserToResizeRows = false;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.ContextMenuStrip = this.contextMenuStrip1;
            this.Data.Location = new System.Drawing.Point(4, 73);
            this.Data.MultiSelect = false;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(642, 308);
            this.Data.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.перевестиВДругоеОтделениеToolStripMenuItem,
            this.перевестиВЗаочноеОтдToolStripMenuItem,
            this.перевестиВДистанционноеОтдToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 114);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // перевестиВДругоеОтделениеToolStripMenuItem
            // 
            this.перевестиВДругоеОтделениеToolStripMenuItem.Name = "перевестиВДругоеОтделениеToolStripMenuItem";
            this.перевестиВДругоеОтделениеToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.перевестиВДругоеОтделениеToolStripMenuItem.Text = "Перевести в дневное отд.";
            this.перевестиВДругоеОтделениеToolStripMenuItem.Click += new System.EventHandler(this.перевестиВДругоеОтделениеToolStripMenuItem_Click);
            // 
            // перевестиВЗаочноеОтдToolStripMenuItem
            // 
            this.перевестиВЗаочноеОтдToolStripMenuItem.Name = "перевестиВЗаочноеОтдToolStripMenuItem";
            this.перевестиВЗаочноеОтдToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.перевестиВЗаочноеОтдToolStripMenuItem.Text = "Перевести в заочное отд.";
            this.перевестиВЗаочноеОтдToolStripMenuItem.Click += new System.EventHandler(this.перевестиВЗаочноеОтдToolStripMenuItem_Click);
            // 
            // перевестиВДистанционноеОтдToolStripMenuItem
            // 
            this.перевестиВДистанционноеОтдToolStripMenuItem.Name = "перевестиВДистанционноеОтдToolStripMenuItem";
            this.перевестиВДистанционноеОтдToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.перевестиВДистанционноеОтдToolStripMenuItem.Text = "Перевести в дистанционное отд.";
            this.перевестиВДистанционноеОтдToolStripMenuItem.Click += new System.EventHandler(this.перевестиВДистанционноеОтдToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.журналToolStripMenuItem,
            this.отчислитьДобавитьToolStripMenuItem,
            this.таблицаToolStripMenuItem,
            this.автоматическоеЗаполнениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйФайлToolStripMenuItem
            // 
            this.новыйФайлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыйФайлToolStripMenuItem.Image")));
            this.новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
            this.новыйФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.новыйФайлToolStripMenuItem.Text = "Новый файл";
            this.новыйФайлToolStripMenuItem.Click += new System.EventHandler(this.новыйФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьФайлToolStripMenuItem.Image")));
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЖурналToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.сохранитьЖурналсериализацияToolStripMenuItem,
            this.сохранитьЖурналToolStripMenuItem,
            this.загрузитьЖурналToolStripMenuItem});
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.журналToolStripMenuItem.Text = "Журнал";
            // 
            // удалитьЖурналToolStripMenuItem
            // 
            this.удалитьЖурналToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьЖурналToolStripMenuItem.Image")));
            this.удалитьЖурналToolStripMenuItem.Name = "удалитьЖурналToolStripMenuItem";
            this.удалитьЖурналToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.удалитьЖурналToolStripMenuItem.Text = "Очистить журнал";
            this.удалитьЖурналToolStripMenuItem.Click += new System.EventHandler(this.удалитьЖурналToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очиститьToolStripMenuItem.Image")));
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить окно журнала";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // сохранитьЖурналсериализацияToolStripMenuItem
            // 
            this.сохранитьЖурналсериализацияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьЖурналсериализацияToolStripMenuItem.Image")));
            this.сохранитьЖурналсериализацияToolStripMenuItem.Name = "сохранитьЖурналсериализацияToolStripMenuItem";
            this.сохранитьЖурналсериализацияToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.сохранитьЖурналсериализацияToolStripMenuItem.Text = "Сохранить журнал(сериализация)";
            this.сохранитьЖурналсериализацияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЖурналсериализацияToolStripMenuItem_Click);
            // 
            // сохранитьЖурналToolStripMenuItem
            // 
            this.сохранитьЖурналToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьЖурналToolStripMenuItem.Image")));
            this.сохранитьЖурналToolStripMenuItem.Name = "сохранитьЖурналToolStripMenuItem";
            this.сохранитьЖурналToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.сохранитьЖурналToolStripMenuItem.Text = "Сохранить журнал(для чтения)";
            this.сохранитьЖурналToolStripMenuItem.Click += new System.EventHandler(this.сохранитьЖурналToolStripMenuItem_Click);
            // 
            // загрузитьЖурналToolStripMenuItem
            // 
            this.загрузитьЖурналToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("загрузитьЖурналToolStripMenuItem.Image")));
            this.загрузитьЖурналToolStripMenuItem.Name = "загрузитьЖурналToolStripMenuItem";
            this.загрузитьЖурналToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.загрузитьЖурналToolStripMenuItem.Text = "Загрузить журнал";
            this.загрузитьЖурналToolStripMenuItem.Click += new System.EventHandler(this.загрузитьЖурналToolStripMenuItem_Click);
            // 
            // отчислитьДобавитьToolStripMenuItem
            // 
            this.отчислитьДобавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьИзБазыToolStripMenuItem,
            this.отчислитьСтудентаToolStripMenuItem,
            this.добавитьСтудентаToolStripMenuItem,
            this.изменитьДанныеОСтудентеToolStripMenuItem});
            this.отчислитьДобавитьToolStripMenuItem.Name = "отчислитьДобавитьToolStripMenuItem";
            this.отчислитьДобавитьToolStripMenuItem.Size = new System.Drawing.Size(194, 20);
            this.отчислитьДобавитьToolStripMenuItem.Text = "Отчислить/Добавить/Изменить";
            // 
            // удалитьИзБазыToolStripMenuItem
            // 
            this.удалитьИзБазыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьИзБазыToolStripMenuItem.Image")));
            this.удалитьИзБазыToolStripMenuItem.Name = "удалитьИзБазыToolStripMenuItem";
            this.удалитьИзБазыToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.удалитьИзБазыToolStripMenuItem.Text = "Удалить из базы";
            this.удалитьИзБазыToolStripMenuItem.Click += new System.EventHandler(this.удалитьИзБазыToolStripMenuItem_Click);
            // 
            // отчислитьСтудентаToolStripMenuItem
            // 
            this.отчислитьСтудентаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отчислитьСтудентаToolStripMenuItem.Image")));
            this.отчислитьСтудентаToolStripMenuItem.Name = "отчислитьСтудентаToolStripMenuItem";
            this.отчислитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.отчислитьСтудентаToolStripMenuItem.Text = "Отчислить студентов с долгами";
            this.отчислитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.отчислитьСтудентаToolStripMenuItem_Click);
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            this.добавитьСтудентаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьСтудентаToolStripMenuItem.Image")));
            this.добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            this.добавитьСтудентаToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            this.добавитьСтудентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтудентаToolStripMenuItem_Click);
            // 
            // изменитьДанныеОСтудентеToolStripMenuItem
            // 
            this.изменитьДанныеОСтудентеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьДанныеОСтудентеToolStripMenuItem.Image")));
            this.изменитьДанныеОСтудентеToolStripMenuItem.Name = "изменитьДанныеОСтудентеToolStripMenuItem";
            this.изменитьДанныеОСтудентеToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.изменитьДанныеОСтудентеToolStripMenuItem.Text = "Изменить данные о студенте";
            this.изменитьДанныеОСтудентеToolStripMenuItem.Click += new System.EventHandler(this.изменитьДанныеОСтудентеToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дневноеОтделениеToolStripMenuItem,
            this.заочноеОтделениеToolStripMenuItem,
            this.дистанционноеОтделениеToolStripMenuItem,
            this.всеToolStripMenuItem,
            this.очиститьToolStripMenuItem1,
            this.заполнитьToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // дневноеОтделениеToolStripMenuItem
            // 
            this.дневноеОтделениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("дневноеОтделениеToolStripMenuItem.Image")));
            this.дневноеОтделениеToolStripMenuItem.Name = "дневноеОтделениеToolStripMenuItem";
            this.дневноеОтделениеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.дневноеОтделениеToolStripMenuItem.Text = "Дневное отделение";
            this.дневноеОтделениеToolStripMenuItem.Click += new System.EventHandler(this.дневноеОтделениеToolStripMenuItem_Click);
            // 
            // заочноеОтделениеToolStripMenuItem
            // 
            this.заочноеОтделениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заочноеОтделениеToolStripMenuItem.Image")));
            this.заочноеОтделениеToolStripMenuItem.Name = "заочноеОтделениеToolStripMenuItem";
            this.заочноеОтделениеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.заочноеОтделениеToolStripMenuItem.Text = "Заочное отделение";
            this.заочноеОтделениеToolStripMenuItem.Click += new System.EventHandler(this.заочноеОтделениеToolStripMenuItem_Click);
            // 
            // дистанционноеОтделениеToolStripMenuItem
            // 
            this.дистанционноеОтделениеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("дистанционноеОтделениеToolStripMenuItem.Image")));
            this.дистанционноеОтделениеToolStripMenuItem.Name = "дистанционноеОтделениеToolStripMenuItem";
            this.дистанционноеОтделениеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.дистанционноеОтделениеToolStripMenuItem.Text = "Дистанционное отделение";
            this.дистанционноеОтделениеToolStripMenuItem.Click += new System.EventHandler(this.дистанционноеОтделениеToolStripMenuItem_Click);
            // 
            // всеToolStripMenuItem
            // 
            this.всеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("всеToolStripMenuItem.Image")));
            this.всеToolStripMenuItem.Name = "всеToolStripMenuItem";
            this.всеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.всеToolStripMenuItem.Text = "Все";
            this.всеToolStripMenuItem.Click += new System.EventHandler(this.всеToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem1
            // 
            this.очиститьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("очиститьToolStripMenuItem1.Image")));
            this.очиститьToolStripMenuItem1.Name = "очиститьToolStripMenuItem1";
            this.очиститьToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.очиститьToolStripMenuItem1.Text = "Очистить";
            this.очиститьToolStripMenuItem1.Click += new System.EventHandler(this.очиститьToolStripMenuItem1_Click);
            // 
            // заполнитьToolStripMenuItem
            // 
            this.заполнитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заполнитьToolStripMenuItem.Image")));
            this.заполнитьToolStripMenuItem.Name = "заполнитьToolStripMenuItem";
            this.заполнитьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.заполнитьToolStripMenuItem.Text = "Заполнить";
            this.заполнитьToolStripMenuItem.Click += new System.EventHandler(this.заполнитьToolStripMenuItem_Click);
            // 
            // автоматическоеЗаполнениеToolStripMenuItem
            // 
            this.автоматическоеЗаполнениеToolStripMenuItem.Name = "автоматическоеЗаполнениеToolStripMenuItem";
            this.автоматическоеЗаполнениеToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.автоматическоеЗаполнениеToolStripMenuItem.Text = "Автоматическое заполнение";
            this.автоматическоеЗаполнениеToolStripMenuItem.Click += new System.EventHandler(this.автоматическоеЗаполнениеToolStripMenuItem_Click);
            // 
            // nameSearchBox
            // 
            this.nameSearchBox.Location = new System.Drawing.Point(4, 47);
            this.nameSearchBox.Name = "nameSearchBox";
            this.nameSearchBox.Size = new System.Drawing.Size(211, 20);
            this.nameSearchBox.TabIndex = 2;
            this.nameSearchBox.TextChanged += new System.EventHandler(this.nameSearchBox_TextChanged);
            // 
            // biletSearchBox
            // 
            this.biletSearchBox.Location = new System.Drawing.Point(325, 47);
            this.biletSearchBox.Name = "biletSearchBox";
            this.biletSearchBox.Size = new System.Drawing.Size(218, 20);
            this.biletSearchBox.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Поиск по имени";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(322, 31);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(132, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Поиск по номеру билета";
            // 
            // JournalBook
            // 
            this.JournalBook.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.JournalBook.Location = new System.Drawing.Point(652, 47);
            this.JournalBook.Multiline = true;
            this.JournalBook.Name = "JournalBook";
            this.JournalBook.ReadOnly = true;
            this.JournalBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JournalBook.Size = new System.Drawing.Size(224, 334);
            this.JournalBook.TabIndex = 6;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Black;
            this.linkLabel3.Location = new System.Drawing.Point(649, 31);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(106, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Журнал изменений";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // buttonNameSearch
            // 
            this.buttonNameSearch.Location = new System.Drawing.Point(224, 47);
            this.buttonNameSearch.Name = "buttonNameSearch";
            this.buttonNameSearch.Size = new System.Drawing.Size(95, 20);
            this.buttonNameSearch.TabIndex = 9;
            this.buttonNameSearch.Text = "Найти";
            this.buttonNameSearch.UseVisualStyleBackColor = true;
            this.buttonNameSearch.Click += new System.EventHandler(this.buttonNameSearch_Click);
            // 
            // buttonBiletSearch
            // 
            this.buttonBiletSearch.Location = new System.Drawing.Point(553, 47);
            this.buttonBiletSearch.Name = "buttonBiletSearch";
            this.buttonBiletSearch.Size = new System.Drawing.Size(92, 20);
            this.buttonBiletSearch.TabIndex = 10;
            this.buttonBiletSearch.Text = "Найти";
            this.buttonBiletSearch.UseVisualStyleBackColor = true;
            this.buttonBiletSearch.Click += new System.EventHandler(this.buttonBiletSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(888, 393);
            this.Controls.Add(this.buttonBiletSearch);
            this.Controls.Add(this.buttonNameSearch);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.JournalBook);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.biletSearchBox);
            this.Controls.Add(this.nameSearchBox);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Деканат ЭТФ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЖурналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчислитьДобавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчислитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеОСтудентеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дневноеОтделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заочноеОтделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дистанционноеОтделениеToolStripMenuItem;
        private System.Windows.Forms.TextBox nameSearchBox;
        private System.Windows.Forms.TextBox biletSearchBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox JournalBook;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ToolStripMenuItem автоматическоеЗаполнениеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonNameSearch;
        private System.Windows.Forms.Button buttonBiletSearch;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЖурналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИзБазыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem перевестиВДругоеОтделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиВЗаочноеОтдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевестиВДистанционноеОтдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьЖурналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьЖурналсериализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заполнитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйФайлToolStripMenuItem;
    }
}

