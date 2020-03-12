using BJ21;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ21
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Card> playercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        List<Card> bankercardList = new List<Card>()
        {
            new Card() { Value  = 0, Name = "null", Image = "null" }
        };

        int playercardSum = 0;
        int bankercardSum = 0;
        Random random = new Random();
        List<int> usedCards = new List<int>();
        List<PictureBox> bankerbox = new List<PictureBox>();
        List<PictureBox> playerbox = new List<PictureBox>();
        private Label lblBanker;
        private Label lblPlayer;
        private PictureBox pbBanker1;
        private PictureBox pbPlayer1;
        private PictureBox pbPlayer2;
        private Label rsltLabel;
        private Button btnStart;
        private Button btnHit;
        private Button btnStand;
        private Button btnRestart;
        private Button btnExit;


        #region creationof52carddeck

        List<Card> deck = new List<Card>()
            {
                #region spades

                new Card() { Value = 2, Name = "Two Spades", Image = "cards\\2S.png" },
                new Card() { Value = 3, Name = "Three Spades", Image = "cards\\3S.png"},
                new Card() { Value = 4, Name =  "Four Spades", Image = "cards\\4S.png"},
                new Card() { Value = 5, Name = "Five Spades", Image = "cards\\5S.png" },
                new Card() { Value = 6, Name = "Six Spades", Image = "cards\\6S.png" },
                new Card() { Value = 7, Name = "Seven Spades", Image = "cards\\7S.png" },
                new Card() { Value = 8, Name = "Eight Spades", Image = "cards\\8S.png" },
                new Card() { Value = 9, Name = "Nine Spades", Image = "cards\\9S.png" },
                new Card() { Value = 10, Name = "Ten Spades", Image = "cards\\10S.png" },
                new Card() { Value = 10, Name = "Jack Spades", Image = "cards\\JS.png" },
                new Card() { Value = 10, Name = "Queen Spades", Image = "cards\\QS.png" },
                new Card() { Value = 10, Name = "King Spades", Image = "cards\\KS.png" },
                new Card() { Value = 11, Name = "Ace Spades", Image = "cards\\AS.png" },

                #endregion

                #region diamonds

                new Card() { Value  = 2, Name = "Two Diamonds", Image = "cards\\2D.png" },
                new Card() { Value = 3, Name = "Three Diamonds", Image = "cards\\3D.png" },
                new Card() { Value = 4, Name =  "Four Diamonds", Image = "cards\\4D.png"},
                new Card() { Value = 5, Name = "Five Diamonds", Image = "cards\\5D.png" },
                new Card() { Value = 6, Name = "Six Diamonds", Image = "cards\\6D.png" },
                new Card() { Value = 7, Name = "Seven Diamonds", Image = "cards\\7D.png" },
                new Card() { Value = 8, Name = "Eight Diamonds", Image = "cards\\8D.png" },
                new Card() { Value = 9, Name = "Nine Diamonds", Image = "cards\\9D.png" },
                new Card() { Value = 10, Name = "Ten Diamonds", Image = "cards\\10D.png" },
                new Card() { Value = 10, Name = "Jack Diamonds", Image = "cards\\JD.png" },
                new Card() { Value = 10, Name = "Queen Diamonds", Image = "cards\\QD.png" },
                new Card() { Value = 10, Name = "King Diamonds", Image = "cards\\KD.png" },
                new Card() { Value = 11, Name = "Ace Diamonds", Image = "cards\\AD.png" },

                #endregion

                #region clubs

                new Card() { Value  = 2, Name = "Two Clubs", Image = "cards\\2C.png" },
                new Card() { Value = 3, Name = "Three Clubs", Image = "cards\\3C.png" },
                new Card() { Value = 4, Name =  "Four Clubs", Image = "cards\\4C.png"},
                new Card() { Value = 5, Name = "Five Clubs", Image = "cards\\5C.png" },
                new Card() { Value = 6, Name = "Six Clubs", Image = "cards\\6C.png" },
                new Card() { Value = 7, Name = "Seven Clubs", Image = "cards\\7C.png" },
                new Card() { Value = 8, Name = "Eight Clubs", Image = "cards\\8C.png" },
                new Card() { Value = 9, Name = "Nine Clubs", Image= "cards\\9C.png" },
                new Card() { Value = 10, Name = "Ten Clubs", Image = "cards\\10C.png" },
                new Card() { Value = 10, Name = "Jack Clubs", Image = "cards\\JC.png" },
                new Card() { Value = 10, Name = "Queen Clubs", Image = "cards\\QC.png" },
                new Card() { Value = 10, Name = "King Clubs", Image = "cards\\KC.png" },
                new Card() { Value = 11, Name = "Ace Clubs", Image = "cards\\AC.png" },

                #endregion

                #region hearts

                new Card() { Value  = 2, Name = "Two Hearts", Image = "cards\\2H.png" },
                new Card() { Value = 3, Name = "Three Hearts", Image = "cards\\3H.png" },
                new Card() { Value = 4, Name =  "Four Hearts", Image = "cards\\4H.png"},
                new Card() { Value = 5, Name = "Five Hearts", Image = "cards\\5H.png" },
                new Card() { Value = 6, Name = "Six Hearts", Image = "cards\\6H.png" },
                new Card() { Value = 7, Name = "Seven Hearts", Image = "cards\\7H.png" },
                new Card() { Value = 8, Name = "Eight Hearts", Image = "cards\\8H.png" },
                new Card() { Value = 9, Name = "Nine Hearts", Image = "cards\\9H.png" },
                new Card() { Value = 10, Name = "Ten Hearts", Image = "cards\\10H.png" },
                new Card() { Value = 10, Name = "Jack Hearts", Image = "cards\\JH.png" },
                new Card() { Value = 10, Name = "Queen Hearts", Image = "cards\\QH.png" },
                new Card() { Value = 10, Name = "King Hearts", Image = "cards\\KH.png" },
                new Card() { Value = 11, Name = "Ace Hearts", Image = "cards\\AH.png" }

                #endregion
            };

        #endregion
        private int selectRandomCard()
        {
            int randomCard;
            randomCard = random.Next(0, deck.Count);
            return randomCard;
        }

        private void sumPlayerCards()
        {
            playercardSum = 0;
            for (int i = 0; i < playercardList.Count; i++)
            {
                playercardSum += playercardList[i].Value;
            }

            if (playercardSum > 21)
            {
                foreach (Card c in playercardList)
                {
                    if (c.Value == 11)
                    {
                        playercardSum -= 10;
                        if (playercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void sumBankerCards()
        {
            bankercardSum = 0;
            for (int i = 0; i < bankercardList.Count; i++)
            {
                bankercardSum += bankercardList[i].Value;
            }
            if (bankercardSum > 21)
            {
                foreach (Card c in bankercardList)
                {
                    if (c.Value == 11)
                    {
                        bankercardSum -= 10;
                        if (bankercardSum <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        // give one card to player
        
        private void resetGame()
        {
            rsltLabel.Text = null;

            displayCardBack(pbPlayer1);
            displayCardBack(pbPlayer2);
            //displayCardBack(pictureBox3);
            displayCardBack(pbBanker1);
            //displayCardBack(pictureBox6);
            foreach (PictureBox pb in playerbox)
            {
                this.Controls.Remove(pb);
            }
            playerbox = new List<PictureBox>();
            foreach (PictureBox pb in bankerbox)
            {
                this.Controls.Remove(pb);
            }
            bankerbox = new List<PictureBox>();

            playercardSum = 0;
            bankercardSum = 0;
            playercardList.Clear();
            bankercardList.Clear();
            usedCards.Clear();
            rsltLabel.Text = "Player choice";
        }

        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "cards\\back.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        // palyer stop move
        private void InitializeComponent()
        {
            this.lblBanker = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pbBanker1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.rsltLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanker
            // 
            this.lblBanker.AutoSize = true;
            this.lblBanker.BackColor = System.Drawing.Color.Transparent;
            this.lblBanker.ForeColor = System.Drawing.Color.White;
            this.lblBanker.Location = new System.Drawing.Point(16, 53);
            this.lblBanker.Name = "lblBanker";
            this.lblBanker.Size = new System.Drawing.Size(41, 13);
            this.lblBanker.TabIndex = 0;
            this.lblBanker.Text = "Banker";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(20, 180);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player";
            // 
            // pbBanker1
            // 
            this.pbBanker1.BackColor = System.Drawing.Color.White;
            this.pbBanker1.Image = global::BJ21.Properties.Resources.back;
            this.pbBanker1.Location = new System.Drawing.Point(77, 12);
            this.pbBanker1.Name = "pbBanker1";
            this.pbBanker1.Size = new System.Drawing.Size(71, 96);
            this.pbBanker1.TabIndex = 2;
            this.pbBanker1.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.Color.White;
            this.pbPlayer1.Image = global::BJ21.Properties.Resources.back;
            this.pbPlayer1.Location = new System.Drawing.Point(77, 137);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(71, 96);
            this.pbPlayer1.TabIndex = 3;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.Color.White;
            this.pbPlayer2.Image = global::BJ21.Properties.Resources.back;
            this.pbPlayer2.Location = new System.Drawing.Point(154, 137);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(71, 96);
            this.pbPlayer2.TabIndex = 2;
            this.pbPlayer2.TabStop = false;
            // 
            // rsltLabel
            // 
            this.rsltLabel.AutoSize = true;
            this.rsltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsltLabel.ForeColor = System.Drawing.Color.White;
            this.rsltLabel.Location = new System.Drawing.Point(23, 264);
            this.rsltLabel.Name = "rsltLabel";
            this.rsltLabel.Size = new System.Drawing.Size(0, 13);
            this.rsltLabel.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(101, 300);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "&Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(182, 300);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "S&tand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.BtnStand_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(263, 300);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(476, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(563, 333);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rsltLabel);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbBanker1);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblBanker);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BJ21";
            ((System.ComponentModel.ISupportInitialize)(this.pbBanker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (playercardSum > 0)
            {
                rsltLabel.Text = String.Format
                ("Already started.");
            }

            else
            {
                playercardSum = 0;
                bankercardSum = 0;

                #region init player
                int randomCard1 = selectRandomCard();
                Card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();


                while (usedCards.Contains(randomCard2))
                {
                    randomCard2 = selectRandomCard();
                }
                randomCard2 = 1 * randomCard2;

                Card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                playercardList.Add(card1);
                playercardList.Add(card2);

                pbPlayer1.ImageLocation = card1.Image;
                pbPlayer1.SizeMode = PictureBoxSizeMode.AutoSize;

                pbPlayer2.ImageLocation = card2.Image;
                pbPlayer2.SizeMode = PictureBoxSizeMode.AutoSize;
                #endregion
                #region init banker
                int randomCard3 = selectRandomCard();
                while (usedCards.Contains(randomCard3))
                {
                    randomCard3 = selectRandomCard();
                }
                randomCard3 = 1 * randomCard3;
                Card card3 = deck[randomCard3];
                usedCards.Add(randomCard3);

                bankercardList.Add(card3);

                pbBanker1.ImageLocation = card3.Image;
                pbBanker1.SizeMode = PictureBoxSizeMode.AutoSize;

                #endregion

                sumPlayerCards();

                //sumCards();

                if (playercardSum == 21)
                {
                    rsltLabel.Text = String.Format
                        ("The sum of your cards is {0}, you win!!!", playercardSum);
                    MessageBox.Show("You win!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetGame();
                }


            }
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                rsltLabel.Text = "Click the Start button...";
                //displayCardBack(pictureBox3);
            }

            else
            {
                if (playercardSum > 100) //to be changed
                {
                    resetGame();
                    rsltLabel.Text = "Resetting game...";
                }

                else
                {
                    playercardSum = 0;
                    int randomCard = selectRandomCard();
                    Card card = deck[randomCard];
                    usedCards.Add(randomCard);

                    if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                    else randomCard = 1 * randomCard;


                    //player new card
                    PictureBox p3 = new PictureBox();
                    p3.Width = 71;
                    p3.Height = 96;
                    p3.Location = new Point(154 + 77 + playerbox.Count * 77, 137);
                    p3.ImageLocation = card.Image;
                    p3.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(p3);

                    playerbox.Add(p3);

                    playercardList.Add(card);
                    sumPlayerCards();
                    if (playercardSum > 21)
                    {
                        rsltLabel.Text = String.Format
                            ("The sum of your cards is {0}, you lose!", playercardSum);
                        MessageBox.Show("You lose!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                    else if (playercardSum == 21)
                    {
                        rsltLabel.Text = String.Format
                            ("The sum of your cards is {0}, you win!!!", playercardSum);
                        MessageBox.Show("You win!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                }
            }

        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            if (playercardSum == 0)
            {
                rsltLabel.Text = "Click the Start button...";
                return;
            }
            sumBankerCards();

            //banker move
            while (bankercardSum <= 16)
            {
                int randomCard = selectRandomCard();
                Card card = deck[randomCard];
                usedCards.Add(randomCard);

                if (usedCards.Contains(randomCard)) randomCard = selectRandomCard();
                else randomCard = 1 * randomCard;

                PictureBox p4 = new PictureBox();
                p4.Width = 71;
                p4.Height = 96;
                p4.Location = new Point(154 + bankerbox.Count * 77, 12);
                p4.ImageLocation = card.Image;
                p4.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p4);


                bankerbox.Add(p4);

                bankercardList.Add(card);
                sumBankerCards();
            }

            if (bankercardSum > 21)
            {
                rsltLabel.Text = String.Format
                    ("The sum of banker cards is {0}, you win!!!", bankercardSum);
                MessageBox.Show("You win!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else if (playercardSum <= bankercardSum)
            {
                rsltLabel.Text = String.Format
                    ("The sum of your cards is {0}, you lose.", playercardSum);
                MessageBox.Show("You lose.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else
            {
                rsltLabel.Text = String.Format
                    ("The sum of your cards is {0}, you win!!!", playercardSum);
                MessageBox.Show("You win!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}