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
            NotesRichTextBox = new RichTextBox();
            AdressofOrderLabel = new Label();
            AdressofOrderComboBox = new ComboBox();
            DeleteButton = new Button();
            SendMsgComboBox = new ComboBox();
            SendMsgLabel = new Label();
            OnHoldComboBox = new ComboBox();
            OnHoldLabel = new Label();
            CopyButton = new Button();
            NotesPanel = new Panel();
            SMSComboBox = new ComboBox();
            SMSLabel = new Label();
            SendSMSCustomerLlabel = new Label();
            SendMsgsLabel = new Label();
            CurrentDateLabel = new Label();
            panel1 = new Panel();
            NotesLlabel = new Label();
            TabControl = new TabControl();
            HomeTabPage = new TabPage();
            SupplierTabPage = new TabPage();
            CancelPreorderButton = new Button();
            CopyOKButton = new Button();
            ShipButton = new Button();
            CourrierButton = new Button();
            OrdersTabPage = new TabPage();
            CleanersDateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            ClearCleanersButton = new Button();
            CleanersPasteButton = new Button();
            CleanersTextBox = new TextBox();
            CleanersDateTimePicker = new DateTimePicker();
            CleanersLabel = new Label();
            label7 = new Label();
            ClearShip0Button = new Button();
            PasteShip0Button = new Button();
            Ship0TextBox = new TextBox();
            Ship14DateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            ClearShip14Button = new Button();
            PasteShip14Button = new Button();
            Ship14TextBox = new TextBox();
            label9 = new Label();
            Ship14DateTimePicker = new DateTimePicker();
            ShipLabel = new Label();
            label2 = new Label();
            ClearBattery0Button = new Button();
            PasteBattery0Button = new Button();
            Battery0TextBox = new TextBox();
            Battery14DateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            ClearBattery14Button = new Button();
            PasteBattery14Button = new Button();
            Battery14TextBox = new TextBox();
            label5 = new Label();
            Battery14DateTimePicker = new DateTimePicker();
            CourrierLabel = new Label();
            label1 = new Label();
            ClearCPU0Button = new Button();
            PasteCPU0Button = new Button();
            CPU0TextBox = new TextBox();
            CPU14DateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            ClearCPU14Button = new Button();
            PasteCPU14Button = new Button();
            CPU14TextBox = new TextBox();
            CPU0Label = new Label();
            CPU14DateTimePicker = new DateTimePicker();
            CPULabel = new Label();
            NotesPanel.SuspendLayout();
            panel1.SuspendLayout();
            TabControl.SuspendLayout();
            HomeTabPage.SuspendLayout();
            SupplierTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // NotesRichTextBox
            // 
            NotesRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesRichTextBox.Location = new Point(10, 375);
            NotesRichTextBox.Name = "NotesRichTextBox";
            NotesRichTextBox.Size = new Size(404, 63);
            NotesRichTextBox.TabIndex = 0;
            NotesRichTextBox.Text = "";
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
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.DarkSalmon;
            DeleteButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(276, 326);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(138, 43);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Διαγραφή";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
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
            // CopyButton
            // 
            CopyButton.BackColor = Color.Chartreuse;
            CopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CopyButton.Location = new Point(8, 326);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(138, 43);
            CopyButton.TabIndex = 10;
            CopyButton.Text = "Αντιγραφή";
            CopyButton.UseVisualStyleBackColor = false;
            // 
            // NotesPanel
            // 
            NotesPanel.BorderStyle = BorderStyle.FixedSingle;
            NotesPanel.Controls.Add(SMSComboBox);
            NotesPanel.Controls.Add(SMSLabel);
            NotesPanel.Controls.Add(SendSMSCustomerLlabel);
            NotesPanel.Controls.Add(SendMsgsLabel);
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
            // SendMsgsLabel
            // 
            SendMsgsLabel.AutoSize = true;
            SendMsgsLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SendMsgsLabel.Location = new Point(142, 1);
            SendMsgsLabel.Name = "SendMsgsLabel";
            SendMsgsLabel.Size = new Size(121, 15);
            SendMsgsLabel.TabIndex = 12;
            SendMsgsLabel.Text = "Αποστολή μηνύματος";
            // 
            // CurrentDateLabel
            // 
            CurrentDateLabel.AutoSize = true;
            CurrentDateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentDateLabel.Location = new Point(146, 441);
            CurrentDateLabel.Name = "CurrentDateLabel";
            CurrentDateLabel.Size = new Size(124, 15);
            CurrentDateLabel.TabIndex = 12;
            CurrentDateLabel.Text = "Σημερινή Ημερομηνία";
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
            // TabControl
            // 
            TabControl.Controls.Add(HomeTabPage);
            TabControl.Controls.Add(SupplierTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(447, 324);
            TabControl.TabIndex = 17;
            // 
            // HomeTabPage
            // 
            HomeTabPage.Controls.Add(panel1);
            HomeTabPage.Controls.Add(NotesPanel);
            HomeTabPage.Location = new Point(4, 24);
            HomeTabPage.Name = "HomeTabPage";
            HomeTabPage.Padding = new Padding(3);
            HomeTabPage.Size = new Size(439, 296);
            HomeTabPage.TabIndex = 0;
            HomeTabPage.Text = "Αρχική";
            HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // SupplierTabPage
            // 
            SupplierTabPage.Controls.Add(CancelPreorderButton);
            SupplierTabPage.Controls.Add(CopyOKButton);
            SupplierTabPage.Controls.Add(ShipButton);
            SupplierTabPage.Controls.Add(CourrierButton);
            SupplierTabPage.Location = new Point(4, 24);
            SupplierTabPage.Name = "SupplierTabPage";
            SupplierTabPage.Padding = new Padding(3);
            SupplierTabPage.Size = new Size(439, 296);
            SupplierTabPage.TabIndex = 1;
            SupplierTabPage.Text = "Προμηθευτές";
            SupplierTabPage.UseVisualStyleBackColor = true;
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
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(CleanersDateTimePicker2);
            OrdersTabPage.Controls.Add(label12);
            OrdersTabPage.Controls.Add(ClearCleanersButton);
            OrdersTabPage.Controls.Add(CleanersPasteButton);
            OrdersTabPage.Controls.Add(CleanersTextBox);
            OrdersTabPage.Controls.Add(CleanersDateTimePicker);
            OrdersTabPage.Controls.Add(CleanersLabel);
            OrdersTabPage.Controls.Add(label7);
            OrdersTabPage.Controls.Add(ClearShip0Button);
            OrdersTabPage.Controls.Add(PasteShip0Button);
            OrdersTabPage.Controls.Add(Ship0TextBox);
            OrdersTabPage.Controls.Add(Ship14DateTimePicker2);
            OrdersTabPage.Controls.Add(label8);
            OrdersTabPage.Controls.Add(ClearShip14Button);
            OrdersTabPage.Controls.Add(PasteShip14Button);
            OrdersTabPage.Controls.Add(Ship14TextBox);
            OrdersTabPage.Controls.Add(label9);
            OrdersTabPage.Controls.Add(Ship14DateTimePicker);
            OrdersTabPage.Controls.Add(ShipLabel);
            OrdersTabPage.Controls.Add(label2);
            OrdersTabPage.Controls.Add(ClearBattery0Button);
            OrdersTabPage.Controls.Add(PasteBattery0Button);
            OrdersTabPage.Controls.Add(Battery0TextBox);
            OrdersTabPage.Controls.Add(Battery14DateTimePicker2);
            OrdersTabPage.Controls.Add(label4);
            OrdersTabPage.Controls.Add(ClearBattery14Button);
            OrdersTabPage.Controls.Add(PasteBattery14Button);
            OrdersTabPage.Controls.Add(Battery14TextBox);
            OrdersTabPage.Controls.Add(label5);
            OrdersTabPage.Controls.Add(Battery14DateTimePicker);
            OrdersTabPage.Controls.Add(CourrierLabel);
            OrdersTabPage.Controls.Add(label1);
            OrdersTabPage.Controls.Add(ClearCPU0Button);
            OrdersTabPage.Controls.Add(PasteCPU0Button);
            OrdersTabPage.Controls.Add(CPU0TextBox);
            OrdersTabPage.Controls.Add(CPU14DateTimePicker2);
            OrdersTabPage.Controls.Add(label3);
            OrdersTabPage.Controls.Add(ClearCPU14Button);
            OrdersTabPage.Controls.Add(PasteCPU14Button);
            OrdersTabPage.Controls.Add(CPU14TextBox);
            OrdersTabPage.Controls.Add(CPU0Label);
            OrdersTabPage.Controls.Add(CPU14DateTimePicker);
            OrdersTabPage.Controls.Add(CPULabel);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(439, 296);
            OrdersTabPage.TabIndex = 2;
            OrdersTabPage.Text = "Παραγγελίες";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // CleanersDateTimePicker2
            // 
            CleanersDateTimePicker2.CustomFormat = "dd/MM/yy";
            CleanersDateTimePicker2.Format = DateTimePickerFormat.Custom;
            CleanersDateTimePicker2.Location = new Point(364, 267);
            CleanersDateTimePicker2.Name = "CleanersDateTimePicker2";
            CleanersDateTimePicker2.Size = new Size(68, 23);
            CleanersDateTimePicker2.TabIndex = 44;
            CleanersDateTimePicker2.ValueChanged += CleanersDateTimePicker2_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(347, 271);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 43;
            label12.Text = "ή";
            // 
            // ClearCleanersButton
            // 
            ClearCleanersButton.BackColor = Color.DarkSalmon;
            ClearCleanersButton.Location = new Point(253, 267);
            ClearCleanersButton.Name = "ClearCleanersButton";
            ClearCleanersButton.Size = new Size(23, 23);
            ClearCleanersButton.TabIndex = 42;
            ClearCleanersButton.Text = "✖";
            ClearCleanersButton.UseVisualStyleBackColor = false;
            ClearCleanersButton.Click += ClearCleanersButton_Click;
            // 
            // CleanersPasteButton
            // 
            CleanersPasteButton.BackColor = Color.Chartreuse;
            CleanersPasteButton.Location = new Point(230, 267);
            CleanersPasteButton.Name = "CleanersPasteButton";
            CleanersPasteButton.Size = new Size(23, 23);
            CleanersPasteButton.TabIndex = 41;
            CleanersPasteButton.Text = "✔";
            CleanersPasteButton.UseVisualStyleBackColor = false;
            CleanersPasteButton.Click += CleanersPasteButton_Click;
            // 
            // CleanersTextBox
            // 
            CleanersTextBox.Location = new Point(23, 267);
            CleanersTextBox.Name = "CleanersTextBox";
            CleanersTextBox.Size = new Size(206, 23);
            CleanersTextBox.TabIndex = 40;
            // 
            // CleanersDateTimePicker
            // 
            CleanersDateTimePicker.CustomFormat = "dd/MM/yy";
            CleanersDateTimePicker.Format = DateTimePickerFormat.Custom;
            CleanersDateTimePicker.Location = new Point(278, 267);
            CleanersDateTimePicker.Name = "CleanersDateTimePicker";
            CleanersDateTimePicker.Size = new Size(68, 23);
            CleanersDateTimePicker.TabIndex = 39;
            CleanersDateTimePicker.ValueChanged += CleanersDateTimePicker_ValueChanged;
            // 
            // CleanersLabel
            // 
            CleanersLabel.AutoSize = true;
            CleanersLabel.Location = new Point(62, 249);
            CleanersLabel.Name = "CleanersLabel";
            CleanersLabel.Size = new Size(133, 15);
            CleanersLabel.TabIndex = 38;
            CleanersLabel.Text = "Πάνες - Μωρομάντηλα";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(1, 193);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 37;
            label7.Text = "14";
            // 
            // ClearShip0Button
            // 
            ClearShip0Button.BackColor = Color.DarkSalmon;
            ClearShip0Button.Location = new Point(253, 219);
            ClearShip0Button.Name = "ClearShip0Button";
            ClearShip0Button.Size = new Size(23, 23);
            ClearShip0Button.TabIndex = 36;
            ClearShip0Button.Text = "✖";
            ClearShip0Button.UseVisualStyleBackColor = false;
            ClearShip0Button.Click += ClearShip0Button_Click;
            // 
            // PasteShip0Button
            // 
            PasteShip0Button.BackColor = Color.Chartreuse;
            PasteShip0Button.Location = new Point(230, 219);
            PasteShip0Button.Name = "PasteShip0Button";
            PasteShip0Button.Size = new Size(23, 23);
            PasteShip0Button.TabIndex = 35;
            PasteShip0Button.Text = "✔";
            PasteShip0Button.UseVisualStyleBackColor = false;
            PasteShip0Button.Click += PasteShip0Button_Click;
            // 
            // Ship0TextBox
            // 
            Ship0TextBox.Location = new Point(23, 219);
            Ship0TextBox.Name = "Ship0TextBox";
            Ship0TextBox.Size = new Size(206, 23);
            Ship0TextBox.TabIndex = 34;
            // 
            // Ship14DateTimePicker2
            // 
            Ship14DateTimePicker2.CustomFormat = "dd/MM/yy";
            Ship14DateTimePicker2.Format = DateTimePickerFormat.Custom;
            Ship14DateTimePicker2.Location = new Point(364, 189);
            Ship14DateTimePicker2.Name = "Ship14DateTimePicker2";
            Ship14DateTimePicker2.Size = new Size(68, 23);
            Ship14DateTimePicker2.TabIndex = 33;
            Ship14DateTimePicker2.ValueChanged += Ship14DateTimePicker2_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(347, 193);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 32;
            label8.Text = "ή";
            // 
            // ClearShip14Button
            // 
            ClearShip14Button.BackColor = Color.DarkSalmon;
            ClearShip14Button.Location = new Point(253, 189);
            ClearShip14Button.Name = "ClearShip14Button";
            ClearShip14Button.Size = new Size(23, 23);
            ClearShip14Button.TabIndex = 31;
            ClearShip14Button.Text = "✖";
            ClearShip14Button.UseVisualStyleBackColor = false;
            ClearShip14Button.Click += ClearShip14Button_Click;
            // 
            // PasteShip14Button
            // 
            PasteShip14Button.BackColor = Color.Chartreuse;
            PasteShip14Button.Location = new Point(230, 189);
            PasteShip14Button.Name = "PasteShip14Button";
            PasteShip14Button.Size = new Size(23, 23);
            PasteShip14Button.TabIndex = 30;
            PasteShip14Button.Text = "✔";
            PasteShip14Button.UseVisualStyleBackColor = false;
            PasteShip14Button.Click += PasteShip14Button_Click;
            // 
            // Ship14TextBox
            // 
            Ship14TextBox.Location = new Point(23, 189);
            Ship14TextBox.Name = "Ship14TextBox";
            Ship14TextBox.Size = new Size(206, 23);
            Ship14TextBox.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(7, 223);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 28;
            label9.Text = "0";
            // 
            // Ship14DateTimePicker
            // 
            Ship14DateTimePicker.CustomFormat = "dd/MM/yy";
            Ship14DateTimePicker.Format = DateTimePickerFormat.Custom;
            Ship14DateTimePicker.Location = new Point(278, 189);
            Ship14DateTimePicker.Name = "Ship14DateTimePicker";
            Ship14DateTimePicker.Size = new Size(68, 23);
            Ship14DateTimePicker.TabIndex = 27;
            Ship14DateTimePicker.ValueChanged += Ship14DateTimePicker_ValueChanged;
            // 
            // ShipLabel
            // 
            ShipLabel.AutoSize = true;
            ShipLabel.Location = new Point(106, 171);
            ShipLabel.Name = "ShipLabel";
            ShipLabel.Size = new Size(45, 15);
            ShipLabel.TabIndex = 26;
            ShipLabel.Text = "Καράβι";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1, 115);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 25;
            label2.Text = "14";
            // 
            // ClearBattery0Button
            // 
            ClearBattery0Button.BackColor = Color.DarkSalmon;
            ClearBattery0Button.Location = new Point(253, 141);
            ClearBattery0Button.Name = "ClearBattery0Button";
            ClearBattery0Button.Size = new Size(23, 23);
            ClearBattery0Button.TabIndex = 24;
            ClearBattery0Button.Text = "✖";
            ClearBattery0Button.UseVisualStyleBackColor = false;
            ClearBattery0Button.Click += ClearBattery0Button_Click;
            // 
            // PasteBattery0Button
            // 
            PasteBattery0Button.BackColor = Color.Chartreuse;
            PasteBattery0Button.Location = new Point(230, 141);
            PasteBattery0Button.Name = "PasteBattery0Button";
            PasteBattery0Button.Size = new Size(23, 23);
            PasteBattery0Button.TabIndex = 23;
            PasteBattery0Button.Text = "✔";
            PasteBattery0Button.UseVisualStyleBackColor = false;
            PasteBattery0Button.Click += PasteBattery0Button_Click;
            // 
            // Battery0TextBox
            // 
            Battery0TextBox.Location = new Point(23, 141);
            Battery0TextBox.Name = "Battery0TextBox";
            Battery0TextBox.Size = new Size(206, 23);
            Battery0TextBox.TabIndex = 22;
            // 
            // Battery14DateTimePicker2
            // 
            Battery14DateTimePicker2.CustomFormat = "dd/MM/yy";
            Battery14DateTimePicker2.Format = DateTimePickerFormat.Custom;
            Battery14DateTimePicker2.Location = new Point(364, 111);
            Battery14DateTimePicker2.Name = "Battery14DateTimePicker2";
            Battery14DateTimePicker2.Size = new Size(68, 23);
            Battery14DateTimePicker2.TabIndex = 21;
            Battery14DateTimePicker2.ValueChanged += Battery14DateTimePicker2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 115);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 20;
            label4.Text = "ή";
            // 
            // ClearBattery14Button
            // 
            ClearBattery14Button.BackColor = Color.DarkSalmon;
            ClearBattery14Button.Location = new Point(253, 111);
            ClearBattery14Button.Name = "ClearBattery14Button";
            ClearBattery14Button.Size = new Size(23, 23);
            ClearBattery14Button.TabIndex = 19;
            ClearBattery14Button.Text = "✖";
            ClearBattery14Button.UseVisualStyleBackColor = false;
            ClearBattery14Button.Click += ClearBattery14Button_Click;
            // 
            // PasteBattery14Button
            // 
            PasteBattery14Button.BackColor = Color.Chartreuse;
            PasteBattery14Button.Location = new Point(230, 111);
            PasteBattery14Button.Name = "PasteBattery14Button";
            PasteBattery14Button.Size = new Size(23, 23);
            PasteBattery14Button.TabIndex = 18;
            PasteBattery14Button.Text = "✔";
            PasteBattery14Button.UseVisualStyleBackColor = false;
            PasteBattery14Button.Click += PasteBattery14Button_Click;
            // 
            // Battery14TextBox
            // 
            Battery14TextBox.Location = new Point(23, 111);
            Battery14TextBox.Name = "Battery14TextBox";
            Battery14TextBox.Size = new Size(206, 23);
            Battery14TextBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(7, 145);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 16;
            label5.Text = "0";
            // 
            // Battery14DateTimePicker
            // 
            Battery14DateTimePicker.CustomFormat = "dd/MM/yy";
            Battery14DateTimePicker.Format = DateTimePickerFormat.Custom;
            Battery14DateTimePicker.Location = new Point(278, 111);
            Battery14DateTimePicker.Name = "Battery14DateTimePicker";
            Battery14DateTimePicker.Size = new Size(68, 23);
            Battery14DateTimePicker.TabIndex = 15;
            Battery14DateTimePicker.ValueChanged += Battery14DateTimePicker_ValueChanged;
            // 
            // CourrierLabel
            // 
            CourrierLabel.AutoSize = true;
            CourrierLabel.Location = new Point(68, 93);
            CourrierLabel.Name = "CourrierLabel";
            CourrierLabel.Size = new Size(120, 15);
            CourrierLabel.TabIndex = 14;
            CourrierLabel.Text = "Courier με μπαταρίες";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(1, 32);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 13;
            label1.Text = "14";
            // 
            // ClearCPU0Button
            // 
            ClearCPU0Button.BackColor = Color.DarkSalmon;
            ClearCPU0Button.Location = new Point(253, 58);
            ClearCPU0Button.Name = "ClearCPU0Button";
            ClearCPU0Button.Size = new Size(23, 23);
            ClearCPU0Button.TabIndex = 12;
            ClearCPU0Button.Text = "✖";
            ClearCPU0Button.UseVisualStyleBackColor = false;
            ClearCPU0Button.Click += ClearCPU0Button_Click;
            // 
            // PasteCPU0Button
            // 
            PasteCPU0Button.BackColor = Color.Chartreuse;
            PasteCPU0Button.Location = new Point(230, 58);
            PasteCPU0Button.Name = "PasteCPU0Button";
            PasteCPU0Button.Size = new Size(23, 23);
            PasteCPU0Button.TabIndex = 11;
            PasteCPU0Button.Text = "✔";
            PasteCPU0Button.UseVisualStyleBackColor = false;
            PasteCPU0Button.Click += PasteCPU0Button_Click;
            // 
            // CPU0TextBox
            // 
            CPU0TextBox.Location = new Point(23, 58);
            CPU0TextBox.Name = "CPU0TextBox";
            CPU0TextBox.Size = new Size(206, 23);
            CPU0TextBox.TabIndex = 10;
            // 
            // CPU14DateTimePicker2
            // 
            CPU14DateTimePicker2.CustomFormat = "dd/MM/yy";
            CPU14DateTimePicker2.Format = DateTimePickerFormat.Custom;
            CPU14DateTimePicker2.Location = new Point(364, 28);
            CPU14DateTimePicker2.Name = "CPU14DateTimePicker2";
            CPU14DateTimePicker2.Size = new Size(68, 23);
            CPU14DateTimePicker2.TabIndex = 9;
            CPU14DateTimePicker2.ValueChanged += OrderCPUDateTimePicker2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 32);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 8;
            label3.Text = "ή";
            // 
            // ClearCPU14Button
            // 
            ClearCPU14Button.BackColor = Color.DarkSalmon;
            ClearCPU14Button.Location = new Point(253, 28);
            ClearCPU14Button.Name = "ClearCPU14Button";
            ClearCPU14Button.Size = new Size(23, 23);
            ClearCPU14Button.TabIndex = 7;
            ClearCPU14Button.Text = "✖";
            ClearCPU14Button.UseVisualStyleBackColor = false;
            ClearCPU14Button.Click += ClearCPU14Button_Click;
            // 
            // PasteCPU14Button
            // 
            PasteCPU14Button.BackColor = Color.Chartreuse;
            PasteCPU14Button.Location = new Point(230, 28);
            PasteCPU14Button.Name = "PasteCPU14Button";
            PasteCPU14Button.Size = new Size(23, 23);
            PasteCPU14Button.TabIndex = 6;
            PasteCPU14Button.Text = "✔";
            PasteCPU14Button.UseVisualStyleBackColor = false;
            PasteCPU14Button.Click += PasteCPU14Button_Click;
            // 
            // CPU14TextBox
            // 
            CPU14TextBox.Location = new Point(23, 28);
            CPU14TextBox.Name = "CPU14TextBox";
            CPU14TextBox.Size = new Size(206, 23);
            CPU14TextBox.TabIndex = 5;
            // 
            // CPU0Label
            // 
            CPU0Label.AutoSize = true;
            CPU0Label.ForeColor = Color.IndianRed;
            CPU0Label.Location = new Point(7, 62);
            CPU0Label.Name = "CPU0Label";
            CPU0Label.Size = new Size(13, 15);
            CPU0Label.TabIndex = 2;
            CPU0Label.Text = "0";
            // 
            // CPU14DateTimePicker
            // 
            CPU14DateTimePicker.CustomFormat = "dd/MM/yy";
            CPU14DateTimePicker.Format = DateTimePickerFormat.Custom;
            CPU14DateTimePicker.Location = new Point(278, 28);
            CPU14DateTimePicker.Name = "CPU14DateTimePicker";
            CPU14DateTimePicker.Size = new Size(68, 23);
            CPU14DateTimePicker.TabIndex = 1;
            CPU14DateTimePicker.ValueChanged += OrderCPUDateTimePicker_ValueChanged;
            // 
            // CPULabel
            // 
            CPULabel.AutoSize = true;
            CPULabel.Location = new Point(27, 10);
            CPULabel.Name = "CPULabel";
            CPULabel.Size = new Size(202, 15);
            CPULabel.TabIndex = 0;
            CPULabel.Text = "Laptop/Tablet/mobile/Consoles/Cpu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 468);
            Controls.Add(TabControl);
            Controls.Add(CurrentDateLabel);
            Controls.Add(CopyButton);
            Controls.Add(DeleteButton);
            Controls.Add(NotesRichTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Product Assistant";
            Load += Form1_Load;
            NotesPanel.ResumeLayout(false);
            NotesPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabControl.ResumeLayout(false);
            HomeTabPage.ResumeLayout(false);
            SupplierTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            OrdersTabPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox NotesRichTextBox;
        private Label AdressofOrderLabel;
        private ComboBox AdressofOrderComboBox;
        private Button DeleteButton;
        private ComboBox SendMsgComboBox;
        private Label SendMsgLabel;
        private ComboBox OnHoldComboBox;
        private Label OnHoldLabel;
        private Button CopyButton;
        private Panel NotesPanel;
        private Label SendMsgsLabel;
        private Label SendSMSCustomerLlabel;
        private ComboBox SMSComboBox;
        private Label SMSLabel;
        private Label CurrentDateLabel;
        private Panel panel1;
        private Label NotesLlabel;
        private TabControl TabControl;
        private TabPage HomeTabPage;
        private TabPage SupplierTabPage;
        private Button ShipButton;
        private Button CourrierButton;
        private Button CopyOKButton;
        private Button CancelPreorderButton;
        private TabPage OrdersTabPage;
        private Label CPU0Label;
        private DateTimePicker CPU14DateTimePicker;
        private Label CPULabel;
        private TextBox CPU14TextBox;
        private Button PasteCPU14Button;
        private Button ClearCPU14Button;
        private DateTimePicker CPU14DateTimePicker2;
        private Label label3;
        private Button ClearCPU0Button;
        private Button PasteCPU0Button;
        private TextBox CPU0TextBox;
        private Label label1;
        private Label label2;
        private Button ClearBattery0Button;
        private Button PasteBattery0Button;
        private TextBox Battery0TextBox;
        private DateTimePicker Battery14DateTimePicker2;
        private Label label4;
        private Button ClearBattery14Button;
        private Button PasteBattery14Button;
        private TextBox Battery14TextBox;
        private Label label5;
        private DateTimePicker Battery14DateTimePicker;
        private Label CourrierLabel;
        private Label label7;
        private Button ClearShip0Button;
        private Button PasteShip0Button;
        private TextBox Ship0TextBox;
        private DateTimePicker Ship14DateTimePicker2;
        private Label label8;
        private Button ClearShip14Button;
        private Button PasteShip14Button;
        private TextBox Ship14TextBox;
        private Label label9;
        private DateTimePicker Ship14DateTimePicker;
        private Label ShipLabel;
        private DateTimePicker CleanersDateTimePicker2;
        private Label label12;
        private Button ClearCleanersButton;
        private Button CleanersPasteButton;
        private TextBox CleanersTextBox;
        private DateTimePicker CleanersDateTimePicker;
        private Label CleanersLabel;
    }
}