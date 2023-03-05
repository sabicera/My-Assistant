using System.Globalization;

namespace My_Assistant
{
    public partial class Form1 : Form
    {
        private string? myValue;
        readonly string text1 = "Τιμές ΟΚ";
        public Form1()
        {
            InitializeComponent();
            // Load the saved value if it exists
            myValue = Properties.Settings.Default.MyValue;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Save the value to the application settings
            Properties.Settings.Default.MyValue = myValue;
            Properties.Settings.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCPU14Value))
            {
                CPU14TextBox.Text = Properties.Settings.Default.LatestCPU14Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCPU0Value))
            {
                CPU0TextBox.Text = Properties.Settings.Default.LatestCPU0Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCPURichTextBoxValue))
            {
                CPURichTextBox.Text = Properties.Settings.Default.LatestCPURichTextBoxValue;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestBattery14Value))
            {
                Battery14TextBox.Text = Properties.Settings.Default.LatestBattery14Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestBattery0Value))
            {
                Battery0TextBox.Text = Properties.Settings.Default.LatestBattery0Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestBatteryRichTextBoxValue))
            {
                BatteryRichTextBox.Text = Properties.Settings.Default.LatestBatteryRichTextBoxValue;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestShip14Value))
            {
                Ship14TextBox.Text = Properties.Settings.Default.LatestShip14Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestShip0Value))
            {
                Ship0TextBox.Text = Properties.Settings.Default.LatestShip0Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestShipRichTextBoxValue))
            {
                ShipRichTextBox.Text = Properties.Settings.Default.LatestShipRichTextBoxValue;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCleaners14Value))
            {
                Cleaners14TextBox.Text = Properties.Settings.Default.LatestCleaners14Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCleaners0Value))
            {
                Cleaners0TextBox.Text = Properties.Settings.Default.LatestCleaners0Value;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LatestCleanersRichTextBoxValue))
            {
                CleanersRichTextBox.Text = Properties.Settings.Default.LatestCleanersRichTextBoxValue;
            }
        }
        private void AdressofOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Έστειλα στην " + AdressofOrderComboBox.Text + " να διευθετήσει την παραγγελια ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyHomeButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void DeleteHomeButton_Click(object sender, EventArgs e)
        {
            HomeRichTextBox.Text = string.Empty;
        }
        private void SendMsgComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            Clipboard.Clear();
            if (SendMsgComboBox.Text == "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή")
                if (currentDate.DayOfWeek < DayOfWeek.Friday || (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.TimeOfDay < TimeSpan.FromHours(11)))
                {
                    // Calculate the next Tuesday and Thursday
                    DateTime nextTuesday = currentDate.AddDays((DayOfWeek.Tuesday + 7 - currentDate.DayOfWeek) % 7);
                    DateTime nextThursday = currentDate.AddDays((DayOfWeek.Thursday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the next Tuesday and Thursday in the NotesRichTextBox
                    HomeRichTextBox.Text = "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή εντός " + nextTuesday.ToString("dd/MM") + " και " + nextThursday.ToString("dd/MM");
                }
                else
                {
                    // Calculate the second Wednesday following the current date
                    DateTime secondWednesday = currentDate.AddDays(5).AddDays((DayOfWeek.Wednesday + 7 - currentDate.AddDays(5).DayOfWeek) % 7);
                    // Display the second Wednesday in the NotesRichTextBox
                    HomeRichTextBox.Text = "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή εντός " + secondWednesday.ToString("dd/MM") + " με Καράβι";
                }
            else if (SendMsgComboBox.Text == "ενημέρωσε για καθυστέρηση παραγγελίας και παραλαβή")
                if (currentDate.DayOfWeek < DayOfWeek.Friday || (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.TimeOfDay < TimeSpan.FromHours(11)))
                {
                    // Calculate the next Tuesday and Thursday
                    DateTime nextTuesday = currentDate.AddDays((DayOfWeek.Tuesday + 7 - currentDate.DayOfWeek) % 7);
                    DateTime nextThursday = currentDate.AddDays((DayOfWeek.Thursday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the next Tuesday and Thursday in the NotesRichTextBox
                    HomeRichTextBox.Text = "ενημέρωσε για καθυστέρηση παραγγελίας και παραλαβή " + nextTuesday.ToString("dd/MM") + " και " + nextThursday.ToString("dd/MM");
                }
                else
                {
                    // Calculate the second Wednesday following the current date
                    DateTime secondWednesday = currentDate.AddDays(5).AddDays((DayOfWeek.Wednesday + 7 - currentDate.AddDays(5).DayOfWeek) % 7);
                    // Display the second Wednesday in the NotesRichTextBox
                    HomeRichTextBox.Text = "ενημέρωσε για καθυστέρηση παραγγελίας και παραλαβή " + secondWednesday.ToString("dd/MM") + " με Καράβι";
                }
            else
            {
                HomeRichTextBox.Text = "Ενημέρωσε για " + SendMsgComboBox.Text;
            }
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void OnHoldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Αναμονή " + OnHoldComboBox.Text + " ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void SMSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define a counter for the working days
            int workingDays = 0;
            // Define the current date
            DateTime currentDate = DateTime.Today;
            // Loop through each date until 5 working days have been counted
            while (workingDays < 7)
            {
                // Move to the next day
                currentDate = currentDate.AddDays(1);
                workingDays++;
            }
            Clipboard.Clear();
            if (SMSComboBox.Text == "Pickup Reminder")
            {
                HomeRichTextBox.Text = "WE REMIND YOU THAT YOU CAN PICKUP YOUR ORDER UNTIL " + currentDate.ToString("dd/MM/yy") + " OR IT WILL BE CANCELLED.";
            }
            else if (SMSComboBox.Text == "Υπενθύμιση παραλαβής")
            {
                HomeRichTextBox.Text = "ΣΑΣ ΥΠΕΝΘΥΜΙΖΟΥΜΕ ΤΗΝ ΕΚΚΡΕΜΟΤΗΤΑ ΠΑΡΑΛΑΒΗΣ ΤΗΣ ΠΑΡΑΓΓΕΛΙΑΣ ΣΑΣ Η ΟΠΟΙΑ ΘΑ ΑΚΥΡΩΘΕΙ ΕΑΝ ΔΕΝ ΠΑΡΑΛΗΦΘΕΙ ΜΕΧΡΙ " + currentDate.ToString("dd/MM/yy");
            }
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CourrierButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Courier // παραγγελία με λειτουργικά";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Καράβι // αν γίνετε να φύγει με το σημερινό";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyOKButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Αντιγραφή οκ, παραγγελία στην Κύπρο : Όταν παραλάβετε, στείλτε τα με το καράβι. Ευχαριστώ.";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CancelPreorderButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Να ακυρωθεί η προέγκριση, θα πληρώσει σε εμάς ο πελάτης.";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Date Time Pickers
        private void CPUDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CPURichTextBox.Text = string.Empty;
            string orderNumber = CPU14TextBox.Text;
            string selectedDate = CPUDateTimePicker.Value.ToString("dddd d/M");
            string newValue = $"{orderNumber} Παραλαμβάνουμε με Courier {selectedDate}=ΠΚ={DateTime.Now:d/M/yy}";
            // Append the new value to the text box and update the class-level variable
            CPURichTextBox.AppendText(newValue);
            myValue = newValue;
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CPURichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CPUDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CPURichTextBox.Text = string.Empty;
            string orderNumber = CPU14TextBox.Text;
            string selectedDate = CPUDateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = CPUDateTimePicker2.Value.ToString("dddd d/M");
            CPURichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CPURichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BatteryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            BatteryRichTextBox.Text = string.Empty;
            string orderNumber = Battery14TextBox.Text;
            string selectedDate = BatteryDateTimePicker.Value.ToString("dddd d/M");
            BatteryRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, BatteryRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BatteryDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            BatteryRichTextBox.Text = string.Empty;
            string orderNumber = Battery14TextBox.Text;
            string selectedDate = BatteryDateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = BatteryDateTimePicker2.Value.ToString("dddd d/M");
            BatteryRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, BatteryRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            ShipRichTextBox.Text = string.Empty;
            string orderNumber = Ship14TextBox.Text;
            string selectedDate = ShipDateTimePicker.Value.ToString("dddd d/M");
            ShipRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, ShipRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            ShipRichTextBox.Text = string.Empty;
            string orderNumber = Ship14TextBox.Text;
            string selectedDate = ShipDateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = ShipDateTimePicker2.Value.ToString("dddd d/M");
            ShipRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, ShipRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CleanersRichTextBox.Text = string.Empty;
            string orderNumber = Cleaners14TextBox.Text;
            string selectedDate = CleanersDateTimePicker.Value.ToString("dddd d/M");
            CleanersRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CleanersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CleanersRichTextBox.Text = string.Empty;
            string orderNumber = Cleaners14TextBox.Text;
            string selectedDate = CleanersDateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = CleanersDateTimePicker2.Value.ToString("dddd d/M");
            CleanersRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy"));
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CleanersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Paste Order Buttons
        private void PasteCPU14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CPU14TextBox.Text = Clipboard.GetText();
            }
        }
        private void PasteCPU0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CPU0TextBox.Text = Clipboard.GetText();
            }
        }
        private void PasteBattery14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Battery14TextBox.Text = Clipboard.GetText();
            }
        }
        private void PasteBattery0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Battery0TextBox.Text = Clipboard.GetText();
            }
        }
        private void PasteShip14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Ship14TextBox.Text = Clipboard.GetText();
            }
        }
        private void PasteShip0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Ship0TextBox.Text = Clipboard.GetText();
            }
        }
        private void Cleaners14PasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Cleaners14TextBox.Text = Clipboard.GetText();
            }
        }
        private void Cleaners0PasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Cleaners0TextBox.Text = Clipboard.GetText();
            }
        }
        // Clear Order Buttons
        private void ClearCPU14Button_Click(object sender, EventArgs e)
        {
            CPU14TextBox.Text = string.Empty;
        }
        private void ClearCPU0Button_Click(object sender, EventArgs e)
        {
            CPU0TextBox.Text = string.Empty;
        }
        private void ClearBattery14Button_Click(object sender, EventArgs e)
        {
            Battery14TextBox.Text = string.Empty;
        }
        private void ClearBattery0Button_Click(object sender, EventArgs e)
        {
            Battery0TextBox.Text = string.Empty;
        }
        private void ClearShip14Button_Click(object sender, EventArgs e)
        {
            Ship14TextBox.Text = string.Empty;
        }
        private void ClearShip0Button_Click(object sender, EventArgs e)
        {
            Ship0TextBox.Text = string.Empty;
        }
        private void Cleaners14ClearButton_Click(object sender, EventArgs e)
        {
            Cleaners14TextBox.Text = string.Empty;
        }
        private void Cleaners0ClearButton_Click(object sender, EventArgs e)
        {
            Cleaners0TextBox.Text = string.Empty;
        }
        // Orders Copy Rich Text Box
        private void CPUCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CPURichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BatteryCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, BatteryRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, ShipRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CleanersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Orders Reset Rich Text Box
        private void CPUResetButton_Click(object sender, EventArgs e)
        {
            CPURichTextBox.Text = string.Empty;
        }
        private void BatteryResetButton_Click(object sender, EventArgs e)
        {
            BatteryRichTextBox.Text = string.Empty;
        }
        private void ShipResetButton_Click(object sender, EventArgs e)
        {
            ShipRichTextBox.Text = string.Empty;
        }
        private void CleanersResetButton_Click(object sender, EventArgs e)
        {
            CleanersRichTextBox.Text = string.Empty;
        }
        // Auto Gen Buttons
        private void ShipAutoButton_Click(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            Clipboard.Clear();
            if (Ship14TextBox.Text is not null)
                if (currentDate.DayOfWeek > DayOfWeek.Friday || (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.TimeOfDay > TimeSpan.FromHours(11)))
                {
                    // Calculate the second next Friday
                    DateTime secondnextFriday = currentDate.AddDays(14).AddDays((DayOfWeek.Friday + 7 - currentDate.AddDays(7).DayOfWeek) % 7);
                    // Display the next Friday in the ShipRichTextBox
                    ShipRichTextBox.Text = Ship14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + secondnextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
                }
                else
                {
                    // Calculate this Friday
                    DateTime nextFriday = currentDate.AddDays(7).AddDays((DayOfWeek.Friday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the upcoming Friday in the ShipRichTextBox
                    ShipRichTextBox.Text = Ship14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + nextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
                }
            else
            {
                ShipRichTextBox.Text = string.Empty;
            }
        }
        private void CleanersAutoButton_Click(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            Clipboard.Clear();
            if (Cleaners14TextBox.Text is not null)
                if (currentDate.DayOfWeek > DayOfWeek.Friday || (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.TimeOfDay > TimeSpan.FromHours(11)))
                {
                    // Calculate the second next Friday
                    DateTime secondnextFriday = currentDate.AddDays(14).AddDays((DayOfWeek.Friday + 7 - currentDate.AddDays(7).DayOfWeek) % 7);
                    // Display the next Friday in the ShipRichTextBox
                    CleanersRichTextBox.Text = Cleaners14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + secondnextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
                }
                else
                {
                    // Calculate this Friday
                    DateTime nextFriday = currentDate.AddDays(7).AddDays((DayOfWeek.Friday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the upcoming Friday in the ShipRichTextBox
                    CleanersRichTextBox.Text = Cleaners14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + nextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy");
                }
            else
            {
                CleanersRichTextBox.Text = string.Empty;
            }
        }
        // Copy from Order Text Box
        private void Ship0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, Ship0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Battery0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, Battery0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CPU0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, CPU0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Cleaners0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, Cleaners0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Suppliers Tab
        private void CopySuppliersButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void DeleteSuppliersButton_Click(object sender, EventArgs e)
        {
            SuppliersRichTextBox.Text = string.Empty;
        }
        // Save and Load Function
        private void CPU14TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCPU14Value = CPU14TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void CPU0TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCPU0Value = CPU0TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void CPURichTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCPURichTextBoxValue = CPURichTextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Battery14TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestBattery14Value = Battery14TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Battery0TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestBattery0Value = Battery0TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void BatteryRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestBatteryRichTextBoxValue = BatteryRichTextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Ship14TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestShip14Value = Ship14TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Ship0TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestShip0Value = Ship0TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void ShipRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestShipRichTextBoxValue = ShipRichTextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Cleaners14TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCleaners14Value = Cleaners14TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void Cleaners0TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCleaners0Value = Cleaners0TextBox.Text;
            Properties.Settings.Default.Save();
        }
        private void CleanersRichTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LatestCleanersRichTextBoxValue = CleanersRichTextBox.Text;
            Properties.Settings.Default.Save();
        }
        // Calculations
        private void CostGRTextBox_TextChanged(object sender, EventArgs e) => CalculateGRTotal();
        private void ShippingGRTextBox_TextChanged(object sender, EventArgs e) => CalculateGRTotal();
        private void CalculateGRTotal()
        {
            // Set the culture to a European culture that uses the euro symbol
            var culture = new CultureInfo("en-EN");
            var format = (NumberFormatInfo)culture.NumberFormat.Clone();
            format.CurrencySymbol = string.Empty;

            decimal.TryParse(CostGRTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal cost);
            decimal.TryParse(ShippingGRTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal shipping);

            // Perform the calculations
            decimal subtotal = cost + shipping;
            decimal tax = (subtotal * 1.04m) * 1.24m;
            decimal total = tax;

            // Display the result in the TotalTextBox with 2 decimal places and the euro symbol
            TotalGRButton.Text = total.ToString("N4", format);
        }
        private void CostGRSecTextBox_TextChanged(object sender, EventArgs e) => CalculateGRSecTotal();
        private void ShippingGRSecTextBox_TextChanged(object sender, EventArgs e) => CalculateGRSecTotal();
        private void CalculateGRSecTotal()
        {
            // Set the culture to a European culture that uses the euro symbol
            var culture = new CultureInfo("en-EN");
            var format = (NumberFormatInfo)culture.NumberFormat.Clone();
            format.CurrencySymbol = string.Empty;

            decimal.TryParse(CostGRSecTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal cost);
            decimal.TryParse(ShippingGRSecTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal shipping);

            // Perform the calculations
            decimal subtotal = cost + shipping;
            decimal tax = (subtotal * 1.04m) * 1.24m;
            decimal total = tax;

            // Display the result in the TotalTextBox with 2 decimal places and the euro symbol
            TotalGRSecButton.Text = total.ToString("N4", format);
        }
        private void CostUKTextBox_TextChanged(object sender, EventArgs e) => CalculateUKTotal();
        private void ShippingUKTextBox_TextChanged(object sender, EventArgs e) => CalculateUKTotal();
        private void CalculateUKTotal()
        {
            // Set the culture to a European culture that uses the euro symbol
            var culture = new CultureInfo("en-EN");
            var format = (NumberFormatInfo)culture.NumberFormat.Clone();
            format.CurrencySymbol = string.Empty;

            decimal.TryParse(CostUKTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal cost);
            decimal.TryParse(ShippingUKTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal shipping);

            // Perform the calculations
            decimal subtotal = cost + shipping;
            decimal tax = ((subtotal * 1.03m) * 1.04m) * 1.24m;
            decimal total = tax;

            // Display the result in the TotalTextBox with 2 decimal places and the euro symbol
            TotalUKButton.Text = total.ToString("N4", format);
        }
        private void CostUKSecTextBox_TextChanged(object sender, EventArgs e) => CalculateUKSecTotal();
        private void ShippingUKSecTextBox_TextChanged(object sender, EventArgs e) => CalculateUKSecTotal();
        private void CalculateUKSecTotal()
        {
            // Set the culture to a European culture that uses the euro symbol
            var culture = new CultureInfo("en-EN");
            var format = (NumberFormatInfo)culture.NumberFormat.Clone();
            format.CurrencySymbol = string.Empty;

            decimal.TryParse(CostUKSecTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal cost);
            decimal.TryParse(ShippingUKSecTextBox.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal shipping);

            // Perform the calculations
            decimal subtotal = cost + shipping;
            decimal tax = ((subtotal * 1.03m) * 1.04m) * 1.24m;
            decimal total = tax;

            // Display the result in the TotalTextBox with 2 decimal places and the euro symbol
            TotalUKSecButton.Text = total.ToString("N4", format);
        }
        private void CalcTextBox1_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox2_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox3_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox4_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox5_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox6_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox7_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox8_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox9_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox10_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox11_TextChanged(object sender, EventArgs e) => Calculator();
        private void CalcTextBox12_TextChanged(object sender, EventArgs e) => Calculator();
        private void Calculator()
        {
            // Set the culture to a European culture that uses the euro symbol
            var culture = new CultureInfo("en-EN");
            var format = (NumberFormatInfo)culture.NumberFormat.Clone();
            format.CurrencySymbol = string.Empty;

            decimal.TryParse(CalcTextBox1.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc1);
            decimal.TryParse(CalcTextBox2.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc2);
            decimal.TryParse(CalcTextBox3.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc3);
            decimal.TryParse(CalcTextBox4.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc4);
            decimal.TryParse(CalcTextBox5.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc5);
            decimal.TryParse(CalcTextBox6.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc6);
            decimal.TryParse(CalcTextBox7.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc7);
            decimal.TryParse(CalcTextBox8.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc8);
            decimal.TryParse(CalcTextBox9.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc9);
            decimal.TryParse(CalcTextBox10.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc10);
            decimal.TryParse(CalcTextBox11.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc11);
            decimal.TryParse(CalcTextBox12.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, culture, out decimal Calc12);

            // Perform the calculations
            decimal subtotal = Calc1 + Calc2 + Calc3 + Calc4 + Calc5 + Calc6 + Calc7 + Calc8 + Calc9 + Calc10 + Calc11 + Calc12;

            // Display the result in the TotalTextBox with 2 decimal places and the euro symbol
            CalculatorTotalTextBox.Text = subtotal.ToString("N4", format);
        }
        // Calculations Copy Buttons
        private void TotalGRButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, TotalGRButton.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void TotalGRSecButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, TotalGRSecButton.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void TotalUKButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, TotalUKButton.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void TotalUKSecButton_Click(object sender, EventArgs e)
        {
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, TotalUKSecButton.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Calculation Reset Button
        private void ResetGRButton_Click(object sender, EventArgs e)
        {
            CostGRTextBox.Text = string.Empty;
            ShippingGRTextBox.Text = string.Empty;
        }
        private void ResetGRSecButton_Click(object sender, EventArgs e)
        {
            CostGRSecTextBox.Text = string.Empty;
            ShippingGRSecTextBox.Text = string.Empty;
        }
        private void ResetUKButton_Click(object sender, EventArgs e)
        {
            CostUKTextBox.Text = string.Empty;
            ShippingUKTextBox.Text = string.Empty;
        }
        private void ResetUKSecButton_Click(object sender, EventArgs e)
        {
            CostUKSecTextBox.Text = string.Empty;
            ShippingUKSecTextBox.Text = string.Empty;
        }
        private void ResetButton14_Click(object sender, EventArgs e)
        {
            FirstTextBox1.Text = string.Empty;
            FirstTextBox2.Text = string.Empty;
            FirstTextBox3.Text = string.Empty;
            FirstTextBox4.Text = string.Empty;
            FirstTextBox5.Text = string.Empty;
            FirstTextBox6.Text = string.Empty;
            FirstTextBox7.Text = string.Empty;
            FirstTextBox8.Text = string.Empty;
            FirstTextBox9.Text = string.Empty;
            FirstTextBox10.Text = string.Empty;
            FirstTextBox11.Text = string.Empty;
            FirstTextBox12.Text = string.Empty;
            FirstTextBox13.Text = string.Empty;
            FirstTextBox14.Text = string.Empty;
            FirstTextBox15.Text = string.Empty;
            FirstTextBox16.Text = string.Empty;
        }
        private void ResetButton0_Click(object sender, EventArgs e)
        {
            SecondTextBox1.Text = string.Empty;
            SecondTextBox2.Text = string.Empty;
            SecondTextBox3.Text = string.Empty;
            SecondTextBox4.Text = string.Empty;
            SecondTextBox5.Text = string.Empty;
            SecondTextBox6.Text = string.Empty;
            SecondTextBox7.Text = string.Empty;
            SecondTextBox8.Text = string.Empty;
            SecondTextBox9.Text = string.Empty;
            SecondTextBox10.Text = string.Empty;
            SecondTextBox11.Text = string.Empty;
            SecondTextBox12.Text = string.Empty;
            SecondTextBox13.Text = string.Empty;
            SecondTextBox14.Text = string.Empty;
            SecondTextBox15.Text = string.Empty;
            SecondTextBox16.Text = string.Empty;
        }
        private void ResetKButton14_Click(object sender, EventArgs e)
        {
            ThirdTextBox1.Text = string.Empty;
            ThirdTextBox2.Text = string.Empty;
            ThirdTextBox3.Text = string.Empty;
            ThirdTextBox4.Text = string.Empty;
            ThirdTextBox5.Text = string.Empty;
            ThirdTextBox6.Text = string.Empty;
            ThirdTextBox7.Text = string.Empty;
            ThirdTextBox8.Text = string.Empty;
            ThirdTextBox9.Text = string.Empty;
            ThirdTextBox10.Text = string.Empty;
            ThirdTextBox11.Text = string.Empty;
            ThirdTextBox12.Text = string.Empty;
            ThirdTextBox13.Text = string.Empty;
            ThirdTextBox14.Text = string.Empty;
            ThirdTextBox15.Text = string.Empty;
            ThirdTextBox16.Text = string.Empty;
        }
        private void ResetKButton0_Click(object sender, EventArgs e)
        {
            ForthTextBox1.Text = string.Empty;
            ForthTextBox2.Text = string.Empty;
            ForthTextBox3.Text = string.Empty;
            ForthTextBox4.Text = string.Empty;
            ForthTextBox5.Text = string.Empty;
            ForthTextBox6.Text = string.Empty;
            ForthTextBox7.Text = string.Empty;
            ForthTextBox8.Text = string.Empty;
            ForthTextBox9.Text = string.Empty;
            ForthTextBox10.Text = string.Empty;
            ForthTextBox11.Text = string.Empty;
            ForthTextBox12.Text = string.Empty;
            ForthTextBox13.Text = string.Empty;
            ForthTextBox14.Text = string.Empty;
            ForthTextBox15.Text = string.Empty;
            ForthTextBox16.Text = string.Empty;
        }
        private void PricesOKButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            DataObject data = new();
            data.SetData(DataFormats.StringFormat, text1);
            Clipboard.SetDataObject(data);
        }
        private void ToLimassolButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "=1 για Λεμεσό";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void FromNicosiaButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Από Λευκωσία";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void FromLarnacaButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Από Λάρνακα";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void TempOrderButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = $"ΠΡΟΣΩΡΙΝΗ ΔΕΣΜΕΥΣΗ αναμονη προκαταβολης _ το προϊόν είναι δεσμευμένο στον προμηθευτή και θα είναι κανονικά διαθέσιμο 3-4 ΜΕΡΕΣ μετά την προκαταβολή του πελάτη=ΠΚ {DateTime.Now:dd/MM/yy}";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ContactWaitButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = $"Αναμονή επικοινωνίας από πελάτη=ΠΚ {DateTime.Now:dd/MM/yy}";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);

        }
        private void TempButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = $"Αναμονή προκαταβολής=ΠΚ {DateTime.Now:dd/MM/yy}";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ArticleButton39_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"Άρθρο 39α ,υπόχρεος για την καταβολή του φόρου είναι ο αγοραστής";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BooksButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"ΠΡΟΣΟΧΗ - ΒΙΒΛΙΑ - ΦΠΑ 6,5%";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void MasksButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"ΠΡΟΣΟΧΗ - ΜΑΣΚΕΣ - ΦΠΑ 6%";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BooksOrderButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"ΔΕΣΜΕΥΣΗ ΚΥΠΡΟΥ(ΒΙΒΛΙΑ)";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void FixPricesButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"Καλημέρα, φτιάξε τιμές μόλις μπορέσεις, ευχαριστώ....";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void PricesNotButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = $"Τιμές ΟΚ, εκτός";
            DataObject data = new();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
    }
}