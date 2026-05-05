Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
bool e = true;
Console.WriteLine("Введіть масив для обробки");
//var arr = ReadJaggedRandom();
while (e) {
    Console.WriteLine("Введіть блок для виконання завдання ( 1, 2, 3 або 4 )");
    var num = Console.ReadLine();
    switch (num) {
        case "1":
            //Block_2_Max(ref arr);
            break;
        case "2":
            //Block_2_Alex(ref arr);
            break;
        case "3":
            //Block_2_Illia(ref arr);
            break;
        case "4":
            //Block_2_Sania(ref arr);
            break;
        default:
            Console.WriteLine("Ви ввели щось не зрозуміле (((");
            break;
    }
    Console.WriteLine("Чи продовжувати далі змінювати масив? (true or false)");
    e = bool.Parse(Console.ReadLine());
}
