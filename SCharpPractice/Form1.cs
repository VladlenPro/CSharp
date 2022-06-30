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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.Run();
        }

        private void ntbAsIs_Click(object sender, EventArgs e)
        {
            IsAs isAs = new IsAs();
            isAs.Run();
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            ExampleIDispose exampleIDispose = new ExampleIDispose();
            exampleIDispose.Run();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            TypeExample typeExample = new TypeExample();
            typeExample.Run();
            typeExample.Run1();
        }

        private void btnIndexer_Click(object sender, EventArgs e)
        {
            Indexer indexer = new Indexer();
            indexer.Run();
        }
    }
}