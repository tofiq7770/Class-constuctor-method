



//using Class_constuctor_method;

//CustomMath math = new();

//task2-1

//int[] numbers = { 1, 3, 5, 7 };

//Console.WriteLine(math.GetOdd(numbers));


//task2 - 2

//int num = int.Parse(Console.ReadLine());

//Console.WriteLine(math.GetNum(num));

//task2 - 3

//int[] numbers = { 2, 4, 5, 6, 8 };

//Console.WriteLine(math.GetSquare(numbers));


//task2-4

//int num = 5;

//Console.WriteLine(math.GetSquare(num));


//task3 - 1

//Employee employee1 = new Employee()
//{
//    id = 1,
//    name = "Tofiq",
//    surname = "Nasibli",
//    address = "Hazi aslanov",
//    email = "tofiq@gmail.com",
//    age = 18,

//};

//Employee employee2 = new Employee()
//{
//    id = 2,
//    name = "Ali",
//    surname = "Huseynli",
//    address = "Hazi aslanov",
//    email = "ali@gmail.com",
//    age = 17,

//};

//Employee employee3 = new Employee()
//{
//    id = 3,
//    name = "Abbas",
//    surname = "Mammadli",
//    address = "Hazi aslanov",
//    email = "abbas@gmail.com",
//    age = 23,
//};

//    Employee[] employees = { employee1, employee2, employee3 };

//task3-1

//GetAge(17,employees);

//static void GetAge(int age, Employee[] arr)
//{

//    foreach (var employee in arr)
//    {
//        if (employee.age > age)
//        {
//            Console.WriteLine(employee.GetFullData());
//        }
//    }
//}

//task3-2

//Console.WriteLine(GetBetAge(employees));

//static int GetBetAge(Employee[] arr)
//{
//    int count = 0;
//    foreach (var employee in arr)
//    {
//        if (employee.age > 20 && employee.age < 30)
//        {
//            count++;
//        }
//    }
//    return count;
//}

//task3-3

//Console.WriteLine(GetSumAge(employees));

//static int GetSumAge(Employee[] arr)
//{
//    int sum = 0;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i].age;
//    }
//    return sum;
//}
