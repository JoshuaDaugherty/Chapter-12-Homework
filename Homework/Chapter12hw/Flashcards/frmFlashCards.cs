using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcards
{
    public partial class frmFlashCards : Form
    {
        List<FlashCard> cards;

        public frmFlashCards()
        {
            InitializeComponent();
            txtTerm.Visible = false;
            btnAdd.Visible = false;
            lblResult.Visible = false;

            cards = new List<FlashCard>(); // create new flashcards list and add 5 terms to it
            cards.Add(new FlashCard("1", "one"));
            cards.Add(new FlashCard("2", "two"));
            cards.Add(new FlashCard("3", "three"));
            cards.Add(new FlashCard("4", "four"));
            cards.Add(new FlashCard("5", "five"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm();
        }

        private void ExitForm()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTerm.Text = "";
            lblResult.Text = "";
            txtTerm.Focus();
        }

        private void btnDefine_Click(object sender, EventArgs e)
        {
            foreach (FlashCard f in cards)
            {
                // check if that term present in available flashcards
                lblResult.Text = "";
                if (f.getTerm().ToLower() == txtTerm.Text.Trim().ToLower())
                {
                    //if yes then display its definition
                    lblResult.Height = 60;
                    lblResult.Text = f.getDefinition();
                    lblResult.Visible = true;
                    txtTerm.Focus();

                    txtTerm.Visible = true;
                    btnAdd.Visible = true;
                    return; // and return, dont go further
                }
            }

            // if term not present then following code will be executed
            lblResult.Height = 30;
            lblResult.Text = "I don't know that term yet. What does it mean?";
            lblResult.Visible = true;
            txtTerm.Visible = true;
            txtTerm.Text = "";
            txtTerm.Focus();
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // if both textboxes has some text means their length > 0
            // trim removes blank spaces at start and end of text if any,
            // this is to ensure user has not typed only spaces
            if (txtTerm.Text.ToString().Trim().Length > 0 &&
            txtTerm.Text.ToString().Trim().Length > 0)
            {
                txtTerm.Visible = false;
                btnAdd.Visible = false;
                lblResult.Height = 60;

                // check if that term already present in cards
                foreach (FlashCard f in cards)
                {
                    if (f.getTerm().ToLower() == txtTerm.Text.Trim().ToLower())
                    {
                        // if present then show its definition
                        lblResult.Text = f.getDefinition();
                        return;
                    }
                }

                // if that term is new then add its definition to flash cards
                FlashCard newcard = new FlashCard(txtTerm.Text, txtTerm.Text);

                if (cards.Count < 20) // if there are less than 20 cards then add new card
                {
                    cards.Add(newcard);
                }
                else
                {
                    MessageBox.Show("cannot add more than 20 Flashcards... ");
                    return;
                }

                lblResult.Text = newcard.getDefinition();
                txtTerm.Focus();

            }
        }
    }
}


        
    
        
    

