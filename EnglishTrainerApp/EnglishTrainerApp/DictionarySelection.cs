using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        // GetItemText(listBox_availableDictionaries.SelectedIndex);
            Data.trainerService.ChooseDictionaryForLearning(selectedDictionary);

            Trainer trainer = new Trainer();
            trainer.Owner = this;
            trainer.Show();
            Hide();
        }

        private void button_loadDictionary_Click(object sender, EventArgs e)
        {
            /*if (openFileDialog_LoadDictionary.ShowDialog() == DialogResult.OK)

            Trainer trainer = new Trainer();
            trainer.Owner = this;
            trainer.Show();
            Hide();*/
        }
    }
}
