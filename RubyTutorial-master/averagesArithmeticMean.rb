=begin
Johnathan R. Burgess
Learning Ruby
11/15/2019

Averages/Arithmetic Mean problem - Rosetta Code
http://www.rosettacode.org/wiki/Averages/Arithmetic_mean

Write a program to find the mean (arithmetic average) of a numeric vector.

In case of a zero-length input, since the mean of an empty set of numbers
is ill-defined, the program may choose to behave in any way it deems appropriate,
though if the programming language has an established convention for conveying math
errors or undefined values, it's preferable to follow it.

=end

# our main method
def main()
  # calls our mean processing function, passing it an array of number
  # also assigns the result of the function to a variable "mean"
  mean = mean_of_numeric_vector([56,24,1,6,3,7])
  # outputs the value in mean
  puts "The mean of the vector is: #{mean}"
end

# this is the main processing function
def mean_of_numeric_vector(vector)
  # holds the total, this will be incremented to as the loop executes
  total = 0
  # iterate over every item in our array "vector"
  for item in vector
    # increments total
    total += item
  end
  # return value of total divided by the size of our array "vector"
  return total/vector.size
end

# calls our main function
main