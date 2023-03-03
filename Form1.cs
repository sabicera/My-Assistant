using System.Windows.Forms;

namespace My_Assistant
{
    public partial class Form1 : Form
    {
        private readonly List<DateTime> cyprusHolidays = new();
        private void AddHolidays(int year)
        {
            //Σταθερές Εορτές
            cyprusHolidays.Add(new DateTime(year, 1, 1)); // Πρωτοχρονία
            cyprusHolidays.Add(new DateTime(year, 1, 6)); // Θεοφάνεια
            cyprusHolidays.Add(new DateTime(year, 3, 25)); // 25η Μαρτίου
            cyprusHolidays.Add(new DateTime(year, 4, 1)); // Ανεξαρτησία της Κύπρου
            cyprusHolidays.Add(new DateTime(year, 5, 1)); // Εργατική Πρωτομαϊα
            cyprusHolidays.Add(new DateTime(year, 8, 15)); // Κοίμηση της Θεοτόκου
            cyprusHolidays.Add(new DateTime(year, 10, 1)); // Ημέρα Ανεξαρτησίας της Κύπρου
            cyprusHolidays.Add(new DateTime(year, 10, 28)); // Ημέρα του Όχι
            cyprusHolidays.Add(new DateTime(year, 12, 25)); // Χριστούγεννα

            //Κινητές Εορτές
            cyprusHolidays.Add(new DateTime(2022, 12, 26)); // Χριστούγεννα 2023
            cyprusHolidays.Add(new DateTime(2023, 1, 2)); // Πρωτοχρονία 2023
            cyprusHolidays.Add(new DateTime(2023, 2, 27)); // Καθαρά Δευτέρα 2023
        }
        public Form1()
        {
            InitializeComponent();
            AddHolidays(DateTime.Now.Year);
        }
        private void AdressofOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Έστειλα στην " + AdressofOrderComboBox.Text + " να διευθετήσει την παραγγελια ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyHomeButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
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
            else
            {
                HomeRichTextBox.Text = "Ενημέρωσε για " + SendMsgComboBox.Text; ;
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnHoldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            HomeRichTextBox.Text = "Αναμονή " + OnHoldComboBox.Text + " ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
            DataObject data = new DataObject();
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
                HomeRichTextBox.Text = "WE REMIND YOU THAT YOU CAN PICKUP YOUR ORDER UNTIL " + currentDate.ToString("dd/MM/yy") + " OR IT WILL BE CANCELLED."; ;
            }
            else if (SMSComboBox.Text == "Υπενθύμιση παραλαβής")
            {
                HomeRichTextBox.Text = "ΣΑΣ ΥΠΕΝΘΥΜΙΖΟΥΜΕ ΤΗΝ ΕΚΚΡΕΜΟΤΗΤΑ ΠΑΡΑΛΑΒΗΣ ΤΗΣ ΠΑΡΑΓΓΕΛΙΑΣ ΣΑΣ Η ΟΠΟΙΑ ΘΑ ΑΚΥΡΩΘΕΙ ΕΑΝ ΔΕΝ ΠΑΡΑΛΗΦΘΕΙ ΜΕΧΡΙ " + currentDate.ToString("dd/MM/yy");
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, HomeRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CourrierButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Courier // παραγγελία με λειτουργικά"; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Καράβι // αν γίνετε να φύγει με το σημερινό"; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyOKButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Αντιγραφή οκ, παραγγελία στην Κύπρο : Όταν παραλάβετε, στείλτε τα με το καράβι. Ευχαριστώ."; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CancelPreorderButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            SuppliersRichTextBox.Text = "Να ακυρωθεί η προέγκριση, θα πληρώσει σε εμάς ο πελάτης."; ;
            DataObject data = new DataObject();
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
            CPURichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
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
            CPURichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, CPURichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BatteryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            BatteryRichTextBox.Text = string.Empty;
            string orderNumber = Battery14TextBox.Text;
            string selectedDate = BatteryDateTimePicker.Value.ToString("dddd d/M");
            BatteryRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
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
            BatteryRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Courier " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, BatteryRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            ShipRichTextBox.Text = string.Empty;
            string orderNumber = Ship14TextBox.Text;
            string selectedDate = ShipDateTimePicker.Value.ToString("dddd d/M");
            ShipRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
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
            ShipRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, ShipRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            CleanersRichTextBox.Text = string.Empty;
            string orderNumber = Cleaners14TextBox.Text;
            string selectedDate = CleanersDateTimePicker.Value.ToString("dddd d/M");
            CleanersRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
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
            CleanersRichTextBox.AppendText(orderNumber + " Παραλαμβάνουμε με Καράβι " + selectedDate + " ή " + selectedDate2 + "=ΠΚ=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
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
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, CPURichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void BatteryCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, BatteryRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, ShipRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersCopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
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
                    ShipRichTextBox.Text = Ship14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + secondnextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
                }
                else
                {
                    // Calculate this Friday
                    DateTime nextFriday = currentDate.AddDays(7).AddDays((DayOfWeek.Friday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the upcoming Friday in the ShipRichTextBox
                    ShipRichTextBox.Text = Ship14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + nextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
                }
            else
            {
                ShipRichTextBox.Text = "";
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
                    CleanersRichTextBox.Text = Cleaners14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + secondnextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
                }
                else
                {
                    // Calculate this Friday
                    DateTime nextFriday = currentDate.AddDays(7).AddDays((DayOfWeek.Friday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the upcoming Friday in the ShipRichTextBox
                    CleanersRichTextBox.Text = Cleaners14TextBox.Text + " Παραλαμβάνουμε με Καράβι " + nextFriday.ToString("dd/MM") + " =ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
                }
            else
            {
                CleanersRichTextBox.Text = "";
            }
        }
        // Copy from Order Text Box
        private void Ship0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, Ship0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Battery0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, Battery0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CPU0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, CPU0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Cleaners0CopyButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, Cleaners0TextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        // Suppliers Tab
        private void CopySuppliersButton_Click(object sender, EventArgs e)
        {
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, SuppliersRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void DeleteSuppliersButton_Click(object sender, EventArgs e)
        {
            SuppliersRichTextBox.Text = string.Empty;
        }
    }
}