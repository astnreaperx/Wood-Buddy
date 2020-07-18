using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;

namespace WoodWorkingForm
{
    internal partial class ProjectListForm : Form
    {

        public List<WoodProject> _woodProjectsList;
        public BindingSource source;

        public ProjectListForm()
        {
            InitializeComponent();

            this.Name = "Edit Project";
            bindControls();
        }


        /// <summary>
        /// A Method for databinding the combobox for the form
        /// </summary>
        public void bindControls()
        {
            source = new BindingSource();
            source.DataSource = _woodProjectsList;
            cboProjectList.DataSource = source;

            cboProjectList.DisplayMember = ("Name");
        }

        /// <summary>
        /// A event handler for when the combobox selection has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = ((WoodProject)cboProjectList.SelectedItem).Name;
            txtDescription.Text = ((WoodProject)cboProjectList.SelectedItem).Description;
            txtProjectNumber.Text = ((WoodProject)cboProjectList.SelectedItem).ProjectNumber.ToString();

            // Add DGV for Wood Item Costs

            txtComments.Text = ((WoodProject)cboProjectList.SelectedItem).Comments;

            dgvProjectCost.DataSource = ((WoodProject)cboProjectList.SelectedItem).WoodItemCosts;
        }

        /// <summary>
        /// A event handler for when the update button is clicked
        /// it assings the current object on the combobox to the corresponding textbox field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboProjectList.SelectedIndex;

            _woodProjectsList[selectedIndex].Name = txtName.Text;       
            _woodProjectsList[selectedIndex].Description = txtDescription.Text;       
            _woodProjectsList[selectedIndex].ProjectNumber = int.Parse(txtProjectNumber.Text);

            // Add DGV for Wood Item Costs

            _woodProjectsList[selectedIndex].Comments = txtComments.Text;
            List<WoodItemCost> list = dgvProjectCost.DataSource as List<WoodItemCost>;
            _woodProjectsList[selectedIndex].WoodItemCosts = list;

            source.CurrencyManager.Refresh();
        }

        /// <summary>
        /// A Event for when the save button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Serialize();
        }

        /// <summary>
        /// A Method for Serializing a lost of wood projects to xml format
        /// in a specific file location
        /// </summary>
        private void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            //Fix this... Not a good way of saving to a xml format
            using (Stream stream = new FileStream(path , FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<WoodProject>));
                serializer.Serialize(stream, _woodProjectsList);
                stream.Close();
            }
        }

        /// <summary>
        /// A method for deserializing the data from xml format
        /// from a specific file location.
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
        /// A event handler for when the load button os clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Deserialize();
        }
    }
}
