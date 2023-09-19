//1. FELADAT
//int num = int.Parse(Console.ReadLine());
//for (int i = 1; i < num; i++)
//{
//    Console.WriteLine(i);
//}

//1. FELADAT átírva
//int num = int.Parse(Console.ReadLine());
//for (int i = 2; i < num; i+=2)
//{
//    Console.WriteLine(i);
//}

//2. FELADAT
//string passwd = "";
//string tmp;
//int i = 0;
//do
//{
//    tmp = Console.ReadLine();
//    i++;
//} while (i < 3 | passwd == tmp);
//
//if (i == 3)
//{
//    Console.Error.WriteLine("Túl sokszor próbálkozott!") ;
//}

//3. FELADAT
//Random rnd = new Random();
//int num = int.Parse(Console.ReadLine());
//int tmp;
//int i = 0;
//do
//{
//    tmp = rnd.Next(1, 1001);
//    i++;
//} while (tmp != num);
//Console.WriteLine(i);

//4.feladat
//Random rnd = new Random();
//int players = int.Parse(Console.ReadLine());
//int num = 0;
//while (num != 6)
//{
//    int i = 0;
//    while (num != 6 && i < players)
//    {
//        Console.WriteLine((i + 1) + ". players turn");
//        ConsoleKeyInfo keyInfo = Console.ReadKey();
//        if (keyInfo.Key == ConsoleKey.Enter)
//        {
//            num = rnd.Next(1, 7);
//            Console.WriteLine("Number: " + num);
//        }
//
//        i++;
//    }
//} 

