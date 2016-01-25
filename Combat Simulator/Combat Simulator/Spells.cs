using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Simulator
{
    public class Spells
    {
        public int PageNum;
        public string Name;
        public int Level;
        public string CastTime;
        public string Range;
        public string Material;
        public bool Verbal;
        public bool Somatic;
        public bool Ritual;
        public bool Concentration;
        public string Duration;
        public string School;
        public string Info;

        public Spells(int pageNum, string name, int level, string castTime, string range, string material, bool verbal,
            bool somatic, bool ritual, bool concentration, string duration, string school, string info)
        {
            this.PageNum = pageNum;
            this.Name = name;
            this.Level = level;
            this.CastTime = castTime;
            this.Range = range;
            this.Material = material;
            this.Verbal = verbal;
            this.Somatic = somatic;
            this.Ritual = ritual;
            this.Concentration = concentration;
            this.Duration = duration;
            this.School = school;
            this.Info = info;
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter cannot be cast to Point return false.
            Spells p = obj as Spells;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return this.Name == p.Name;

        }

        public override string ToString()
        {
            string output = "";

            output += this.Name + "\r\n";
            output += "Page Number: " + this.PageNum + "\r\n";
            
            if (this.Level==0)
            {
                output += this.School + " Cantrip" + "\r\n";
            }
            else
            {
                if (Ritual)
                {
                    output += this.Level + "-Level " + this.School + " (ritual)" + "\r\n";
                }
                else
                {
                    output += this.Level + "-Level " + this.School + "\r\n";
                }
            }

            output += "Cast Time: " + this.CastTime + "\r\n";
            output += "Range: " + this.Range + "\r\n";

            if (this.Verbal)
            {
                output += "Components: V\r\n";
            }
            else if (this.Somatic)
            {
                output += "Components: S\r\n";
            }
            else if (this.Material.Length!=0)
            {
                output += "Components: M(" + this.Material + ")\r\n";
            }
            else if (this.Verbal && this.Somatic)
            {
                output += "Components: V, S\r\n";
            }
            else if (this.Verbal && this.Material.Length != 0)
            {
                output += "Components: V, M(" + this.Material + ")\r\n";
            }
            else if (this.Somatic && this.Material.Length != 0)
            {
                output += "Components: S, M(" + this.Material + ")\r\n";
            }
            else if (this.Verbal && this.Somatic && this.Material.Length != 0)
            {
                output += "Components: V, S, M(" + this.Material + ")\r\n";
            }

            if (this.Concentration)
            {
                output += "Duration: Concentration, " + this.Duration + "\r\n";
            }
            else
            {
                output += "Duration: " + this.Duration + "\r\n";
            }
            output += this.Info + "\r\n";

            return output;
        }
    }
}
