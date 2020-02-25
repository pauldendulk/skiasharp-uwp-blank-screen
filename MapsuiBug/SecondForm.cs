using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MapsuiBug
{
    class SecondForm : ContentPage
    {
        public SecondForm() : base()
        {
            this.Content = new Label
            {
                Text = "This is the second form. Now go back."
            };
        }
    }
}
