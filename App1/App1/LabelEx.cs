using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public class LabelEx : Xamarin.Forms.Label
    {
        public string ExtendedValue
        {
            get
            {
                return (string)GetValue(ExtendedValueProperty);
            }
            set
            {
                SetValue(ExtendedValueProperty, value);
            }
        }

        public static readonly BindableProperty ExtendedValueProperty = BindableProperty.Create(nameof(ExtendedValue),
                                                                                                typeof(string),
                                                                                                typeof(LabelEx),
                                                                                                null);
    }
}
