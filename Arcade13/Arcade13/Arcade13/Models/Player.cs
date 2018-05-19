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
    public class Player
    {
        public bool IsHuman { get; private set; }
        public Token Token { get; private set; }  
        
        public override bool Equals(object obj)
        {
            
            if(this.GetType() == typeof(CPUPlayer) && obj.GetType() == typeof(HumanPlayer))
            {
                return ((HumanPlayer)this).Equals(obj);
            }
            else if(this.GetType() == typeof(CPUPlayer) && obj.GetType() == typeof(CPUPlayer))
            {
                return ((CPUPlayer)this).Equals(obj);
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}