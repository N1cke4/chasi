namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int second;
        int minute;
        int Hour;





        private void button1_Click(object sender, EventArgs e)
        {

            


            Hour = int.Parse(textBox1.Text);
            minute = int.Parse(textBox2.Text);
            second = int.Parse(textBox3.Text);


            minute = Hour * 60 + minute;
            second = minute * 60 + second;
            int total = second ;


            label1.Text = "прошло с полночи =" + total.ToString() + " секунд";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
