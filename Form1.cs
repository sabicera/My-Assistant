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
            Clipboard.Clear();
            NotesRichTextBox.Text = "��������� ��� " + SendMsgComboBox.Text; ;
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
            DateTime today = DateTime.Today;
            DateTime futureDate = today.AddDays(5);
            Clipboard.Clear();
            if (SMSComboBox.Text == "Pickup Reminder")
            {
                NotesRichTextBox.Text = "WE REMIND YOU THAT YOU CAN PICKUP YOUR ORDER UNTIL " + futureDate.ToString("dd/MM/yy") + " OR IT WILL BE CANCELLED."; ;
            }
            else if (SMSComboBox.Text == "���������� ���������")
            {
                NotesRichTextBox.Text = "��� ������������� ��� ����������� ��������� ��� ����������� ��� � ����� �� �������� ��� ��� ���������� ����� " + futureDate.ToString("dd/MM/yy");
            }
            DataObject data = new DataObject();
            data.SetData(DataFormats.UnicodeText, NotesRichTextBox.Text);
            Clipboard.SetDataObject(data, true);
        }
    }
}