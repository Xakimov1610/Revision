string? convert_to_binary(int num)
{
    if(num == 0) return "0";

    var result = "";
    
    while(num != 0)
    {
        var digit = num % 2;
        result += digit.ToString();
        num /= 2;
    }

    return new string(result.Reverse().ToArray());
}

System.Console.WriteLine(convert_to_binary(0));