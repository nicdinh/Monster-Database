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

        public Spells(int pageNum, string name, string castTime, string range, string material, bool verbal,
            bool somatic, bool ritual, bool concentration, string duration, string school, string info)
        {
            this.PageNum = pageNum;
            this.Name = name;
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

    }
}
