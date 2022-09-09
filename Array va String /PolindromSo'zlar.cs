bool is_palindrome(string word)
{
    var low = 0;
    var high = word.Length-1;
    
    while(low < high)
    {
        if(word[low] != word[high]) return false;

        low++;
        high--;      
    }
    return true;
    
}
System.Console.WriteLine(is_palindrome("aziza"));
 