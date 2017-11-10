using System;
using System.Windows.Forms;

using EnglishTrainer.InfrastructureImplementation;

namespace EnglishTrainerApp
{
    public partial class PersonalAccount : Form
    {
        public PersonalAccount(Guid id, string name)
        {
            InitializeComponent();
            userId = id;
            label_LoggedAs.Text += name;
        }

        private Guid userId;

        private void button_WatchStatistics_Click(object sender, EventArgs e)
        {
            listBox_Learned.Items.Clear();
            listBox_OnLearning.Items.Clear();
            tabControl_Statistics.Visible = true;
            var learnedWords = Data.learnedWordsRepository.GetProgressForUser(userId);
            foreach (var word in learnedWords)
                listBox_Learned.Items.Add(word);
            var learningWords = Data.wordsOnLearningRepository.GetProgressForUser(userId);
            foreach (var word in learningWords)
                listBox_OnLearning.Items.Add(word);
        }

        private void button_StartTraining_Click(object sender, EventArgs e)
        {
            DictionarySelection dictionarySelection = new DictionarySelection();
            dictionarySelection.Owner = this;
            dictionarySelection.Show();
            Hide();
        }
    }
}
