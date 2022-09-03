void print_digits(int num)
{
    if(num == 0)
        System.Console.WriteLine(num);

    while(num != 0)
    {
        var digit = num % 10;
        System.Console.WriteLine(digit);
        num /= 10;
    } 
}
print_digits(154);