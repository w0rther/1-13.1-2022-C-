using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesIO
{
    internal class Program
    {
        private static void fileReadFull(FileStream file)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                Console.WriteLine("Egyszerre  olvassa a fájlt");
                string s = sr.ReadToEnd();
                Console.WriteLine(s);

                Console.WriteLine();

            }
        }

        private static void fileReadLine(FileStream file) {
           using (StreamReader sr = new StreamReader(file))
            {
                Console.WriteLine("Soronként olvassa a fájlt");
                while (!sr.EndOfStream)
                {
                    string s =sr.ReadLine();
                    Console.WriteLine(s);

                }
            }
        
        
        }

        private static void fileWrite(FileStream file,string[] s)
        {
            using (StreamWriter sr = new StreamWriter(file))
            {
                Console.WriteLine("Írja a fájlt");
                for (int i = 0; i < s.Length;)
                {
                    sr.WriteLine(s[i]);
                    Console.WriteLine(s);
                }
            }
        }
        static void Main(string[] args)
        {
            FileInpOut f = new FileInpOut();

            string[] s = { "C# Label Control", "C# Button Control", "C# TextBox Control", "C# ComboBox", "C# ListBox Control", "C# Checked ListBox Control", "C# CheckBox Control", "C# PictureBox Control", "C# ProgressBar Control", "C# ScrollBars Control", "C# DateTimePicker Control", "C# Treeview Control", "C# ListView Control", "C# Menu Control", "C# MDI Form", "C# Color Dialog Box", "C# Font Dialog Box", "C# OpenFile Dialog Box", "C# Print Dialog Box" };
            fileWrite(f.getFile().s);

            f.closeFile();

            Console.ReadKey();
        }

    }
}