
namespace OOPCaseOpgave
{
    internal class Gui
    {
        public static void Print(int x, int y, string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
