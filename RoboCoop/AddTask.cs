using System;
using System.Data;
using System.Windows.Forms;

namespace RoboCoop
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow row = Form1.DS.Tables["TaskTab"].NewRow();//pour avoir une ligne ayant la même strucure qu'une lugne de latable Task
                row["name"] = txt_name.Text;
                // ou bien via les indices
                //row[1] = txt_name.Text;
                row[2] = decimal.Parse(txt_duration.Text);
                row[3] = cmb_status.Text;
                Form1.DS.Tables["TaskTab"].Rows.Add(row);
                MessageBox.Show("Tache ajoutée avec succès...");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
           txt_code.Text=(Convert.ToInt32(Form1.DS.Tables[1].Rows[Form1.DS.Tables[1].Rows.Count - 1]["Code"]) + 10).ToString();
            txt_code.Enabled = false;
        }
    }
}
