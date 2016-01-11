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

        public Database()
        {
            LoadDatabase();
            InitializeComponent();

        }

        public void LoadDatabase()
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
                                newAction.AddSpells(temp.Substring(1, temp.IndexOf(",")-1), x);
                                temp = temp.Substring(temp.IndexOf(",") + 1);
                            }
                            newAction.AddSpells(temp.Substring(1),x);
                            line = Rep.ReadLine();
                        }
                        else if(line.Contains("Level"))
                        {
                            temp = line.Substring(line.IndexOf("(")+1,1);
                            Slots[x] = int.Parse(temp);

                            temp = line.Substring(line.IndexOf(": ")+1);

                            while (temp.Contains(","))
                            {
                                newAction.AddSpells(temp.Substring(1, temp.IndexOf(",") - 1), x);
                                temp = temp.Substring(temp.IndexOf(",") + 1);
                            }
                            newAction.AddSpells(temp.Substring(1), x);
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

                    if (range==true)
                    {
                        newAction.AddRangeAttack(name,attackmod,normal,max,damage);
                    }
                    else
                    {
                        newAction.AddMeleeAttack(name,attackmod,damage,normal);
                    }
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
    }
}
