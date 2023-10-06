namespace HangManGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strWord = "";
        List<Label> listLabel = new List<Label>();
        int Amount = 0;

        enum BodyParts
        {
            Head,
            LeftEye,
            RightEye,
            Mouth,
            LeftArm,
            RightArm,
            Body,
            LeftLeg,
            RightLeg
        }

        private void pDraw_Paint(object? sender, PaintEventArgs e)
        {
            DrawHangPost();
        }

        private void DrawHangPost()
        {
            Graphics g = pDraw.CreateGraphics();
            Pen p = new Pen(Color.Brown, 10);
            g.DrawLine(p, new Point(130, 218), new Point(130, 5));
            g.DrawLine(p, new Point(135, 5), new Point(65, 5));
            g.DrawLine(p, new Point(60, 0), new Point(60, 50));
        }

        private void DrawBodyPart(BodyParts bp)
        {
            Graphics g = pDraw.CreateGraphics();
            Pen p = new Pen(Color.Brown, 2);

            if (bp == BodyParts.Head)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if (bp == BodyParts.LeftEye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 50, 60, 5, 5);
            }
            else if (bp == BodyParts.RightEye)
            {
                SolidBrush s = new SolidBrush(Color.Black);
                g.FillEllipse(s, 65, 60, 5, 5);
            }
            else if (bp == BodyParts.Mouth)
            {
                g.DrawArc(p, 50, 60, 20, 20, 45, 90);
            }
            else if (bp == BodyParts.Body)
            {
                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (bp == BodyParts.LeftArm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));
            }
            else if (bp == BodyParts.RightArm)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            }
            else if (bp == BodyParts.LeftLeg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (bp == BodyParts.RightLeg)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));
            }
        }

        private string GetRandomWord()
        {
            System.IO.StreamReader myFile = new System.IO.StreamReader("C:\\Users\\bsbaq\\source\\repos\\HangManGame\\words.txt");
            string WordList = myFile.ReadToEnd();
            string[] arrWords = System.Text.RegularExpressions.Regex.Split(WordList, "\r\n");
            Random rndWord = new Random();
            return arrWords[rndWord.Next(0, arrWords.Length - 1)];
        }

        private void MakeLabels()
        {
            strWord = GetRandomWord();
            char[] chars = strWord.ToCharArray();
            int BetweenPixelsOfLabels = 330 / chars.Length;

            for (int i = 0; i < chars.Length; i++)
            {
                listLabel.Add(new Label());
                listLabel[i].Location = new Point((i * BetweenPixelsOfLabels) + 10, 80);
                listLabel[i].Text = "_";
                listLabel[i].Parent = groupBox2;
                listLabel[i].BringToFront();
                listLabel[i].CreateControl();
            }
            lblWordLength.Text = "Word Length" + (chars.Length).ToString();
        }

        private void ResetGame()
        {
            Graphics g = pDraw.CreateGraphics();
            g.Clear(pDraw.BackColor);
            GetRandomWord();
            MakeLabels();
            DrawHangPost();
            lblMissedLetters.Text = "Missed Letters";
            lblWordLength.Text = "Word Length";
            txtSubmitLetter.Text = "";
            txtSubmitWord.Text = "";
        }


        private void btnSubmitWord_Click_1(object sender, EventArgs e)
        {

            if (txtSubmitWord.Text == strWord)
            {
                MessageBox.Show("Congratulations, You WON!!");
                ResetGame();
            }
            else
            {
                MessageBox.Show("The word you have guessed is wrong");
                DrawBodyPart((BodyParts)Amount);
                Amount++;
                if (Amount == 9)
                {
                    MessageBox.Show("GameOver , Sorry you Lost" + " " + "the word was" + " " + strWord);
                    ResetGame();
                }
            }
        }

        private void btnSubmitLetter_Click(object sender, EventArgs e)
        {
            char chrLetter = txtSubmitLetter.Text.ToLower().ToCharArray()[0];

            if (!char.IsLetter(chrLetter))
            {
                MessageBox.Show("You can only submit letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubmitLetter.Text = "";
                txtSubmitLetter.Focus();

                return;
            }
            if (strWord.Contains(chrLetter))
            {
                char[] WordChar = strWord.ToCharArray();
                for (int i = 0; i < WordChar.Length; i++)
                {
                    if (WordChar[i] == chrLetter)
                    {
                        listLabel[i].Text = chrLetter.ToString();
                    }
                }
                foreach (Label chara in listLabel)
                {
                    if (chara.Text == "_")
                    {
                        
                        txtSubmitLetter.Text = "";
                        txtSubmitLetter.Focus();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("The Letter you Guessed is not in the Word!!", "Sorry");
                lblMissedLetters.Text += " " + chrLetter.ToString() + ",";
                DrawBodyPart((BodyParts)Amount);
                Amount++;
                txtSubmitLetter.Text = "";
                txtSubmitLetter.Focus();
                if (Amount == 9)
                {
                    MessageBox.Show("GameOver , Sorry you Lost" + " " + "the word was" + " " + strWord);
                    ResetGame();
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pDraw.Paint += new PaintEventHandler(pDraw_Paint);
            DrawHangPost();
            GetRandomWord();
            MakeLabels();
        }
    }
}