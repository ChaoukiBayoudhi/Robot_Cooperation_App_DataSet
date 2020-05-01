using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCoop
{
    public partial class DeleteOrModifyTask : Form
    {
        private String action;
        
        public DeleteOrModifyTask(string action)
        {
            InitializeComponent();
            this.action = action;
                        
        }

        private void DeleteOrModifyTask_Load(object sender, EventArgs e)
        {
           if(action=="Delete")
            {
                this.Text = "Suppression d'une tâche";
                bt_deleteorModify.Text = "Supprimer";
                foreach (Control x in groupBox1.Controls)
                {
                    if (!(x is Label) && x.Name != "txt_code")
                        x.Enabled = false;
                }
            }
           else
            {
                this.Text = "Modification d'une tâche";
                bt_deleteorModify.Text = "Modifier";
            }
        }

        private void bt_deleteorModify_Click(object sender, EventArgs e)
        {
            try
            {
                switch (action)
                {
                    case "Delete":
                        DataRow[] tabRow=Form1.DS.Tables["TaskTab"].Select("Code =" + int.Parse(txt_code.Text));
                        if (tabRow.Length==0)
                        {
                            throw new Exception("Veuillez verifier le code de la tache");
                        }
                        Form1.DS.Tables["TaskTab"].Rows.Remove(tabRow[0]);
                        MessageBox.Show("Tâche supprimée avec succès...");
                        break;
                    case "Modify":
                        DataRow[] tabRow1 = Form1.DS.Tables["TaskTab"].Select("Code =" + int.Parse(txt_code.Text));
                        if (tabRow1.Length == 0)
                        {
                            throw new Exception("Veuillez verifier le code de la tache");
                        }

                        int index=Form1.DS.Tables["TaskTab"].Rows.IndexOf(tabRow1[0]);

                        Form1.DS.Tables["TaskTab"].Rows[index]["name"] = txt_name.Text;
                        Form1.DS.Tables["TaskTab"].Rows[index]["duration"] = float.Parse(txt_duration.Text);
                        Form1.DS.Tables["TaskTab"].Rows[index]["status"] = cmb_status.Text;
                        MessageBox.Show("Tâche modifiée avec succés");

                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            int code = int.Parse(txt_code.Text);
            DataRow[] tabRow = Form1.DS.Tables["TaskTab"].Select("Code=" + code);
            if (tabRow.Length > 0)
            {
                txt_name.Text = tabRow[0]["name"].ToString();
                txt_duration.Text = tabRow[0]["duration"].ToString();
                cmb_status.DropDownStyle = ComboBoxStyle.Simple;
                cmb_status.Text = tabRow[0]["status"].ToString();
            }
            else
            {
                foreach (Control x in groupBox1.Controls)
                {
                    if (!(x is Label) && x.Name != "txt_code")
                        x.Text = string.Empty;
                }
            }
        }

        private void txt_code_Leave(object sender, EventArgs e)
        {
           /* int code = int.Parse(txt_code.Text);
            DataRow[] tabRow = Form1.DS.Tables["TaskTab"].Select("Code=" + code);
            if(tabRow.Length>0)
            {
                txt_name.Text = tabRow[0]["name"].ToString();
                txt_duration.Text= tabRow[0]["duration"].ToString();
                cmb_status.DropDownStyle = ComboBoxStyle.Simple;
                cmb_status.Text= tabRow[0]["status"].ToString();
            }*/
        }
    }
}
