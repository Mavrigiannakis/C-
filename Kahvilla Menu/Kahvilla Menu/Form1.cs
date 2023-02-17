namespace Kahvilla_Menu
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true;
        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvilla palvelee luokassa 320 v�lituntisin\n";
            meistaLB.Text += "9:00 - 14:30 joka p�iv� maanantaista torstaisin ja perjantaisin\n";
            meistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa l�mpimien\n";
            meistaLB.Text += "juomien lis�ksi virvokkeita sek� pient� puurtavaa ja makeisia\n";
            meistaLB.Text += "Tervetuloa tutustumaan!\n";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            herkutPL.Visible = false;
            koriPL.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = true;
            koriPL.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            meistaPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            herkutPL.Visible = false;
            koriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}