/* Задача 68: Задайте значения M и N. Напишите программу, 
которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7 */
System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
// NOD (a,b);
PrintResult(a,b);
void PrintResult(int m, int n)
{
    System.Console.WriteLine($"НОД -> {NOD (a,b)}");
}

int NOD (int a, int b)
{
        if (b == 0)
                return a;
        else
                return NOD (b, a % b);
}


// void button1_Click(object sender, EventArgs e)
//         {
//            int a, b, c;
//            a = Convert.ToInt32(textBox1.Text);
//            b = Convert.ToInt32(textBox2.Text);
//            textBox3.Text = nod(a, b).ToString();
 
 
 
//         }