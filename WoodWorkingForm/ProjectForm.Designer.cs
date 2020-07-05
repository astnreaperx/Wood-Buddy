namespace WoodWorkingForm
{
    partial class ProjectForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.grpProjectData = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.cboProjects = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpProjectCost = new System.Windows.Forms.GroupBox();
            this.txtLabourCost = new System.Windows.Forms.TextBox();
            this.txtFinishCost = new System.Windows.Forms.TextBox();
            this.txtDeliveryCost = new System.Windows.Forms.TextBox();
            this.txtMaterialCost = new System.Windows.Forms.TextBox();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.lblFinsishCost = new System.Windows.Forms.Label();
            this.lblLabourCost = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblProjectNumberValue = new System.Windows.Forms.Label();
            this.btnClearData = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.grpComments = new System.Windows.Forms.GroupBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpProjectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.grpProjectCost.SuspendLayout();
            this.grpComments.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 35);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Project Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 66);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(4, 150);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(83, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Project Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(91, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.Location = new System.Drawing.Point(92, 63);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(91, 72);
            this.txtDescription.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(92, 148);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(91, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // grpProjectData
            // 
            this.grpProjectData.Controls.Add(this.txtNumber);
            this.grpProjectData.Controls.Add(this.txtDescription);
            this.grpProjectData.Controls.Add(this.txtName);
            this.grpProjectData.Controls.Add(this.lblNumber);
            this.grpProjectData.Controls.Add(this.lblDescription);
            this.grpProjectData.Controls.Add(this.lblName);
            this.grpProjectData.Location = new System.Drawing.Point(20, 40);
            this.grpProjectData.Margin = new System.Windows.Forms.Padding(2);
            this.grpProjectData.Name = "grpProjectData";
            this.grpProjectData.Padding = new System.Windows.Forms.Padding(2);
            this.grpProjectData.Size = new System.Drawing.Size(200, 187);
            this.grpProjectData.TabIndex = 1;
            this.grpProjectData.TabStop = false;
            this.grpProjectData.Text = "Project";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(104, 27);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 19);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToResizeColumns = false;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(236, 75);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(553, 317);
            this.dgvProjects.TabIndex = 7;
            this.dgvProjects.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvProjects_CellValidating);
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
            // 
            // cboProjects
            // 
            this.cboProjects.FormattingEnabled = true;
            this.cboProjects.Location = new System.Drawing.Point(278, 40);
            this.cboProjects.Margin = new System.Windows.Forms.Padding(2);
            this.cboProjects.Name = "cboProjects";
            this.cboProjects.Size = new System.Drawing.Size(92, 21);
            this.cboProjects.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 440);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(442, 416);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 19);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // grpProjectCost
            // 
            this.grpProjectCost.Controls.Add(this.txtLabourCost);
            this.grpProjectCost.Controls.Add(this.txtFinishCost);
            this.grpProjectCost.Controls.Add(this.txtDeliveryCost);
            this.grpProjectCost.Controls.Add(this.txtMaterialCost);
            this.grpProjectCost.Controls.Add(this.lblDeliveryCost);
            this.grpProjectCost.Controls.Add(this.lblFinsishCost);
            this.grpProjectCost.Controls.Add(this.lblLabourCost);
            this.grpProjectCost.Controls.Add(this.lblMaterialCost);
            this.grpProjectCost.Location = new System.Drawing.Point(20, 248);
            this.grpProjectCost.Margin = new System.Windows.Forms.Padding(2);
            this.grpProjectCost.Name = "grpProjectCost";
            this.grpProjectCost.Padding = new System.Windows.Forms.Padding(2);
            this.grpProjectCost.Size = new System.Drawing.Size(200, 136);
            this.grpProjectCost.TabIndex = 2;
            this.grpProjectCost.TabStop = false;
            this.grpProjectCost.Text = "Project Costs";
            // 
            // txtLabourCost
            // 
            this.txtLabourCost.Location = new System.Drawing.Point(94, 53);
            this.txtLabourCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabourCost.Name = "txtLabourCost";
            this.txtLabourCost.Size = new System.Drawing.Size(89, 20);
            this.txtLabourCost.TabIndex = 3;
            // 
            // txtFinishCost
            // 
            this.txtFinishCost.Location = new System.Drawing.Point(94, 76);
            this.txtFinishCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtFinishCost.Name = "txtFinishCost";
            this.txtFinishCost.Size = new System.Drawing.Size(89, 20);
            this.txtFinishCost.TabIndex = 5;
            // 
            // txtDeliveryCost
            // 
            this.txtDeliveryCost.Location = new System.Drawing.Point(94, 98);
            this.txtDeliveryCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtDeliveryCost.Name = "txtDeliveryCost";
            this.txtDeliveryCost.Size = new System.Drawing.Size(89, 20);
            this.txtDeliveryCost.TabIndex = 7;
            // 
            // txtMaterialCost
            // 
            this.txtMaterialCost.Location = new System.Drawing.Point(94, 30);
            this.txtMaterialCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterialCost.Name = "txtMaterialCost";
            this.txtMaterialCost.Size = new System.Drawing.Size(89, 20);
            this.txtMaterialCost.TabIndex = 1;
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Location = new System.Drawing.Point(18, 101);
            this.lblDeliveryCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(72, 13);
            this.lblDeliveryCost.TabIndex = 6;
            this.lblDeliveryCost.Text = "Delivery Cost:";
            // 
            // lblFinsishCost
            // 
            this.lblFinsishCost.AutoSize = true;
            this.lblFinsishCost.Location = new System.Drawing.Point(28, 78);
            this.lblFinsishCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinsishCost.Name = "lblFinsishCost";
            this.lblFinsishCost.Size = new System.Drawing.Size(61, 13);
            this.lblFinsishCost.TabIndex = 4;
            this.lblFinsishCost.Text = "Finsih Cost:";
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.AutoSize = true;
            this.lblLabourCost.Location = new System.Drawing.Point(22, 55);
            this.lblLabourCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Size = new System.Drawing.Size(67, 13);
            this.lblLabourCost.TabIndex = 2;
            this.lblLabourCost.Text = "Labour Cost:";
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.AutoSize = true;
            this.lblMaterialCost.Location = new System.Drawing.Point(19, 32);
            this.lblMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Size = new System.Drawing.Size(71, 13);
            this.lblMaterialCost.TabIndex = 0;
            this.lblMaterialCost.Text = "Material Cost:";
            // 
            // lblProjectNumberValue
            // 
            this.lblProjectNumberValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProjectNumberValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProjectNumberValue.Location = new System.Drawing.Point(400, 40);
            this.lblProjectNumberValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectNumberValue.Name = "lblProjectNumberValue";
            this.lblProjectNumberValue.Size = new System.Drawing.Size(45, 20);
            this.lblProjectNumberValue.TabIndex = 6;
            this.lblProjectNumberValue.Text = " ";
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(511, 440);
            this.btnClearData.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(87, 19);
            this.btnClearData.TabIndex = 11;
            this.btnClearData.Text = "Clear All Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(17, 19);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(166, 64);
            this.txtComments.TabIndex = 0;
            // 
            // grpComments
            // 
            this.grpComments.Controls.Add(this.txtComments);
            this.grpComments.Location = new System.Drawing.Point(20, 397);
            this.grpComments.Name = "grpComments";
            this.grpComments.Size = new System.Drawing.Size(199, 97);
            this.grpComments.TabIndex = 3;
            this.grpComments.TabStop = false;
            this.grpComments.Text = "Comments";
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Controls.Add(this.btnAdd);
            this.grpButtons.Location = new System.Drawing.Point(21, 513);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(198, 61);
            this.grpButtons.TabIndex = 4;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Add to List";
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(511, 415);
            this.btnClearSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(87, 19);
            this.btnClearSelected.TabIndex = 9;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.grpComments);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.lblProjectNumberValue);
            this.Controls.Add(this.grpProjectCost);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboProjects);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.grpProjectData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.aaaaaaaa);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProjectData.ResumeLayout(false);
            this.grpProjectData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.grpProjectCost.ResumeLayout(false);
            this.grpProjectCost.PerformLayout();
            this.grpComments.ResumeLayout(false);
            this.grpComments.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox grpProjectData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.ComboBox cboProjects;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox grpProjectCost;
        private System.Windows.Forms.TextBox txtLabourCost;
        private System.Windows.Forms.TextBox txtFinishCost;
        private System.Windows.Forms.TextBox txtDeliveryCost;
        private System.Windows.Forms.TextBox txtMaterialCost;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.Label lblFinsishCost;
        private System.Windows.Forms.Label lblLabourCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Button btnClearData;
        public System.Windows.Forms.Label lblProjectNumberValue;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpComments;
        private System.Windows.Forms.Button btnClearSelected;
    }
}