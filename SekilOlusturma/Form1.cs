namespace SekilOlusturma
{
    public partial class Form1 : Form
    {

        Dortgen dortgen1 = new Dortgen();
        Elips elips1 = new Elips();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dortgen1.x = e.Location.X;
            dortgen1.y = e.Location.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                dortgen1.width = e.Location.X - dortgen1.x;
                dortgen1.height = e.Location.Y - dortgen1.y;
                DrawRectangle(dortgen1.x, dortgen1.y, dortgen1.width, dortgen1.height);

                listBox1.Items.Add("Sekil'in Alani " + (dortgen1.alanHesaplama()).ToString());
            }
            else if(button2.BackColor == Color.Red)
            {
                elips1.width = e.Location.X - dortgen1.x;
                elips1.height = e.Location.Y - dortgen1.y;
                DrawEllipse(elips1.x, elips1.y, elips1.width, elips1.height);
                listBox1.Items.Add("Sekil'in Alani " + (elips1.alanHesaplama()).ToString());
            }
        }

        private void DrawEllipse(int x, int y, int width, int height)
        {
            System.Drawing.Pen kalem = new System.Drawing.Pen(System.Drawing.Color.Red, 5.0f);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(kalem, new Rectangle(x, y, width, height));
            kalem.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle(int x, int y, int width, int height)
        {
            System.Drawing.Pen kalem = new System.Drawing.Pen(System.Drawing.Color.Red, 5);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(kalem, new Rectangle(x, y, width, height));
            kalem.Dispose();
            formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button1.BackColor = Color.White;
        }
    }
}