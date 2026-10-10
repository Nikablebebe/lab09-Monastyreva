// int totalExercises = 8;

// for (int number = totalExercises; number >= 1; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5) {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++) {
//     for (int day = 1; day <= 5; day++) {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^"); 
// }

// int skipped = 0; 

// for (int ticket = 1; ticket <= 30; ticket++) {
//     if (ticket == 4 || ticket == 12 || ticket == 19) {
//         skipped = skipped + 1; 
//         continue; // билет уже вытянут
//     }
    
//     Console.WriteLine($"Пропущено билетов: {skipped}");
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     break;
// }

// for (; ; ) {
//     Console.Write("Введите код группы (для выхода — «выход»): ");
//     string groupCode = Console.ReadLine();

//     if (groupCode == "выход") {
//         break;
//     }

//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");

//ЗАДАЧА А
// int number = 156; 

// for (int i = 1; i <= number; i = i + 2) {
//     Console.WriteLine(i);
// }

//ЗАДАЧА Б
// for (int i = 100; i >= 0; i = i - 10) {
//     Console.WriteLine(i);
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

//ВАРИАНТ 2
// int n = 100; 
// int m = 15; 

// for (int i = n; i >= 0; i = i - m) {
//     Console.WriteLine(i);
// }

//ВАРИАНТ 9
int n = 200; 
int sum = 0;

for (int i = 1; i <= n; i++) {
    if (i % 5 == 0) {
        continue; 
    }
    sum = sum + i; 
}

Console.WriteLine($"Сумма: {sum}");