using System;
using System.Windows.Forms;

namespace EnglishTrainerApp
{
    public partial class DictionarySelection : Form
    {
        public DictionarySelection()
        {
            InitializeComponent();
            var dictionaries = Data.dictionaryRepository.GetExistingDictionaries();
            foreach (var dictionary in dictionaries)
                listBox_availableDictionaries.Items.Add(dictionary);
        }

        private void button_selectDictionary_Click(object sender, EventArgs e)
        {
            string selectedDictionary = listBox_availableDictionaries.SelectedItem.ToString();
            Data.trainerService.ChooseDictionaryForLearning(selectedDictionary);

            Trainer trainer = new Trainer();
            trainer.Owner = this;
            trainer.Show();
            Hide();
        }

        private void button_loadDictionary_Click(object sender, EventArgs e)
        {

        }
    }
}
