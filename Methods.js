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

function getLargestSubstringProduct(string, length) 
{
    var largestProduct = 0

    for (var i = 0; i <= string.length - length; i++) 
    {
        var substring = string.substring(i, i + length).split("")

        var product = substring.reduce((x,y) => parseInt(x) * parseInt(y))

        if (product > largestProduct)
        {
            largestProduct = product
        }
    }

    return largestProduct
}

console.log("test")