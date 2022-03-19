Console.Title = "Камень - Ножницы - Бумага";

int player_point = 0;
int AI_point = 0;
int player_choice = 0;
int win = 0;
int defeat = 0;
int round = 1;

start:
Console.Clear();
Console.WriteLine("  Игра - Камень, Ножницы Бумага // Deluxe Eddition");
checkpoint:
Console.WriteLine($" Побед [{win}] Поражений [{defeat}] Раунд [{round}]");
Console.WriteLine("\n Выбирайте ваш супер предмет !!!");
Console.WriteLine("[1] Камень [2] Ножницы [3] Бумага");
try
{
    player_choice = Convert.ToInt32(Console.ReadLine());
}
catch
{

}

switch (player_choice)
{
    case 1:
        Console.WriteLine("Вы выбрали Камень");
        player_point = 2;
        break;

    case 2:
        Console.WriteLine("Вы выбрали Ножницы");
        player_point = 1;
        break;

    case 3:
        Console.WriteLine("Вы выбрали Бумагу");
        player_point = 0;
        break;

    default:
        Console.WriteLine("ОШИБКА ! Введите номер предмета");
        goto checkpoint;
}

Random value = new Random();
int AI_choice = value.Next(1, 4);
Console.ReadLine();
switch (AI_choice)
{
    case 1:
        Console.WriteLine("Противник выбрал Камень");
        AI_point = 2;
        break;

    case 2:
        Console.WriteLine("Противник выбрал Ножницы");
        AI_point = 1;
        break;

    case 3:
        Console.WriteLine("Противник выбрал Бумагу");
        AI_point = 0;
        break;
}
Console.ReadLine();
if (player_point == AI_point)
{
    Console.WriteLine("Ничья");
    round++;
    Console.ReadLine();
    player_point = 0;
    goto start;
}

else if ((player_point == 0) && (AI_point == 2))
{
    Console.WriteLine("С победой !");
    round++;
    win++;
    Console.ReadLine();
    goto start;
}

else if ((player_point == 2) && (AI_point == 0))
{
    Console.WriteLine("Ты проиграл");
    round++;
    defeat++;
    Console.ReadLine();
    goto start;
}
else if (player_point > AI_point)
{
    Console.WriteLine("Ты выиграл");
    round++;
    win++;
    Console.ReadLine();
    goto start;
}
else if (player_point < AI_point)
{
    Console.WriteLine("Ты проиграл");
    round++;
    defeat++;
    Console.ReadLine();
    goto start;
}