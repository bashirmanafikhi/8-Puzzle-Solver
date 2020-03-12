using PuzzleSolver_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleSolver_Forms
{
    public partial class MainForm : Form
    {
        Puzzle puzzle;
        PuzzleAnswer answer;
        int counter = 0;

        public MainForm()
        {
            InitializeComponent();

            State initial = new State(new int[,] { { 1, 3, 2 }, { 8, 0, 4 }, { 5, 6, 7 } });
            State goal = new State(new int[,] { { 1, 2, 3 }, { 8, 0, 4 }, { 7, 6, 5 } });

            puzzle = new Puzzle(initial, goal);

            puzzle.ChangedEvent += Puzzle_ChangedEvent;
            puzzle.SolvedEvent += Puzzle_SolvedEvent;

            SyncBoard();
        }

        private void Puzzle_SolvedEvent(Puzzle sender)
        {
            MessageBox.Show("Win!");
        }

        private void Puzzle_ChangedEvent(Puzzle sender)
        {
            SyncBoard();
        }


        private void Button_Pressed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = int.Parse(btn.Name.Split('_')[1]);
            int y = int.Parse(btn.Name.Split('_')[2]);

            // check left
            if (panel1.Controls["btn_" + (x) + "_" + (y + 1)] != null &&
               !panel1.Controls["btn_" + (x) + "_" + (y + 1)].Visible)
                puzzle.Move(Direction.Left);

            // check Right
            else if (panel1.Controls["btn_" + (x) + "_" + (y - 1)] != null &&
                    !panel1.Controls["btn_" + (x) + "_" + (y - 1)].Visible)
                puzzle.Move(Direction.Right);

            // check Up
            else if (panel1.Controls["btn_" + (x + 1) + "_" + (y)] != null &&
                    !panel1.Controls["btn_" + (x + 1) + "_" + (y)].Visible)
                puzzle.Move(Direction.Up);

            // check Down
            else if (panel1.Controls["btn_" + (x - 1) + "_" + (y)] != null &&
                    !panel1.Controls["btn_" + (x - 1) + "_" + (y)].Visible)
                puzzle.Move(Direction.Down);
        }

        void SyncBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (puzzle.CurrentState[i, j] != 0)
                    {
                        panel1.Controls["btn_" + i + "_" + j].Text = puzzle.CurrentState[i, j].ToString();
                        panel1.Controls["btn_" + i + "_" + j].Visible = true;
                    }
                    else
                    {
                        panel1.Controls["btn_" + i + "_" + j].Text = "";
                        panel1.Controls["btn_" + i + "_" + j].Visible = false;
                    }
        }

        private void btnSetCurrentState_Click(object sender, EventArgs e)
        {
            SetStateForm setStateForm = new SetStateForm(puzzle.CurrentState);
            setStateForm.ShowDialog();
            puzzle.CurrentState = setStateForm.State;
        }

        private void btnSetGoalState_Click(object sender, EventArgs e)
        {
            SetStateForm setStateForm = new SetStateForm(puzzle.GoalState);
            setStateForm.ShowDialog();
            puzzle.GoalState = setStateForm.State;
        }

        private async void btnSolve_Click(object sender, EventArgs e)
        {
            Pause();
            PuzzleSolver solver = new PuzzleSolver(puzzle);
            answer = await solver.SolveAsync();
            Continue();

            timerSolving.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (answer == null)
            {
                lblPleaseWait.Text = "This state is unsolvable!";
                counter = 0;
                timerSolving.Stop();
            }

            if ( counter < answer.Path.Count)
            {
                puzzle.CurrentState = answer.Path[counter++];
                SyncBoard();
            }
            else
            {
                lblPleaseWait.Text = "Solved in " + answer.StepsCount + " steps";
                lblPleaseWait.Text += "\nWe tested " + answer.TestedStatesCount + " states";
                answer = null;
                counter = 0;
                timerSolving.Stop();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            puzzle.Shuffle();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            puzzle.Undo();
        }

        private void Pause()
        {
            progressBar1.Visible = true;
            UseWaitCursor = true;
            pnlMain.Enabled = false;
            lblPleaseWait.Text = "Solving.. Please Wait..";
        }

        private void Continue()
        {
            progressBar1.Visible = false;
            pnlMain.Enabled = true;
            UseWaitCursor = false;
        }
    }
}
