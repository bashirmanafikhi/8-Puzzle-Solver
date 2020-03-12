using PuzzleSolver_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleSolver_Forms
{
    public partial class SetStateForm : Form
    {
        public State State { get; set; }

        public SetStateForm(State state)
        {
            InitializeComponent();
            State = state;
            syncFromState();
        }

        private void syncFromState()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Controls["btn_" + i + "_" + j].Text = State[i, j] != 0 ? State[i, j].ToString() : "";
        }

        private void syncToState()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    State[i, j] = Controls["btn_" + i + "_" + j].Text != "" ? int.Parse(Controls["btn_" + i + "_" + j].Text) : 0;
        }


        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.DoDragDrop(button, DragDropEffects.Copy);

        }

        private void btn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Button)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btn_DragDrop(object sender, DragEventArgs e)
        {
            Button button = (Button)sender;
            Button reciver = (Button)e.Data.GetData(typeof(Button));

            string temp = button.Text;
            button.Text = reciver.Text;
            reciver.Text = temp;

            syncToState();
        }
    }
}
