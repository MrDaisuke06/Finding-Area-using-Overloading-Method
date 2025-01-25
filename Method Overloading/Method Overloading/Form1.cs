namespace Method_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle c = new Circle(Convert.ToDouble(textBox1.Text));
            textBox2.Text = Convert.ToString(c.FindArea(c.radius));

            HISTORY.Items.Add("Area of the Circle "+textBox2.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text));
            textBox2.Text = Convert.ToString(r.Findarea2(r.width, r.width));
            HISTORY.Items.Add("Area of the Rectangle "+textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
            textBox2.Text = Convert.ToString(t.Findarea3(t.Base, t.height));
            HISTORY.Items.Add("Area of the Triangle "+textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();   
        }
    }
}
