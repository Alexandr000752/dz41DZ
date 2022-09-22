
Console.WriteLine("Введите числа через запятую: ");
string numbers = Console.ReadLine();

int[] a = Array(numbers);
NumberOfPositive(a);


void NumberOfPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > 0 )
        {
            Console.Write(array[i] + ", ");
            result++;            
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Введенно {result} положительных чисел");
}

int[] Array(string nums)
{
    int count = 1;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == ',')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    int index = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        string temp = "";

        while (nums [i] != ',')
        {
        if(i != nums.Length - 1)
        {
            temp += nums [i].ToString();
            i++;
        }
        else
        {
            temp += nums [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}
