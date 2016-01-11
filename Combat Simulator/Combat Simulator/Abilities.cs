using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Simulator
{
    public class Abilities
    {
        public ArrayList AbilityName = new ArrayList();
        public ArrayList AbilityDes = new ArrayList();
        public bool hasdata=false;

        public Abilities()
        {
        }

        public void AddAbility(string Name, string Description)
        {
            AbilityName.Add(Name);
            AbilityDes.Add(Description);
            hasdata = true;
        }
        public bool IsNull()
        {
            return hasdata;
        }

        public override string ToString()
        {
            string output = "Ability\r\n";

            if (AbilityName.Count > 0)
            {
                string[] temp1 = new string[AbilityName.Count];
                string[] temp2 = new string[AbilityDes.Count];

                AbilityName.CopyTo(temp1);
                AbilityDes.CopyTo(temp2);


                for (int x = 0; x < temp1.Length; x++)
                {
                    output+=string.Format("{0}. {1}\r\n", temp1[x], temp2[x]);
                }
            }

            return output;
        }
    }
}
