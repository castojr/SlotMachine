using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SlotMachine
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                leftImage.ImageUrl = ImageSelector();
                middleImage.ImageUrl = ImageSelector();
                rightImage.ImageUrl = ImageSelector();
            }

        }
        Random random = new Random();

        private string ImageSelector()
        {
            string[] png = new string[] {"Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png", "Lemon.png", "Orange.png", "Plum.png", "Seven.png", "Strawberry.png", "Watermellon.png" };
            return png[random.Next(png.Length)];
        }

        private string ImageDisplay()
        {
            leftImage.ImageUrl = ImageSelector();
            middleImage.ImageUrl = ImageSelector();
            rightImage.ImageUrl = ImageSelector();
            return ImageSelector();
        }

        private int YourBet()
        {
            return int.Parse(betTextBox.Text);
        }

        private bool ThreeSevens()
        {
            if(leftImage.ImageUrl == "Seven.png" && middleImage.ImageUrl == "Seven.png" && rightImage.ImageUrl == "Seven.png")
            {
                return true;
            }
            return false;
        }

        private string ThreeSevensResults()
        {
            return resultsLabel.Text = String.Format("JACKPOT!!! You bet {0} and Won {1:C)", YourBet(), YourBet() * 100);
        }

        private bool Bar()
        {
            if(leftImage.ImageUrl == "Bar.png" || middleImage.ImageUrl == "Bar.png" || rightImage.ImageUrl == "Bar.png")
            {
                return true;
            }
            return false;
        }

        private string BarResults()
        {
            return resultsLabel.Text = String.Format("Sorry, you lose {0:C}. Better luck next time.", YourBet());
        }

        private bool ThreeCherries()
        {
            if(leftImage.ImageUrl == "Cherry.png" && middleImage.ImageUrl == "Cherry.png" && rightImage.ImageUrl == "Cherry.png")
            {
                return true;
            }
            return false;
        }

        private string ThreeCherriesResults()
        {
            return resultsLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 4); 
        }

        private bool OneCherry()
        {
            if(leftImage.ImageUrl == "Cherry.png" || middleImage.ImageUrl == "Cherry.png" || rightImage.ImageUrl == "Cherry.png")
            {
                return true;
            }
            return false;
        }

        private string OneCherryResults()
        {
            return resultsLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() *2);
        }

        private bool TwoCherries()
        {
            if(leftImage.ImageUrl == "Cherry.png" && middleImage.ImageUrl == "Cherry.png")
            {
                return true;
            }
            else if (middleImage.ImageUrl == "Cherry.png" && rightImage.ImageUrl == "Cherry.png")
            {
                return true;
            }
            else if (leftImage.ImageUrl == "Cherry.png" && rightImage.ImageUrl == "Cherry.png")
            {
                return true;
            }
            return false;
        }

        private string TwoCherriesResults()
        {
            return resultsLabel.Text = String.Format("You bet {0:C} and Won {1:C}", YourBet(), YourBet() * 3);
        }

        private string YouLoseText()
        {
            return resultsLabel.Text = String.Format("Sorry, you lose {0:C}. Better luck next time.", YourBet());
        }

        private string SpinResults()
        {
            if(ThreeSevens())
            {
                return ThreeSevensResults();
            }
            else if (Bar())
            {
                return BarResults();
            }
            else if (ThreeCherries())
            {
                return ThreeCherriesResults();
            }
            else if (TwoCherries())
            {
                return TwoCherriesResults();
            }
            else if (OneCherry())
            {
                return OneCherryResults();
            }
            else
            {
                return YouLoseText();
            }
        }

        private int WinLose()
        {
            if(SpinResults() == String.Format("Sorry, you lose {0:C}. Better luck next time.", YourBet()))
            {
                return -YourBet();
            }
            return YourBet();
        }


        protected void spinButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if(betTextBox.Text.Trim().Length == 0)
            {
                return;
            }

            if(!int.TryParse(betTextBox.Text, out bet))
            {
                return;
            }

            ImageDisplay();
        }
    }
}