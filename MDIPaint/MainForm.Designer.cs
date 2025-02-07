namespace MDIPaint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерХолстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectRedColor = new System.Windows.Forms.ToolStripButton();
            this.selectGreenColor = new System.Windows.Forms.ToolStripButton();
            this.selectBlueColor = new System.Windows.Forms.ToolStripButton();
            this.selectAnyColor = new System.Windows.Forms.ToolStripButton();
            this.choosePenWidth = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFontButton = new System.Windows.Forms.ToolStripButton();
            this.choosePen = new System.Windows.Forms.ToolStripButton();
            this.chooseEraser = new System.Windows.Forms.ToolStripButton();
            this.chooseLine = new System.Windows.Forms.ToolStripButton();
            this.chooseCircle = new System.Windows.Forms.ToolStripButton();
            this.chooseFilledCircle = new System.Windows.Forms.ToolStripButton();
            this.chooseRectangle = new System.Windows.Forms.ToolStripButton();
            this.chooseFilledRectangle = new System.Windows.Forms.ToolStripButton();
            this.chooseTextButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutButton = new System.Windows.Forms.ToolStripButton();
            this.bucketOfPaintButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.файлToolStripMenuItem.Text = "&Файл";
            this.файлToolStripMenuItem.DropDownOpening += new System.EventHandler(this.файлToolStripMenuItem_DropDownOpening);
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.новыйToolStripMenuItem.Text = "&Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(338, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.сохранитьКакToolStripMenuItem.Text = "&Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(338, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(341, 34);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерХолстаToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(95, 30);
            this.рисунокToolStripMenuItem.Text = "&Рисунок";
            this.рисунокToolStripMenuItem.DropDownOpening += new System.EventHandler(this.рисунокToolStripMenuItem_DropDownOpening);
            // 
            // размерХолстаToolStripMenuItem
            // 
            this.размерХолстаToolStripMenuItem.Name = "размерХолстаToolStripMenuItem";
            this.размерХолстаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.размерХолстаToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.размерХолстаToolStripMenuItem.Text = "&Размер холста";
            this.размерХолстаToolStripMenuItem.Click += new System.EventHandler(this.размерХолстаToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(72, 30);
            this.окноToolStripMenuItem.Text = "&Окно";
            this.окноToolStripMenuItem.DropDownOpening += new System.EventHandler(this.окноToolStripMenuItem_DropDownOpening);
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.каскадомToolStripMenuItem.Text = "&Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.слеваНаправоToolStripMenuItem.Text = "&Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.слеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.сверхуВнизToolStripMenuItem.Text = "&Сверху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(301, 34);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "&Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 30);
            this.справкаToolStripMenuItem.Text = "&Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(280, 34);
            this.оПрограммеToolStripMenuItem.Text = "&О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRedColor,
            this.selectGreenColor,
            this.selectBlueColor,
            this.selectAnyColor,
            this.choosePenWidth,
            this.manageFontButton,
            this.toolStripSeparator3,
            this.choosePen,
            this.chooseEraser,
            this.chooseLine,
            this.chooseCircle,
            this.chooseFilledCircle,
            this.chooseRectangle,
            this.chooseFilledRectangle,
            this.chooseTextButton,
            this.zoomInButton,
            this.zoomOutButton,
            this.toolStripSeparator4,
            this.bucketOfPaintButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelSize,
            this.statusLabelColor,
            this.statusLabelPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelSize
            // 
            this.statusLabelSize.Name = "statusLabelSize";
            this.statusLabelSize.Size = new System.Drawing.Size(135, 25);
            this.statusLabelSize.Text = "Размер пера: 1";
            // 
            // statusLabelColor
            // 
            this.statusLabelColor.Name = "statusLabelColor";
            this.statusLabelColor.Size = new System.Drawing.Size(144, 25);
            this.statusLabelColor.Text = "Цвет пера: Black";
            // 
            // statusLabelPosition
            // 
            this.statusLabelPosition.Name = "statusLabelPosition";
            this.statusLabelPosition.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // selectRedColor
            // 
            this.selectRedColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectRedColor.Image = ((System.Drawing.Image)(resources.GetObject("selectRedColor.Image")));
            this.selectRedColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectRedColor.Name = "selectRedColor";
            this.selectRedColor.Size = new System.Drawing.Size(34, 33);
            this.selectRedColor.Text = "toolStripButton1";
            this.selectRedColor.ToolTipText = "Выбрать красный цвет";
            this.selectRedColor.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // selectGreenColor
            // 
            this.selectGreenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectGreenColor.Image = global::MDIPaint.Properties.Resources.GreenColorIcon;
            this.selectGreenColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectGreenColor.Name = "selectGreenColor";
            this.selectGreenColor.Size = new System.Drawing.Size(34, 33);
            this.selectGreenColor.Text = "selectGreenColor";
            this.selectGreenColor.ToolTipText = "Выбрать зелёный цвет";
            this.selectGreenColor.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // selectBlueColor
            // 
            this.selectBlueColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectBlueColor.Image = global::MDIPaint.Properties.Resources.BlueColorIcon;
            this.selectBlueColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectBlueColor.Name = "selectBlueColor";
            this.selectBlueColor.Size = new System.Drawing.Size(34, 33);
            this.selectBlueColor.Text = "selectBlueColor";
            this.selectBlueColor.ToolTipText = "Выбрать синий цвет";
            this.selectBlueColor.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // selectAnyColor
            // 
            this.selectAnyColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectAnyColor.Image = global::MDIPaint.Properties.Resources.ColorSelectionIcon;
            this.selectAnyColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectAnyColor.Name = "selectAnyColor";
            this.selectAnyColor.Size = new System.Drawing.Size(34, 33);
            this.selectAnyColor.Text = "selectAnyColor";
            this.selectAnyColor.ToolTipText = "Выбрать любой цвет";
            this.selectAnyColor.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // choosePenWidth
            // 
            this.choosePenWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.choosePenWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.choosePenWidth.Image = global::MDIPaint.Properties.Resources.ruler;
            this.choosePenWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.choosePenWidth.Name = "choosePenWidth";
            this.choosePenWidth.Size = new System.Drawing.Size(42, 33);
            this.choosePenWidth.Text = "choosePenWidth";
            this.choosePenWidth.ToolTipText = "Выбрать размер кисти";
            this.choosePenWidth.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(134, 34);
            this.toolStripMenuItem11.Text = "10";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // manageFontButton
            // 
            this.manageFontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.manageFontButton.Image = global::MDIPaint.Properties.Resources.font_size;
            this.manageFontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.manageFontButton.Name = "manageFontButton";
            this.manageFontButton.Size = new System.Drawing.Size(34, 33);
            this.manageFontButton.Text = "toolStripButton2";
            this.manageFontButton.ToolTipText = "Настроить шрифт";
            this.manageFontButton.Click += new System.EventHandler(this.manageFontButton_Click);
            // 
            // choosePen
            // 
            this.choosePen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.choosePen.Image = global::MDIPaint.Properties.Resources.feather;
            this.choosePen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.choosePen.Name = "choosePen";
            this.choosePen.Size = new System.Drawing.Size(34, 33);
            this.choosePen.Text = "Перо";
            this.choosePen.ToolTipText = "Выбрать инструмент перо";
            this.choosePen.Click += new System.EventHandler(this.choosePen_Click);
            // 
            // chooseEraser
            // 
            this.chooseEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseEraser.Image = global::MDIPaint.Properties.Resources.eraser;
            this.chooseEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseEraser.Name = "chooseEraser";
            this.chooseEraser.Size = new System.Drawing.Size(34, 33);
            this.chooseEraser.Text = "toolStripButton1";
            this.chooseEraser.ToolTipText = "Выбрать инструмент ластик";
            this.chooseEraser.Click += new System.EventHandler(this.chooseEraser_Click);
            // 
            // chooseLine
            // 
            this.chooseLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseLine.Image = global::MDIPaint.Properties.Resources.diagonal_line;
            this.chooseLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseLine.Name = "chooseLine";
            this.chooseLine.Size = new System.Drawing.Size(34, 33);
            this.chooseLine.Text = "toolStripButton1";
            this.chooseLine.ToolTipText = "Выбрать инструмент линия";
            this.chooseLine.Click += new System.EventHandler(this.chooseLine_Click);
            // 
            // chooseCircle
            // 
            this.chooseCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseCircle.Image = global::MDIPaint.Properties.Resources.dry_clean;
            this.chooseCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseCircle.Name = "chooseCircle";
            this.chooseCircle.Size = new System.Drawing.Size(34, 33);
            this.chooseCircle.Text = "Окружность";
            this.chooseCircle.ToolTipText = "Выбрать инструмент окружность";
            this.chooseCircle.Click += new System.EventHandler(this.chooseCircle_Click);
            // 
            // chooseFilledCircle
            // 
            this.chooseFilledCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseFilledCircle.Image = global::MDIPaint.Properties.Resources.circle;
            this.chooseFilledCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseFilledCircle.Name = "chooseFilledCircle";
            this.chooseFilledCircle.Size = new System.Drawing.Size(34, 33);
            this.chooseFilledCircle.Text = "toolStripButton1";
            this.chooseFilledCircle.ToolTipText = "Выбрать инструмент закрашенная окружность";
            this.chooseFilledCircle.Click += new System.EventHandler(this.chooseFilledCircle_Click);
            // 
            // chooseRectangle
            // 
            this.chooseRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseRectangle.Image = global::MDIPaint.Properties.Resources.rectangular_shape_outline;
            this.chooseRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseRectangle.Name = "chooseRectangle";
            this.chooseRectangle.Size = new System.Drawing.Size(34, 33);
            this.chooseRectangle.Text = "Прямоугольник";
            this.chooseRectangle.ToolTipText = "Выбрать инструмент прямоугольник";
            this.chooseRectangle.Click += new System.EventHandler(this.chooseRectangle_Click);
            // 
            // chooseFilledRectangle
            // 
            this.chooseFilledRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseFilledRectangle.Image = global::MDIPaint.Properties.Resources.rectangleF;
            this.chooseFilledRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseFilledRectangle.Name = "chooseFilledRectangle";
            this.chooseFilledRectangle.Size = new System.Drawing.Size(34, 33);
            this.chooseFilledRectangle.Text = "toolStripButton2";
            this.chooseFilledRectangle.ToolTipText = "Выбрать инструмент закрашенный прямоугольник";
            this.chooseFilledRectangle.Click += new System.EventHandler(this.chooseFilledRectangle_Click);
            // 
            // chooseTextButton
            // 
            this.chooseTextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseTextButton.Image = global::MDIPaint.Properties.Resources.text;
            this.chooseTextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseTextButton.Name = "chooseTextButton";
            this.chooseTextButton.Size = new System.Drawing.Size(34, 33);
            this.chooseTextButton.Text = "chooseTextButton";
            this.chooseTextButton.ToolTipText = "Выбрать инструмент текст";
            this.chooseTextButton.Click += new System.EventHandler(this.chooseTextButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInButton.Image = global::MDIPaint.Properties.Resources.zoom_in;
            this.zoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(34, 33);
            this.zoomInButton.Text = "toolStripButton2";
            this.zoomInButton.ToolTipText = "Увеличить масштаб изображения";
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.zoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutButton.Image = global::MDIPaint.Properties.Resources.zoom_out;
            this.zoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(34, 33);
            this.zoomOutButton.Text = "toolStripButton1";
            this.zoomOutButton.ToolTipText = "Уменьшить масштаб изображения";
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // bucketOfPaintButton
            // 
            this.bucketOfPaintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bucketOfPaintButton.Image = global::MDIPaint.Properties.Resources.fill;
            this.bucketOfPaintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bucketOfPaintButton.Name = "bucketOfPaintButton";
            this.bucketOfPaintButton.Size = new System.Drawing.Size(34, 33);
            this.bucketOfPaintButton.Text = "toolStripButton1";
            this.bucketOfPaintButton.ToolTipText = "Выбрать инструмент ведро с краской";
            this.bucketOfPaintButton.Click += new System.EventHandler(this.bucketOfPaintButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MDIPaint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерХолстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton selectGreenColor;
        private System.Windows.Forms.ToolStripButton selectBlueColor;
        private System.Windows.Forms.ToolStripButton selectAnyColor;
        private System.Windows.Forms.ToolStripButton selectRedColor;
        private System.Windows.Forms.ToolStripDropDownButton choosePenWidth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton choosePen;
        private System.Windows.Forms.ToolStripButton chooseCircle;
        private System.Windows.Forms.ToolStripButton chooseRectangle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSize;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelPosition;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelColor;
        private System.Windows.Forms.ToolStripButton chooseEraser;
        private System.Windows.Forms.ToolStripButton chooseLine;
        private System.Windows.Forms.ToolStripButton chooseFilledCircle;
        private System.Windows.Forms.ToolStripButton chooseFilledRectangle;
        private System.Windows.Forms.ToolStripButton zoomOutButton;
        private System.Windows.Forms.ToolStripButton zoomInButton;
        private System.Windows.Forms.ToolStripButton manageFontButton;
        private System.Windows.Forms.ToolStripButton chooseTextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton bucketOfPaintButton;
    }
}

