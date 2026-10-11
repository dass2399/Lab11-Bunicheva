// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1091;
// bool found1 = false;

// foreach (int number in recordBooks) {
//     if (number == target) {
//         found1 = true;
//         break;
//     }
// }
// Console.WriteLine(found1 ? "Студент найден" : "Студент не найден");


// int variant = 1;
// bool isPrime = true;
// if (variant <= 1) {
//     isPrime = false;
// }

// for (int divisor = 2; divisor < variant; divisor++) {
//     if (variant % divisor == 0) {
//         isPrime = false;
//         break;
//     }
// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab) {
//     if (points < 0) {
//         continue;
//     }
//     sum += points;
//     count++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Количество сданных работ: {count}");


// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++) {
//     for (int j = i + 1; j < groupIds.Length; j++) {
//         if (groupIds[i] == groupIds[j]) {
//             hasDuplicates = true;
// Console.WriteLine($"Совпашие номера: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
// }

// Console.WriteLine(hasDuplicates ? "Есть повторящиеся номера" : "Все номера уникальны");

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++) {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++) {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree) {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }
// if (!found) {
//     Console.WriteLine("Свободных слотов нет");
// }
// //самостоятельные задания
// //задача Б

// int number1 = 29;
// bool isPrimee = true;

// if (number1 <= 1) {
//     isPrimee = false;
// } else {
//     for (int n = 2; n < number1; n++) {
//         if  (number1 % n == 0) {
//             isPrimee = false;
//             break;
//         }
//     }
// }

// Console.WriteLine(isPrimee ? "Число простое" : "Число составное");

// //задача В

// int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
// int sum1 = 0;

// foreach (int num2 in numbers1) {
//     if (num2 % 2 != 0) {
//         continue;
//     }
//     sum1 += num2;
// }

// Console.WriteLine($"Сумма чётных чисел: {sum1}");

// //индивидуальный вариант
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


//вариант №6

int[] array = { 1, 3, 5, 4, 7 };
bool isSorted = true;

for (int m = 0; m < array.Length - 1; m++) {
    if (array[m] > array[m + 1]) {
        isSorted = false;
        break;
    }
}

Console.WriteLine(isSorted ? "Массив отсортирован" : "Массив не отсортирован");

// // вариант №9
// string word = "шалаш";
// bool isPalidrome = true;

// for (int e = 0; e < word.Length; e++) {
//     if (word[e] != word[word.Length - 1 - e]) {
//         isPalindrome = false;
//         break;
//     }
// }

// Console.WriteLine(isPalindrome ? "Слово является палиндромом" : "Слово не является палиндромом");


// //Дополнительное задание.Пара чисел с заданной суммой. 

// int[] numbers3 = { 2, 7, 11, 15, 3, 6 };
// int target1 = 9;
// bool found2 = false;

// for (int r = 0; r < numbers3.Length; r++) {
//     for (int p = r + 1; p < numbers3.Length; p++) {
//         if (numbers3[r] + numbers3[p] == target1) {
// Console.WriteLine($"Индексы: {r} и {p}");
//               found2 = true;
//               break;            
//         }
//     }
//     if (found2) {
//         break;
//     }
// }

// if (!found2) {
//     Console.WriteLine("Пара не найдена");
// }