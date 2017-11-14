function isPrime(num)
{
    for (var d = 2; d < num; d++)
    {
        if (num % d === 0) return false
    }

    return true
}

function getNthPrime(num) 
{
    var primesFound = 1
    var currentNumber = 3

    while (primesFound != num)
    {
        if (isPrime(currentNumber)) primesFound++
        if (primesFound === num)    return currentNumber
        currentNumber += 2
    }
}

console.log(getNthPrime(10001))