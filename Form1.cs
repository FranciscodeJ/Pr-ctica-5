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
            double Radio, Altura;                                // Se declaran las variables que serán utilizadas
            double AreaBase, AreaLateral, AreaTotal;            // Double sirve para que aparezcan hasta 16 cifras en las cajas de texto.
            double Volumen;

            Radio = double.Parse(textBox1.Text);                      // Se declara que lo que se escribirá en los cuadros de texto 1 y 2 serán los valores de la altura y el radio.
            Altura = double.Parse(textBox2.Text);

            AreaBase = Radio * Radio * Math.PI;                     // Se declaran las fórmulas para la base, el volumen, el area total, y el area lateral mediante las variables que ya asignamos. 
            AreaLateral = 2 * Radio * Math.PI * Altura;
            AreaTotal = 2 * Math.PI * Radio * (Altura + Radio);
            Volumen = Math.PI * Altura * Radio * Radio;

            textBox4.Text = AreaBase.ToString("0.##");            // Se declara que en los cuadros de texto correspondientes, se muestren los resultados de las operaciones de las respectivas fórmulas.
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
            Application.Exit();            // cuando se oprima el botón, la aplicación cerrará.
        }
    }
}
