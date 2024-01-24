# input
def inputFunction():
    miles = \
          int \
            (input \
             ("Enter number of miles you are traveling with United States Airlines:"))
    return miles
# processing
def processingFunction(miles):
    passenger_class=""
    if miles < 10000:
        passenger_class="Class Z"
    elif miles > 100000:
        passenger_class="Class A"
    elif miles > 50000:
        if miles < 100000:
            passenger_class="Class B"
    elif miles > 10000:
        if miles < 50000:
            passenger_class="Class C"

    return passenger_class
# output
def outputFunction(passenger_class):
    print("You are a",passenger_class,"passenger!")

def main():
    miles = inputFunction()
    passenger_class = processingFunction(miles)
    outputFunction(passenger_class)
    
main()
