function isPrime(num) {
    for (var d = 2; d < num; d++) {
        if (num % d === 0) return false
    }

    return true
}

function getNthPrime(num) {
    var primesFound = 1
    var currentNumber = 3

    while (primesFound != num) {
        if (isPrime(currentNumber)) primesFound++
            if (primesFound === num) return currentNumber
        currentNumber += 2
    }
}

function getLargestSubstringProduct(string, length) {
    var largestProduct = 0

    for (var i = 0; i <= string.length - length; i++) {
        var substring = string.substring(i, i + length).split("");

        var product = substring.reduce((x, y) => parseInt(x) * parseInt(y))

        if (product > largestProduct) {
            largestProduct = product
        }
    }

    return largestProduct
}

function findPythagoreanTripletWithGivenSum(sum, r = 2) 
{
    var rSquaredOverTwo = (r * r) / 2

    var factorPairs = getAllFactorPairs(rSquaredOverTwo)

    var triplets = factorPairs.map(x => getTriplet(r, x))

    var validTriplets = triplets.filter(x => x[0] + x[1] + x[2] === sum)

    if (validTriplets.length > 0) { return validTriplets[0] }

    return findPythagoreanTripletWithGivenSum(sum, r + 2) 

}

function getTriplet(r, x)
{
    return [r + x[0], r + x[1], r + x[0] + x[1]]
}

function getAllFactorPairs(num) 
{
    var values = Array.from(Array(num), (x,i) => i + 1)

    return values.map(x => { if (num % x == 0) return [x, num / x] }).filter(x => x !== undefined)
}

function getProductOfArrayElements(array) 
{
    return array.reduce((x,y) => x * y)
}

module.exports = {
    getNthPrime: getNthPrime,
    getLargestSubstringProduct: getLargestSubstringProduct,
    findPythagoreanTripletWithGivenSum: findPythagoreanTripletWithGivenSum
};