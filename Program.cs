Console.Clear();

Console.Write("Введите целое число больше 1: ");
int num = int.Parse(Console.ReadLine());
int count = 2;

while (count <= num) {
    Console.WriteLine(count);
    count += 2;
}
