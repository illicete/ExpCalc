using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsCalculator
{
    
    public class Character
    {
        
        public List<string> defaultAttrList = new List<string> {   "Intelligence", "Wits", "Resolve", "Strength",
            "Dexterity", "Stamina", "Presence",  "Manipulation", "Composure", "Capacity", "Control", "Regeneration" };

        public List<string> defaultSkillList = new List<string> {  "Weapons", "Deception", "Diplomacy", "Sealing", "TechniqueHacking",
                     "Awareness", "TacticalMovement", "Stealth", "MechanicalAptitude", "Medicine", "MedicalNinjutsu"};
       

                       
        public List<Attribute> Attributes;
        public List<Skill> Skills;
        //   public Skill Taijutsu", "Weapons", "Deception", "Diplomacy", "Sealing", "TechniqueHacking,
        //       Awareness", "TacticalMovement", "Stealth", "MechanicalAptitude", "Medicine", "MedicalNinjutsu;

        public Character(List<string> AttrList = null, List<string> SkillList = null, bool testMode = true) {
            if (testMode)
            {
                SkillList = defaultSkillList;
                AttrList = defaultAttrList;
            }

            Attributes = new List<Attribute>();

            foreach (string s in SkillList)
            {

            }
            foreach (string s in AttrList)
            {
                Attributes.Add(new Attribute(1, s));
            }
       //     Attributes.Add(new Attribute());
      
        }

        internal void FillPage(DataGridView dgvAttributes)
        {
            foreach (Attribute attr in Attributes)
            {
                dgvAttributes.Rows.Add(attr.Name, attr.Value);
            }
        }


        public int GetAttributeExp(int Level, DataGridView dgvReqs)
        {
            int attributeExp = 0;
            string AttributeReq = "";
            foreach (DataGridViewRow row in dgvReqs.Rows)
            {
                int mult = 0;

                if ((row.Cells[1].Value == null || !int.TryParse(row.Cells[1].Value.ToString(), out mult)) || mult == 0)
                    continue;



                AttributeReq = row.Cells[0].Value.ToString();
                for (int i = 1; i <= Math.Ceiling((Decimal)Level / mult); i++)
                {
                    if (Attributes.Where(attr => attr.Name == AttributeReq).First().Value < i)
                        attributeExp += (((i) * 2));
                }
            }
            
            return attributeExp;
        }

        internal void UpdateFromFile(DataGridView dgvAttributes)
        {

            List<List<String>> AttributesFromFile = new List<List<string>>();
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"E:\Users\Peter\Workspaces\StatsCalculator";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(theDialog.FileName))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                var values = line.Split(',');
                                AttributesFromFile.Add(new List<string> { values[0].ToString(), values[1].ToString() });
                                
                            }
                        }

                    }
                    Update(AttributesFromFile, dgvAttributes);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            

            }



        }

        internal void Save()
        {
            Stream myStream = null;
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"E:\Users\Peter\Workspaces\StatsCalculator";
            

                try
                {

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = "unknown.txt";
                    // set filters - this can be done in properties as well
                    savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        {
                            foreach (Attribute a in Attributes)
                            {
                                sw.WriteLine(a.Name + ","+ a.Value);
                            }
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Something went wrong, yo: " + ex.Message);
                }


            


        }

        internal void Update(List<List<string>> lAttributes, DataGridView dgvAttributes)
        {

            for (int i = 0; i < lAttributes.Count; i++)
            {
                int value = 0;
             
                int.TryParse(lAttributes[i][1].ToString(), out value);
                Attribute attribute = Attributes.Where(attr => attr.Name == lAttributes[i][0].ToString()).FirstOrDefault();
                if (attribute != null)
                {
                    attribute.Value = value;
                }
                else
                {
                    dgvAttributes.Rows.Add(lAttributes[i][0].ToString(), value);
                    Attributes.Add(new Attribute(value, lAttributes[i][0].ToString()));
                }


            }


            }
        }
    }

