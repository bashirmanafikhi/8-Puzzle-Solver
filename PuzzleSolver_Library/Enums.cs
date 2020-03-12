using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Library
{
    public enum Heuristic
    {
        MisplacedTiles,
        ManhattanDistance
    }

    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    }

}
