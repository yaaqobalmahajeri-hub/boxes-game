using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxesGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

     public  void setVisibale(bool b)
        {
            rock1.Visible = rock6.Visible = rock12.Visible=rock13.Visible = rock11.Visible  = rock7.Visible
                = rock8.Visible = rock9.Visible = rock10.Visible = rock5.Visible = rock4.Visible = rock3.Visible = rock2.Visible = b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            winnerLabel.Visible = false;
            counts = 0;
             setVisibale(true);
            MessageBox.Show("1- select the rock. \r\n 2-press the key (break the rock). \r\n 3- continue .","how to play ?",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        Button btn;
       public int counts = 0;
        private void startButton_Click(object sender, EventArgs e)
        {

            setVisibale(true);

        }

      
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);// reload the program
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {



            int btnx= ball.Top;
           int btnl= ball.Left;
            
            if (sender.Equals(ballPressButton)&&btn!=null)
            {
                ball.Left = btn.Left;
                if (btn.Focus())
                {
                    

                    ball.Left = btn.Left;
                    for (int i = 0; ball.Top> btn.Top; i++)
                    {
                        ball.Top -=20 ;
                        System.Threading.Thread.Sleep(20);
                       

                    }
                    counts++;
                    for (int i = 0; ball.Top < btnx; i++)
                    {
                        ball.Top += 20;
                        System.Threading.Thread.Sleep(20);
                        btn.Visible = false;


                    }
                   
                }



            }




            if (counts == 13)
            {
                winnerLabel.Visible = true;
                winnerLabel.Text = "Winner !!";
                
            }

            ballPressButton.Focus();

        }

        private void rock1_Click(object sender, EventArgs e)
        {
            btn=(Button)sender;
            if(btn!=null)
               button14_Click(sender, e);   
            
        }

       

        
    }
}
