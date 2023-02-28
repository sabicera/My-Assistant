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
            NotesRichTextBox.Text = "Έστειλα στην " + AdressofOrderComboBox.Text + " να διευθετήσει την παραγγελια ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            NotesRichTextBox.Text = string.Empty;
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
                    NotesRichTextBox.Text = "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή εντός " + nextTuesday.ToString("dd/MM") + " και " + nextThursday.ToString("dd/MM");
                }
                else
                {
                    // Calculate the second Wednesday following the current date
                    DateTime secondWednesday = currentDate.AddDays(5).AddDays((DayOfWeek.Wednesday + 7 - currentDate.AddDays(5).DayOfWeek) % 7);
                    // Display the second Wednesday in the NotesRichTextBox
                    NotesRichTextBox.Text = "ενημέρωσε για καθυστέρηση από προμηθευτή και πιθανή παραλαβή εντός " + secondWednesday.ToString("dd/MM") + " με Καράβι";
                }
            else
            {
                NotesRichTextBox.Text = "Ενημέρωσε για " + SendMsgComboBox.Text; ;
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentDateLabel.Text = DateTime.Now.ToLongDateString();
        }
        private void OnHoldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "Αναμονή " + OnHoldComboBox.Text + " ΠΚ=" + DateTime.Now.ToString("dd/MM/yy"); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void SMSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define a counter for the working days
            int workingDays = 0;
            // Define the current date
            DateTime currentDate = DateTime.Today;
            // Loop through each date until 5 working days have been counted
            while (workingDays < 3)
            {
                // Move to the next day
                currentDate = currentDate.AddDays(1);
                // If the date is a weekend or holiday, skip it
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }
                // Otherwise, increment the working day counter
                workingDays++;
            }
            Clipboard.Clear();
            if (SMSComboBox.Text == "Pickup Reminder")
            {
                NotesRichTextBox.Text = "WE REMIND YOU THAT YOU CAN PICKUP YOUR ORDER UNTIL " + currentDate.ToString("dd/MM/yy") + " OR IT WILL BE CANCELLED."; ;
            }
            else if (SMSComboBox.Text == "Υπενθύμιση παραλαβής")
            {
                NotesRichTextBox.Text = "ΣΑΣ ΥΠΕΝΘΥΜΙΖΟΥΜΕ ΤΗΝ ΕΚΚΡΕΜΟΤΗΤΑ ΠΑΡΑΛΑΒΗΣ ΤΗΣ ΠΑΡΑΓΓΕΛΙΑΣ ΣΑΣ Η ΟΠΟΙΑ ΘΑ ΑΚΥΡΩΘΕΙ ΕΑΝ ΔΕΝ ΠΑΡΑΛΗΦΘΕΙ ΜΕΧΡΙ " + currentDate.ToString("dd/MM/yy");
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
    }
}