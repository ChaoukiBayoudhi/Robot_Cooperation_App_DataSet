namespace RoboCoop
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rch_description = new System.Windows.Forms.RichTextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rch_description);
            this.groupBox1.Controls.Add(this.cmb_status);
            this.groupBox1.Controls.Add(this.txt_duration);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(405, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les informations d\'une tache";
            // 
            // rch_description
            // 
            this.rch_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_description.Location = new System.Drawing.Point(131, 158);
            this.rch_description.Margin = new System.Windows.Forms.Padding(2);
            this.rch_description.Name = "rch_description";
            this.rch_description.Size = new System.Drawing.Size(217, 102);
            this.rch_description.TabIndex = 12;
            this.rch_description.Text = "";
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "waiting",
            "canceled",
            "working on",
            "other"});
            this.cmb_status.Location = new System.Drawing.Point(131, 124);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(217, 26);
            this.cmb_status.TabIndex = 9;
            // 
            // txt_duration
            // 
            this.txt_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_duration.Location = new System.Drawing.Point(131, 93);
            this.txt_duration.Margin = new System.Windows.Forms.Padding(2);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(217, 24);
            this.txt_duration.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(131, 63);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(217, 24);
            this.txt_name.TabIndex = 6;
            // 
            // txt_code
            // 
            this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_code.Location = new System.Drawing.Point(131, 31);
            this.txt_code.Margin = new System.Windows.Forms.Padding(2);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(217, 24);
            this.txt_code.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Etat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(439, 125);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(93, 47);
            this.bt_cancel.TabIndex = 11;
            this.bt_cancel.Text = "Annuler";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(439, 36);
            this.bt_add.Margin = new System.Windows.Forms.Padding(2);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(93, 47);
            this.bt_add.TabIndex = 10;
            this.bt_add.Text = "Ajouter";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_add);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTask";
            this.Text = "Ajouter une nouvelle tache";
            this.Load += new System.EventHandler(this.AddTask_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rch_description;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}