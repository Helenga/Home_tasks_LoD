using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EnglishTrainerApp
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent(); 
        }

        private void Bw_pressedButtonWaiter(object sender, DoWorkEventArgs e)
        {
            Waiter();
        }

       // private Thread pressedButtonWaiter = new Thread(Waiter);

        private static void Waiter()
        {
            if (pressed)
            Data.trainerService.AnswerHandler(answerValue, passingPair);
        }

        private void button_true_Click(object sender, EventArgs e)
        {
            answerValue = true;
            pressed = true;
        }

        private void button_false_Click(object sender, EventArgs e)
        {
            answerValue = false;
            pressed = true;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            button_Start.Visible = false;
            trainerController();
        }

        private void trainerController()
        {
            foreach (var pair in Data.trainerService.StartTraining())
            {
                passingPair = pair;
                pressed = false;
                label_Word.Text = pair.Key;
                label_Translation.Text = pair.Value;
                label_Word.Update();
                label_Translation.Update();
               /*
                bw = new BackgroundWorker();
                bw.DoWork += Bw_pressedButtonWaiter;
                bw.RunWorkerAsync();
                */
                Task task = new Task(Waiter);
                task.Start();
                task.Wait(); 

                //  pressedButtonWaiter = new Thread(Waiter);
               // pressedButtonWaiter.Start();
               // pressedButtonWaiter.Join();
               // button_false.Click += button_false_Click;
               // button_true.Click += button_true_Click;
                
               // Data.trainerService.AnswerHandler(answerValue, pair);

                //pressedButtonWaiter = new Thread(new ThreadStart(Waiter));
                // button_true.Click += Button_true_Click;
                // button_false.Click += Button_false_Click;
                // Thread thread = Thread.CurrentThread;
                // thread.Suspend();
                // Data.trainerService.AnswerHandler(answerValue, pair);
                // thread.Resume();
            }
        }

        private static bool answerValue;
        private static bool pressed;
        private static KeyValuePair<string, string> passingPair;
    }
}
