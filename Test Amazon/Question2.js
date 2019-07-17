function generalizedGCD(num, arr)
{
    // Here I use spread syntex to get minimum of array
    const lowest = Math.min(...arr);
    
    //Open the loop
    for(let i = lowest; i > 1; i--)
    {
        //I declare the variable for comparison later(of numbers)
        let isCommonDivisor = true;
        //Open the loop again for comparison
        for(let j = 0; j < num; j++)
        {
            //
            if(arr[j] % i != 0)
            {
                isCommonDivisor = false;
                break;
            }    
        }
        if(isCommonDivisor)
        {
            return i;
        }
    }
    return 1;
}