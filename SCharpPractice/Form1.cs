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

        private void btnREfVal_Click(object sender, EventArgs e)
        {
            RefVal refVal = new RefVal();
            refVal.Run();
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            StractClass stractClass = new StractClass();
            stractClass.Run();
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            LinqExample linqExample = new LinqExample();
            linqExample.Run();
            linqExample.Run2();
            linqExample.Run3();
        }

        private void btnExtention_Click(object sender, EventArgs e)
        {
            ExtentionMethods extentionMethods = new ExtentionMethods();
            extentionMethods.Run();
        }

        private void btnGarbageCollector_Click(object sender, EventArgs e)
        {
            GarbageCollector garbageCollector = new GarbageCollector();
            garbageCollector.Run(); 
        }
    }
}