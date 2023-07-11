namespace PedraPapelTesoura2
{
    public partial class Form1 : Form
    {
        private string escolhaDoUsuario;
        private string escolhaDaMaquina;
        int sorteio;
        string[] opcoes =
         {
            "PEDRA","PAPEL","TESOURA"
         };

        public Form1()
        {
            InitializeComponent();
        }


        public void OpcoesdoUsuario(int escolha)
        {
            escolhaDoUsuario = opcoes[escolha];
            EscolhaDoComputador();
            Comparacao();
        }
        public void Comparacao()
        {
            if (escolhaDoUsuario == escolhaDaMaquina)
            {
                textBox2.Text = "Empate";
            }
            else if ((escolhaDoUsuario == "TESOURA" && escolhaDaMaquina == "PAPEL") || (escolhaDoUsuario == "PEDRA" && escolhaDaMaquina == "TESOURA") || (escolhaDoUsuario == "PEDRA" && escolhaDaMaquina == "PAPEL"))

            {
                textBox2.Text = " você ganhou ";

            }
            else
            {
                textBox2.Text = " Máquina ganhou perdeu";
            }

        }
        public void EscolhaDoComputador()
        {
            Random rand = new Random();
            sorteio = rand.Next(3);
            escolhaDaMaquina = opcoes[sorteio];
            textBox1.Text = escolhaDaMaquina;

        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Papel_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(2);
        }

        private void Escolha_Click(object sender, EventArgs e)
        {

        }

        private void Pedra_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(0);
        }

        private void Tesoura_Click(object sender, EventArgs e)
        {
            OpcoesdoUsuario(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            EscolhaDoComputador();
        }
    }
}