using System.Globalization;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        string operacao = "SOMA";
        Calculadora calc = new Calculadora();
        double v1 = 0.0;
        double v2 = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Botao(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtResultado.Text = txtResultado.Text + button.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                lbloperacao.Text = " + ";
                operacao = "SOMA";
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {          
            if (txtResultado.Text != string.Empty)
            {
                v2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    calc.Valor1 = v1;
                    calc.Valor2 = v2;

                    txtResultado.Text = Convert.ToString(calc.Somar(v1, v2));
                }
                if (operacao == "SUB")
                {
                    calc.Valor1 = v1;
                    calc.Valor2 = v2;

                    txtResultado.Text = Convert.ToString(calc.Subtrair(v1, v2));
                }
                if (operacao == "MULT")
                {
                    calc.Valor1 = v1;
                    calc.Valor2 = v2;

                    txtResultado.Text = Convert.ToString(calc.Multiplicacao(v1, v2));
                }

                if (operacao == "DIV")
                {
                    calc.Valor1 = v1;
                    calc.Valor2 = v2;

                    txtResultado.Text = Convert.ToString(calc.Divisao(v1, v2));
                }
            }
            else
            {
                MessageBox.Show("INFORME DOIS VALORES PARA REALIZAR QUALQUER OPERAÇÃO!");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                lbloperacao.Text = " - ";
                operacao = "SUB";
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                lbloperacao.Text = " x ";
                operacao = "MULT";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                v1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                lbloperacao.Text = " ÷ ";
                operacao = "DIV";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
            lbloperacao.Text = String.Empty;
            v1 = 0;
            v2 = 0;            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = String.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}