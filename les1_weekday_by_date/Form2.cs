namespace les1_weekday_by_date
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string dayOfWeek = selectedDate.ToString("dddd");
            textBox1.Text = dayOfWeek;
        }
    }
}