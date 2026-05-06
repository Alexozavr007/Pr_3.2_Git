Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
bool e = true;
Console.WriteLine("Введіть масив для обробки");
var arr = ReadJaggedRandom();
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
static int[][] ReadJaggedRandom()
{
    Random rnd = new Random();
    Console.Write("Введіть кількість рядків: ");
    int rows = int.Parse(Console.ReadLine());
    int[][] jagged = new int[rows][];

    for (int i = 0; i < rows; i++)
    {
        int cols = rnd.Next(1, 11);
        jagged[i] = new int[cols];

        for (int j = 0; j < cols; j++)
        {
            jagged[i][j] = rnd.Next(0, 51);
        }
    }
    return jagged;
}
static void PrintJaggedArray(int[][] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Рядок {i + 1}: ");
        Console.WriteLine(string.Join(", ", arr[i]));
    }
}