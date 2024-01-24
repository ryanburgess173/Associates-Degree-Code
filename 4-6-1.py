#Simple Bank ATM
def main():
    PIN=7777;balance=500;pin=0;success=False

    pin=getInput(pin)
    pin,PIN,balance,success=processing(pin,PIN,balance,success)
    display(success,balance)

#Input Function
def getInput(pin):
    pin=int(input("Please enter your PIN:"))
    return pin

#Processing Function
def processing(pin,PIN,balance,success):
    if pin==PIN:
        success=True
        amt=float(input("How much would you like to withdraw?"))
        if amt<=balance:
            balance=balance-amt
            return pin,PIN,balance,success
        else:
            print("You don't have that much money!")
    else:
        success=False
        return pin,PIN,balance,success

#Output Function
def display(success,balance):
    if success:
        print("Your new balance is:$", format(balance,'7.2f'),sep='')
    else:
        print("Your card is being held for security reasons.")
        print("Please step into the bank to make your withdrawal.")
main()
