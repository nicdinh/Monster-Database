using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Simulator
{
    public class Actions
    {
        //public string[][] Spells=new string[10][];
        public Spells[][] Spells = new Spells[10][];
        public int SpellMod;
        public int SpellDC;
        public int[] SpellSlots = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string[] Attacks;
        public int[] AttackMod;
        public bool[] Range;
        public int[] Normal;
        public int[] Max;
        public string[] Damage;
        public string[] Info; 
        public bool Contains=false;
        public LegendaryActions[] Legend;
        public int LegendPoints;

        public Actions()
        {
        }

        public void AddSpells(Spells Input, int Level)
        {
            if (this.Spells[Level] == null)
            {
                this.Spells[Level] = new Spells[1] { Input };
            }
            else
            {
                Spells[] temp = new Spells[this.Spells[Level].Length + 1];
                for (int x = 0; x < this.Spells[Level].Length; x++)
                {
                    temp[x] = this.Spells[Level][x];
                }
                temp[this.Spells[Level].Length] = Input;

                this.Spells[Level] = temp;
            }
            this.Contains = true;
        }

        public void AddSlots(int[] Slots)
        {
            this.SpellSlots = Slots;
        }

        public int NumAttacks()
        {
            return Attacks.Length;
        }

        public int NumSpells()
        {
            return Spells.Length;
        }

        public void AddSpellMod(int spellMod, int spellDC)
        {
            this.SpellMod = spellMod;
            this.SpellDC = spellDC;
        }

        public void AddMeleeAttack(string attack, int attackMod, string damage, int range, string info)
        {
            if (this.Attacks == null)
            {
                this.Attacks = new String[1] { attack };
                this.AttackMod = new int[1] { attackMod };
                this.Range = new bool[1] { false };
                this.Normal = new int[1] {5};
                this.Max = new int[1] {5};
                this.Damage = new string[1] {damage};
                this.Info = new string[1] {info};
            }
            else
            {
                string[] tempAttack = new String[this.Attacks.Length + 1];
                int[] tempAttackMod = new int[this.AttackMod.Length + 1];
                bool[] tempRange = new bool[this.Range.Length + 1];
                int[] tempNormal = new int[this.Normal.Length + 1];
                int[] tempMax = new int[this.Max.Length + 1];
                string[] tempDamage = new String[this.Damage.Length + 1];
                string[] tempInfo = new String[this.Damage.Length + 1];

                for (int x = 0; x < this.Attacks.Length; x++)
                {
                    tempAttack[x] = this.Attacks[x];
                    tempAttackMod[x] = this.AttackMod[x];
                    tempRange[x] = this.Range[x];
                    tempNormal[x] = this.Normal[x];
                    tempMax[x] = this.Max[x];
                    tempDamage[x] = this.Damage[x];
                    tempInfo[x] = this.Info[x];
                }
                tempAttack[this.Attacks.Length] = attack;
                tempAttackMod[this.Attacks.Length] = attackMod;
                tempRange[this.Attacks.Length] = false;
                tempNormal[this.Attacks.Length] = range;
                tempMax[this.Attacks.Length] = range;
                tempDamage[this.Attacks.Length] = damage;
                tempInfo[this.Attacks.Length] = info;

                this.Attacks = tempAttack;
                this.AttackMod = tempAttackMod;
                this.Range = tempRange;
                this.Normal = tempNormal;
                this.Max = tempMax;
                this.Damage = tempDamage;
                this.Info = tempInfo;
            }
            this.Contains = true;
        }

        public void AddRangeAttack(string attack, int attackMod,int normal, int max, string damage, string info)
        {
            if (this.Attacks == null)
            {
                this.Attacks = new String[1] { attack };
                this.AttackMod = new int[1] { attackMod };
                this.Range = new bool[1] { true };
                this.Normal = new int[1] { normal };
                this.Max = new int[1] { max };
                this.Damage = new string[1] { damage };
                this.Info = new string[1] { info };
            }
            else
            {
                string[] tempAttack = new String[this.Attacks.Length + 1];
                int[] tempAttackMod = new int[this.AttackMod.Length + 1];
                bool[] tempRange = new bool[this.Range.Length + 1];
                int[] tempNormal = new int[this.Normal.Length + 1];
                int[] tempMax = new int[this.Max.Length + 1];
                string[] tempDamage = new String[this.Damage.Length + 1];
                string[] tempInfo = new String[this.Info.Length + 1];

                for (int x = 0; x < this.Attacks.Length; x++)
                {
                    tempAttack[x] = this.Attacks[x];
                    tempAttackMod[x] = this.AttackMod[x];
                    tempRange[x] = this.Range[x];
                    tempNormal[x] = this.Normal[x];
                    tempMax[x] = this.Max[x];
                    tempDamage[x] = this.Damage[x];
                    tempInfo[x] = this.Info[x];
                }
                tempAttack[this.Attacks.Length] = attack;
                tempAttackMod[this.Attacks.Length] = attackMod;
                tempRange[this.Attacks.Length] = true;
                tempNormal[this.Attacks.Length] = normal;
                tempMax[this.Attacks.Length] = max;
                tempDamage[this.Attacks.Length] = damage;
                tempInfo[this.Attacks.Length] = info;

                this.Attacks = tempAttack;
                this.AttackMod = tempAttackMod;
                this.Range = tempRange;
                this.Normal = tempNormal;
                this.Max = tempMax;
                this.Damage = tempDamage;
                this.Info = tempInfo;
            }
            this.Contains = true;
        }

        public override string ToString()
        {
            string output="";

            if (this.SpellDC > 0)
            {
                output += string.Format("Spellcasting. Spell Save DC {0}, {1} to Hit with Spell Attacks\r\n", this.SpellDC, this.SpellMod);

                for (int x = 0; x < 10; x++)
                {
                    if (SpellSlots[x] != 0)
                    {
                        if (x == 0)
                        {
                            output += "Cantrips (at will): ";
                            for (int y = 0; y < Spells[x].Length; y++)
                            {
                                output += Spells[x][y];
                                if (y != Spells[x].Length - 1)
                                {
                                    output += ", ";
                                }
                            }
                            output += "\r\n";
                        }
                        else
                        {
                            output += string.Format("{0} Level ({1} slots): ", x, SpellSlots[x]);
                            for (int y = 0; y < Spells[x].Length; y++)
                            {
                                output += Spells[x][y];
                                if (y != Spells[x].Length - 1)
                                {
                                    output += ", ";
                                }
                            }
                            output += "\r\n";
                        }
                    }
                }
            }

            if (Attacks != null)
            {
                string temp = "";

                for (int x = 0; x < Attacks.Length; x++)
                {
                    if (Range[x] == false)
                    {
                        if (AttackMod[x] > 0)
                        {
                            temp += string.Format("{0}. Melee Attack: +{1} to Hit, reach {2} ft\r\n", Attacks[x], AttackMod[x], Normal[x]);
                            temp += string.Format("Hit: {0}\r\n", Damage[x]);
                        }
                        else
                        {
                            temp += string.Format("{0}. Melee Attack: {1} to Hit, reach {2} ft\r\n", Attacks[x], AttackMod[x], Normal[x]);
                            temp += string.Format("Hit: {0}\r\n", Damage[x]);
                        }
                    }
                    else
                    {
                        if (AttackMod[x] > 0)
                        {
                            temp += string.Format("{0}. Range Attack: +{1} to Hit, reach {2}/{3} ft\r\n", Attacks[x], AttackMod[x], Normal[x], Max[x]);
                            temp += string.Format("Hit: {0}\r\n", Damage[x]);
                        }
                        else
                        {
                            temp += string.Format("{0}. Range Attack: {1} to Hit, reach {2}/{3} ft\r\n", Attacks[x], AttackMod[x], Normal[x], Max[x]);
                            temp += string.Format("Hit: {0}\r\n", Damage[x]);
                        }
                    }

                }

                output += temp;
            }

            if (this.Legend != null)
            {
                output += "Legendary Actions\n";
                output += "The monster can take {0} legendary actions, choosing from the options below.\n";
                output += "Only one legendary action option can be used at a time and only at the end of\n";
                output += "another creature's turn. The lich regains spend legendary actions at the start\n";
                output += "of its turn.\n";

                for (int x = 0; x < this.Legend.Length; x++)
                {
                    output += Legend[x].ToString();
                }

            }

            return output;
        }

        public void AddLegendary(LegendaryActions input)
        {
            if (this.Legend==null)
            {
                this.Legend = new LegendaryActions[1] { input };
            }
            else
            {
                LegendaryActions[] temp = new LegendaryActions[this.Legend.Length + 1];

                for (int x = 0; x < this.Attacks.Length; x++)
                {
                    temp[x] = this.Legend[x];
                }
                temp[this.Legend.Length] = input;

                this.Legend = temp;
            }
        }
    }

    public class LegendaryActions
    {
        public string Name;
        public string Description;
        public int Cost;

        public LegendaryActions(string name, string description, int cost)
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;
        }

        public override string ToString()
        {
            string output = "";

            if (Cost>1)
            {
                output += Name + "\n";
            }
            else
            {
                output += Name + " (Cost " + Cost + " Actions\n";
            }

            output += Description + "\n";

            return output;
        }
    }
}
