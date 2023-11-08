namespace sexto_sistematico
{
    public partial class Form1 : Form
    {
        List<jugadores> ba = new List<jugadores>();

        jugadores j1 = new jugadores("51", "204", "AL", "Venezuela");
        jugadores j2= new jugadores("54", "171", "AL", "Venezuela");
        jugadores j3 = new jugadores("26", "204", "AL", "Venezuela");
        jugadores j4 = new jugadores("56", "204", "AL", "Venezuela");
        jugadores j5 = new jugadores("25", "204", "AL", "Venezuela");
        jugadores j6 = new jugadores("38", "204", "AL", "Venezuela");
        jugadores j7 = new jugadores("34", "204", "AL", "Venezuela");
        jugadores j8 = new jugadores("30", "204", "AL", "Venezuela");


        

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            jugadores b = new jugadores();

            dtgv_tabla.DataSource = null;
            MessageBox.Show("Jugadores de la liga americana");

            dtgv_tabla.DataSource = b.Liga(ba);
        }

        private void btn_bateadores_Click(object sender, EventArgs e)
        {
            jugadores b = new jugadores();

            dtgv_tabla.DataSource = null;
            MessageBox.Show("Jugadores con un promedio arriba");


            dtgv_tabla.DataSource = b.Pro(ba);
        }
    }
}