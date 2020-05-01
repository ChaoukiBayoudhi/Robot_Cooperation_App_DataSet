using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboCoop
{
    public partial class Form1 : Form
    {
        internal static DataSet DS = new DataSet();//n'est pas une base de données locale
                                                    //DS est un objet un peu specifique
                                                    //peut simuler la structure d'une base de données
                                                    //cet objet continent de tables(gérées par la classe DataTable),
                                                    //de views (géerées par la classe DataView)
                                                    //....
        internal static SqlDataAdapter DA;//sert à executer les commandes SQL sur la base de données,
                                           //remplir le dataset avec les resultats des select via la methode Fill (sans contraintes) ou bien 
                                           //FillSchema (tout le schema relationnel)
        private String ConnectionStr;
        private SqlConnection conx; //on etablit la connexion une seule fois pour recuperer les données
                                    //et les stocker dans un  objet local qui est le DataSet
        
        public Form1()
        {
            InitializeComponent();
            //step 1 create the Connection object
            ConnectionStr= @"Data Source=DESKTOP-7J9ODH9;Initial Catalog=RobotDB6;Integrated Security=True;Pooling=False";
            conx = new SqlConnection(ConnectionStr);
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTask f1 = new AddTask();
            f1.MdiParent = this; //pour faire le lien avec la fenêtre conteneur
            f1.Show();
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListOfTasksForm l1 = new ListOfTasksForm();
            l1.MdiParent = this; //pour faire le lien avec la fenêtre conteneur
            l1.Show();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteOrModifyTask d1 = new DeleteOrModifyTask("Modify");
            d1.MdiParent = this;
            d1.Show();
        }

        private void suppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteOrModifyTask d1 = new DeleteOrModifyTask("Delete");
            d1.MdiParent = this;
            d1.Show();
        }

        private void nombreDeTachesParRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskPerRobot tp = new TaskPerRobot();
            tp.MdiParent = this;
            tp.Show();
        }

        private void participationDesRobotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RobotParticipation frp = new RobotParticipation();
            frp.MdiParent = this;
            frp.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (res == DialogResult.No);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                DS.Clear();
                DA = new SqlDataAdapter("select * from Robot;select * from Task;select * from TaskRobot", conx);

               
                DA.TableMappings.Add("Robot", "RobotTab");
                DA.TableMappings.Add("Task", "TaskTab");
                DA.TableMappings.Add("TaskRobot", "TaskRobotTab");
                DA.Fill(DS); //le chargement du DataSet

                int nbTables = DS.Tables.Count;
                
                //Give Names for tables
                DS.Tables[0].TableName = "RobotTab";
                DS.Tables[1].TableName = "TaskTab";
                DS.Tables[2].TableName = "TaskRobotTab";
               /* DS.Tables[0].Columns[0].DataType = System.Type.GetType("System.Int32");
                DS.Tables[0].Columns[1].DataType = System.Type.GetType("System.String");
                DS.Tables[0].Columns[2].DataType = System.Type.GetType("System.Decimal");
                DS.Tables[0].Columns[3].DataType = System.Type.GetType("System.String");
                */
                // int nbrows = DS.Tables[0].Rows.Count;//  ceci est equivalent à select count(*) from Robot en SQL

                /*int indexLastLine = DS.Tables[0].Rows.Count - 1;//index of the last line
                DS.Tables[0].Rows[indexLastLine]["Id"]
                */

                //Set Auto-Incriment Priamry key column for the Robot Table
                DS.Tables[0].Columns["Id"].AllowDBNull = false;
                DS.Tables[0].Columns["Id"].AutoIncrement = true;//precise si la colonne est automatiquement 
                if (DS.Tables[0].Rows.Count == 0)
                    DS.Tables[0].Columns["Id"].AutoIncrementSeed = 10;
                else
                    DS.Tables[0].Columns["Id"].AutoIncrementSeed = Convert.ToInt64(DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Id"]) + 10;
                DS.Tables[0].Columns["Id"].AutoIncrementStep = 10;//l'increment à ajouter lors de chaque ajout

                //Set Auto-Incriment Priamry key column for the Task table
                DS.Tables[1].Columns["Code"].AllowDBNull = false;
                DS.Tables[1].Columns["Code"].AutoIncrement = true;//precise si la colonne est automatiquement 
                if (DS.Tables[1].Rows.Count == 0)
                    DS.Tables[1].Columns["Code"].AutoIncrementSeed = 10;
                else
                    DS.Tables[1].Columns["Code"].AutoIncrementSeed = Convert.ToInt64(DS.Tables[1].Rows[DS.Tables[1].Rows.Count - 1]["Code"]) + 10;
                DS.Tables[1].Columns["Code"].AutoIncrementStep = 10;//l'increment à ajouter lors de chaque ajout


                //set primary key for the added DtaTable
                DS.Tables[0].PrimaryKey = new DataColumn[] { DS.Tables[0].Columns["Id"] };
                DS.Tables[1].PrimaryKey = new DataColumn[] { DS.Tables[1].Columns["Code"] };
                DS.Tables[2].PrimaryKey = new DataColumn[] { DS.Tables[2].Columns["IdRobot"], DS.Tables[2].Columns["CodeTask"] };





                //To set Foreign keys for TaskRobot you should do

                ForeignKeyConstraint RobotTask_RobtFK = new ForeignKeyConstraint
               ("RobotTask_To_Robot_FK",
                DS.Tables[0].Columns["Id"],
                DS.Tables[2].Columns["IdRobot"]);
                RobotTask_RobtFK.DeleteRule = Rule.None;
                // if "Rule.Cascade" Cannot delete value that has associated existing Module.  
                DS.Tables["TaskRobotTab"].Constraints.Add(RobotTask_RobtFK);

                ForeignKeyConstraint RobotTask_TaskFK = new ForeignKeyConstraint
               ("RobotTask_To_Task_FK",
                DS.Tables[1].Columns["Code"],
                DS.Tables[2].Columns["CodeTask"]);
                RobotTask_TaskFK.DeleteRule = Rule.None;
                // if "Rule.Cascade" Cannot delete value that has associated existing Module.  
                DS.Tables["TaskRobotTab"].Constraints.Add(RobotTask_TaskFK);

                MessageBox.Show("Données chargées dans le DataSet Local");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
