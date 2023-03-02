using System.Windows.Forms;

namespace My_Assistant
{
    public partial class Form1 : Form
    {
        private readonly List<DateTime> cyprusHolidays = new();
        private void AddHolidays(int year)
        {
            //�������� ������
            cyprusHolidays.Add(new DateTime(year, 1, 1)); // �����������
            cyprusHolidays.Add(new DateTime(year, 1, 6)); // ���������
            cyprusHolidays.Add(new DateTime(year, 3, 25)); // 25� �������
            cyprusHolidays.Add(new DateTime(year, 4, 1)); // ����������� ��� ������
            cyprusHolidays.Add(new DateTime(year, 5, 1)); // �������� ���������
            cyprusHolidays.Add(new DateTime(year, 8, 15)); // ������� ��� ��������
            cyprusHolidays.Add(new DateTime(year, 10, 1)); // ����� ������������ ��� ������
            cyprusHolidays.Add(new DateTime(year, 10, 28)); // ����� ��� ���
            cyprusHolidays.Add(new DateTime(year, 12, 25)); // ������������

            //������� ������
            cyprusHolidays.Add(new DateTime(2022, 12, 26)); // ������������ 2023
            cyprusHolidays.Add(new DateTime(2023, 1, 2)); // ����������� 2023
            cyprusHolidays.Add(new DateTime(2023, 2, 27)); // ������ ������� 2023
        }
        public Form1()
        {
            InitializeComponent();
            AddHolidays(DateTime.Now.Year);
        }
        private void AdressofOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "������� ���� " + AdressofOrderComboBox.Text + " �� ����������� ��� ���������� ��=" + DateTime.Now.ToString("dd/MM/yy"); ;
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
            if (SendMsgComboBox.Text == "��������� ��� ����������� ��� ���������� ��� ������ ��������")
                if (currentDate.DayOfWeek < DayOfWeek.Friday || (currentDate.DayOfWeek == DayOfWeek.Friday && currentDate.TimeOfDay < TimeSpan.FromHours(11)))
                {
                    // Calculate the next Tuesday and Thursday
                    DateTime nextTuesday = currentDate.AddDays((DayOfWeek.Tuesday + 7 - currentDate.DayOfWeek) % 7);
                    DateTime nextThursday = currentDate.AddDays((DayOfWeek.Thursday + 7 - currentDate.DayOfWeek) % 7);
                    // Display the next Tuesday and Thursday in the NotesRichTextBox
                    NotesRichTextBox.Text = "��������� ��� ����������� ��� ���������� ��� ������ �������� ����� " + nextTuesday.ToString("dd/MM") + " ��� " + nextThursday.ToString("dd/MM");
                }
                else
                {
                    // Calculate the second Wednesday following the current date
                    DateTime secondWednesday = currentDate.AddDays(5).AddDays((DayOfWeek.Wednesday + 7 - currentDate.AddDays(5).DayOfWeek) % 7);
                    // Display the second Wednesday in the NotesRichTextBox
                    NotesRichTextBox.Text = "��������� ��� ����������� ��� ���������� ��� ������ �������� ����� " + secondWednesday.ToString("dd/MM") + " �� ������";
                }
            else
            {
                NotesRichTextBox.Text = "��������� ��� " + SendMsgComboBox.Text; ;
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
            NotesRichTextBox.Text = "������� " + OnHoldComboBox.Text + " ��=" + DateTime.Now.ToString("dd/MM/yy"); ;
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
            while (workingDays < 7)
            {
                // Move to the next day
                currentDate = currentDate.AddDays(1);
                workingDays++;
            }
            Clipboard.Clear();
            if (SMSComboBox.Text == "Pickup Reminder")
            {
                NotesRichTextBox.Text = "WE REMIND YOU THAT YOU CAN PICKUP YOUR ORDER UNTIL " + currentDate.ToString("dd/MM/yy") + " OR IT WILL BE CANCELLED."; ;
            }
            else if (SMSComboBox.Text == "���������� ���������")
            {
                NotesRichTextBox.Text = "��� ������������� ��� ����������� ��������� ��� ����������� ��� � ����� �� �������� ��� ��� ���������� ����� " + currentDate.ToString("dd/MM/yy");
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }

        private void CourrierButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "Courier // ���������� �� �����������"; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void ShipButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "������ // �� ������ �� ����� �� �� ��������"; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CopyOKButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "��������� ��, ���������� ���� ����� : ���� ����������, ������� �� �� �� ������. ���������."; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CancelPreorderButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = "�� �������� � ����������, �� �������� �� ���� � �������."; ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void OrderCPUDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = CPU14TextBox.Text;
            string selectedDate = CPU14DateTimePicker.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void OrderCPUDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = CPU14TextBox.Text;
            string selectedDate = CPU14DateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = CPU14DateTimePicker2.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� Courier " + selectedDate + " � " + selectedDate2 + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Battery14DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = Battery14TextBox.Text;
            string selectedDate = Battery14DateTimePicker.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Battery14DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = Battery14TextBox.Text;
            string selectedDate = Battery14DateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = Battery14DateTimePicker2.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Ship14DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = Ship14TextBox.Text;
            string selectedDate = Ship14DateTimePicker.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void Ship14DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = Ship14TextBox.Text;
            string selectedDate = Ship14DateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = Ship14DateTimePicker2.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void PasteCPU14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CPU14TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearCPU14Button_Click(object sender, EventArgs e)
        {
            CPU14TextBox.Text = string.Empty;
        }
        private void PasteCPU0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CPU0TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearCPU0Button_Click(object sender, EventArgs e)
        {
            CPU0TextBox.Text = string.Empty;
        }
        private void PasteBattery14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Battery14TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearBattery14Button_Click(object sender, EventArgs e)
        {
            Battery14TextBox.Text = string.Empty;
        }
        private void PasteBattery0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Battery0TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearBattery0Button_Click(object sender, EventArgs e)
        {
            Battery0TextBox.Text = string.Empty;
        }
        private void PasteShip14Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Ship14TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearShip14Button_Click(object sender, EventArgs e)
        {
            Ship14TextBox.Text = string.Empty;
        }
        private void PasteShip0Button_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Ship0TextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearShip0Button_Click(object sender, EventArgs e)
        {
            Ship0TextBox.Text = string.Empty;
        }
        private void CleanersDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = CleanersTextBox.Text;
            string selectedDate = CleanersDateTimePicker.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Clipboard.Clear();
            NotesRichTextBox.Text = string.Empty;
            string orderNumber = CleanersTextBox.Text;
            string selectedDate = CleanersDateTimePicker.Value.ToString("dddd d/M");
            string selectedDate2 = CleanersDateTimePicker2.Value.ToString("dddd d/M");
            NotesRichTextBox.AppendText(orderNumber + " �������������� �� courier " + selectedDate + "=��=" + DateTime.Now.ToString("d/M/yy")); ;
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
        private void CleanersPasteButton_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CleanersTextBox.Text = Clipboard.GetText();
            }
        }
        private void ClearCleanersButton_Click(object sender, EventArgs e)
        {
            CleanersTextBox.Text = string.Empty;
        }
    }
}