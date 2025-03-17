namespace XOgame
{
    public partial class Form1 : Form
    {
        int siraKimde = 1; //1 : X oyuncusu, 0 : O oyuncusu
        int[,] tahta = new int[3,3];

        public Form1()
        {
            InitializeComponent();
        }
        public void kazananVarmi()
        {
            for(int i = 0; i < 3; i++)
            {
                    if (tahta[i, 0] == 1 && tahta[i, 1] == 1 && tahta[i, 2] == 1)
                    {
                        label1.Text = "X Oyuncusu Kazandi!!!";
                    }
                    if (tahta[i, 0] == 2 && tahta[i, 1] == 2 && tahta[i, 2] == 2)
                    {
                        label1.Text = "O Oyuncusu Kazandi!!!";
                    }
            }
            for (int i = 0; i < 3; i++)
            {
                if (tahta[0, i] == 1 && tahta[1, i] == 1 && tahta[2, i] == 1)
                {
                    label1.Text = "X Oyuncusu Kazandi!!!";
                }
                if (tahta[0, i] == 2 && tahta[1, i] == 2 && tahta[2, i] == 2)
                {
                    label1.Text = "O Oyuncusu Kazandi!!!";
                }
            }
            //Kosegen kontrolu
            if (tahta[0, 0] == 1 && tahta[1, 1] == 1 && tahta[2, 2] == 1)
            {
                label1.Text = "X Oyuncusu Kazandi!!!";
            }
            if (tahta[0, 0] == 2 && tahta[1, 1] == 2 && tahta[2, 2] == 2)
            {
                label1.Text = "O Oyuncusu Kazandi!!!";
            }

            if (tahta[0, 2] == 1 && tahta[1, 1] == 1 && tahta[2, 0] == 1)
            {
                label1.Text = "X Oyuncusu Kazandi!!!";
            }
            if (tahta[0, 2] == 2 && tahta[1, 1] == 2 && tahta[2, 0] == 2)
            {
                label1.Text = "O Oyuncusu Kazandi!!!";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button1.Text = "X";
                siraKimde=0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[0,0] = 1;
            }
            else
            {
                button1.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[0, 0] = 2;

            }
            button1.Enabled = false;
            kazananVarmi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button2.Text = "X";
                siraKimde=0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[0, 1] = 1;
            }
            else
            {
                button2.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[0, 1] = 2;

            }
            button2.Enabled = false;
            kazananVarmi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button3.Text = "X";
                siraKimde=0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[0, 2] = 1;
            }
            else
            {
                button3.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[0, 2] = 2;

            }
            button3.Enabled = false;
            kazananVarmi();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button4.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[1, 0] = 1;
            }
            else
            {
                button4.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[1,0]=2;
            }
            button4.Enabled = false;
            kazananVarmi();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button5.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[1,1] = 1;
            }
            else
            {
                button5.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[1, 1] = 2;
            }
            button5.Enabled = false;
            kazananVarmi();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button6.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[1,2] = 1;
            }
            else
            {
                button6.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[1,2]=2;
            }
            button6.Enabled = false;
            kazananVarmi();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button7.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[2,0]=1;
            }
            else
            {
                button7.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[2,0]=2;
            }
            button7.Enabled = false;
            kazananVarmi();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button8.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[2,1]=1;
            }
            else
            {
                button8.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : X oyuncusu";
                tahta[2,1]=2;
            }
            button8.Enabled = false;
            kazananVarmi();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (siraKimde == 1)
            {
                button9.Text = "X";
                siraKimde = 0;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[2,2]=1;
            }
            else
            {
                button9.Text = "O";
                siraKimde = 1;
                label1.Text = "Oyuncu sirasi : O oyuncusu";
                tahta[2,2]=2;
            }
            button9.Enabled = false;
            kazananVarmi();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            label1.Text = "";
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    tahta[i,j] = 0;
                }
            }

        }
    }
}