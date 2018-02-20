using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace FarManagerExample

{

    class Program

    {

        static void showFolderContent(DirectoryInfo cur, int pos)

        {

            FileSystemInfo[] data = cur.GetFileSystemInfos();

            for (int i = 0; i < data.Length; i++)

            {

                if (i == pos)

                    Console.BackgroundColor = ConsoleColor.White;

                else

                    Console.BackgroundColor = ConsoleColor.Black;



                if (data[i].GetType() == typeof(DirectoryInfo))

                    Console.ForegroundColor = ConsoleColor.Blue;

                else

                    Console.ForegroundColor = ConsoleColor.Red;



                Console.WriteLine(data[i].Name);

            }



        }



        static void Main(string[] args)

        {

            Console.CursorVisible = false;

            int pos = 0;



            DirectoryInfo dir = new DirectoryInfo(@"/Users/Валерий/Desktop/programming");



            while (true)

            {

                Console.Clear();

                showFolderContent(dir, pos);



                ConsoleKeyInfo btn = Console.ReadKey();

                switch (btn.Key)

                {

                    case ConsoleKey.UpArrow:

                        pos--;

                        if (pos < 0)

                            pos = dir.GetFileSystemInfos().Length - 1;

                        break;

                    case ConsoleKey.DownArrow:

                        pos++;

                        if (pos >= dir.GetFileSystemInfos().Length)

                            pos = 0;

                        break;

                    case ConsoleKey.Enter:

                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];

                        if (f.GetType() == typeof(DirectoryInfo))

                        {

                            dir = new DirectoryInfo(f.FullName);

                            pos = 0;

                        }

                        else

                        {

                            Process.Start(f.FullName);

                        }

                        break;

                    case ConsoleKey.Escape:

                        dir = dir.Parent;

                        break;



                }

            }





        }

    }

}
