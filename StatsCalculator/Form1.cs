using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsCalculator
{
    public partial class Form1 : Form
    {
       public static Character Chara; //Determination
        public Form1()
        {
            InitializeComponent();
            dgvAttributes.AllowUserToAddRows = false;


        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int Level = (int)nddLevel.Value;
        
            int AttrExp = 0;
            int SkillExp = 0;
            
            for (int i = 1; i <= Level; i++)
            {
                if(  i> (int)nupCurLevel.Value)
                SkillExp += i;

            }
            AttrExp = Chara.GetAttributeExp(Level, dgvReqs);


            lblSkillExp.Text = SkillExp.ToString();
            lblAttributeExp.Text = AttrExp.ToString();
            lblTotalExpCost.Text = (AttrExp + SkillExp).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chara = new Character();
            Chara.FillPage(dgvAttributes);

            dgvAttributes.Height = dgvAttributes.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvAttributes.ColumnHeadersHeight + 2;
            dgvAttributes.Width = dgvAttributes.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgvAttributes.RowHeadersWidth + 2;

            foreach (Attribute a in Chara.Attributes) {
                dgvReqs.Rows.Add(a.Name.ToString(), "");
            }

            dgvReqs.Height = dgvReqs.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvReqs.ColumnHeadersHeight + 2;
            dgvReqs.Width = dgvReqs.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgvReqs.RowHeadersWidth + 2;

        }

        private void dgvAttributes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {if (dgvAttributes != null && Chara != null)
            {
                
                Chara.Update(dgvToList(dgvAttributes), dgvAttributes);

            }
        }

        private List<List<string>> dgvToList(DataGridView dgvAttributes)
        {
            List<List<string>> List = new List<List<string>>();
            string first = "";
            string second = "0";

            foreach (DataGridViewRow row in dgvAttributes.Rows)
            {
                first = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : "";
                second = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "0";
                List.Add(new List<string> { first, second});


            }

            return List;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool reqFound = false;
            bool attFound = false;
            foreach (DataGridViewRow row in dgvAttributes.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtAddAttribute.Text)
                { attFound = true; }
            }
            foreach (DataGridViewRow row in dgvReqs.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtAddAttribute.Text)
                { reqFound = true; }
            }
            if (!reqFound)
            {
                dgvReqs.Rows.Add(txtAddAttribute.Text, "");
                dgvReqs.Height = dgvReqs.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvReqs.ColumnHeadersHeight + 2;
                dgvReqs.Width = dgvReqs.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgvReqs.RowHeadersWidth + 2;
            }
            if (!attFound)
            {
                dgvAttributes.Rows.Add(txtAddAttribute.Text, 1);
                dgvAttributes.Height = dgvAttributes.Rows.GetRowsHeight(DataGridViewElementStates.None) + dgvAttributes.ColumnHeadersHeight + 2;
                dgvAttributes.Width = dgvAttributes.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dgvAttributes.RowHeadersWidth + 2;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Chara.UpdateFromFile(dgvAttributes);
      
            dgvAttributes.Rows.Clear();
            dgvAttributes.Refresh();
            foreach (Attribute a in Chara.Attributes)
            {
                dgvAttributes.Rows.Add(a.Name.ToString(), a.Value);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Chara.Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvAttributes.SelectedRows)
            {
                dgvAttributes.Rows.RemoveAt(item.Index);
            }
            foreach (DataGridViewRow item in this.dgvReqs.SelectedRows)
            {
                dgvReqs.Rows.RemoveAt(item.Index);
            }
        }
    }
}
