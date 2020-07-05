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
        private BindingSource _bindProject;

        public ProjectForm()
        {
            InitializeComponent();

            this.Name = "ProjectForm";

            _woodProjectsList = new List<WoodProject>();

            _woodProjectsList.Add(new WoodProject("WOOD", "PINE", 1, new WoodProjectCost(3, 6, 7, 8)));
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            bindControls();
        }

        /// <summary>
        /// Changing the wood cost causes a crazy error 
        /// </summary>
        public void bindControls()
        {
            _bindProject = new BindingSource();
            _bindProject.DataSource = _woodProjectsList;

            this.dgvProjects.DataSource = _bindProject;
            this.dgvProjects.Columns[3].ReadOnly = true;
            this.cboProjects.DataSource = _bindProject;

            cboProjects.DisplayMember = "Name";
            cboProjects.ValueMember = "ProjectNumber";
            
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                string Name = txtName.Text;
                string Description = txtDescription.Text;
                int ProjectNumber = int.Parse(txtNumber.Text);

                int materialCost = int.Parse(txtMaterialCost.Text);
                int labourCost = int.Parse(txtLabourCost.Text);
                int finishCost = int.Parse(txtFinishCost.Text);
                int deliveryCost = int.Parse(txtDeliveryCost.Text);

                string comments = txtComments.Text;

                _woodProjectsList.Add(new WoodProject(Name, Description, ProjectNumber, new WoodProjectCost(materialCost,labourCost,finishCost, deliveryCost), comments));

                _bindProject.CurrencyManager.Refresh();
                bindControls();
                clear();
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
                errorProvider.SetError(txtName,"Name is required!");
            }

            if(txtNumber.Text == string.Empty)
            {
                valid = false;
                errorProvider.SetError(txtNumber, "Project Number is required!");
            }

            if(!Decimal.TryParse(txtNumber.Text, out result))
            {
                errorProvider.SetError(txtNumber, "A Project Number is required!");
            }
            if (!Decimal.TryParse(txtMaterialCost.Text, out result))
            {
                errorProvider.SetError(txtMaterialCost, "A Material Cost is required!");
            }
            if (!Decimal.TryParse(txtLabourCost.Text, out result))
            {
                errorProvider.SetError(txtLabourCost, "A Labour Cost is required!");
            }
            if (!Decimal.TryParse(txtFinishCost.Text, out result))
            {
                errorProvider.SetError(txtFinishCost, "A Finish Cost is required!");
            }
            if (!Decimal.TryParse(txtDeliveryCost.Text, out result))
            {
                errorProvider.SetError(txtDeliveryCost, "A Delivery Cost is required!");
            }

            return valid;
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
            txtMaterialCost.Clear();
            txtLabourCost.Clear();
            txtFinishCost.Clear();
            txtDeliveryCost.Clear();
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
        /// The save feature
        /// </summary>
        private void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            saveFileDialog.Filter = "XML-File | *.xml";

            string path = saveFileDialog.FileName;

            //Fix this... Not a good way of saving to a xml format
            using (Stream stream = new FileStream(path + ".xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<WoodProject>));
                serializer.Serialize(stream, _woodProjectsList);
                stream.Close();
            }
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

                bindControls();

            }
        }
        
        /// <summary>
        /// Clears out all of the data in the Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearData_Click(object sender, EventArgs e)
        {
            if (_woodProjectsList.Count > 0)
            {
                _woodProjectsList.Clear();
                cboProjects.SelectedItem = null;
                lblProjectNumberValue.Text = null;
                bindControls();
            }

        }

        /// <summary>
        /// Clears the currently selected row or row of slected cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            _woodProjectsList.RemoveAt(dgvProjects.CurrentRow.Index);
            bindControls();
        }

        private void dgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            int currentIndex =  int.Parse(cboProjects.SelectedIndex.ToString()) + 1;
            lblProjectNumberValue.Text = currentIndex.ToString();
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

        private void aaaaaaaa(object sender, EventArgs e)
        {

        }
    }
}
