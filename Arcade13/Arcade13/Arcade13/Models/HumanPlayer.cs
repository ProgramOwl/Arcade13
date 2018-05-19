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
    public class HumanPlayer : BasePlayer
    {
        public string Name;

        public int Wins { get; private set; }

        public int Losses { get; private set; }

        public HumanPlayer(string n)
        {
            Name = n;
            Wins = 0;
            Losses = 0;
        }

        public override void Turn()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if(obj.GetType() == typeof(HumanPlayer))
            {
                HumanPlayer p = (HumanPlayer)obj;

                if(p.Name == Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}