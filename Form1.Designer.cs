namespace My_Assistant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AdressofOrderComboBox = new ComboBox();
            AdressofOrderLabel = new Label();
            Battery0TextBox = new TextBox();
            Battery14TextBox = new TextBox();
            BatteryCopyButton = new Button();
            BatteryDateTimePicker = new DateTimePicker();
            BatteryDateTimePicker2 = new DateTimePicker();
            BatteryResetButton = new Button();
            BatteryRichTextBox = new RichTextBox();
            CancelPreorderButton = new Button();
            CleanersClearButton = new Button();
            CleanersCopyButton = new Button();
            CleanersDateTimePicker = new DateTimePicker();
            CleanersDateTimePicker2 = new DateTimePicker();
            CleanersLabel = new Label();
            CleanersPasteButton = new Button();
            CleanersResetButton = new Button();
            CleanersRichTextBox = new RichTextBox();
            CleanersTextBox = new TextBox();
            ClearBattery0Button = new Button();
            ClearBattery14Button = new Button();
            ClearCPU0Button = new Button();
            ClearCPU14Button = new Button();
            ClearShip0Button = new Button();
            ClearShip14Button = new Button();
            CopyHomeButton = new Button();
            CopyOKButton = new Button();
            CourrierButton = new Button();
            CourrierLabel = new Label();
            CPU0Label = new Label();
            CPU0TextBox = new TextBox();
            CPU14TextBox = new TextBox();
            CPUCopyButton = new Button();
            CPUDateTimePicker = new DateTimePicker();
            CPUDateTimePicker2 = new DateTimePicker();
            CPULabel = new Label();
            CPUResetButton = new Button();
            CPURichTextBox = new RichTextBox();
            DeleteHomeButton = new Button();
            HomeRichTextBox = new RichTextBox();
            HomeTabPage = new TabPage();
            panel1 = new Panel();
            NotesLlabel = new Label();
            OnHoldComboBox = new ComboBox();
            OnHoldLabel = new Label();
            NotesPanel = new Panel();
            SMSComboBox = new ComboBox();
            SMSLabel = new Label();
            SendSMSCustomerLlabel = new Label();
            SendMsgComboBox = new ComboBox();
            SendMsgLabel = new Label();
            CPU14Label = new Label();
            CleanersorLabel = new Label();
            Battery14Label = new Label();
            CPUorLabel = new Label();
            BatteryorLabel = new Label();
            Battery0Label = new Label();
            Ship14Label = new Label();
            ShiporLabel = new Label();
            Ship0Label = new Label();
            OrdersTabPage = new TabPage();
            Battery0CopyButton = new Button();
            CPU0CopyButton = new Button();
            Ship0CopyButton = new Button();
            CleanersAutoButton = new Button();
            ShipAutoButton = new Button();
            PasteBattery0Button = new Button();
            PasteBattery14Button = new Button();
            PasteCPU0Button = new Button();
            PasteCPU14Button = new Button();
            PasteShip0Button = new Button();
            PasteShip14Button = new Button();
            Ship0TextBox = new TextBox();
            Ship14TextBox = new TextBox();
            ShipCopyButton = new Button();
            ShipDateTimePicker = new DateTimePicker();
            ShipDateTimePicker2 = new DateTimePicker();
            ShipLabel = new Label();
            ShipResetButton = new Button();
            ShipRichTextBox = new RichTextBox();
            ShipButton = new Button();
            SuppliersCopyButton = new Button();
            SuppliersDeleteButton = new Button();
            SuppliersRichTextBox = new RichTextBox();
            SupplierTabPage = new TabPage();
            TabControl = new TabControl();
            HomeTabPage.SuspendLayout();
            panel1.SuspendLayout();
            NotesPanel.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            SupplierTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // AdressofOrderComboBox
            // 
            AdressofOrderComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AdressofOrderComboBox.FormattingEnabled = true;
            AdressofOrderComboBox.Items.AddRange(new object[] { "Λάρνακα", "Λεμεσό", "Λευκωσία" });
            AdressofOrderComboBox.Location = new Point(185, 32);
            AdressofOrderComboBox.Name = "AdressofOrderComboBox";
            AdressofOrderComboBox.Size = new Size(198, 23);
            AdressofOrderComboBox.TabIndex = 2;
            AdressofOrderComboBox.SelectedIndexChanged += AdressofOrderComboBox_SelectedIndexChanged;
            // 
            // AdressofOrderLabel
            // 
            AdressofOrderLabel.AutoSize = true;
            AdressofOrderLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AdressofOrderLabel.Location = new Point(14, 35);
            AdressofOrderLabel.Name = "AdressofOrderLabel";
            AdressofOrderLabel.Size = new Size(165, 15);
            AdressofOrderLabel.TabIndex = 1;
            AdressofOrderLabel.Text = "Έστειλα για διευθέτηση στην:";
            // 
            // Battery0TextBox
            // 
            Battery0TextBox.Location = new Point(23, 170);
            Battery0TextBox.Name = "Battery0TextBox";
            Battery0TextBox.Size = new Size(206, 23);
            Battery0TextBox.TabIndex = 22;
            // 
            // Battery14TextBox
            // 
            Battery14TextBox.Location = new Point(23, 143);
            Battery14TextBox.Name = "Battery14TextBox";
            Battery14TextBox.Size = new Size(206, 23);
            Battery14TextBox.TabIndex = 17;
            // 
            // BatteryCopyButton
            // 
            BatteryCopyButton.BackColor = Color.Chartreuse;
            BatteryCopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BatteryCopyButton.Location = new Point(333, 198);
            BatteryCopyButton.Name = "BatteryCopyButton";
            BatteryCopyButton.Size = new Size(49, 41);
            BatteryCopyButton.TabIndex = 47;
            BatteryCopyButton.Text = "Copy";
            BatteryCopyButton.UseVisualStyleBackColor = false;
            BatteryCopyButton.Click += BatteryCopyButton_Click;
            // 
            // BatteryDateTimePicker
            // 
            BatteryDateTimePicker.CustomFormat = "dd/MM";
            BatteryDateTimePicker.Format = DateTimePickerFormat.Custom;
            BatteryDateTimePicker.Location = new Point(296, 143);
            BatteryDateTimePicker.Name = "BatteryDateTimePicker";
            BatteryDateTimePicker.Size = new Size(50, 23);
            BatteryDateTimePicker.TabIndex = 15;
            BatteryDateTimePicker.ValueChanged += BatteryDateTimePicker_ValueChanged;
            // 
            // BatteryDateTimePicker2
            // 
            BatteryDateTimePicker2.CustomFormat = "dd/MM/yy";
            BatteryDateTimePicker2.Format = DateTimePickerFormat.Custom;
            BatteryDateTimePicker2.Location = new Point(366, 143);
            BatteryDateTimePicker2.Name = "BatteryDateTimePicker2";
            BatteryDateTimePicker2.Size = new Size(49, 23);
            BatteryDateTimePicker2.TabIndex = 21;
            BatteryDateTimePicker2.ValueChanged += BatteryDateTimePicker2_ValueChanged;
            // 
            // BatteryResetButton
            // 
            BatteryResetButton.BackColor = Color.DarkSalmon;
            BatteryResetButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BatteryResetButton.Location = new Point(383, 198);
            BatteryResetButton.Name = "BatteryResetButton";
            BatteryResetButton.Size = new Size(49, 41);
            BatteryResetButton.TabIndex = 46;
            BatteryResetButton.Text = "Reset";
            BatteryResetButton.UseVisualStyleBackColor = false;
            BatteryResetButton.Click += BatteryResetButton_Click;
            // 
            // BatteryRichTextBox
            // 
            BatteryRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BatteryRichTextBox.Location = new Point(23, 198);
            BatteryRichTextBox.Name = "BatteryRichTextBox";
            BatteryRichTextBox.Size = new Size(304, 41);
            BatteryRichTextBox.TabIndex = 45;
            BatteryRichTextBox.Text = "";
            // 
            // CancelPreorderButton
            // 
            CancelPreorderButton.Location = new Point(8, 93);
            CancelPreorderButton.Name = "CancelPreorderButton";
            CancelPreorderButton.Size = new Size(168, 23);
            CancelPreorderButton.TabIndex = 3;
            CancelPreorderButton.Text = "Ακύρωση προέγκρισης";
            CancelPreorderButton.UseVisualStyleBackColor = true;
            CancelPreorderButton.Click += CancelPreorderButton_Click;
            // 
            // CleanersClearButton
            // 
            CleanersClearButton.BackColor = Color.DarkSalmon;
            CleanersClearButton.Location = new Point(253, 379);
            CleanersClearButton.Name = "CleanersClearButton";
            CleanersClearButton.Size = new Size(23, 23);
            CleanersClearButton.TabIndex = 42;
            CleanersClearButton.Text = "✖";
            CleanersClearButton.UseVisualStyleBackColor = false;
            CleanersClearButton.Click += ClearCleanersButton_Click;
            // 
            // CleanersCopyButton
            // 
            CleanersCopyButton.BackColor = Color.Chartreuse;
            CleanersCopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CleanersCopyButton.Location = new Point(333, 432);
            CleanersCopyButton.Name = "CleanersCopyButton";
            CleanersCopyButton.Size = new Size(49, 41);
            CleanersCopyButton.TabIndex = 53;
            CleanersCopyButton.Text = "Copy";
            CleanersCopyButton.UseVisualStyleBackColor = false;
            CleanersCopyButton.Click += CleanersCopyButton_Click;
            // 
            // CleanersDateTimePicker
            // 
            CleanersDateTimePicker.CustomFormat = "dd/MM";
            CleanersDateTimePicker.Format = DateTimePickerFormat.Custom;
            CleanersDateTimePicker.Location = new Point(296, 379);
            CleanersDateTimePicker.Name = "CleanersDateTimePicker";
            CleanersDateTimePicker.Size = new Size(50, 23);
            CleanersDateTimePicker.TabIndex = 39;
            CleanersDateTimePicker.ValueChanged += CleanersDateTimePicker_ValueChanged;
            // 
            // CleanersDateTimePicker2
            // 
            CleanersDateTimePicker2.CustomFormat = "dd/MM";
            CleanersDateTimePicker2.Format = DateTimePickerFormat.Custom;
            CleanersDateTimePicker2.Location = new Point(366, 379);
            CleanersDateTimePicker2.Name = "CleanersDateTimePicker2";
            CleanersDateTimePicker2.Size = new Size(49, 23);
            CleanersDateTimePicker2.TabIndex = 44;
            CleanersDateTimePicker2.ValueChanged += CleanersDateTimePicker2_ValueChanged;
            // 
            // CleanersLabel
            // 
            CleanersLabel.AutoSize = true;
            CleanersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CleanersLabel.Location = new Point(62, 362);
            CleanersLabel.Name = "CleanersLabel";
            CleanersLabel.Size = new Size(141, 15);
            CleanersLabel.TabIndex = 38;
            CleanersLabel.Text = "Πάνες - Μωρομάντηλα";
            // 
            // CleanersPasteButton
            // 
            CleanersPasteButton.BackColor = Color.DeepSkyBlue;
            CleanersPasteButton.Location = new Point(230, 379);
            CleanersPasteButton.Name = "CleanersPasteButton";
            CleanersPasteButton.Size = new Size(23, 23);
            CleanersPasteButton.TabIndex = 41;
            CleanersPasteButton.Text = "P";
            CleanersPasteButton.UseVisualStyleBackColor = false;
            CleanersPasteButton.Click += CleanersPasteButton_Click;
            // 
            // CleanersResetButton
            // 
            CleanersResetButton.BackColor = Color.DarkSalmon;
            CleanersResetButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CleanersResetButton.Location = new Point(383, 432);
            CleanersResetButton.Name = "CleanersResetButton";
            CleanersResetButton.Size = new Size(49, 41);
            CleanersResetButton.TabIndex = 52;
            CleanersResetButton.Text = "Reset";
            CleanersResetButton.UseVisualStyleBackColor = false;
            CleanersResetButton.Click += CleanersResetButton_Click;
            // 
            // CleanersRichTextBox
            // 
            CleanersRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CleanersRichTextBox.Location = new Point(23, 432);
            CleanersRichTextBox.Name = "CleanersRichTextBox";
            CleanersRichTextBox.Size = new Size(304, 41);
            CleanersRichTextBox.TabIndex = 51;
            CleanersRichTextBox.Text = "";
            // 
            // CleanersTextBox
            // 
            CleanersTextBox.Location = new Point(23, 379);
            CleanersTextBox.Name = "CleanersTextBox";
            CleanersTextBox.Size = new Size(206, 23);
            CleanersTextBox.TabIndex = 40;
            // 
            // ClearBattery0Button
            // 
            ClearBattery0Button.BackColor = Color.DarkSalmon;
            ClearBattery0Button.Location = new Point(276, 170);
            ClearBattery0Button.Name = "ClearBattery0Button";
            ClearBattery0Button.Size = new Size(23, 23);
            ClearBattery0Button.TabIndex = 24;
            ClearBattery0Button.Text = "✖";
            ClearBattery0Button.UseVisualStyleBackColor = false;
            ClearBattery0Button.Click += ClearBattery0Button_Click;
            // 
            // ClearBattery14Button
            // 
            ClearBattery14Button.BackColor = Color.DarkSalmon;
            ClearBattery14Button.Location = new Point(253, 143);
            ClearBattery14Button.Name = "ClearBattery14Button";
            ClearBattery14Button.Size = new Size(23, 23);
            ClearBattery14Button.TabIndex = 19;
            ClearBattery14Button.Text = "✖";
            ClearBattery14Button.UseVisualStyleBackColor = false;
            ClearBattery14Button.Click += ClearBattery14Button_Click;
            // 
            // ClearCPU0Button
            // 
            ClearCPU0Button.BackColor = Color.DarkSalmon;
            ClearCPU0Button.Location = new Point(276, 53);
            ClearCPU0Button.Name = "ClearCPU0Button";
            ClearCPU0Button.Size = new Size(23, 23);
            ClearCPU0Button.TabIndex = 12;
            ClearCPU0Button.Text = "✖";
            ClearCPU0Button.UseVisualStyleBackColor = false;
            ClearCPU0Button.Click += ClearCPU0Button_Click;
            // 
            // ClearCPU14Button
            // 
            ClearCPU14Button.BackColor = Color.DarkSalmon;
            ClearCPU14Button.Location = new Point(253, 25);
            ClearCPU14Button.Name = "ClearCPU14Button";
            ClearCPU14Button.Size = new Size(23, 23);
            ClearCPU14Button.TabIndex = 7;
            ClearCPU14Button.Text = "✖";
            ClearCPU14Button.UseVisualStyleBackColor = false;
            ClearCPU14Button.Click += ClearCPU14Button_Click;
            // 
            // ClearShip0Button
            // 
            ClearShip0Button.BackColor = Color.DarkSalmon;
            ClearShip0Button.Location = new Point(276, 288);
            ClearShip0Button.Name = "ClearShip0Button";
            ClearShip0Button.Size = new Size(23, 23);
            ClearShip0Button.TabIndex = 36;
            ClearShip0Button.Text = "✖";
            ClearShip0Button.UseVisualStyleBackColor = false;
            ClearShip0Button.Click += ClearShip0Button_Click;
            // 
            // ClearShip14Button
            // 
            ClearShip14Button.BackColor = Color.DarkSalmon;
            ClearShip14Button.Location = new Point(253, 261);
            ClearShip14Button.Name = "ClearShip14Button";
            ClearShip14Button.Size = new Size(23, 23);
            ClearShip14Button.TabIndex = 31;
            ClearShip14Button.Text = "✖";
            ClearShip14Button.UseVisualStyleBackColor = false;
            ClearShip14Button.Click += ClearShip14Button_Click;
            // 
            // CopyHomeButton
            // 
            CopyHomeButton.BackColor = Color.Chartreuse;
            CopyHomeButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CopyHomeButton.Location = new Point(6, 253);
            CopyHomeButton.Name = "CopyHomeButton";
            CopyHomeButton.Size = new Size(138, 43);
            CopyHomeButton.TabIndex = 20;
            CopyHomeButton.Text = "Αντιγραφή";
            CopyHomeButton.UseVisualStyleBackColor = false;
            CopyHomeButton.Click += CopyHomeButton_Click;
            // 
            // CopyOKButton
            // 
            CopyOKButton.Location = new Point(8, 64);
            CopyOKButton.Name = "CopyOKButton";
            CopyOKButton.Size = new Size(168, 23);
            CopyOKButton.TabIndex = 2;
            CopyOKButton.Text = "Αντιγραφή ΟΚ";
            CopyOKButton.UseVisualStyleBackColor = true;
            CopyOKButton.Click += CopyOKButton_Click;
            // 
            // CourrierButton
            // 
            CourrierButton.Location = new Point(8, 6);
            CourrierButton.Name = "CourrierButton";
            CourrierButton.Size = new Size(168, 23);
            CourrierButton.TabIndex = 0;
            CourrierButton.Text = "Courier + Λειτουργικά";
            CourrierButton.UseVisualStyleBackColor = true;
            CourrierButton.Click += CourrierButton_Click;
            // 
            // CourrierLabel
            // 
            CourrierLabel.AutoSize = true;
            CourrierLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CourrierLabel.Location = new Point(68, 125);
            CourrierLabel.Name = "CourrierLabel";
            CourrierLabel.Size = new Size(130, 15);
            CourrierLabel.TabIndex = 14;
            CourrierLabel.Text = "Courier με μπαταρίες";
            // 
            // CPU0Label
            // 
            CPU0Label.AutoSize = true;
            CPU0Label.ForeColor = Color.IndianRed;
            CPU0Label.Location = new Point(7, 57);
            CPU0Label.Name = "CPU0Label";
            CPU0Label.Size = new Size(13, 15);
            CPU0Label.TabIndex = 2;
            CPU0Label.Text = "0";
            // 
            // CPU0TextBox
            // 
            CPU0TextBox.Location = new Point(23, 53);
            CPU0TextBox.Name = "CPU0TextBox";
            CPU0TextBox.Size = new Size(206, 23);
            CPU0TextBox.TabIndex = 10;
            // 
            // CPU14TextBox
            // 
            CPU14TextBox.Location = new Point(23, 25);
            CPU14TextBox.Name = "CPU14TextBox";
            CPU14TextBox.Size = new Size(206, 23);
            CPU14TextBox.TabIndex = 5;
            // 
            // CPUCopyButton
            // 
            CPUCopyButton.BackColor = Color.Chartreuse;
            CPUCopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CPUCopyButton.Location = new Point(333, 80);
            CPUCopyButton.Name = "CPUCopyButton";
            CPUCopyButton.Size = new Size(49, 41);
            CPUCopyButton.TabIndex = 20;
            CPUCopyButton.Text = "Copy";
            CPUCopyButton.UseVisualStyleBackColor = false;
            CPUCopyButton.Click += CPUCopyButton_Click;
            // 
            // CPUDateTimePicker
            // 
            CPUDateTimePicker.CustomFormat = "dd/MM";
            CPUDateTimePicker.Format = DateTimePickerFormat.Custom;
            CPUDateTimePicker.Location = new Point(296, 25);
            CPUDateTimePicker.Name = "CPUDateTimePicker";
            CPUDateTimePicker.Size = new Size(50, 23);
            CPUDateTimePicker.TabIndex = 1;
            CPUDateTimePicker.ValueChanged += CPUDateTimePicker_ValueChanged;
            // 
            // CPUDateTimePicker2
            // 
            CPUDateTimePicker2.CustomFormat = "dd/MM";
            CPUDateTimePicker2.Format = DateTimePickerFormat.Custom;
            CPUDateTimePicker2.Location = new Point(366, 25);
            CPUDateTimePicker2.Name = "CPUDateTimePicker2";
            CPUDateTimePicker2.Size = new Size(49, 23);
            CPUDateTimePicker2.TabIndex = 9;
            CPUDateTimePicker2.ValueChanged += CPUDateTimePicker2_ValueChanged;
            // 
            // CPULabel
            // 
            CPULabel.AutoSize = true;
            CPULabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CPULabel.Location = new Point(27, 7);
            CPULabel.Name = "CPULabel";
            CPULabel.Size = new Size(206, 15);
            CPULabel.TabIndex = 0;
            CPULabel.Text = "Laptop/Tablet/mobile/Consoles/Cpu";
            // 
            // CPUResetButton
            // 
            CPUResetButton.BackColor = Color.DarkSalmon;
            CPUResetButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CPUResetButton.Location = new Point(383, 80);
            CPUResetButton.Name = "CPUResetButton";
            CPUResetButton.Size = new Size(49, 41);
            CPUResetButton.TabIndex = 19;
            CPUResetButton.Text = "Reset";
            CPUResetButton.UseVisualStyleBackColor = false;
            CPUResetButton.Click += CPUResetButton_Click;
            // 
            // CPURichTextBox
            // 
            CPURichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CPURichTextBox.Location = new Point(23, 80);
            CPURichTextBox.Name = "CPURichTextBox";
            CPURichTextBox.Size = new Size(304, 41);
            CPURichTextBox.TabIndex = 18;
            CPURichTextBox.Text = "";
            // 
            // DeleteHomeButton
            // 
            DeleteHomeButton.BackColor = Color.DarkSalmon;
            DeleteHomeButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteHomeButton.Location = new Point(272, 253);
            DeleteHomeButton.Name = "DeleteHomeButton";
            DeleteHomeButton.Size = new Size(138, 43);
            DeleteHomeButton.TabIndex = 19;
            DeleteHomeButton.Text = "Διαγραφή";
            DeleteHomeButton.UseVisualStyleBackColor = false;
            DeleteHomeButton.Click += DeleteHomeButton_Click;
            // 
            // HomeRichTextBox
            // 
            HomeRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            HomeRichTextBox.Location = new Point(6, 302);
            HomeRichTextBox.Name = "HomeRichTextBox";
            HomeRichTextBox.Size = new Size(404, 63);
            HomeRichTextBox.TabIndex = 18;
            HomeRichTextBox.Text = "";
            // 
            // HomeTabPage
            // 
            HomeTabPage.Controls.Add(panel1);
            HomeTabPage.Controls.Add(CopyHomeButton);
            HomeTabPage.Controls.Add(NotesPanel);
            HomeTabPage.Controls.Add(DeleteHomeButton);
            HomeTabPage.Controls.Add(HomeRichTextBox);
            HomeTabPage.Location = new Point(4, 24);
            HomeTabPage.Name = "HomeTabPage";
            HomeTabPage.Padding = new Padding(3);
            HomeTabPage.Size = new Size(438, 487);
            HomeTabPage.TabIndex = 0;
            HomeTabPage.Text = "Αρχική";
            HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(NotesLlabel);
            panel1.Controls.Add(OnHoldComboBox);
            panel1.Controls.Add(AdressofOrderLabel);
            panel1.Controls.Add(AdressofOrderComboBox);
            panel1.Controls.Add(OnHoldLabel);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 113);
            panel1.TabIndex = 16;
            // 
            // NotesLlabel
            // 
            NotesLlabel.AutoSize = true;
            NotesLlabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesLlabel.Location = new Point(157, 9);
            NotesLlabel.Name = "NotesLlabel";
            NotesLlabel.Size = new Size(68, 15);
            NotesLlabel.TabIndex = 16;
            NotesLlabel.Text = "Σημειώσεις";
            // 
            // OnHoldComboBox
            // 
            OnHoldComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OnHoldComboBox.FormattingEnabled = true;
            OnHoldComboBox.Items.AddRange(new object[] { "επικοινωνίας και προκαταβολής από πελάτη", "προκαταβολής από πελάτη", "επικοινωνίας από πελάτη", "από προμηθευτή", "απάντησης από προμηθευτή για διαθεσιμότητα", "από τοπικό", "απάντησης από τοπικό προμηθευτή για διαθεσιμότητα" });
            OnHoldComboBox.Location = new Point(91, 72);
            OnHoldComboBox.Name = "OnHoldComboBox";
            OnHoldComboBox.Size = new Size(292, 23);
            OnHoldComboBox.TabIndex = 9;
            OnHoldComboBox.SelectedIndexChanged += OnHoldComboBox_SelectedIndexChanged;
            // 
            // OnHoldLabel
            // 
            OnHoldLabel.AutoSize = true;
            OnHoldLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OnHoldLabel.Location = new Point(27, 75);
            OnHoldLabel.Name = "OnHoldLabel";
            OnHoldLabel.Size = new Size(58, 15);
            OnHoldLabel.TabIndex = 8;
            OnHoldLabel.Text = "Αναμονή :";
            // 
            // NotesPanel
            // 
            NotesPanel.BorderStyle = BorderStyle.FixedSingle;
            NotesPanel.Controls.Add(SMSComboBox);
            NotesPanel.Controls.Add(SMSLabel);
            NotesPanel.Controls.Add(SendSMSCustomerLlabel);
            NotesPanel.Controls.Add(SendMsgComboBox);
            NotesPanel.Controls.Add(SendMsgLabel);
            NotesPanel.Location = new Point(6, 122);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new Size(404, 125);
            NotesPanel.TabIndex = 11;
            // 
            // SMSComboBox
            // 
            SMSComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SMSComboBox.FormattingEnabled = true;
            SMSComboBox.Items.AddRange(new object[] { "Υπενθύμιση παραλαβής", "Pickup Reminder" });
            SMSComboBox.Location = new Point(109, 73);
            SMSComboBox.Name = "SMSComboBox";
            SMSComboBox.Size = new Size(274, 23);
            SMSComboBox.TabIndex = 15;
            SMSComboBox.SelectedIndexChanged += SMSComboBox_SelectedIndexChanged;
            // 
            // SMSLabel
            // 
            SMSLabel.AutoSize = true;
            SMSLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SMSLabel.Location = new Point(27, 76);
            SMSLabel.Name = "SMSLabel";
            SMSLabel.Size = new Size(76, 15);
            SMSLabel.TabIndex = 14;
            SMSLabel.Text = "Υπενθύμιση :";
            // 
            // SendSMSCustomerLlabel
            // 
            SendSMSCustomerLlabel.AutoSize = true;
            SendSMSCustomerLlabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SendSMSCustomerLlabel.Location = new Point(157, 55);
            SendSMSCustomerLlabel.Name = "SendSMSCustomerLlabel";
            SendSMSCustomerLlabel.Size = new Size(90, 15);
            SendSMSCustomerLlabel.TabIndex = 13;
            SendSMSCustomerLlabel.Text = "Αποστολή SMS";
            // 
            // SendMsgComboBox
            // 
            SendMsgComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SendMsgComboBox.FormattingEnabled = true;
            SendMsgComboBox.Items.AddRange(new object[] { "παραλαβή σε 10-15 εργάσιμες μέρες", "διπλή παραγγελία", "Δευτέρα - Τρίτη", "προκαταβολή", "διαθεσιμότητα", "διαθεσιμότητα και προκαταβολή", "πρόβλημα διαθεσιμότητας. Πρότεινε κάτι άλλο", "καθυστέρηση παραγγελίας και παραλαβή", "παλιό service. Να περάσει να παραλάβει", "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή" });
            SendMsgComboBox.Location = new Point(109, 18);
            SendMsgComboBox.Name = "SendMsgComboBox";
            SendMsgComboBox.Size = new Size(274, 23);
            SendMsgComboBox.TabIndex = 5;
            SendMsgComboBox.SelectedIndexChanged += SendMsgComboBox_SelectedIndexChanged;
            // 
            // SendMsgLabel
            // 
            SendMsgLabel.AutoSize = true;
            SendMsgLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SendMsgLabel.Location = new Point(8, 21);
            SendMsgLabel.Name = "SendMsgLabel";
            SendMsgLabel.Size = new Size(95, 15);
            SendMsgLabel.TabIndex = 4;
            SendMsgLabel.Text = "Ενημέρωσε για :";
            // 
            // CPU14Label
            // 
            CPU14Label.AutoSize = true;
            CPU14Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CPU14Label.ForeColor = Color.Black;
            CPU14Label.Location = new Point(1, 29);
            CPU14Label.Name = "CPU14Label";
            CPU14Label.Size = new Size(21, 15);
            CPU14Label.TabIndex = 13;
            CPU14Label.Text = "14";
            // 
            // CleanersorLabel
            // 
            CleanersorLabel.AutoSize = true;
            CleanersorLabel.Location = new Point(349, 383);
            CleanersorLabel.Name = "CleanersorLabel";
            CleanersorLabel.Size = new Size(14, 15);
            CleanersorLabel.TabIndex = 43;
            CleanersorLabel.Text = "ή";
            // 
            // Battery14Label
            // 
            Battery14Label.AutoSize = true;
            Battery14Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Battery14Label.ForeColor = Color.Black;
            Battery14Label.Location = new Point(1, 147);
            Battery14Label.Name = "Battery14Label";
            Battery14Label.Size = new Size(21, 15);
            Battery14Label.TabIndex = 25;
            Battery14Label.Text = "14";
            // 
            // CPUorLabel
            // 
            CPUorLabel.AutoSize = true;
            CPUorLabel.Location = new Point(349, 29);
            CPUorLabel.Name = "CPUorLabel";
            CPUorLabel.Size = new Size(14, 15);
            CPUorLabel.TabIndex = 8;
            CPUorLabel.Text = "ή";
            // 
            // BatteryorLabel
            // 
            BatteryorLabel.AutoSize = true;
            BatteryorLabel.Location = new Point(349, 147);
            BatteryorLabel.Name = "BatteryorLabel";
            BatteryorLabel.Size = new Size(14, 15);
            BatteryorLabel.TabIndex = 20;
            BatteryorLabel.Text = "ή";
            // 
            // Battery0Label
            // 
            Battery0Label.AutoSize = true;
            Battery0Label.ForeColor = Color.IndianRed;
            Battery0Label.Location = new Point(7, 174);
            Battery0Label.Name = "Battery0Label";
            Battery0Label.Size = new Size(13, 15);
            Battery0Label.TabIndex = 16;
            Battery0Label.Text = "0";
            // 
            // Ship14Label
            // 
            Ship14Label.AutoSize = true;
            Ship14Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Ship14Label.ForeColor = Color.Black;
            Ship14Label.Location = new Point(1, 265);
            Ship14Label.Name = "Ship14Label";
            Ship14Label.Size = new Size(21, 15);
            Ship14Label.TabIndex = 37;
            Ship14Label.Text = "14";
            // 
            // ShiporLabel
            // 
            ShiporLabel.AutoSize = true;
            ShiporLabel.Location = new Point(349, 265);
            ShiporLabel.Name = "ShiporLabel";
            ShiporLabel.Size = new Size(14, 15);
            ShiporLabel.TabIndex = 32;
            ShiporLabel.Text = "ή";
            // 
            // Ship0Label
            // 
            Ship0Label.AutoSize = true;
            Ship0Label.ForeColor = Color.IndianRed;
            Ship0Label.Location = new Point(7, 292);
            Ship0Label.Name = "Ship0Label";
            Ship0Label.Size = new Size(13, 15);
            Ship0Label.TabIndex = 28;
            Ship0Label.Text = "0";
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(Battery0CopyButton);
            OrdersTabPage.Controls.Add(CPU0CopyButton);
            OrdersTabPage.Controls.Add(Ship0CopyButton);
            OrdersTabPage.Controls.Add(CleanersAutoButton);
            OrdersTabPage.Controls.Add(ShipAutoButton);
            OrdersTabPage.Controls.Add(Battery0TextBox);
            OrdersTabPage.Controls.Add(Battery14TextBox);
            OrdersTabPage.Controls.Add(BatteryCopyButton);
            OrdersTabPage.Controls.Add(BatteryDateTimePicker);
            OrdersTabPage.Controls.Add(BatteryDateTimePicker2);
            OrdersTabPage.Controls.Add(BatteryResetButton);
            OrdersTabPage.Controls.Add(BatteryRichTextBox);
            OrdersTabPage.Controls.Add(CleanersClearButton);
            OrdersTabPage.Controls.Add(CleanersCopyButton);
            OrdersTabPage.Controls.Add(CleanersDateTimePicker);
            OrdersTabPage.Controls.Add(CleanersDateTimePicker2);
            OrdersTabPage.Controls.Add(CleanersLabel);
            OrdersTabPage.Controls.Add(CleanersPasteButton);
            OrdersTabPage.Controls.Add(CleanersResetButton);
            OrdersTabPage.Controls.Add(CleanersRichTextBox);
            OrdersTabPage.Controls.Add(CleanersTextBox);
            OrdersTabPage.Controls.Add(ClearBattery0Button);
            OrdersTabPage.Controls.Add(ClearBattery14Button);
            OrdersTabPage.Controls.Add(ClearCPU0Button);
            OrdersTabPage.Controls.Add(ClearCPU14Button);
            OrdersTabPage.Controls.Add(ClearShip0Button);
            OrdersTabPage.Controls.Add(ClearShip14Button);
            OrdersTabPage.Controls.Add(CourrierLabel);
            OrdersTabPage.Controls.Add(CPU0Label);
            OrdersTabPage.Controls.Add(CPU0TextBox);
            OrdersTabPage.Controls.Add(CPU14TextBox);
            OrdersTabPage.Controls.Add(CPUCopyButton);
            OrdersTabPage.Controls.Add(CPUDateTimePicker);
            OrdersTabPage.Controls.Add(CPUDateTimePicker2);
            OrdersTabPage.Controls.Add(CPULabel);
            OrdersTabPage.Controls.Add(CPUResetButton);
            OrdersTabPage.Controls.Add(CPURichTextBox);
            OrdersTabPage.Controls.Add(CPU14Label);
            OrdersTabPage.Controls.Add(CleanersorLabel);
            OrdersTabPage.Controls.Add(Battery14Label);
            OrdersTabPage.Controls.Add(CPUorLabel);
            OrdersTabPage.Controls.Add(BatteryorLabel);
            OrdersTabPage.Controls.Add(Battery0Label);
            OrdersTabPage.Controls.Add(Ship14Label);
            OrdersTabPage.Controls.Add(ShiporLabel);
            OrdersTabPage.Controls.Add(Ship0Label);
            OrdersTabPage.Controls.Add(PasteBattery0Button);
            OrdersTabPage.Controls.Add(PasteBattery14Button);
            OrdersTabPage.Controls.Add(PasteCPU0Button);
            OrdersTabPage.Controls.Add(PasteCPU14Button);
            OrdersTabPage.Controls.Add(PasteShip0Button);
            OrdersTabPage.Controls.Add(PasteShip14Button);
            OrdersTabPage.Controls.Add(Ship0TextBox);
            OrdersTabPage.Controls.Add(Ship14TextBox);
            OrdersTabPage.Controls.Add(ShipCopyButton);
            OrdersTabPage.Controls.Add(ShipDateTimePicker);
            OrdersTabPage.Controls.Add(ShipDateTimePicker2);
            OrdersTabPage.Controls.Add(ShipLabel);
            OrdersTabPage.Controls.Add(ShipResetButton);
            OrdersTabPage.Controls.Add(ShipRichTextBox);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(438, 487);
            OrdersTabPage.TabIndex = 2;
            OrdersTabPage.Text = "Παραγγελίες";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // Battery0CopyButton
            // 
            Battery0CopyButton.BackColor = Color.Chartreuse;
            Battery0CopyButton.Location = new Point(253, 170);
            Battery0CopyButton.Name = "Battery0CopyButton";
            Battery0CopyButton.Size = new Size(23, 23);
            Battery0CopyButton.TabIndex = 57;
            Battery0CopyButton.Text = "C";
            Battery0CopyButton.UseVisualStyleBackColor = false;
            // 
            // CPU0CopyButton
            // 
            CPU0CopyButton.BackColor = Color.Chartreuse;
            CPU0CopyButton.Location = new Point(253, 53);
            CPU0CopyButton.Name = "CPU0CopyButton";
            CPU0CopyButton.Size = new Size(23, 23);
            CPU0CopyButton.TabIndex = 56;
            CPU0CopyButton.Text = "C";
            CPU0CopyButton.UseVisualStyleBackColor = false;
            // 
            // Ship0CopyButton
            // 
            Ship0CopyButton.BackColor = Color.Chartreuse;
            Ship0CopyButton.Location = new Point(253, 288);
            Ship0CopyButton.Name = "Ship0CopyButton";
            Ship0CopyButton.Size = new Size(23, 23);
            Ship0CopyButton.TabIndex = 58;
            Ship0CopyButton.Text = "C";
            Ship0CopyButton.UseVisualStyleBackColor = false;
            // 
            // CleanersAutoButton
            // 
            CleanersAutoButton.BackColor = Color.Thistle;
            CleanersAutoButton.Location = new Point(317, 405);
            CleanersAutoButton.Name = "CleanersAutoButton";
            CleanersAutoButton.Size = new Size(75, 23);
            CleanersAutoButton.TabIndex = 55;
            CleanersAutoButton.Text = "Auto";
            CleanersAutoButton.UseVisualStyleBackColor = false;
            CleanersAutoButton.Click += CleanersAutoButton_Click;
            // 
            // ShipAutoButton
            // 
            ShipAutoButton.BackColor = Color.Thistle;
            ShipAutoButton.Location = new Point(317, 288);
            ShipAutoButton.Name = "ShipAutoButton";
            ShipAutoButton.Size = new Size(75, 23);
            ShipAutoButton.TabIndex = 54;
            ShipAutoButton.Text = "Auto";
            ShipAutoButton.UseVisualStyleBackColor = false;
            ShipAutoButton.Click += ShipAutoButton_Click;
            // 
            // PasteBattery0Button
            // 
            PasteBattery0Button.BackColor = Color.DeepSkyBlue;
            PasteBattery0Button.Location = new Point(230, 170);
            PasteBattery0Button.Name = "PasteBattery0Button";
            PasteBattery0Button.Size = new Size(23, 23);
            PasteBattery0Button.TabIndex = 23;
            PasteBattery0Button.Text = "P";
            PasteBattery0Button.UseVisualStyleBackColor = false;
            PasteBattery0Button.Click += PasteBattery0Button_Click;
            // 
            // PasteBattery14Button
            // 
            PasteBattery14Button.BackColor = Color.DeepSkyBlue;
            PasteBattery14Button.Location = new Point(230, 143);
            PasteBattery14Button.Name = "PasteBattery14Button";
            PasteBattery14Button.Size = new Size(23, 23);
            PasteBattery14Button.TabIndex = 18;
            PasteBattery14Button.Text = "P";
            PasteBattery14Button.UseVisualStyleBackColor = false;
            PasteBattery14Button.Click += PasteBattery14Button_Click;
            // 
            // PasteCPU0Button
            // 
            PasteCPU0Button.BackColor = Color.DeepSkyBlue;
            PasteCPU0Button.Location = new Point(230, 53);
            PasteCPU0Button.Name = "PasteCPU0Button";
            PasteCPU0Button.Size = new Size(23, 23);
            PasteCPU0Button.TabIndex = 11;
            PasteCPU0Button.Text = "P";
            PasteCPU0Button.UseVisualStyleBackColor = false;
            PasteCPU0Button.Click += PasteCPU0Button_Click;
            // 
            // PasteCPU14Button
            // 
            PasteCPU14Button.BackColor = Color.DeepSkyBlue;
            PasteCPU14Button.Location = new Point(230, 25);
            PasteCPU14Button.Name = "PasteCPU14Button";
            PasteCPU14Button.Size = new Size(23, 23);
            PasteCPU14Button.TabIndex = 6;
            PasteCPU14Button.Text = "P";
            PasteCPU14Button.UseVisualStyleBackColor = false;
            PasteCPU14Button.Click += PasteCPU14Button_Click;
            // 
            // PasteShip0Button
            // 
            PasteShip0Button.BackColor = Color.DeepSkyBlue;
            PasteShip0Button.Location = new Point(230, 288);
            PasteShip0Button.Name = "PasteShip0Button";
            PasteShip0Button.Size = new Size(23, 23);
            PasteShip0Button.TabIndex = 35;
            PasteShip0Button.Text = "P";
            PasteShip0Button.UseVisualStyleBackColor = false;
            PasteShip0Button.Click += PasteShip0Button_Click;
            // 
            // PasteShip14Button
            // 
            PasteShip14Button.BackColor = Color.DeepSkyBlue;
            PasteShip14Button.Location = new Point(230, 261);
            PasteShip14Button.Name = "PasteShip14Button";
            PasteShip14Button.Size = new Size(23, 23);
            PasteShip14Button.TabIndex = 30;
            PasteShip14Button.Text = "P";
            PasteShip14Button.UseVisualStyleBackColor = false;
            PasteShip14Button.Click += PasteShip14Button_Click;
            // 
            // Ship0TextBox
            // 
            Ship0TextBox.Location = new Point(23, 288);
            Ship0TextBox.Name = "Ship0TextBox";
            Ship0TextBox.Size = new Size(206, 23);
            Ship0TextBox.TabIndex = 34;
            // 
            // Ship14TextBox
            // 
            Ship14TextBox.Location = new Point(23, 261);
            Ship14TextBox.Name = "Ship14TextBox";
            Ship14TextBox.Size = new Size(206, 23);
            Ship14TextBox.TabIndex = 29;
            // 
            // ShipCopyButton
            // 
            ShipCopyButton.BackColor = Color.Chartreuse;
            ShipCopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShipCopyButton.Location = new Point(333, 316);
            ShipCopyButton.Name = "ShipCopyButton";
            ShipCopyButton.Size = new Size(49, 41);
            ShipCopyButton.TabIndex = 50;
            ShipCopyButton.Text = "Copy";
            ShipCopyButton.UseVisualStyleBackColor = false;
            ShipCopyButton.Click += ShipCopyButton_Click;
            // 
            // ShipDateTimePicker
            // 
            ShipDateTimePicker.CustomFormat = "dd/MM";
            ShipDateTimePicker.Format = DateTimePickerFormat.Custom;
            ShipDateTimePicker.Location = new Point(296, 261);
            ShipDateTimePicker.Name = "ShipDateTimePicker";
            ShipDateTimePicker.Size = new Size(50, 23);
            ShipDateTimePicker.TabIndex = 27;
            ShipDateTimePicker.ValueChanged += ShipDateTimePicker_ValueChanged;
            // 
            // ShipDateTimePicker2
            // 
            ShipDateTimePicker2.CustomFormat = "dd/MM";
            ShipDateTimePicker2.Format = DateTimePickerFormat.Custom;
            ShipDateTimePicker2.Location = new Point(366, 261);
            ShipDateTimePicker2.Name = "ShipDateTimePicker2";
            ShipDateTimePicker2.Size = new Size(49, 23);
            ShipDateTimePicker2.TabIndex = 33;
            ShipDateTimePicker2.ValueChanged += ShipDateTimePicker2_ValueChanged;
            // 
            // ShipLabel
            // 
            ShipLabel.AutoSize = true;
            ShipLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShipLabel.Location = new Point(106, 243);
            ShipLabel.Name = "ShipLabel";
            ShipLabel.Size = new Size(49, 15);
            ShipLabel.TabIndex = 26;
            ShipLabel.Text = "Καράβι";
            // 
            // ShipResetButton
            // 
            ShipResetButton.BackColor = Color.DarkSalmon;
            ShipResetButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShipResetButton.Location = new Point(383, 316);
            ShipResetButton.Name = "ShipResetButton";
            ShipResetButton.Size = new Size(49, 41);
            ShipResetButton.TabIndex = 49;
            ShipResetButton.Text = "Reset";
            ShipResetButton.UseVisualStyleBackColor = false;
            ShipResetButton.Click += ShipResetButton_Click;
            // 
            // ShipRichTextBox
            // 
            ShipRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShipRichTextBox.Location = new Point(23, 316);
            ShipRichTextBox.Name = "ShipRichTextBox";
            ShipRichTextBox.Size = new Size(304, 41);
            ShipRichTextBox.TabIndex = 48;
            ShipRichTextBox.Text = "";
            // 
            // ShipButton
            // 
            ShipButton.Location = new Point(8, 35);
            ShipButton.Name = "ShipButton";
            ShipButton.Size = new Size(168, 23);
            ShipButton.TabIndex = 1;
            ShipButton.Text = "Καράβι-Σημερινό";
            ShipButton.UseVisualStyleBackColor = true;
            ShipButton.Click += ShipButton_Click;
            // 
            // SuppliersCopyButton
            // 
            SuppliersCopyButton.BackColor = Color.Chartreuse;
            SuppliersCopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SuppliersCopyButton.Location = new Point(8, 132);
            SuppliersCopyButton.Name = "SuppliersCopyButton";
            SuppliersCopyButton.Size = new Size(138, 43);
            SuppliersCopyButton.TabIndex = 19;
            SuppliersCopyButton.Text = "Αντιγραφή";
            SuppliersCopyButton.UseVisualStyleBackColor = false;
            SuppliersCopyButton.Click += CopySuppliersButton_Click;
            // 
            // SuppliersDeleteButton
            // 
            SuppliersDeleteButton.BackColor = Color.DarkSalmon;
            SuppliersDeleteButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SuppliersDeleteButton.Location = new Point(276, 132);
            SuppliersDeleteButton.Name = "SuppliersDeleteButton";
            SuppliersDeleteButton.Size = new Size(138, 43);
            SuppliersDeleteButton.TabIndex = 18;
            SuppliersDeleteButton.Text = "Διαγραφή";
            SuppliersDeleteButton.UseVisualStyleBackColor = false;
            SuppliersDeleteButton.Click += DeleteSuppliersButton_Click;
            // 
            // SuppliersRichTextBox
            // 
            SuppliersRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SuppliersRichTextBox.Location = new Point(8, 181);
            SuppliersRichTextBox.Name = "SuppliersRichTextBox";
            SuppliersRichTextBox.Size = new Size(425, 63);
            SuppliersRichTextBox.TabIndex = 4;
            SuppliersRichTextBox.Text = "";
            // 
            // SupplierTabPage
            // 
            SupplierTabPage.Controls.Add(SuppliersCopyButton);
            SupplierTabPage.Controls.Add(SuppliersRichTextBox);
            SupplierTabPage.Controls.Add(SuppliersDeleteButton);
            SupplierTabPage.Controls.Add(CancelPreorderButton);
            SupplierTabPage.Controls.Add(CopyOKButton);
            SupplierTabPage.Controls.Add(ShipButton);
            SupplierTabPage.Controls.Add(CourrierButton);
            SupplierTabPage.Location = new Point(4, 24);
            SupplierTabPage.Name = "SupplierTabPage";
            SupplierTabPage.Padding = new Padding(3);
            SupplierTabPage.Size = new Size(438, 487);
            SupplierTabPage.TabIndex = 1;
            SupplierTabPage.Text = "Προμηθευτές";
            SupplierTabPage.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(HomeTabPage);
            TabControl.Controls.Add(SupplierTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(446, 515);
            TabControl.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 513);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Product Assistant";
            Load += Form1_Load;
            HomeTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NotesPanel.ResumeLayout(false);
            NotesPanel.PerformLayout();
            OrdersTabPage.ResumeLayout(false);
            OrdersTabPage.PerformLayout();
            SupplierTabPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button BatteryCopyButton;
        private Button BatteryResetButton;
        private Button CancelPreorderButton;
        private Button CleanersClearButton;
        private Button CleanersCopyButton;
        private Button CleanersPasteButton;
        private Button CleanersResetButton;
        private Button ClearBattery0Button;
        private Button ClearBattery14Button;
        private Button ClearCPU0Button;
        private Button ClearCPU14Button;
        private Button ClearShip0Button;
        private Button ClearShip14Button;
        private Button CopyHomeButton;
        private Button CopyOKButton;
        private Button CourrierButton;
        private Button CPUCopyButton;
        private Button CPUResetButton;
        private Button DeleteHomeButton;
        private Button PasteBattery0Button;
        private Button PasteBattery14Button;
        private Button PasteCPU0Button;
        private Button PasteCPU14Button;
        private Button PasteShip0Button;
        private Button PasteShip14Button;
        private Button ShipButton;
        private Button ShipCopyButton;
        private Button ShipResetButton;
        private Button SuppliersCopyButton;
        private Button SuppliersDeleteButton;
        private ComboBox AdressofOrderComboBox;
        private ComboBox OnHoldComboBox;
        private ComboBox SendMsgComboBox;
        private ComboBox SMSComboBox;
        private DateTimePicker BatteryDateTimePicker;
        private DateTimePicker BatteryDateTimePicker2;
        private DateTimePicker CleanersDateTimePicker;
        private DateTimePicker CleanersDateTimePicker2;
        private DateTimePicker CPUDateTimePicker;
        private DateTimePicker CPUDateTimePicker2;
        private DateTimePicker ShipDateTimePicker;
        private DateTimePicker ShipDateTimePicker2;
        private Label AdressofOrderLabel;
        private Label CleanersLabel;
        private Label CourrierLabel;
        private Label CPU0Label;
        private Label CPULabel;
        private Label CPU14Label;
        private Label CleanersorLabel;
        private Label Battery14Label;
        private Label CPUorLabel;
        private Label BatteryorLabel;
        private Label Battery0Label;
        private Label Ship14Label;
        private Label ShiporLabel;
        private Label Ship0Label;
        private Label NotesLlabel;
        private Label OnHoldLabel;
        private Label SendMsgLabel;
        private Label SendSMSCustomerLlabel;
        private Label ShipLabel;
        private Label SMSLabel;
        private Panel NotesPanel;
        private Panel panel1;
        private RichTextBox BatteryRichTextBox;
        private RichTextBox CleanersRichTextBox;
        private RichTextBox CPURichTextBox;
        private RichTextBox HomeRichTextBox;
        private RichTextBox ShipRichTextBox;
        private RichTextBox SuppliersRichTextBox;
        private TabControl TabControl;
        private TabPage HomeTabPage;
        private TabPage OrdersTabPage;
        private TabPage SupplierTabPage;
        private TextBox Battery0TextBox;
        private TextBox Battery14TextBox;
        private TextBox CleanersTextBox;
        private TextBox CPU0TextBox;
        private TextBox CPU14TextBox;
        private TextBox Ship0TextBox;
        private TextBox Ship14TextBox;
        private Button button1;
        private Button ShipAutoButton;
        private Button Battery0CopyButton;
        private Button CPU0CopyButton;
        private Button Ship0CopyButton;
        private Button CleanersAutoButton;
    }
}