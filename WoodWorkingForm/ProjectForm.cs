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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WoodWorkingForm
{
    public partial class ProjectForm : Form
    {
        public List<WoodProject> _woodProjectsList;
        public List<WoodItemCost> _woodItemCostsList;
        public BindingSource _bindProject;
        public BindingSource _bindCost;

        public ProjectForm()
        {
            InitializeComponent();

            this.Name = "ProjectForm";

            bindControls();

            _woodProjectsList = new List<WoodProject>();
            _woodItemCostsList = new List<WoodItemCost>();

            _bindProject = new BindingSource();
            _bindProject.DataSource = _woodProjectsList;

            _bindCost = new BindingSource();
            _bindCost.DataSource = _woodItemCostsList;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            
        }

        
        /// <summary>
        /// A click event for if the exit tool strip item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// A click event for if the add button ic clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                string Name = txtName.Text;
                string Description = txtDescription.Text;
                int ProjectNumber = int.Parse(txtNumber.Text);
                string comments = txtComments.Text;
                List<WoodItemCost> temp = new List<WoodItemCost>();
                
                WoodProject tempProject = new WoodProject(Name, Description, ProjectNumber, temp, comments);

                // Add each item from the Cost list into the Object List
                foreach (var item in _woodItemCostsList)
                {
                    tempProject.AddWoodItemCost(item);
                }

                // Add the new project to the List
                _woodProjectsList.Add(tempProject);
                _bindProject.CurrencyManager.Refresh();
                _bindCost.Clear();
                clear();
   
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        /// <summary>
        /// Clear the form
        /// </summary>
        private void clear()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtNumber.Clear();
            txtComments.Clear();
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Serialize();            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Deserialize();
        }

        
        /// <summary>
        /// Clears out all of the data in the Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearData_Click(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Clears the currently selected row or row of slected cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSelected_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            this.dgvProjectsCost.DataSource = _woodProjectsList[dgvProjects.CurrentCell.RowIndex].WoodItemCosts;
        }


        /// <summary>
        /// Validation 
        /// Need to be improved , can be bettter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProjects_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                int i;
                Control edit = dgvProjects.EditingControl;
                if (!int.TryParse(Convert.ToString(edit), out i))
                {
                    e.Cancel = true;
                    errorProvider.SetError(edit, "Please Enter A Number!");
                    errorProvider.SetIconAlignment(edit, ErrorIconAlignment.MiddleRight);
                    errorProvider.SetIconPadding(edit, - 20); 
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            if(e.ColumnIndex == 0 || e.ColumnIndex == 1 )
            {
                Control edit = dgvProjects.EditingControl;
                if(e.FormattedValue == string.Empty)
                {
                    e.Cancel = true;
                    errorProvider.SetError(edit, "Please dont leave it blank");
                    errorProvider.SetIconAlignment(edit, ErrorIconAlignment.MiddleRight);
                    errorProvider.SetIconPadding(edit, -20);
                }
                else
                {
                    errorProvider.Clear();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearExpense_Click(object sender, EventArgs e)
        {
            clearExpenses();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddExpense_Click(object sender, EventArgs e)
        {

            AddExpense();
        }

        //--------------------------------------------------------------
        
        /// <summary>
        /// 
        /// </summary>
        public void bindControls()
        {
            dgvProjects.DataSource = _bindProject;
            dgvWoodItemCosts.DataSource = _bindCost;
            cboProjects.DataSource = _bindProject;

            cboProjects.DisplayMember = "Name";
            cboProjects.ValueMember = "ProjectNumber";

        }

        /// <summary>
        /// 
        /// </summary>
        private void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<WoodProject>));
                serializer.Serialize(stream, _woodProjectsList);
                stream.Close();
            }
        }

        /// <summary>
        /// The Load feature  
        /// </summary>
        public void Deserialize()
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.ShowDialog();

            string path = fb.FileName;

            using (FileStream fileStream = File.OpenRead(path))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<WoodProject>));
                List<WoodProject> tempList = null;
                tempList = (List<WoodProject>)deserializer.Deserialize(fileStream);
                fileStream.Close();

                _woodProjectsList = tempList;
                _bindProject.DataSource = _woodProjectsList;

                bindControls();

            }
        }


        /// <summary>
        /// Validates the name, desription and project number 
        /// </summary>
        /// <returns> A bool value base on if the information provided is valid or not</returns>
        public bool isValid()
        {
            bool valid = true;
            decimal result;

            if (txtName.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(txtName, "Name is required!");
            }

            if (txtNumber.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(txtNumber, "Project Number is required!");
            }

            if (!Decimal.TryParse(txtNumber.Text, out result))
            {
                errorProvider.SetError(txtNumber, "A Project Number is required!");
            }

            return valid;
        }

        /// <summary>
        /// 
        /// </summary>
        private void clearExpenses()
        {
            txtExpenseName.Clear();
            txtExpenseDescription.Clear();
            txtExpenseCost.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddExpense()
        {
            string name = txtExpenseName.Text;
            string description = txtExpenseDescription.Text;
            int cost = int.Parse(txtExpenseCost.Text);

            WoodItemCost tempItem = new WoodItemCost(name, description, cost);


            _woodItemCostsList.Add(tempItem);

            _bindCost.CurrencyManager.Refresh();
            _bindProject.CurrencyManager.Refresh();
            bindControls();
            clearExpenses();
        }


    }
}
