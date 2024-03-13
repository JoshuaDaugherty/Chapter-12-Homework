using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tiling
{
    //Create room array
    Room[] rooms = new Room[20];
    //Calculation variables
    int count = 0, totalBoxes = 0;

    public partial class frmTiling : Form
    {
       

        public frmTiling()
        {
            InitializeComponent();
            

        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearform();
        }

        private void Clearform() 
        {
            txtName.Text = "";
            txtWidth.Text = "";
            txtLength.Text = "";
            lblResult.Text = "";
            txtName.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            {
                //Check max of rooms can add
                if (count < 20)
                {
                    //Create a room object
                    Room room = new Room(txtName.Text, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtLength.Text));
                    //Add into room array
                    rooms[count] = room;
                    //Increment count
                    count++;
                    //add box count
                    totalBoxes += room.getBoxes();
                    //Display result
                    string result = "Rooms:" + count + "/" + 20 + "\n";
                    result += "Total Boxes Needed:" + totalBoxes + "\n\n";
                    for (int i = 0; i < count; i++)
                    {
                        result += rooms[i].Display() + "\n";
                    }
                    lblResult.Text = result;
                    //Clear text boxes and set focus
                    txtName.Text = "";
                    txtWidth.Text = "";
                    txtLength.Text = "";
                    txtName.Focus();
                }
                //Otherwise shows message and close the window
                else
                {
                    MessageBox.Show("Not more than 20 rooms you can add");
                    this.Close();
                }
            }


        }





        private void frmTiling_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

