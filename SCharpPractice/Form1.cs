namespace SCharpPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Delegate newDel = new Delegate();
            newDel.Run();
        }

        private void btnEventPractice_Click(object sender, EventArgs e)
        {
            EventsPractice eventsPractice = new EventsPractice();
            Operate operate = new Operate();
            operate.init();
        }
    }
}