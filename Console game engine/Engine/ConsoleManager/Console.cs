﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Mathmatics;

namespace Engine.ConsoleManager
{
    public class Console
    {
        public static bool GetInput(ConsoleKey key)
        {
            return (System.Console.KeyAvailable && System.Console.ReadKey(true).Key == key);
        } 
        
        public static void Write(int code)
        {
            char charcater = (char)code;
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }


        public static void Write(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.Write(charcater);
        }

        public static void Write(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.ForegroundColor = color;
            System.Console.Write(charcater);
            System.Console.ResetColor();
        }
        
        public static void WriteLine(int code)
        {
            char charcater = (char)code;
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color)
        {
            char charcater = (char)code;
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void WriteLine(int code, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.WriteLine(charcater);
        }

        public static void WriteLine(int code, ConsoleColor color, Vector2 writAt)
        {
            char charcater = (char)code;
            System.Console.SetCursorPosition(writAt.x, writAt.y);
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(charcater);
            System.Console.ResetColor();
        }

        public static void Remove(Vector2 charAt)
        {
            System.Console.SetCursorPosition((charAt.x >= 0) ? charAt.x : 0, (charAt.y >= 0) ? charAt.y : 0);
            System.Console.WriteLine(" ");
        }

        public static void Replace(int Char, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, charAt);
        }

        public static void Replace(int Char, ConsoleColor color, Vector2 charAt)
        {
            Remove(charAt);
            WriteLine(Char, color, charAt);
        }

        public static void Replace(int Char, ConsoleColor color, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, color, addCharAt);
        }

        public static void Replace(int Char, Vector2 RemovecharAt, Vector2 addCharAt)
        {
            Remove(RemovecharAt);
            WriteLine(Char, addCharAt);
        }
    }
}
