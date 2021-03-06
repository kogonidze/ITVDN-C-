using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndReplaceManager
{
    class Program
    {
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Start search the line in the book...");
            }

            public class Notes
            {
                private string[] notes;

                public Notes()
                {
                    notes = new string[100];
                    notes[0] = "Get the book";
                    notes[1] = "Have a nice day";
                }

                public int GetIndexOfFreePage()
                {
                    return Array.FindIndex(notes, i => i == null);
                }

                public string this[int index]
                {
                    get
                    {
                        if (index >= 0 && index < notes.Length && notes[index] != null)
                        {
                            return notes[index];
                        }

                        return "There is no such note in your notes!";
                    }

                    set
                    {
                        notes[index] = value;
                    }
                }
            }
        }
        static class FindAndReplaceManager
        {
            private static Book book;
            private static Book.Notes notes;

            static FindAndReplaceManager()
            {
                book = new Book();
                notes = new Book.Notes();
            }

            public static void FindNext(string str)
            {
                book.FindNext(str);
            }

            public static string GetNoteByIndex(int index)
            {
                return notes[index];
            }

            public static void SetNote(string note)
            {
                var indexOfFreePage = notes.GetIndexOfFreePage();
                if (indexOfFreePage > -1)
                {
                    notes[indexOfFreePage] = note;
                    return;
                }

                Console.WriteLine("Our notebook is full");
                
            }
        }
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("утро было прекрасным");

            FindAndReplaceManager.SetNote("не забыть пообедать");

            Console.WriteLine(FindAndReplaceManager.GetNoteByIndex(3));

            Console.ReadKey();
        }
    }
}
