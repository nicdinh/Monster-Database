using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Combat_Simulator
{
    public class Monster
    {
        public string Name;
        public string Size;
        public int AC;

        public int Str;
        public int Dex;
        public int Con;
        public int Int;
        public int Wis;
        public int Char;

        public int ThrowStr;
        public int ThrowDex;
        public int ThrowCon;
        public int ThrowInt;
        public int ThrowWis;
        public int ThrowChar;

        public int Max;
        public int Health;
        public string Speed;//11

        public string Resistance;
        public string Immunity;
        public string Conditions;
        public string Sense;
        public string Language;//4

        public double Challenge;
        public int Experience;//2

        //Skills
        //Strength
        public int Athletics;

        //Dexterity
        public int Acrobatics;
        public int Sleight;
        public int Stealth;

        //Intelligence
        public int Arcana;
        public int History;
        public int Investigation;
        public int Nature;
        public int Religion;

        //Wisdom
        public int Animal;
        public int Insight;
        public int Medicine;
        public int Perception;
        public int Survival;

        //Charisma
        public int Deception;
        public int Intimidation;
        public int Performance;
        public int Persuasion;//18

        public Actions Action;
        public Abilities Ability;

        public string MonsterType;
        public string Alignment;

        //Info for combat
        public string[] Effects;
        public int[] EffectDuration;

        public string Concentration;
        public bool Bloody;



        public Monster(string Name, string Size, int Health, int AC, string Speed)
        {
            this.Name = Name;
            this.Size = Size;
            this.Max = Health;
            this.Health = Health;
            this.AC = AC;
            this.Speed = Speed;

            this.Bloody = false;
        }

        public Monster(string Name,string Size, int AC, int Str, int Dex, int Con, int Int ,int Wis, int Char, int Max, int Health, string Speed)
        {
            this.Name = Name;
            this.Size = Size;
            this.AC = AC;
            this.Str = Str;
            this.Dex = Dex;
            this.Con = Con;
            this.Int = Int;
            this.Wis = Wis;
            this.Char = Char;
            this.Max = Max;
            this.Health = Health;
            this.Speed = Speed;
            this.Resistance = "";
            this.Immunity = "";
            this.Sense = "";


            this.Language = "Common";

            this.Athletics = (int)( Math.Floor((Str - 10) / 2.0) );

            this.Acrobatics = (int)( Math.Floor((Dex - 10) / 2.0) );
            this.Sleight = (int)(Math.Floor((Dex - 10) / 2.0));
            this.Stealth = (int)(Math.Floor((Dex - 10) / 2.0));

            this.Arcana = (int)(Math.Floor((Int - 10) / 2.0));
            this.History = (int)(Math.Floor((Int - 10) / 2.0));
            this.Investigation = (int)(Math.Floor((Int - 10) / 2.0));
            this.Nature = (int)(Math.Floor((Int - 10) / 2.0));
            this.Religion = (int)(Math.Floor((Int - 10) / 2.0));

            this.Animal = (int)(Math.Floor((Wis - 10) / 2.0));
            this.Insight = (int)(Math.Floor((Wis - 10) / 2.0));
            this.Medicine = (int)(Math.Floor((Wis - 10) / 2.0));
            this.Perception = (int)(Math.Floor((Wis - 10) / 2.0));
            this.Survival = (int)(Math.Floor((Wis - 10) / 2.0));

            this.Deception = (int)(Math.Floor((Char - 10) / 2.0));
            this.Intimidation = (int)(Math.Floor((Char - 10) / 2.0));
            this.Performance = (int)(Math.Floor((Char - 10) / 2.0));
            this.Persuasion = (int)(Math.Floor((Char - 10) / 2.0));

            this.Bloody = false;
        }

        public Monster(string Name,string Size, int AC, int Str, int Dex, int Con, int Int, int Wis, int Char, int Max, int Health, string Speed,
                        int Athletics, int Acrobatics, int Sleight, int Stealth, int Arcana, int History, int Investigation, int Nature,
                        int Religion, int Animal, int Insight, int Medicine, int Perception, int Survival, int Deception, int Intimidation,
                        int Performance, int Persuasion, string Language, string Resistance, string Immunity, string Sense, string MonsterType, string Alignment,
                        string Conditions)
        {
            this.Name = Name;
            this.AC = AC;
            this.Str = Str;
            this.Dex = Dex;
            this.Con = Con;
            this.Int = Int;
            this.Wis = Wis;
            this.Char = Char;
            this.Max = Max;
            this.Health = Health;
            this.Speed = Speed;
            this.MonsterType = MonsterType;
            this.Alignment = Alignment;

            if(Size=="")
            {
                this.Size = "Meduim";
            }
            else
            {
                this.Size = Size;
            }

            if (Resistance=="")
            {
                this.Resistance = "None";
            }
            else 
            {
                this.Resistance = Resistance;
            }

            if (Immunity == "")
            {
                this.Immunity = "None";
            }
            else
            {
                this.Immunity = Immunity;
            }

            if (Conditions == "")
            {
                this.Immunity = "None";
            }
            else
            {
                this.Immunity = Conditions;
            }

            if (Sense == "")
            {
                this.Sense = "Average";
            }
            else
            {
                this.Sense = Sense;
            }


            if (Language == "")
            {
                this.Language = "Common";
            }
            else
            {
                this.Language = Language;
            }

            this.Athletics = Athletics;

            this.Acrobatics = Acrobatics;
            this.Sleight = Sleight;
            this.Stealth = Stealth;

            this.Arcana = Arcana;
            this.History = History;
            this.Investigation = Investigation;
            this.Nature = Nature;
            this.Religion = Religion;

            this.Animal = Animal;
            this.Insight = Insight;
            this.Medicine = Medicine;
            this.Perception = Perception;
            this.Survival = Survival;

            this.Deception = Deception;
            this.Intimidation = Intimidation;
            this.Performance = Performance;
            this.Persuasion = Persuasion;

            this.Bloody = false;
        }

        public void AddStat(int Str, int Dex, int Con, int Int, int Wis, int Char)
        {
            this.Str = Str;
            this.Dex = Dex;
            this.Con = Con;
            this.Int = Int;
            this.Wis = Wis;
            this.Char = Char;
        }

        public void AddThrow(int Str, int Dex, int Con, int Int, int Wis, int Char)
        {
            this.ThrowStr = Str;
            this.ThrowDex = Dex;
            this.ThrowCon = Con;
            this.ThrowInt = Int;
            this.ThrowWis = Wis;
            this.ThrowChar = Char;
        }

        public void AddRes(string Res)
        {
            this.Resistance = Res;
        }

        public void AddImm(string Imm)
        {
            this.Immunity = Imm;
        }

        public void AddSense(string Sense)
        {
            this.Sense = Sense;
        }

        public void AddLang(string Lang)
        {
            this.Language = Lang;
        }

        public void AddStrSkills(int Ath)
        {
            this.Athletics = Ath;
        }

        public void AddDexSkills(int Acrobatics, int Sleight, int Stealth)
        {
            this.Acrobatics = Acrobatics;
            this.Sleight = Sleight;
            this.Stealth = Stealth;
        }

        public void AddIntSkills(int Arcana, int  History, int  Investigation, int  Nature, int  Religion)
        {
            this.Arcana = Arcana;
            this.History = History;
            this.Investigation = Investigation;
            this.Nature = Nature;
            this.Religion = Religion;
        }

        public void AddWisSkills(int Animal, int  Insight, int  Medicine, int  Perception, int  Survival)
        {
            this.Animal = Animal;
            this.Insight = Insight;
            this.Medicine = Medicine;
            this.Perception = Perception;
            this.Survival = Survival;
        }

        public void AddCharSkills(int Deception, int Intimidation, int  Performance, int Persuasion)
        {
            this.Deception = Deception;
            this.Intimidation = Intimidation;
            this.Performance = Performance;
            this.Persuasion = Persuasion;
        }

        public void AddCR(double Challenge, int Experience)
        {
            this.Challenge = Challenge;
            this.Experience = Experience;
        }

        public void AddActions(Actions input)
        {
            this.Action = input;
        }

        public void AddAbility(Abilities Input)
        {
            Ability = Input;
        }

        public void EnterDatabase()
        {
            StreamWriter database = File.AppendText ("Monsters.txt");

            database.WriteLine("NEWMONSTER");
            database.WriteLine("Name: {0}, Size: {1}, Health: {2}, AC: {3}, Speed: {4}", this.Name, this.Size, this.Max, this.AC, this.Speed);
            database.WriteLine("Type: {0}, Alignment: {0}", this.MonsterType, this.Alignment);
            database.WriteLine("Str: {0}, Dex: {1}, Con: {2}, Int: {3}, Wis: {4}, Char: {5}", this.Str, this.Dex, this.Con, this.Int, this.Wis, this.Char);
            database.WriteLine("Saving Throw: Str: {0}, Dex: {1}, Con: {2}, Int: {3}, Wis: {4}, Char: {5}", this.ThrowStr, this.ThrowDex, this.ThrowCon, this.ThrowInt, this.ThrowWis, this.ThrowChar);
            database.WriteLine("Resistance: {0}",this.Resistance);
            database.WriteLine("Immunity: {0}", this.Immunity);
            database.WriteLine("Sense: {0}", this.Sense);
            database.WriteLine("Language: {0}", this.Language);
            database.WriteLine("Athletics: {0}", this.Athletics);
            database.WriteLine("Acrobatics: {0}, Sleight: {1}, Stealth: {2}",this.Acrobatics, this.Sleight, this.Stealth);
            database.WriteLine("Arcana: {0}, History: {1}, Investigation: {2}, Nature: {3}, Religion: {4}", this.Arcana, this.History, this.Investigation, this.Nature, this.Religion);
            database.WriteLine("Animal: {0}, Insight: {1}, Medicine: {2}, Perception: {3}, Survival: {4}", this.Animal, this.Insight, this.Medicine, this.Perception, this.Survival);
            database.WriteLine("Deception: {0}, Intimidation: {1}, Performance: {2}, Persuasion: {3}", this.Deception, this.Intimidation, this.Performance, this.Persuasion);
            database.WriteLine("Challenge: {0}, Experience: {1}", this.Challenge, this.Experience);

            if (this.Ability.AbilityName.Count > 0)
            {
                database.WriteLine("{0}", this.Ability);
            }

            database.WriteLine("{0}",this.Action);

            database.Close();
        }

        public int AmountRows()
        {
            int x = 8;

            if (this.Immunity!="None")
            {
                x++;
            }

            if (this.Resistance != "None")
            {
                x++;
            }

            if (this.Athletics != (int)Math.Floor((this.Str - 10) / 2.0) ||
                this.Acrobatics != (int)Math.Floor((this.Dex - 10) / 2.0) || this.Sleight != (int)Math.Floor((this.Dex - 10) / 2.0) || this.Stealth != (int)Math.Floor((this.Dex - 10) / 2.0) ||
                this.Arcana != (int)Math.Floor((this.Int - 10) / 2.0) || this.History != (int)Math.Floor((this.Int - 10) / 2.0) || this.Investigation != (int)Math.Floor((this.Int - 10) / 2.0) || this.Nature != (int)Math.Floor((this.Int - 10) / 2.0) || this.Religion != (int)Math.Floor((this.Int - 10) / 2.0) ||
                this.Animal != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Insight != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Medicine != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Perception != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Survival != (int)Math.Floor((this.Wis - 10) / 2.0) ||
                this.Deception != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Intimidation != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Performance != (int)Math.Floor((this.Wis - 10) / 2.0) || this.Persuasion != (int)Math.Floor((this.Wis - 10) / 2.0))
            {
                x++;
            }

            if (this.Ability.IsNull()==true)
            {
                x++;
            }

            if (this.Action.Contains==true)
            {
                x++;
            }
            

            return x;
        }

        public string[] ReturnArray()
        {
            string[] output = new string[6]{this.Name,this.AC.ToString(),this.Max.ToString(),this.Health.ToString(),"",this.Speed};

            return output;
        }

        public string[] ReturnStats()
        {
            string[] output = new string[6] { "" + Str, "" + Dex, "" + Con, "" + Int, "" + Wis, "" + Char };

            return output;
        }

        public void EnterDamaage(int Damage, string type)
        {
            if (Resistance.Contains(type))
            {
                this.Health -= (int)Math.Floor(Damage/2.0);
            }

            if (this.Health<this.Health/2)
            {
                this.Bloody = true;
            }

            if(Immunity.Contains(type))
            {
                return;
            }
        }

        public void AddEffect(string effect, int duration)
        {
            if(this.Effects==null)
            {
                this.Effects = new string[1];
                this.EffectDuration = new int[1];
                this.Effects[0] = effect;
                this.EffectDuration[0] = duration;
            }
            else
            {
                string[] tempEffect = new string[this.Effects.Length + 1];
                int[] tempDuration = new int[this.EffectDuration.Length + 1];

                for(int x=0; x<this.Effects.Length;x++)
                {
                    tempEffect[x] = this.Effects[x];
                    tempDuration[x] = this.EffectDuration[x];
                }

                tempEffect[this.Effects.Length] = effect;
                tempDuration[this.EffectDuration.Length] = duration;

                this.Effects = tempEffect;
                this.EffectDuration = tempDuration;
            }
        }


    }
}
