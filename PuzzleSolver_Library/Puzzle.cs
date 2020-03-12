using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public class Puzzle
    {
        #region Fields

        private State currentState;
        private State goalState;
        private State initialState;

        #endregion

        #region Properties

        public State InitialState { get { return initialState; } set { initialState = value; } }
        public State GoalState { get { return goalState; } set { goalState = value; } }
        public State CurrentState
        {
            get
            {
                return currentState;
            }
            set
            {
                currentState = value;


                if (ChangedEvent != null)
                    ChangedEvent(this);

                if (CurrentState.Equals(GoalState) && SolvedEvent != null)
                    SolvedEvent(this);
            }
        }
        public int MovementsCount { get; set; }

        #endregion

        #region Events

        public event PuzzleStateChanged ChangedEvent;
        public event PuzzleSolved SolvedEvent;

        #endregion

        #region Constructors

        public Puzzle(State initial = null, State goal = null)
        {
            InitialState = initial ?? new State();
            GoalState = goal ?? new State(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } });
            CurrentState = new State(InitialState.state);
        }

        public Puzzle(int n)
        {
            if (n < 2)
                throw new ArgumentException("puzzles count should be at least two!");
            InitialState = new State(n);
            GoalState = new State(MatrixCalculations.GetMatrix(n, n));
            CurrentState = new State(InitialState.state);
        }

        #endregion

        #region Methods

        public void Move(Direction direction)
        {
            State newState = new State(CurrentState);
            if (newState.Move(direction))
            {
                MovementsCount++;
                CurrentState = newState;
            }
        }

        public void Shuffle()
        {
            InitialState = new State(GoalState.state);

            Random random = new Random();
            for (int i = 0; i < 70; i++)
                InitialState.Move((Direction)random.Next(0, 4));

            InitialState.Parent = null;
            CurrentState = new State(InitialState.state);

            MovementsCount = 0;
        }

        public void Restart()
        {
            CurrentState = new State(InitialState.state);
            MovementsCount = 0;
        }

        public void Undo()
        {
            if (CurrentState.Parent != null)
                CurrentState = CurrentState.Parent;
        }

        #endregion
    }
}
