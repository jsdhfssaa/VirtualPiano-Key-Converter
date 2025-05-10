using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COnverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Keys you pressed in VirtualPiano:");
            string Output = "Is ";
            string ConvertInput = Console.ReadLine();
            foreach (char key in ConvertInput)
            {
                switch (key)
                {
                    case 'a':
                        Output += "B4 ";
                        break;
                    case 'b':
                        Output += "A6 ";
                        break;
                    case 'c':
                        Output += "F6 ";
                        break;
                    case 'd':
                        Output += "D5 ";
                        break;
                    case 'e':
                        Output += "A3 ";
                        break;
                    case 'f':
                        Output += "E5 ";
                        break;
                    case 'g':
                        Output += "F5 ";
                        break;
                    case 'h':
                        Output += "G5 ";
                        break;
                    case 'i':
                        Output += "F4 ";
                        break;
                    case 'j':
                        Output += "A5 ";
                        break;
                    case 'k':
                        Output += "B5 ";
                        break;
                    case 'l':
                        Output += "C6 ";
                        break;
                    case 'm':
                        Output += "C7 ";
                        break;
                    case 'n':
                        Output += "B6 ";
                        break;
                    case 'o':
                        Output += "G4 ";
                        break;
                    case 'p':
                        Output += "A4 ";
                        break;
                    case 'q':
                        Output += "F3 ";
                        break;
                    case 'r':
                        Output += "B3 ";
                        break;
                    case 's':
                        Output += "C5 ";
                        break;
                    case 't':
                        Output += "C4 ";
                        break;
                    case 'u':
                        Output += "E4 ";
                        break;
                    case 'v':
                        Output += "G6 ";
                        break;
                    case 'w':
                        Output += "G3 ";
                        break;
                    case 'x':
                        Output += "E6 ";
                        break;
                    case 'y':
                        Output += "D4 ";
                        break;
                    case 'z':
                        Output += "D6 ";
                        break;
                    case '1':
                        Output += "C2 ";
                        break;
                    case '2':
                        Output += "D2 ";
                        break;
                    case '3':
                        Output += "E2 ";
                        break;
                    case '4':
                        Output += "F2 ";
                        break;
                    case '5':
                        Output += "G2 ";
                        break;
                    case '6':
                        Output += "A2 ";
                        break;
                    case '7':
                        Output += "B2 ";
                        break;
                    case '8':
                        Output += "C3 ";
                        break;
                    case '9':
                        Output += "D3 ";
                        break;
                    case '0':
                        Output += "E3 ";
                        break;
                    case '!':
                        Output += "C#2 ";
                        break;
                    case '@':
                        Output += "D#2 ";
                        break;
                    case '$':
                        Output += "F#2 ";
                        break;
                    case '%':
                        Output += "G#2 ";
                        break;
                    case '^':
                        Output += "A#2 ";
                        break;
                    case '*':
                        Output += "C#3 ";
                        break;
                    case '(':
                        Output += "D#3 ";
                        break;
                    case 'Q':
                        Output += "F#3 ";
                        break;
                    case 'W':
                        Output += "G#3 ";
                        break;
                    case 'E':
                        Output += "A#3 ";
                        break;
                    case 'T':
                        Output += "C#4 ";
                        break;
                    case 'Y':
                        Output += "D#4 ";
                        break;
                    case 'I':
                        Output += "F#4 ";
                        break;
                    case 'O':
                        Output += "G#4 ";
                        break;
                    case 'P':
                        Output += "A#4 ";
                        break;
                    case 'S':
                        Output += "C#5 ";
                        break;
                    case 'D':
                        Output += "D#5 ";
                        break;
                    case 'G':
                        Output += "F#5 ";
                        break;
                    case 'H':
                        Output += "G#5 ";
                        break;
                    case 'J':
                        Output += "A#5 ";
                        break;
                    case 'L':
                        Output += "C#6 ";
                        break;
                    case 'Z':
                        Output += "D#6 ";
                        break;
                    case 'C':
                        Output += "F#6 ";
                        break;
                    case 'V':
                        Output += "G#6 ";
                        break;
                    case 'B':
                        Output += "A#6 ";
                        break;
                    case ' ':
                        Output += "| ";
                        break;
                    default:
                        Output += "?"; // unbekannter Buchstabe
                        break;
                }
            }

            Console.WriteLine(Output);
        }
    }
}
