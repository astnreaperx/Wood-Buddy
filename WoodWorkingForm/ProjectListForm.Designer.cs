namespace WoodWorkingForm
{
    partial class ProjectListForm
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboProjectList = new System.Windows.Forms.ComboBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblProjectNumber = new System.Windows.Forms.Label();
            this.txtProjectNumber = new System.Windows.Forms.TextBox();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblLabourCost = new System.Windows.Forms.Label();
            this.txtLabourCost = new System.Windows.Forms.TextBox();
            this.lblFinsihCost = new System.Windows.Forms.Label();
            this.txtFinishCost = new System.Windows.Forms.TextBox();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.txtDeliveryCost = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(350, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLoad,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tsiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsiLoad
            // 
            this.tsiLoad.Name = "tsiLoad";
            this.tsiLoad.Size = new System.Drawing.Size(100, 22);
            this.tsiLoad.Text = "&Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 6);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(100, 22);
            this.tsiExit.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cboProjectList
            // 
            this.cboProjectList.FormattingEnabled = true;
            this.cboProjectList.Location = new System.Drawing.Point(28, 47);
            this.cboProjectList.Margin = new System.Windows.Forms.Padding(2);
            this.cboProjectList.Name = "cboProjectList";
            this.cboProjectList.Size = new System.Drawing.Size(296, 21);
            this.cboProjectList.TabIndex = 1;
            this.cboProjectList.SelectedIndexChanged += new System.EventHandler(this.cboProjectList_SelectedIndexChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(63, 99);
            this.lblProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(38, 13);
            this.lblProjectName.TabIndex = 2;
            this.lblProjectName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 97);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(38, 122);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.AcceptsTab = true;
            this.txtDescription.AllowDrop = true;
            this.txtDescription.Location = new System.Drawing.Point(104, 119);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 93);
            this.txtDescription.TabIndex = 5;
            // 
            // lblProjectNumber
            // 
            this.lblProjectNumber.AutoSize = true;
            this.lblProjectNumber.Location = new System.Drawing.Point(17, 219);
            this.lblProjectNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectNumber.Name = "lblProjectNumber";
            this.lblProjectNumber.Size = new System.Drawing.Size(83, 13);
            this.lblProjectNumber.TabIndex = 6;
            this.lblProjectNumber.Text = "Project Number:";
            // 
            // txtProjectNumber
            // 
            this.txtProjectNumber.Location = new System.Drawing.Point(104, 217);
            this.txtProjectNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectNumber.Name = "txtProjectNumber";
            this.txtProjectNumber.Size = new System.Drawing.Size(220, 20);
            this.txtProjectNumber.TabIndex = 7;
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.Location = new System.Drawing.Point(104, 269);
            this.txtMaterialCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.Size = new System.Drawing.Size(121, 20);
            this.txtMaterialCost.TabIndex = 9;
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.AutoSize = true;
            this.lblMaterialCost.Location = new System.Drawing.Point(29, 271);
            this.lblMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Size = new System.Drawing.Size(71, 13);
            this.lblMaterialCost.TabIndex = 8;
            this.lblMaterialCost.Text = "Material Cost:";
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.AutoSize = true;
            this.lblLabourCost.Location = new System.Drawing.Point(33, 294);
            this.lblLabourCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Size = new System.Drawing.Size(67, 13);
            this.lblLabourCost.TabIndex = 10;
            this.lblLabourCost.Text = "Labour Cost:";
            // 
            // txtLabourCost
            // 
            this.txtLabourCost.Location = new System.Drawing.Point(104, 292);
            this.txtLabourCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabourCost.Name = "txtLabourCost";
            this.txtLabourCost.Size = new System.Drawing.Size(121, 20);
            this.txtLabourCost.TabIndex = 11;
            // 
            // lblFinsihCost
            // 
            this.lblFinsihCost.AutoSize = true;
            this.lblFinsihCost.Location = new System.Drawing.Point(39, 317);
            this.lblFinsihCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinsihCost.Name = "lblFinsihCost";
            this.lblFinsihCost.Size = new System.Drawing.Size(61, 13);
            this.lblFinsihCost.TabIndex = 12;
            this.lblFinsihCost.Text = "Finish Cost:";
            // 
            // txtFinishCost
            // 
            this.txtFinishCost.Location = new System.Drawing.Point(104, 314);
            this.txtFinishCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtFinishCost.Name = "txtFinishCost";
            this.txtFinishCost.Size = new System.Drawing.Size(121, 20);
            this.txtFinishCost.TabIndex = 13;
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Location = new System.Drawing.Point(28, 341);
            this.lblDeliveryCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryCost.TabIndex = 14;
            this.lblDeliveryCost.Text = "Delivery Cost:";
            // 
            // txtDeliveryCost
            // 
            this.txtDeliveryCost.Location = new System.Drawing.Point(104, 337);
            this.txtDeliveryCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryCost.Name = "txtDeliveryCost";
            this.txtDeliveryCost.Size = new System.Drawing.Size(121, 20);
            this.txtDeliveryCost.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(117, 502);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(60, 20);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 502);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 20);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(41, 526);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(60, 20);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(28, 388);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(296, 88);
            this.txtComments.TabIndex = 16;
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 557);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDeliveryCost);
            this.Controls.Add(this.lblDeliveryCost);
            this.Controls.Add(this.txtFinishCost);
            this.Controls.Add(this.lblFinsihCost);
            this.Controls.Add(this.txtLabourCost);
            this.Controls.Add(this.lblLabourCost);
            this.Controls.Add(this.lblMaterialCost);
            this.Controls.Add(this.txtMaterialCost);
            this.Controls.Add(this.txtProjectNumber);
            this.Controls.Add(this.lblProjectNumber);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.cboProjectList);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectListForm";
            this.Text = "Edit Project List";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboProjectList;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblProjectNumber;
        private System.Windows.Forms.TextBox txtProjectNumber;
        private System.Windows.Forms.TextBox txtMaterialCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblLabourCost;
        private System.Windows.Forms.TextBox txtLabourCost;
        private System.Windows.Forms.Label lblFinsihCost;
        private System.Windows.Forms.TextBox txtFinishCost;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.TextBox txtDeliveryCost;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolStripMenuItem tsiLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox txtComments;
    }
}