namespace ITPM_Project
{
    partial class ManageLocations
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
            this.Updatebtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Managebuilding = new MetroFramework.Controls.MetroTextBox();
            this.Manageroom = new MetroFramework.Controls.MetroTextBox();
            this.Managelecture = new MetroFramework.Controls.MetroRadioButton();
            this.Managelab = new MetroFramework.Controls.MetroRadioButton();
            this.Managecapacity = new MetroFramework.Controls.MetroTextBox();
            this.Deletebtn = new MetroFramework.Controls.MetroTile();
            this.Cancelbtn = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.Locationtable = new System.Windows.Forms.DataGridView();
            this.buildingnamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtyperadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitycol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Locationtable)).BeginInit();
            this.SuspendLayout();
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(137, 410);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(94, 37);
            this.Updatebtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.Updatebtn.TabIndex = 0;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Updatebtn.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(17, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Building Name";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(55, 226);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Room Name";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(55, 281);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Room Type";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(55, 338);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Capacity";
            this.metroLabel4.UseStyleColors = true;
            // 
            // Managebuilding
            // 
            this.Managebuilding.Location = new System.Drawing.Point(185, 161);
            this.Managebuilding.Name = "Managebuilding";
            this.Managebuilding.Size = new System.Drawing.Size(281, 23);
            this.Managebuilding.TabIndex = 1;
            // 
            // Manageroom
            // 
            this.Manageroom.Location = new System.Drawing.Point(185, 226);
            this.Manageroom.Name = "Manageroom";
            this.Manageroom.Size = new System.Drawing.Size(281, 23);
            this.Manageroom.TabIndex = 2;
            // 
            // Managelecture
            // 
            this.Managelecture.AutoSize = true;
            this.Managelecture.BackColor = System.Drawing.Color.Aqua;
            this.Managelecture.Location = new System.Drawing.Point(185, 285);
            this.Managelecture.Name = "Managelecture";
            this.Managelecture.Size = new System.Drawing.Size(86, 15);
            this.Managelecture.TabIndex = 3;
            this.Managelecture.TabStop = true;
            this.Managelecture.Text = "Lecture Hall";
            this.Managelecture.UseVisualStyleBackColor = false;
            // 
            // Managelab
            // 
            this.Managelab.AutoSize = true;
            this.Managelab.BackColor = System.Drawing.Color.Aqua;
            this.Managelab.Location = new System.Drawing.Point(350, 285);
            this.Managelab.Name = "Managelab";
            this.Managelab.Size = new System.Drawing.Size(80, 15);
            this.Managelab.TabIndex = 4;
            this.Managelab.TabStop = true;
            this.Managelab.Text = "Laboratory";
            this.Managelab.UseVisualStyleBackColor = false;
            // 
            // Managecapacity
            // 
            this.Managecapacity.Location = new System.Drawing.Point(185, 334);
            this.Managecapacity.Name = "Managecapacity";
            this.Managecapacity.Size = new System.Drawing.Size(281, 23);
            this.Managecapacity.TabIndex = 5;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(256, 410);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(94, 37);
            this.Deletebtn.Style = MetroFramework.MetroColorStyle.Red;
            this.Deletebtn.TabIndex = 6;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(372, 410);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(94, 37);
            this.Cancelbtn.Style = MetroFramework.MetroColorStyle.Silver;
            this.Cancelbtn.TabIndex = 7;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(38, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 366);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Controls.Add(this.metroTabPage7);
            this.metroTabControl1.Location = new System.Drawing.Point(114, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(806, 40);
            this.metroTabControl1.TabIndex = 9;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(798, 1);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "metroTabPage3";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "metroTabPage5";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "metroTabPage6";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(880, 1);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "metroTabPage7";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            // 
            // Locationtable
            // 
            this.Locationtable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Locationtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Locationtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingnamecol,
            this.roomnamecol,
            this.roomtyperadio,
            this.capacitycol});
            this.Locationtable.Location = new System.Drawing.Point(517, 142);
            this.Locationtable.Name = "Locationtable";
            this.Locationtable.Size = new System.Drawing.Size(443, 305);
            this.Locationtable.TabIndex = 10;
            // 
            // buildingnamecol
            // 
            this.buildingnamecol.HeaderText = "Building Name";
            this.buildingnamecol.Name = "buildingnamecol";
            // 
            // roomnamecol
            // 
            this.roomnamecol.HeaderText = "Room Name";
            this.roomnamecol.Name = "roomnamecol";
            // 
            // roomtyperadio
            // 
            this.roomtyperadio.HeaderText = "Room Type";
            this.roomtyperadio.Name = "roomtyperadio";
            // 
            // capacitycol
            // 
            this.capacitycol.HeaderText = "Capacity";
            this.capacitycol.Name = "capacitycol";
            // 
            // ManageLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 520);
            this.Controls.Add(this.Locationtable);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Managelecture);
            this.Controls.Add(this.Managelab);
            this.Controls.Add(this.Managecapacity);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Managebuilding);
            this.Controls.Add(this.Manageroom);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageLocations";
            this.Text = "Manage Locations";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Locationtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Updatebtn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Managecapacity;
        private MetroFramework.Controls.MetroRadioButton Managelab;
        private MetroFramework.Controls.MetroTextBox Manageroom;
        private MetroFramework.Controls.MetroTextBox Managebuilding;
        private MetroFramework.Controls.MetroRadioButton Managelecture;
        private MetroFramework.Controls.MetroTile Deletebtn;
        private MetroFramework.Controls.MetroTile Cancelbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private System.Windows.Forms.DataGridView Locationtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingnamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtyperadio;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacitycol;
    }
}