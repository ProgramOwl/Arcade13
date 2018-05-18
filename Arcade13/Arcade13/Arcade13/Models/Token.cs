using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Arcade13.Models
{
    public class Token
    {
        public BasePlayer Owner { get; private set; }
        
        public Token(BasePlayer owner)
        {
            Owner = owner;
        }
    }
}