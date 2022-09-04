bool is_power_of_two(int num)
{
    if(num == 0) return false;

    var bit_count = 0;
    
    while(num != 0)
    {
        bit_count += num & 1;
        num = num >> 1;
    }

    return bit_count == 1;
}

System.Console.WriteLine(is_power_of_two(15));