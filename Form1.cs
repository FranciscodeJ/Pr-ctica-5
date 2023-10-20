namespace Práctica__5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Radio, Altura;
            double AreaBase, AreaLateral, AreaTotal;
            double Volumen;

            Radio = double.Parse(textBox1.Text);
            Altura = double.Parse(textBox2.Text);

            AreaBase = Radio * Radio * Math.PI;
            AreaLateral = 2 * Radio * Math.PI * Altura;
            AreaTotal = 2 * Math.PI * Radio * (Altura + Radio);
            Volumen = Math.PI * Altura * Radio * Radio;

            textBox4.Text = AreaBase.ToString("0.##");
            textBox5.Text = AreaLateral.ToString("0.##");
            textBox6.Text = AreaTotal.ToString("0.##");
            textBox7.Text = Volumen.ToString("0.##");


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}