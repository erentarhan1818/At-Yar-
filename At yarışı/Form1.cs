namespace At_yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rasgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label6.Text);
            derece++;
            label6.Text = derece.ToString();


            int birinciatıngenilslıgi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;

            int bitisuzaklıgı = label4.Left;

            pictureBox1.Left = pictureBox1.Left + rasgele.Next(6, 18);
            pictureBox2.Left = pictureBox2.Left + rasgele.Next(6, 18);
            pictureBox3.Left = pictureBox3.Left + rasgele.Next(6, 18);

            if(pictureBox1.Left > pictureBox2.Left +5 && pictureBox1.Left> pictureBox3.Left + 5)
            {
                label5.Text = "1 numaralı at Birinciliği ele aldı";   
            }
            if(pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left >pictureBox3.Left + 5)
            {
                label5.Text = "2 numaralı at ani bir atak yapıp ve öne geçti";
            }
            if(pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left +5)
            {
                label5.Text = "3 numralı attan beklenmedik bi hamle geldi!!!";
            }

            if (birinciatıngenilslıgi +pictureBox1.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label5.Text = "1 numaralı at birinci oldu";
            }
            if(ikinciatıngenisligi + pictureBox2.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label5.Text =("2 numaralı at birinci oldu");
            } 
            if(ucuncuatıngenisligi + pictureBox3.Left >= bitisuzaklıgı)
            {
                timer1.Enabled = false;
                label5.Text =("3 numaralı at birinci oldu");
            }
            
        }
        private void label4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
