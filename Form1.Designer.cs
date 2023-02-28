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
            NotesPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NotesRichTextBox
            // 
            NotesRichTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NotesRichTextBox.Location = new Point(12, 342);
            NotesRichTextBox.Name = "NotesRichTextBox";
            NotesRichTextBox.Size = new Size(392, 96);
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
            DeleteButton.Location = new Point(266, 293);
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
            SendMsgComboBox.Items.AddRange(new object[] { "παραλαβή σε 10-15 εργάσιμες μέρες", "διπλή παραγγελία", "Δευτέρα - Τρίτη", "προκαταβολή", "διαθεσιμότητα", "διαθεσιμότητα και προκαταβολή", "πρόβλημα διαθεσιμότητας. Πρότεινε κάτι άλλο", "καθυστέρηση παραγγελίας και παραλαβή", "παλιό service. Να περάσει να παραλάβει" });
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
            OnHoldComboBox.Location = new Point(115, 72);
            OnHoldComboBox.Name = "OnHoldComboBox";
            OnHoldComboBox.Size = new Size(268, 23);
            OnHoldComboBox.TabIndex = 9;
            OnHoldComboBox.SelectedIndexChanged += OnHoldComboBox_SelectedIndexChanged;
            // 
            // OnHoldLabel
            // 
            OnHoldLabel.AutoSize = true;
            OnHoldLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OnHoldLabel.Location = new Point(51, 75);
            OnHoldLabel.Name = "OnHoldLabel";
            OnHoldLabel.Size = new Size(58, 15);
            OnHoldLabel.TabIndex = 8;
            OnHoldLabel.Text = "Αναμονή :";
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.Chartreuse;
            CopyButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CopyButton.Location = new Point(12, 293);
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
            NotesPanel.Location = new Point(12, 162);
            NotesPanel.Name = "NotesPanel";
            NotesPanel.Size = new Size(392, 125);
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
            CurrentDateLabel.Location = new Point(136, 9);
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
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 113);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 448);
            Controls.Add(panel1);
            Controls.Add(CurrentDateLabel);
            Controls.Add(NotesPanel);
            Controls.Add(CopyButton);
            Controls.Add(DeleteButton);
            Controls.Add(NotesRichTextBox);
            Name = "Form1";
            Text = "Product Assistant";
            Load += Form1_Load;
            NotesPanel.ResumeLayout(false);
            NotesPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label SendSMSCustomerLlabel;
        private ComboBox SMSComboBox;
        private Label SMSLabel;
        private Label CurrentDateLabel;
        private Panel panel1;
        private Label NotesLlabel;
    }
}