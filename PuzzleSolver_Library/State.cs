using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public class State
    {
        #region Fields

        public int[,] state;

        #endregion

        #region Propeties

        public State Parent { get; set; }

        public Point Hole
        {
            get
            {
                Point point = new Point();
                (point.X, point.Y) = MatrixCalculations.FindInMatrix(state, 0);
                return point;
            }
        }

        #endregion

        #region Indexer

        public int this[int x, int y]
        {
            get
            {
                return state[x, y];
            }
            set
            {
                state[x, y] = value;
            }
        }

        #endregion

        #region Constructors

        public State(int n) : this(MatrixCalculations.GetMatrix(n, n)) { }

        public State(int[,] initial)
        {
            state = MatrixCalculations.Copy(initial);

        }

        public State(State parent = null)
        {
            if (parent != null)
            {
                state = new int[parent.state.GetLength(0), parent.state.GetLength(1)];
                Array.Copy(parent.state, state, state.Length);
                this.Parent = parent;
            }
            else
            {
                state = MatrixCalculations.GetMatrix(3, 3);
                MatrixCalculations.Shuffle(state);
            }
        }

        #endregion

        #region Methods

        public bool Move(Direction direction)
        {
            Point hole = Hole;

            if ((direction == Direction.Up && hole.X <= 0) ||
                (direction == Direction.Down && hole.X >= state.GetLength(0) - 1) ||
                (direction == Direction.Left && hole.Y <= 0) ||
                (direction == Direction.Right && hole.Y >= state.GetLength(1) - 1))
                return false;


            switch (direction)
            {
                case Direction.Up:
                    state[hole.X, hole.Y] = state[hole.X - 1, hole.Y];
                    state[hole.X - 1, hole.Y] = 0;
                    break;
                case Direction.Down:
                    state[hole.X, hole.Y] = state[hole.X + 1, hole.Y];
                    state[hole.X + 1, hole.Y] = 0;
                    break;
                case Direction.Right:
                    state[hole.X, hole.Y] = state[hole.X, hole.Y + 1];
                    state[hole.X, hole.Y + 1] = 0;
                    break;
                case Direction.Left:
                    state[hole.X, hole.Y] = state[hole.X, hole.Y - 1];
                    state[hole.X, hole.Y - 1] = 0;
                    break;
                default:
                    break;
            }
            return true;
        }

        public void Shuffle()
        {
            MatrixCalculations.Shuffle(state);
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            bool hasFrame = state.GetLength(0) == 3 && state.GetLength(1) == 3;
            string s = string.Empty;
            s += hasFrame ? "\t╔════════════════╗\n" : "";
            for (int i = 0; i < state.GetLength(0); i++)
            {
                s += hasFrame ? "\t║" : "\t";
                for (int j = 0; j < state.GetLength(1); j++)
                {
                    s += (state[i, j] != 0 ? state[i, j].ToString() : "-") + "\t";
                }
                s = s.TrimEnd();
                s += hasFrame ? "║\n" : "\n";
            }
            s += hasFrame ? "\t╚════════════════╝\n" : "";
            return s;
        }

        public override bool Equals(object obj)
        {
            var matrix = obj as State;
            if (matrix == null)
                return false;

            if (state.GetLength(0) != matrix.state.GetLength(0) || state.GetLength(1) != matrix.state.GetLength(1))
                return false;

            for (int i = 0; i < state.GetLength(0); i++)
                for (int j = 0; j < state.GetLength(1); j++)
                    if (state[i, j] != matrix.state[i, j])
                        return false;

            return true;
        }

        public override int GetHashCode()
        {
            return ((IStructuralEquatable)this.state).GetHashCode(EqualityComparer<int>.Default);
        }

        #endregion
    }
}
