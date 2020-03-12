using PuzzleSolver_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            State initial = new State(new int[,] { { 1, 3, 2 }, { 8, 0, 4 }, { 5, 6, 7 } });
            State goal = new State(new int[,] { { 1, 2, 3 }, { 8, 0, 4 }, { 7, 6, 5 } });

            Puzzle puzzle = new Puzzle(initial, goal);

            puzzle.ChangedEvent += Puzzle_ChangedEvent;
            puzzle.SolvedEvent += Puzzle_SolvedEvent;


            while (true)
            {
                PrintPuzzle(puzzle);
                var key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        puzzle.Move(Direction.Up);
                        break;
                    case ConsoleKey.DownArrow:
                        puzzle.Move(Direction.Down);
                        break;
                    case ConsoleKey.RightArrow:
                        puzzle.Move(Direction.Right);
                        break;
                    case ConsoleKey.LeftArrow:
                        puzzle.Move(Direction.Left);
                        break;
                    case ConsoleKey.R:
                        puzzle.Restart();
                        break;
                    case ConsoleKey.S:
                        puzzle.Shuffle();
                        break;
                    case ConsoleKey.U:
                        puzzle.Undo();
                        break;
                    case ConsoleKey.A:
                        AutoSolve(puzzle);
                        break;
                    case ConsoleKey.Escape:
                        Finished(puzzle);
                        goto outside;
                    default:
                        break;
                }
            }
        outside:;

        }

        private static void Puzzle_ChangedEvent(Puzzle sender)
        {
            PrintPuzzle(sender);
        }

        private static void Puzzle_SolvedEvent(Puzzle sender)
        {
            Console.Clear();
            PrintTemplates.Win();

            Console.WriteLine("\n" + sender.CurrentState + "\n");
            Console.WriteLine("\tYou Win !");
            Console.WriteLine("\tMovments count: " + sender.MovementsCount);
            Console.WriteLine("\tPress any key to return to the game..");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Finished(Puzzle puzzle)
        {
            Console.Clear();
            PrintTemplates.Bashir();

            Console.WriteLine("\n" + puzzle.CurrentState + "\n");
            Console.WriteLine("\tFinished !");
            Console.WriteLine("\tMovments count: " + puzzle.MovementsCount + "\n");
            Console.WriteLine("\tPress any key to exit..");
            Console.ReadKey();

        }

        private static void AutoSolve(Puzzle puzzle)
        {
            Console.Clear();
            PrintTemplates.Logo2();
            Console.WriteLine("\n    Searching for the shortest answer, Please wait.. !\n");

            PuzzleSolver solver = new PuzzleSolver(puzzle);

            PuzzleAnswer answer = solver.SolveAsync().Result;

            if (answer != null)
            {
                foreach (var item in answer.Path)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\tTested States Count: " + answer.TestedStatesCount);
                Console.WriteLine("\tShortest Answer Steps Count: " + answer.StepsCount);
            }
            else
                Console.WriteLine("\tSorry, we couldn't find any answer!");

            Console.WriteLine("\n\tPress any key to exit..");
            Console.ReadKey();
        }





        private static void PrintPuzzle(Puzzle puzzle)
        {
            Console.Clear();
            PrintTemplates.Logo2();
            Console.WriteLine("\n" + puzzle.CurrentState);


            StateDetails details = new StateDetails(puzzle);

            Console.Write("    F = " + details.F);
            Console.Write("\tG = " + details.G);
            Console.Write("\tH = " + details.H + "\n");


            PrintTemplates.HowToPlay();
        }
    }
}
