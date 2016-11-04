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



        protected void spinButton_Click(object sender, EventArgs e)
        {
            ImageDisplay();
        }
    }
}