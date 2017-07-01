using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ResponsiveContent
    {
        public string Test { get; set; } = "Ceci est un test";
        public MainPage()
        {
            InitializeComponent();

        }
    }
}
