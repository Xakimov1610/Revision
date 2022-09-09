int[] merge_two_arrays(int[] arr1, int[] arr2)
{
    var i = 0;
    var j = 0;
    var n = arr1.Length;
    var m = arr2.Length;
    var result = new int[n + m];
    
    while(i < n && j < m)
    {
        if(arr1[i] < arr2[j])
        {
            result.Append(arr1[i]);
            i++;
        }
        else
        {
            result.Append(arr2[j]);
            j++;
        }     
    }
    while(i < n)
    {
        result.Append(arr1[i]);
        i++;
    }
    while(j < m)
    {
        result.Append(arr2[j]);
        j++;
    }

    return result;
    
}

var res = merge_two_arrays(new int[] {1,3,5,7,8,11}, new int[] {2,4,6,9,10});
Array.ForEach(res, Console.WriteLine);