using Menu;
using System;
using System.Collections.Specialized;
using System.Media;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using NAudio.Wave;
namespace Project
{

    public partial class MainForm : Form
    {
        public Branches? branchesList { get; set; }
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;
        public MainForm()
        {
            branchesList = new Branches();
            InitializeComponent();
            updateSelectedBranch();
            //branchLabel.Text = "None";
        }


        private void updateSelectedBranch()
        {
            if (branchesList != null && branchesList.branchesListIndex >= 0)
            {
                branchLabel.Text = branchesList[branchesList.branchesListIndex].ToString();
            }
            else { branchLabel.Text = "None"; }
        }
        private void OpenBranchesForm()
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            if (branchesList == null)
            {
                branchesList = new Branches();
            }
            BranchesForm f = new BranchesForm(branchesList);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;

            // Subscribe to the event in the sub-form
            f.BranchIndexChanged += BranchesForm_BranchUpdated;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void OpenMenuForm()
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            Menu_Form f;
            if (branchesList != null &&
                branchesList.branchesListIndex >= 0 && branchesList.branchesListIndex < branchesList.listOfBranches.Count &&
                branchesList[branchesList.branchesListIndex] != null)
            {
                f = new Menu_Form(branchesList[branchesList.branchesListIndex]);
            }
            else
            {
                f = new Menu_Form();
            }
            f.DishIndexChanged += DishesForm_DishUpdated;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
            f.updateDataGridMenu();
        }

        private void BranchesForm_BranchUpdated(object sender, BranchEventArgs e)
        {
            // Update the main form based on the changes made in the sub-form
            if (branchesList != null)
            {
                branchesList.branchesListIndex = e.BranchIndex;
            }
            updateSelectedBranch();
            // Update UI elements or perform any necessary actions
        }
        private void DishesForm_DishUpdated(object sender, DishEventArgs e)
        {
            // Update the main form based on the changes made in the sub-form
            if (branchesList != null) branchesList.dishIndex = e.DishIndex;
            // Update UI elements or perform any necessary actions
        }

        private void Branches_Click(object sender, EventArgs e)
        {
            OpenBranchesForm();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            OpenMenuForm();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save to file
            if (branchesList == null) return;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Filter = "branch files (*.brc)| *.brc| All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    formatter.Serialize(stream, branchesList);
                    stream.Close();

                }

            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            // load from file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "branch files (*.brc)| *.brc| All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                branchesList = (Branches)binaryFormatter.Deserialize(stream);
                updateSelectedBranch();
                stream.Close();
            }
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            waveOut = new WaveOutEvent();
            audioFile = null;
            string fileName = "Resources\\Theme.mp3";
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            try
            {
                audioFile = new AudioFileReader(fullPath);
                waveOut.Init(audioFile);
                waveOut.Play();
                waveOut.Volume = 0.3f;
            }
            catch (Exception ex)
            {
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                waveOut.Play();
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                waveOut.Pause();
            }
        }
    }
}
