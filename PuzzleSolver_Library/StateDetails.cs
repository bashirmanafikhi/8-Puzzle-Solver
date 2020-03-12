using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public class StateDetails
    {
        public State CurrentState { get; set; }
        public State GoalState { get; set; }

        public Heuristic Heuristic { get; set; }

        public int F
        {
            get
            {
                return G + H;
            }
        }

        public int G
        {
            get
            {
                int counter = 0;
                State s = CurrentState;

                while (s != null)
                {
                    counter++;
                    s = s.Parent;
                }
                return counter;
            }
        }

        public int H
        {
            get
            {
                int misplacedTiles = 0;
                int manhattanSum = 0;


                for (int x1 = 0; x1 < CurrentState.state.GetLength(0); x1++)
                    for (int y1 = 0; y1 < CurrentState.state.GetLength(1); y1++)
                    {
                        if (CurrentState.state[x1, y1] != GoalState.state[x1, y1])
                        {
                            // Misplaced
                            misplacedTiles++;

                            // manhattan distance
                            int x2, y2;
                            (x2, y2) = MatrixCalculations.FindInMatrix(GoalState.state, CurrentState.state[x1, y1]);
                            manhattanSum += MatrixCalculations.CalculateManhattanDistance(x1, x2, y1, y2);
                        }
                    }

                switch (Heuristic)
                {
                    case Heuristic.MisplacedTiles:
                        return misplacedTiles;
                    case Heuristic.ManhattanDistance:
                        return manhattanSum;
                    default:
                        return manhattanSum;
                }
            }
        }

        // Constructor
        public StateDetails(Puzzle puzzle, Heuristic heuristic = Heuristic.ManhattanDistance) : this(puzzle.CurrentState, puzzle.GoalState, heuristic) { }
        public StateDetails(State current, State goal, Heuristic heuristic = Heuristic.ManhattanDistance)
        {
            CurrentState = current;
            GoalState = goal;
            Heuristic = heuristic;
        }

    }
}
