findPythagoreanTripletWithGivenSum = (sum, r = 2) ->

	rSquaredOverTwo = (r * r) / 2

	factorPairs = getUniqueFactorPairs(rSquaredOverTwo)

	triplets = factorPairs.map((x) -> getTriplet(r, x))

	validTriplets = triplets.filter(x -> x[0] + x[1] + x[2] == sum)

	if (validTriplets.length > 0)
		validTriplets[0]

	if (r > sum / 3)
		[-1, -1, -1]

	findPythagoreanTripletWithGivenSum(sum, r + 2)

getTriplet = (r, x) ->

	[r + x[0], r + x[1], r + x[0] + x[1]]

getUniqueFactorPairs = (num) ->

	getUniqueElements(sortTuples(getAllFactorPairs(num)))

getAllFactorPairs = (num) ->

	Array.from(new Array(num), (x, i) -> i + 1).filter((x) -> num % x == 0).map((x) -> [x, num / x])

comparator = (x, y) ->

	if x[0] == y[0]
		0

	if x[0] < y[0]
		-1
	1

sortTuples = (array) ->

	array.map((x) -> x.sort((x, y) -> x > y)).sort((x, y) -> comparator(x, y))

getUniqueElements = (array) ->

	tmp = []

	tmp = array.filter((x) -> tmp.indexOf(x.toString()) < 0)

	return 1

module.exports = { findPythagoreanTripletWithGivenSum: findPythagoreanTripletWithGivenSum }

