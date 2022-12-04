// Task 1 Я сделал так, что он находит вторую цифру в числе любой длины (надеюсь, что так можно)

// void getSecondDigit (int num){
//     while(num >= 100){
//         num /= 10;
//     }
//     Console.WriteLine($"Вторая цифра числа {num % 10}");
// }

// Task 2
// void getThirdDigit(int num){
//     if(num < 100){
//         Console.WriteLine("Третьей цифры нет");
//         return;   
//     }
//     while(num >= 1000){
//         num /= 10;
//     }
//      Console.WriteLine($"Третья цифра числа {num % 10}");
// }

// Task 3
// void isWeekend(int num){
//     if(num > 0 && num < 6){
//         Console.WriteLine("Нет");
//     }else if(num > 5 && num < 8){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Дней недели только 7 ([1; 10])");
//     }
// }

//Task 3 Тут я решил поиграться со switch
void isWeekend2(int num){
    switch (num){
        case 1: case 2: case 3: case 4: case 5:
            Console.WriteLine("Нет");
            break;
        case 6: case 7:
            Console.WriteLine("Да");
            break;
        default:
            Console.WriteLine("Дней недели только 7 ([1; 10])");
            break;
    }
}

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

// Task 1
//getSecondDigit(num);

// Task 2
//getThirdDigit(num);

// Task 3
isWeekend2(num);