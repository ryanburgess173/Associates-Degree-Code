# Johnathan R. Burgess, 3590
# Last modified on 9/21/2016
# CIS-115-FJT01, Intro to Programming and Logic
# Mid-Term Python Project
# Liability Car Insurance Cost Calculator


#INPUT

#This function is responsible for collecting user input and passing
#it to our "main" function
def input_function():
    # Boolean Variables that tell us whether or not the name, age, and violations have been entered, and entered correctly
    age_correct = False
    name_correct = False
    violations_correct = False

    # Run this loop until the name has been entered, and entered correctly
    while(name_correct == False):
        customer_name = input("Enter your name......................: ")
        #tests to see if customer_name is a blank string
        if(customer_name == ""):
            print("Invalid Entry!")
            continue
        #tests to make sure customer_name consists of words and not numbers or symbols
        if(customer_name.isalpha() == False):
            print("Invalid Entry!")
            continue
        else:
            name_correct = True

    # Run this loop until the age has been entered, and entered correctly    
    while(age_correct == False):
        #tries the code below, and if it throws a ValueError, it will run the code below it
        try:
            customer_age = int(input("Enter your age.......................: "))
        #if the ValueError was thrown above, run the code below
        except ValueError:
            print("Invalid Entry!")
            continue
        #Tests to see if nothing was entered
        if(customer_age == None):
            print("Invalid Entry!")
            continue

        #If the age is less than 16
        if(customer_age < 16 and customer_age >= 0):
            print("Invalid Entry!")
        #If age is less than 0
        elif(customer_age < 0):
            print("Invalid Entry!")
        #If age is older than 105
        elif(customer_age > 105):
            print("Invalid Entry!")
        else:
            age_correct = True

    # Run this loop until the number of violations has been entered, and entered correctly
    while(violations_correct == False):
        #Tries the input below, and if a ValueError exception is thrown,
        #it will print that the input is not valid
        try:
            customer_traffic_violations = \
                                int(input \
                                    ("Enter the number of violations.......: "))
        #Do this if a ValueError exception is thrown for the above "try"
        except ValueError:
            print("Invalid Entry!")
            continue
        if(customer_traffic_violations < 0):
            print("Invalid Entry!")
            continue
        else:
            violations_correct = True
            
    return customer_name, customer_age, customer_traffic_violations



#PROCESSING
   #This function processes the risk code and risk level based on traffic violations
def risk_processing_function(customer_traffic_violations):

    #tests the number of traffic violations in order to determine a risk code
    
    if customer_traffic_violations >= 4:
        customer_risk_code = 1
    elif customer_traffic_violations == 3:
        customer_risk_code = 2
    elif customer_traffic_violations == 2:
        customer_risk_code = 2
    elif customer_traffic_violations == 1:
        customer_risk_code = 3
    else:
        customer_risk_code = 4

    #tests the risk code in order to determine a risk level
        
    if customer_risk_code == 1:
        customer_risk_level = "High"
    elif customer_risk_code == 2:
        customer_risk_level = "Moderate"
    elif customer_risk_code == 3:
        customer_risk_level = "Low"
    else:
        customer_risk_level = "No"

    return customer_risk_code, customer_risk_level
        


   #This Function processes the monthly insurance cost for the customer based on risk
   #code and the customer's age
def cost_processing_function(customer_risk_code, customer_age, customer_traffic_violations):
    if customer_age < 25:
        if customer_risk_code == 1:
            customer_insurance_cost = 480
        elif customer_risk_code == 2:
            if customer_traffic_violations == 3:
                customer_insurance_cost = 450
            elif customer_traffic_violations == 2:
                customer_insurance_cost = 405
        elif customer_risk_code == 3:
            customer_insurance_cost = 380
        else:
            customer_insurance_cost = 325


    #Goes through this block if customer_age is greater than or equal to 25             
    elif customer_age >= 25:
        if customer_risk_code == 1:
            customer_insurance_cost = 410
        elif customer_risk_code == 2:
            if customer_traffic_violations == 3:
                customer_insurance_cost = 390
            elif customer_traffic_violations == 2:
                customer_insurance_Cost = 365
        elif customer_risk_code == 3:
            customer_insurance_cost = 315
        else:
            customer_insurance_cost = 275

    return customer_insurance_cost


#OUTPUT
def output_function(name, level, cost):

    #Simple print statement, formatting the customer_insurance_cost to show 2 decimal places
    print(name, ", as a ", level, \
          " risk driver, your insurance will cost $", \
          format(cost, '.2f'), sep="", end=".")
    



#MAIN

def main():
        #calls input_function with no arguments, returns customer_name, customer_age,
        #and customer_traffic_violations
        customer_name, customer_age, customer_traffic_violations = input_function()

        #calls risk_processing_function, passing the arguments
        #customer_traffic_violations, returns customer_risk_code and customer_risk_level
        customer_risk_code, customer_risk_level = \
                            risk_processing_function(customer_traffic_violations)

        #calls cost_processing_function, passing the arguments customer_risk_code,
        #customer_age, and customer_traffic_violations, returns customer_insurance_cost
        customer_insurance_cost = cost_processing_function(customer_risk_code, customer_age, \
                                 customer_traffic_violations)

        #calls output_function, passing the arguments customer_name, customer_risk_level,
        #and customer_insurance_cost.
        output_function(customer_name, customer_risk_level, customer_insurance_cost)


#calls/executes the main function   
main()
