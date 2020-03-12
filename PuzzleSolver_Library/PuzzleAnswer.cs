using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public class PuzzleAnswer
    {
        private int testedStatesCount;
        private List<State> path;

        public int StepsCount { get { return Path.Count - 1; } }
        public int TestedStatesCount { get { return testedStatesCount; } }

        public List<State> Path { get { return path; } }
        public State Start { get { return path.First(); } }
        public State End { get { return path.Last(); } }

        public PuzzleAnswer(State answer, int testedStatesCount = 0)
        {
            this.path = GetPath(answer);
            this.testedStatesCount = testedStatesCount;
        }


        private List<State> GetPath(State answer)
        {
            List<State> path = new List<State>();

            State current = answer;
            while (current != null)
            {
                path.Insert(0, current);
                current = current.Parent;
            }

            return path;
        }
    }
}
