#region Task1

// Verilmiş yazının sonundaki boşluları silinmiş yeni bir yazı düzəldən proqram

Console.WriteLine("Please enter a sentence: ");
string sentence1 = Console.ReadLine();
string sentence2 = "";

int index = 0;
while (sentence1[sentence1.Length - index - 1] == ' ') {
    index++;
}

for (int i = 0; i < sentence1.Length - index; i++) {
    sentence2 += sentence1[i];
}
Console.WriteLine($"Trimmed sentence: {sentence2}");

#endregion

#region Task2

Console.WriteLine("You are welcome!\n");
int[] options = new int[6] { 1, 2, 3, 4, 5, 0 };
int option;

do {
    Console.WriteLine("1.Addition");
    Console.WriteLine("2.Subtraction");
    Console.WriteLine("3.Multiplication");
    Console.WriteLine("4.Division");
    Console.WriteLine("5.Modulus");
    Console.WriteLine("0.Exit");
    Console.Write("\nEnter a number to choose an option: ");
    option = int.Parse(Console.ReadLine());

    for (int i = 0; i < options.Length; i++) {
        if (option == options[i]) {

            if (option == 0) {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.WriteLine("Enter two numbers!");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());

            switch (option) {
                case 1:
                    Console.WriteLine($"The result is: {(a + b)}\n");
                    break;
                case 2:
                    Console.WriteLine($"The result is: {(a - b)}\n");
                    break;
                case 3:
                    Console.WriteLine($"The result is: {(a * b)}\n");
                    break;
                case 4:
                    Console.WriteLine($"The result is: {(a / b)}\n");
                    break;
                case 5:
                    Console.WriteLine($"The result is: {(a % b)}\n");
                    break;
                default:
                    Console.WriteLine("Invalid option!\n");
                    break;
            }
        }
    }
} while (option != 0);

#endregion
