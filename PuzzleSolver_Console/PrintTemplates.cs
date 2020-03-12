using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleSolver_Console
{
    static class PrintTemplates
    {


        public static void HowToPlay()
        {
            Console.WriteLine();
            Console.WriteLine("    use \tarrows \tto play.");
            //Console.WriteLine("    press \tEnter \tto Auto One Move.");
            Console.WriteLine("    press \tS \tto shuffle.");
            Console.WriteLine("    press \tU \tto undo.");
            Console.WriteLine("    press \tR \tto restart.");
            Console.WriteLine("    press \tA \tto AutoSolve.");
            Console.WriteLine("    press \tesc \tto exit.");
            Console.WriteLine();
        }

        public static void Logo1()
        {
            Console.WriteLine(@"
         _      __ __     _ 
        |_) | |  /  / |  |_ 
        |   |_| /_ /_ |_ |_ 
        ===================",
            Console.ForegroundColor = ConsoleColor.Cyan);

            Console.ResetColor();
        }

        public static void Logo2()
        {
            Console.WriteLine(@"
     (            )   ) (         
     )\ )      ( /(( /( )\ )      
    (()/(   (  )\())\()|()/( (    
     /(_))  )\((_)((_)\ /(_)))\   
    (_)) _ ((_)_((_)((_|_)) ((_)  
    | _ \ | | |_  /_  /| |  | __| 
    |  _/ |_| |/ / / / | |__| _|  
    |_|  \___//___/___||____|___| 
",
    Console.ForegroundColor = ConsoleColor.Cyan);

            Console.ResetColor();
        }

        public static void Bashir()
        {
            Console.WriteLine(@"
                  (       ) (   (     
       (    (     )\ ) ( /( )\ ))\ )  
     ( )\   )\   (()/( )\()|()/(()/(  
     )((_|(((_)(  /(_)|(_)\ /(_))(_)) 
    ((_)_ )\ _ )\(_))  _((_|_))(_))   
     | _ )(_)_\(_) __|| || |_ _| _ \  
     | _ \ / _ \ \__ \| __ || ||   /  
     |___//_/ \_\|___/|_||_|___|_|_\  
", Console.ForegroundColor = ConsoleColor.Magenta);

            Console.ResetColor();
        }



        public static void Win()
        {
            Console.WriteLine(@"
                   (       )  
         (  (      )\ ) ( /(  
         )\))(   '(()/( )\()) 
        ((_)()\ )  /(_)|(_)\  
        _(())\_)()(_))  _((_) 
        \ \((_)/ /|_ _|| \| | 
         \ \/\/ /  | | | .` | 
          \_/\_/  |___||_|\_| 
", Console.ForegroundColor = ConsoleColor.Green);

            Console.ResetColor();
        }
    }
}
