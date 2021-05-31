
namespace QRCheck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScanData = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шляхФайлаШаблонівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увымкнутиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інфоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelResultCheckTxt = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelScanStrTxt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPaternStrTxt = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimeTestTxt = new System.Windows.Forms.Label();
            this.labelBaoNumTxt = new System.Windows.Forms.Label();
            this.labelUniqlNumtxt = new System.Windows.Forms.Label();
            this.labelSerialNumtxt = new System.Windows.Forms.Label();
            this.labelTailyText = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimeTestData = new System.Windows.Forms.Label();
            this.labelBaoData = new System.Windows.Forms.Label();
            this.labelUniqNumData = new System.Windows.Forms.Label();
            this.labelSerialNumData = new System.Windows.Forms.Label();
            this.labelTailNumberData = new System.Windows.Forms.Label();
            this.panelAutoCheck = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxAutoTimeout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPathAutoCheckData = new System.Windows.Forms.Label();
            this.progressBarCheck = new System.Windows.Forms.ProgressBar();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelExitAutoCheck = new System.Windows.Forms.Label();
            this.labelInfoText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelAutoCheck.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTitle);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.labelStatus);
            this.splitContainer1.Panel2.Controls.Add(this.labelResultCheckTxt);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.labelInfoText);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 729);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxScanData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(183, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 110);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1157, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Зіскануйте QR код з етикетки =>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxScanData
            // 
            this.textBoxScanData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxScanData.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxScanData.Location = new System.Drawing.Point(3, 52);
            this.textBoxScanData.Name = "textBoxScanData";
            this.textBoxScanData.Size = new System.Drawing.Size(1157, 56);
            this.textBoxScanData.TabIndex = 8;
            this.textBoxScanData.Text = "Please scan QR...";
            this.textBoxScanData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScanData_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 110);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(0, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(1346, 36);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.Text = "QRC 2.0";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шляхФайлаШаблонівToolStripMenuItem,
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem,
            this.інфоToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // шляхФайлаШаблонівToolStripMenuItem
            // 
            this.шляхФайлаШаблонівToolStripMenuItem.Name = "шляхФайлаШаблонівToolStripMenuItem";
            this.шляхФайлаШаблонівToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.шляхФайлаШаблонівToolStripMenuItem.Text = "Шлях до файлу шаблонів";
            this.шляхФайлаШаблонівToolStripMenuItem.Click += new System.EventHandler(this.шляхФайлаШаблонівToolStripMenuItem_Click);
            // 
            // перевіркаВАвтоматичномуРежиміToolStripMenuItem
            // 
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увымкнутиToolStripMenuItem});
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem.Name = "перевіркаВАвтоматичномуРежиміToolStripMenuItem";
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.перевіркаВАвтоматичномуРежиміToolStripMenuItem.Text = "Перевірка в автоматичному режимі";
            // 
            // увымкнутиToolStripMenuItem
            // 
            this.увымкнутиToolStripMenuItem.Name = "увымкнутиToolStripMenuItem";
            this.увымкнутиToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.увымкнутиToolStripMenuItem.Text = "Увімкнути";
            this.увымкнутиToolStripMenuItem.Click += new System.EventHandler(this.увымкнутиToolStripMenuItem_Click);
            // 
            // інфоToolStripMenuItem
            // 
            this.інфоToolStripMenuItem.Name = "інфоToolStripMenuItem";
            this.інфоToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.інфоToolStripMenuItem.Text = "Інфо";
            this.інфоToolStripMenuItem.Click += new System.EventHandler(this.інфоToolStripMenuItem_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(0, 476);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(1346, 71);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.BackColorChanged += new System.EventHandler(this.labelStatus_BackColorChanged);
            // 
            // labelResultCheckTxt
            // 
            this.labelResultCheckTxt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelResultCheckTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelResultCheckTxt.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultCheckTxt.Location = new System.Drawing.Point(0, 443);
            this.labelResultCheckTxt.Name = "labelResultCheckTxt";
            this.labelResultCheckTxt.Size = new System.Drawing.Size(1346, 33);
            this.labelResultCheckTxt.TabIndex = 6;
            this.labelResultCheckTxt.Text = "Результат перевірки=>";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelScanStrTxt, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelPaternStrTxt, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 276);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1346, 167);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 53);
            this.panel2.TabIndex = 6;
            // 
            // labelScanStrTxt
            // 
            this.labelScanStrTxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelScanStrTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScanStrTxt.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScanStrTxt.Location = new System.Drawing.Point(3, 83);
            this.labelScanStrTxt.Name = "labelScanStrTxt";
            this.labelScanStrTxt.Size = new System.Drawing.Size(1340, 25);
            this.labelScanStrTxt.TabIndex = 5;
            this.labelScanStrTxt.Text = "Вхідні данні =>";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 52);
            this.panel1.TabIndex = 4;
            // 
            // labelPaternStrTxt
            // 
            this.labelPaternStrTxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelPaternStrTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPaternStrTxt.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaternStrTxt.Location = new System.Drawing.Point(3, 0);
            this.labelPaternStrTxt.Name = "labelPaternStrTxt";
            this.labelPaternStrTxt.Size = new System.Drawing.Size(1340, 25);
            this.labelPaternStrTxt.TabIndex = 1;
            this.labelPaternStrTxt.Text = "Шаблон =>";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer2.Location = new System.Drawing.Point(0, 44);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1346, 232);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelTimeTestTxt, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelBaoNumTxt, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelUniqlNumtxt, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelSerialNumtxt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelTailyText, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 232);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelTimeTestTxt
            // 
            this.labelTimeTestTxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelTimeTestTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeTestTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeTestTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeTestTxt.Location = new System.Drawing.Point(3, 184);
            this.labelTimeTestTxt.Name = "labelTimeTestTxt";
            this.labelTimeTestTxt.Size = new System.Drawing.Size(174, 48);
            this.labelTimeTestTxt.TabIndex = 5;
            this.labelTimeTestTxt.Text = "Testing date:";
            this.labelTimeTestTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBaoNumTxt
            // 
            this.labelBaoNumTxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelBaoNumTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBaoNumTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBaoNumTxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaoNumTxt.Location = new System.Drawing.Point(3, 138);
            this.labelBaoNumTxt.Name = "labelBaoNumTxt";
            this.labelBaoNumTxt.Size = new System.Drawing.Size(174, 46);
            this.labelBaoNumTxt.TabIndex = 4;
            this.labelBaoNumTxt.Text = "BAU group:";
            this.labelBaoNumTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUniqlNumtxt
            // 
            this.labelUniqlNumtxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelUniqlNumtxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUniqlNumtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUniqlNumtxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUniqlNumtxt.Location = new System.Drawing.Point(3, 92);
            this.labelUniqlNumtxt.Name = "labelUniqlNumtxt";
            this.labelUniqlNumtxt.Size = new System.Drawing.Size(174, 46);
            this.labelUniqlNumtxt.TabIndex = 3;
            this.labelUniqlNumtxt.Text = "Uniq number:";
            this.labelUniqlNumtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSerialNumtxt
            // 
            this.labelSerialNumtxt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSerialNumtxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSerialNumtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialNumtxt.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSerialNumtxt.Location = new System.Drawing.Point(3, 46);
            this.labelSerialNumtxt.Name = "labelSerialNumtxt";
            this.labelSerialNumtxt.Size = new System.Drawing.Size(174, 46);
            this.labelSerialNumtxt.TabIndex = 2;
            this.labelSerialNumtxt.Text = "Serial number:";
            this.labelSerialNumtxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTailyText
            // 
            this.labelTailyText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTailyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTailyText.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTailyText.Location = new System.Drawing.Point(3, 0);
            this.labelTailyText.Name = "labelTailyText";
            this.labelTailyText.Size = new System.Drawing.Size(174, 46);
            this.labelTailyText.TabIndex = 1;
            this.labelTailyText.Text = "Teilenummer:";
            this.labelTailyText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.splitContainer3.Panel2.Controls.Add(this.panelAutoCheck);
            this.splitContainer3.Size = new System.Drawing.Size(1162, 232);
            this.splitContainer3.SplitterDistance = 516;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelTimeTestData, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelBaoData, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelUniqNumData, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelSerialNumData, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTailNumberData, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(516, 232);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // labelTimeTestData
            // 
            this.labelTimeTestData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTimeTestData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTimeTestData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeTestData.Location = new System.Drawing.Point(3, 184);
            this.labelTimeTestData.Name = "labelTimeTestData";
            this.labelTimeTestData.Size = new System.Drawing.Size(510, 48);
            this.labelTimeTestData.TabIndex = 5;
            this.labelTimeTestData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBaoData
            // 
            this.labelBaoData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelBaoData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBaoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBaoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaoData.Location = new System.Drawing.Point(3, 138);
            this.labelBaoData.Name = "labelBaoData";
            this.labelBaoData.Size = new System.Drawing.Size(510, 46);
            this.labelBaoData.TabIndex = 4;
            this.labelBaoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUniqNumData
            // 
            this.labelUniqNumData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelUniqNumData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUniqNumData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUniqNumData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUniqNumData.Location = new System.Drawing.Point(3, 92);
            this.labelUniqNumData.Name = "labelUniqNumData";
            this.labelUniqNumData.Size = new System.Drawing.Size(510, 46);
            this.labelUniqNumData.TabIndex = 3;
            this.labelUniqNumData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSerialNumData
            // 
            this.labelSerialNumData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelSerialNumData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSerialNumData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSerialNumData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSerialNumData.Location = new System.Drawing.Point(3, 46);
            this.labelSerialNumData.Name = "labelSerialNumData";
            this.labelSerialNumData.Size = new System.Drawing.Size(510, 46);
            this.labelSerialNumData.TabIndex = 2;
            this.labelSerialNumData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTailNumberData
            // 
            this.labelTailNumberData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelTailNumberData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTailNumberData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTailNumberData.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTailNumberData.Location = new System.Drawing.Point(3, 0);
            this.labelTailNumberData.Name = "labelTailNumberData";
            this.labelTailNumberData.Size = new System.Drawing.Size(510, 46);
            this.labelTailNumberData.TabIndex = 1;
            this.labelTailNumberData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAutoCheck
            // 
            this.panelAutoCheck.Controls.Add(this.panel4);
            this.panelAutoCheck.Controls.Add(this.labelPathAutoCheckData);
            this.panelAutoCheck.Controls.Add(this.progressBarCheck);
            this.panelAutoCheck.Controls.Add(this.splitContainer4);
            this.panelAutoCheck.Controls.Add(this.checkBox1);
            this.panelAutoCheck.Controls.Add(this.labelExitAutoCheck);
            this.panelAutoCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAutoCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAutoCheck.Location = new System.Drawing.Point(0, 0);
            this.panelAutoCheck.Name = "panelAutoCheck";
            this.panelAutoCheck.Size = new System.Drawing.Size(642, 232);
            this.panelAutoCheck.TabIndex = 0;
            this.panelAutoCheck.VisibleChanged += new System.EventHandler(this.panelAutoCheck_VisibleChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxAutoTimeout);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 35);
            this.panel4.TabIndex = 20;
            // 
            // textBoxAutoTimeout
            // 
            this.textBoxAutoTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAutoTimeout.Location = new System.Drawing.Point(79, 3);
            this.textBoxAutoTimeout.Name = "textBoxAutoTimeout";
            this.textBoxAutoTimeout.Size = new System.Drawing.Size(50, 29);
            this.textBoxAutoTimeout.TabIndex = 20;
            this.textBoxAutoTimeout.Text = "1";
            this.textBoxAutoTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = " Sec.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "TimeOut =";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPathAutoCheckData
            // 
            this.labelPathAutoCheckData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPathAutoCheckData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPathAutoCheckData.Location = new System.Drawing.Point(0, 115);
            this.labelPathAutoCheckData.Name = "labelPathAutoCheckData";
            this.labelPathAutoCheckData.Size = new System.Drawing.Size(642, 30);
            this.labelPathAutoCheckData.TabIndex = 15;
            this.labelPathAutoCheckData.Text = "Файл:";
            this.labelPathAutoCheckData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarCheck
            // 
            this.progressBarCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarCheck.Location = new System.Drawing.Point(0, 145);
            this.progressBarCheck.Name = "progressBarCheck";
            this.progressBarCheck.Size = new System.Drawing.Size(642, 39);
            this.progressBarCheck.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCheck.TabIndex = 12;
            this.progressBarCheck.Tag = "";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer4.Location = new System.Drawing.Point(0, 184);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.buttonSTART);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button1);
            this.splitContainer4.Size = new System.Drawing.Size(642, 48);
            this.splitContainer4.SplitterDistance = 328;
            this.splitContainer4.TabIndex = 6;
            // 
            // buttonSTART
            // 
            this.buttonSTART.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonSTART.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSTART.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSTART.Location = new System.Drawing.Point(0, 0);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(328, 48);
            this.buttonSTART.TabIndex = 8;
            this.buttonSTART.Text = "START >";
            this.buttonSTART.UseVisualStyleBackColor = false;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "PAUSE ||";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(0, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(281, 43);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Перевірити в фоновому режимі";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelExitAutoCheck
            // 
            this.labelExitAutoCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExitAutoCheck.BackColor = System.Drawing.Color.Crimson;
            this.labelExitAutoCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExitAutoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExitAutoCheck.ForeColor = System.Drawing.Color.White;
            this.labelExitAutoCheck.Location = new System.Drawing.Point(599, 0);
            this.labelExitAutoCheck.Name = "labelExitAutoCheck";
            this.labelExitAutoCheck.Size = new System.Drawing.Size(45, 36);
            this.labelExitAutoCheck.TabIndex = 2;
            this.labelExitAutoCheck.Text = "X";
            this.labelExitAutoCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExitAutoCheck.Click += new System.EventHandler(this.labelExitAutoCheck_Click);
            // 
            // labelInfoText
            // 
            this.labelInfoText.BackColor = System.Drawing.Color.SeaGreen;
            this.labelInfoText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoText.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoText.Location = new System.Drawing.Point(0, 0);
            this.labelInfoText.Name = "labelInfoText";
            this.labelInfoText.Size = new System.Drawing.Size(1346, 44);
            this.labelInfoText.TabIndex = 0;
            this.labelInfoText.Text = "Інфо:";
            this.labelInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "DataList";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Вкажіть місце збереження Файлу статистики";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.RestoreDirectory = true;
            this.openFileDialog2.Title = "Виберіть txt файл з данними";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelAutoCheck.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelInfoText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шляхФайлаШаблонівToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelScanStrTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPaternStrTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScanData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelResultCheckTxt;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTimeTestTxt;
        private System.Windows.Forms.Label labelBaoNumTxt;
        private System.Windows.Forms.Label labelUniqlNumtxt;
        private System.Windows.Forms.Label labelSerialNumtxt;
        private System.Windows.Forms.Label labelTailyText;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTimeTestData;
        private System.Windows.Forms.Label labelBaoData;
        private System.Windows.Forms.Label labelUniqNumData;
        private System.Windows.Forms.Label labelSerialNumData;
        private System.Windows.Forms.Label labelTailNumberData;
        private System.Windows.Forms.Panel panelAutoCheck;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem перевіркаВАвтоматичномуРежиміToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увымкнутиToolStripMenuItem;
        private System.Windows.Forms.Label labelExitAutoCheck;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelPathAutoCheckData;
        private System.Windows.Forms.ProgressBar progressBarCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxAutoTimeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem інфоToolStripMenuItem;
    }
}

