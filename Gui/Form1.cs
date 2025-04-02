using System.Drawing;
namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             bool valid = true;

            // Reset kolorów
            txtSeed.BackColor = SystemColors.Window;
            txtCount.BackColor = SystemColors.Window;
            txtCapacity.BackColor = SystemColors.Window;

            // Sprawdzanie danych wejœciowych
            if (!int.TryParse(txtSeed.Text, out int seed))
            {
                txtSeed.BackColor = Color.LightCoral;
                valid = false;
            }

            if (!int.TryParse(txtCount.Text, out int count))
            {
                txtCount.BackColor = Color.LightCoral;
                valid = false;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity))
            {
                txtCapacity.BackColor = Color.LightCoral;
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Popraw dane zaznaczone na czerwono!", "B³¹d danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jeœli wszystko OK – dzia³amy
            var problem = new ProblemPlecakowy.Problem(count, seed);
            var wynik = problem.Solve(capacity);

            txtOutput.Text = problem.ToString() + "\n\n" + wynik.ToString();
            
           
        }
    }
}
