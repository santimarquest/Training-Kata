# Manhattan Distance
	Manhattan distance is the distance between two points in a grid (like the grid-like street geography of the New York borough of Manhattan) 
	calculated by only taking a vertical and/or horizontal path.

	Write a function int manhattanDistance(Point, Point) that returns the Manhattan Distance between the two points.

	# Potential constraints
		The class Point is immutable
		The class Point has no Getters, no Setters
		The class Point has no public properties (i.e. the internal state cannot be read from outside the class).

	# Suggested tests
		manhattanDistance( Point(1, 1), Point(1, 1) ) should returns 0
		manhattanDistance( Point(5, 4), Point(3, 2) ) should returns 4
		manhattanDistance( Point(1, 1), Point(0, 3) ) should returns 3

	# Test
		NUnit

# Banking
	
	Your bank is tired of its mainframe COBOL accounting software and they hired both of you for a greenfield project in - what a happy coincidence
	Your task is to show them that your TDD-fu and your new-age programming language can cope with good ole’ COBOL!

	# Requirements
		Write a class Account that offers the following methods void deposit(int) void withdraw(int) String printStatement()

	# An example statement would be:

	Date        Amount  Balance
	24.12.2015   +500      500
	23.8.2016    -100      400