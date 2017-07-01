using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class ResponsiveContent : ContentPage
    {

        public LabelEx LabelTitle { get; set; }
        
        public ResponsiveContent()
        {
            this.BindingContext = this;
            LabelTitle = new LabelEx() { Text = "Hello" };
            this.Content = LabelTitle;
        }
    }
}
