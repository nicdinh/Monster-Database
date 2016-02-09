using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Combat_Simulator
{
    public partial class Database : Form
    {
        public Monster[] AllCreatures;
        public Spells[][] AllSpells= new Spells[26][];
        public bool SpellLoad = false;
        public bool MonsterLoad = false;

        public Database()
        {
  

        }

        public void LoadDatabaseMonster()
        {
            StreamReader Rep = new StreamReader("Monsters.txt");
            Actions newAction = new Actions();
            string line = Rep.ReadLine();

            
            while (line!=null)
            {

                 Monster newMonster;

                if (line=="NEWMONSTER")
                {
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if(line.Substring(0,6)=="Name: ")
                {
                    string temp = line.Substring(6);

                    string name = temp.Substring(0, temp.IndexOf(","));
                    temp=temp.Substring(temp.IndexOf(","));
                    temp=temp.Substring(8);

                    string size = temp.Substring(0, temp.IndexOf(","));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(10);

                    int health = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(5);

                    int ac = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(9);

                    string speed = temp;

                    newMonster=new Monster(name, size, health, ac, speed);

                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 5) == "Str: ")
                {
                    string temp = line.Substring(4);

                    int Str = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int Dex = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int Con = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int Int = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int Wis = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(7);

                    int Char = int.Parse(temp);

                    newMonster.AddStat(Str, Dex, Con, Int, Wis, Char);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 19) == "Saving Throw: Str: ")
                {
                    string temp = line.Substring(18);

                    int ThrowStr = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int ThrowDex = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int ThrowCon = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int ThrowInt = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(6);

                    int ThrowWis = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(7);

                    int ThrowChar = int.Parse(temp);

                    newMonster.AddThrow(ThrowStr, ThrowDex, ThrowCon, ThrowInt, ThrowWis, ThrowChar);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0,12) == "Resistance: ")
                {
                    string temp = line.Substring(12);

                    if (temp!="None")
                    {
                        newMonster.AddRes(temp);
                    }
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 10) == "Immunity: ")
                {
                    string temp = line.Substring(10);

                    if (temp != "None")
                    {
                        newMonster.AddImm(temp);
                    }
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 7) == "Sense: ")
                {
                    string temp = line.Substring(7);

                    newMonster.AddSense(temp);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 10) == "Language: ")
                {
                    string temp = line.Substring(10);

                    newMonster.AddLang(temp);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 11) == "Athletics: ")
                {
                    string temp = line.Substring(10);

                    newMonster.AddStrSkills(int.Parse(temp));
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 12) == "Acrobatics: ")//Acrobatics: 2, Sleight: 2, Stealth: 2
                {
                    string temp = line.Substring(11);

                    int Acrobatics = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(10);

                    int Sleight = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(10);

                    int Stealth = int.Parse(temp);

                    newMonster.AddDexSkills(Acrobatics, Sleight, Stealth);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 8) == "Arcana: ")//Arcana: -1, History: -1, Investigation: -1, Nature: -1, Religion: -1
                {
                    string temp = line.Substring(7);

                    int Arcana = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(10);

                    int History = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(16);

                    int Investigation = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(9);

                    int Nature = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(11);

                    int Religion = int.Parse(temp);

                    newMonster.AddIntSkills(Arcana, History, Investigation, Nature, Religion);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 8) == "Animal: ")//Animal: -2, Insight: -2, Medicine: -2, Perception: -2, Survival: -2
                {
                    string temp = line.Substring(7);

                    int Animal = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(10);

                    int Insight = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(11);

                    int Medicine = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(13);

                    int Perception = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(11);

                    int Survival = int.Parse(temp);

                    newMonster.AddWisSkills(Animal, Insight, Medicine, Perception, Survival);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 11) == "Deception: ")//Deception: -1, Intimidation: -1, Performance: -1, Persuasion: -1
                {
                    string temp = line.Substring(10);

                    int Deception = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(15);

                    int Intimidation = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(14);

                    int Performance = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(13);

                    int Persuasion = int.Parse(temp);

                    newMonster.AddCharSkills(Deception, Intimidation, Performance, Persuasion);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                if (line.Substring(0, 11) == "Challenge: ")
                {
                    string temp = line.Substring(10);

                    double Challenge = double.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(13);

                    int Experience = int.Parse(temp);

                    newMonster.AddCR(Challenge, Experience);
                    line = Rep.ReadLine();
                }
                else
                {
                    throw new Exception();
                }

                //Ability
                if (line.Contains("Ability"))
                {
                    line = Rep.ReadLine();
                    while (!line.Contains("Melee") || !line.Contains("Range") || !line.Contains("Spellcasting"))
                    {
                        string temp = line;

                        string name = temp.Substring(0, temp.IndexOf("."));
                        temp = temp.Substring(temp.IndexOf("."));
                        temp = temp.Substring(1);

                        string des = temp;

                        Abilities newAbility = new Abilities();

                        newAbility.AddAbility(name, des);

                        newMonster.AddAbility(newAbility);
                    }
                }

                //Spells
                if(line.Contains("Spellcasting"))
                {
                    string temp = line.Substring(line.IndexOf("DC "));
                    temp = temp.Substring(2);
                    int DC = int.Parse(temp.Substring(0, temp.IndexOf(",")));
                    temp = temp.Substring(temp.IndexOf(", ")+1);
                    int Mod = int.Parse(temp.Substring(0, temp.IndexOf(" to")));

                    line = Rep.ReadLine();

                    int[] Slots = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    for (int x = 0; x < 10; x++ )
                    {
                        if (line.Contains("Cantrip"))
                        {
                            Slots[x] = -1;

                            temp = line.Substring(line.IndexOf(": ") + 1);

                            while(temp.Contains(","))
                            {
                                //newAction.AddSpells(temp.Substring(1, temp.IndexOf(",")-1), x);
                                temp = temp.Substring(temp.IndexOf(",") + 1);
                            }
                            //newAction.AddSpells(temp.Substring(1),x);
                            line = Rep.ReadLine();
                        }
                        else if(line.Contains("Level"))
                        {
                            temp = line.Substring(line.IndexOf("(")+1,1);
                            Slots[x] = int.Parse(temp);

                            temp = line.Substring(line.IndexOf(": ")+1);

                            while (temp.Contains(","))
                            {
                                //newAction.AddSpells(temp.Substring(1, temp.IndexOf(",") - 1), x);
                                temp = temp.Substring(temp.IndexOf(",") + 1);
                            }
                            //newAction.AddSpells(temp.Substring(1), x);
                            line = Rep.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    }

                    newAction.AddSlots(Slots);
                }


                //Attacks
                while (line.Contains("Melee")|| line.Contains("Range"))
                {
                    string temp = line;

                    string name = temp.Substring(0, temp.IndexOf("."));
                    temp = temp.Substring(temp.IndexOf("."));
                    temp = temp.Substring(1);

                    bool range=true;
                    if(temp.Contains("Melee"))
                    {
                        range = false;
                    }

                    temp = temp.Substring(temp.IndexOf(":"));
                    temp = temp.Substring(2);

                    int attackmod = int.Parse(temp.Substring(0, temp.IndexOf(" ")));
                    temp = temp.Substring(temp.IndexOf(","));
                    temp = temp.Substring(8);

                    int normal;
                    int max;

                    if (range==true)
                    {
                        normal = int.Parse(temp.Substring(0, temp.IndexOf("/")));
                        temp = temp.Substring(temp.IndexOf("/"));
                        max = int.Parse(temp.Substring(0, temp.IndexOf(" ")));
                    }
                    else
                    {
                        normal = int.Parse(temp.Substring(0, temp.IndexOf(" ")));
                        max = normal;
                    }

                    line = Rep.ReadLine();

                    string damage = line;

                    /*if (range==true)
                    {
                        newAction.AddRangeAttack(name,attackmod,normal,max,damage);
                    }
                    else
                    {
                        newAction.AddMeleeAttack(name,attackmod,damage,normal);
                    }*/
                }

                newMonster.AddActions(newAction);
                

                //Insert Action Read Stuff
                while (line!="NEWMONSTER"&&line!=null)
                {
                    line = Rep.ReadLine();
                }

                AllCreatures = new Monster[1] {newMonster};

            }

            Rep.Close();
        }

        public void LoadDatabaseSpells()
        {
            StreamReader file = new StreamReader("Spells.txt");
            SpellLoad = true;

            string line = file.ReadLine();

            while (line!=null)
            {
                int PageNum = 0;
                string Name = "";
                int Level = 0;
                string CastTime = "";
                string Range = "";
                string Material = "";
                bool Verbal = false;
                bool Somatic = false;
                bool Ritual = false;
                bool Concentration = false;
                string Duration = "";
                string School = "";
                string Info = "";

                if (line == "New Spell")
                {
                    line = file.ReadLine();
                    Name = line;
                }
                else
                {
                    throw new Exception("Expected New Spell line in the database.");
                }

                line = file.ReadLine();

                if (line.Contains("Page Number"))
                {
                    PageNum = int.Parse(line.Substring(13));
                }
                else
                {
                    throw new Exception("Expected Page Number line in the database.");
                }

                line = file.ReadLine();

                line = line.ToLower();
                if (line.Contains("level") || line.Contains("cantrip"))
                {
                    if (line.Contains("ritual"))
                    {
                        Level = int.Parse(line.Substring(0, 1));
                        School = line.Substring(8);
                    }
                    else
                    {
                        if (line.Contains("cantrip"))
                        {
                            Level = 0;
                            School = line.Substring(0, line.IndexOf("cantrip"));
                        }
                        else
                        {
                            int schoolLength = line.Length - 16;
                            Level = int.Parse(line.Substring(0, 1));
                            School = line.Substring(8, schoolLength);
                            Ritual = true;
                        }
                    }
                }
                else
                {
                    throw new Exception("Expected Level and School line in the database.");
                }

                line = file.ReadLine();

                if (line.Contains("Cast Time"))
                {
                    CastTime = line.Substring(11);
                }
                else
                {
                    throw new Exception("Expected Cast Time line in the database.");
                }

                line = file.ReadLine();

                if (line.Contains("Range"))
                {
                    Range = line.Substring(8);
                }
                else
                {
                    throw new Exception("Expected Range line in the database.");
                }

                line = file.ReadLine();

                if (line.Contains("Components"))
                {
                    if (line.Substring(12).Contains(" V"))
                    {
                        Verbal = true;
                    }
                    if(line.Substring(12).Contains(" S"))
                    {
                        Somatic = true;
                    }
                    if(line.Contains(", M"))
                    {
                        Material = line.Substring(line.IndexOf("(") + 3);
                        Material = Material.Substring(0, Material.Length - 1);
                    }
                }
                else
                {
                    throw new Exception("Expected Components line in the database.");
                }

                line = file.ReadLine();

                if (line.Contains("Duration"))
                {
                    if (line.Contains("Concentration"))
                    {
                        Concentration = true;
                        Duration = line.Substring(25);
                    }
                    else
                    {
                        Duration = line.Substring(10);
                    }
                }
                else
                {
                    throw new Exception("Expected Duration line in the database.");
                }

                line = file.ReadLine();

                while (line != null)
                {
                    if (line == "New Spell")
                    {
                        break;
                    }

                    Info += line + " ";
                    line = file.ReadLine();
                }

                Spells newSpell = new Spells(PageNum, Name, Level, CastTime, Range, Material, Verbal, Somatic, Ritual, Concentration, Duration, School, Info);
                AddSpell(newSpell, false);
            }

            file.Close();
        }

        public void AddSpell(Spells newSpell, bool load)
        {
            int letter = char.ToUpper(newSpell.Name[0]) -64;

            if (!this.SpellLoad)
            {
                this.LoadDatabaseSpells();
            }

            if (this.FindSpell(newSpell.Name)==null)
            {
                if (this.AllSpells[letter] == null)
                {
                        Spells[] temp = new Spells[1] { newSpell };
                        this.AllSpells[letter] = temp;
                }
                else {
                
                    Spells[] temp = new Spells[AllSpells[letter].Length + 1];
                    for (int x = 0; x < AllSpells[letter].Length; x++)
                    {
                        temp[x] = AllSpells[letter][x];
                    }

                    temp[AllSpells[letter].Length] = newSpell;
                    this.AllSpells[letter] = temp;
                }
                if (load)
                {
                    AddSpellToDatabase(newSpell);
                }
            }

        }

        public void AddMonster(Monster newMonster)
        {
            
        }

        public void AddSpellToDatabase(Spells newSpell)
        {
            StreamWriter file = new StreamWriter("Spells.txt", true);

            file.WriteLine("New Spell\r\n" + newSpell.ToString());

            file.Close();
        }

        public Spells FindSpell(string search)
        {
            int letter = char.ToUpper(search[0]) -64;

            if (AllSpells[letter] != null)
            {
                for (int x = 0; x < AllSpells[letter].Length; x++)
                {
                    if (AllSpells[letter][x].Name == search)
                    {
                        return AllSpells[letter][x];
                    }
                }
            }

            return null;
        }
    }
}

