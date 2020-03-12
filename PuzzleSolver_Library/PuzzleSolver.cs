using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public class PuzzleSolver
    {
        Puzzle puzzle;

        public PuzzleSolver(Puzzle puzzle)
        {
            this.puzzle = puzzle;
        }

        public PuzzleAnswer Solve()
        {
            int testedStatesCount = 0;

            List<State> openList = new List<State>();
            List<State> closedList = new List<State>();

            //1) Add the starting square (or node) to the open list
            openList.Add(new State(puzzle.CurrentState.state));

            //2) Repeat the following:
            while (true)
            {
                //a) Look for the lowest F cost square on the open list. We refer to this as the current square.
                State currentState = openList[0];
                for (int i = 1; i < openList.Count; i++)
                {
                    StateDetails currentDetails = new StateDetails(currentState, puzzle.GoalState);
                    StateDetails newDetails = new StateDetails(openList[i], puzzle.GoalState);

                    if (newDetails.F < currentDetails.F)
                    {
                        currentState = openList[i];
                    }
                }

                // b) Switch it to the closed list.
                openList.Remove(currentState);
                closedList.Add(currentState);

                //c) For each of the 8 squares adjacent to this current square …
                var directions = Enum.GetValues(typeof(Direction));
                foreach (Direction direction in directions)
                {
                    State newState = new State(currentState);

                    // If it is not walkable or if it is on the closed list, ignore it. Otherwise do the following
                    if (!newState.Move(direction) || closedList.Contains(newState))
                    {
                        continue;
                    }


                    //If it isn’t on the open list, add it to the open list.
                    // Make the current square the parent of this square.
                    if (!openList.Contains(newState))
                    {
                        openList.Add(newState);
                    }



                    // Record the F, G, and H costs of the square
                    StateDetails currentDetails = new StateDetails(currentState, puzzle.GoalState);
                    StateDetails newDetails = new StateDetails(newState, puzzle.GoalState);



                    /*
                     * If it is on the open list already, 
                     * check to see if this path to that square is better, 
                     * using G cost as the measure.
                     * A lower G cost means that this is a better path. 
                     * If so, change the parent of the square to the current square, 
                     * and recalculate the G and F scores of the square. 
                     * If you are keeping your open list sorted by F score, 
                     * you may need to resort the list to account for the change.
                     */

                    if (openList.Contains(newState))
                    {
                        State s = openList.First(c => c.Equals(newState));
                        StateDetails sDetails = new StateDetails(s, puzzle.GoalState);

                        if (newDetails.G < sDetails.G)
                        {
                            newState.Parent = currentState;
                        }
                    }

                    // just a counter
                    testedStatesCount++;
                }

                //d) Stop when you:

                //Add the target square to the closed list, in which case the path has been found 
                if (closedList.Contains(puzzle.GoalState))
                {
                    // solved :)
                    return new PuzzleAnswer(currentState, testedStatesCount);
                }


                //Fail to find the target square, and the open list is empty. 
                //In this case, there is no path
                if (openList.Count == 0)
                {
                    // doesn't find a way!
                    return null;
                }
            }
        }

        public async Task<PuzzleAnswer> SolveAsync()
        {
            return await Task.Run(() => Solve());
        }
    }
}
