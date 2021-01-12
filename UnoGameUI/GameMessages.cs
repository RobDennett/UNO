using System;

namespace UnoGameUI
{
    public class GameMessages
    {
        public static void DisplayStart()
        {
            Console.WriteLine(@"          _____                    _____                   _______         ");
            Console.WriteLine(@"         /\    \                  /\    \                 /::\    \        ");
            Console.WriteLine(@"        /::\____\                /::\____\               /::::\    \       ");
            Console.WriteLine(@"       /:::/    /               /::::|   |              /::::::\    \      ");
            Console.WriteLine(@"      /:::/    /               /:::::|   |             /::::::::\    \     ");
            Console.WriteLine(@"     /:::/    /               /::::::|   |            /:::/~~\:::\    \    ");
            Console.WriteLine(@"    /:::/    /               /:::/|::|   |           /:::/    \:::\    \   ");
            Console.WriteLine(@"   /:::/    /               /:::/ |::|   |          /:::/    / \:::\    \  ");
            Console.WriteLine(@"  /:::/    /      _____    /:::/  |::|   | _____   /:::/____/   \:::\____\ ");
            Console.WriteLine(@" /:::/____/      /\    \  /:::/   |::|   |/\    \ |:::|    |     |:::|    |");
            Console.WriteLine(@"|:::|    /      /::\____\/:: /    |::|   /::\____\|:::|____|     |:::|    |");
            Console.WriteLine(@"|:::|____\     /:::/    /\::/    /|::|  /:::/    / \:::\    \   /:::/    / ");
            Console.WriteLine(@" \:::\    \   /:::/    /  \/____/ |::| /:::/    /   \:::\    \ /:::/    /  ");
            Console.WriteLine(@"  \:::\    \ /:::/    /           |::|/:::/    /     \:::\    /:::/    /   ");
            Console.WriteLine(@"   \:::\    /:::/    /            |::::::/    /       \:::\__/:::/    /    ");
            Console.WriteLine(@"    \:::\__/:::/    /             |:::::/    /         \::::::::/    /     ");
            Console.WriteLine(@"     \::::::::/    /              |::::/    /           \::::::/    /      ");
            Console.WriteLine(@"      \::::::/    /               /:::/    /             \::::/    /       ");
            Console.WriteLine(@"       \::::/    /               /:::/    /               \::/____/        ");
            Console.WriteLine(@"        \::/____/                \::/    /                 ~~              ");
            Console.WriteLine(@"         ~~                       \/____/                                  ");
            Console.WriteLine("                                    START                                   ");
            Console.WriteLine("                                 PRESS ENTER                                ");
            Console.ReadLine();
        }

        public static void DisplayWin()
        {
            Console.WriteLine(@" __     ______  _    _  __          _______ _   _ ");
            Console.WriteLine(@" \ \   / / __ \| |  | | \ \        / /_   _| \ | |");
            Console.WriteLine(@"  \ \_/ / |  | | |  | |  \ \  /\  / /  | | |  \| |");
            Console.WriteLine(@"   \   /| |  | | |  | |   \ \/  \/ /   | | | . ` |");
            Console.WriteLine(@"    | | | |__| | |__| |    \  /\  /   _| |_| |\  |");
            Console.WriteLine(@"    |_|  \____/ \____/      \/  \/   |_____|_| \_|");   
        }

        public static void DisplayLose()
        {
            Console.WriteLine(@" __     ______  _    _   _      ____   _____ ______ ");
            Console.WriteLine(@" \ \   / / __ \| |  | | | |    / __ \ / ____|  ____|");
            Console.WriteLine(@"  \ \_/ / |  | | |  | | | |   | |  | | (___ | |__   ");
            Console.WriteLine(@"   \   /| |  | | |  | | | |   | |  | |\___ \|  __|  ");
            Console.WriteLine(@"    | | | |__| | |__| | | |___| |__| |____) | |____ ");
            Console.WriteLine(@"    |_|  \____/ \____/  |______\____/|_____/|______|");
        }
    }
  
}
