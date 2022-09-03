int reverse_digits(int num)
{
    if(num == 0) return num;

    var result = 0;
    
    while(num != 0)
    {
        result *= 10;
        var digit = num % 10;
        result += digit;
        num /= 10;
    }

    return result;
}
System.Console.WriteLine(reverse_digits(135));