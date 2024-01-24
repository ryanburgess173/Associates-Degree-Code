# This program will take input from a file/ledger of transcations for a store and give total
# sales for the day for each item.

# Johnathan R. Burgess, 6/6/2018

# This is our main Data Structure
class data:
    itemsTransactions = ""
    itemsTransactions2 = []
    # string of burgers sold
    burgers = ""
    #list
    burgers2 = []
    # string of fries sold
    fries = ""
    #list
    fries2 = []
    # string of drinks sold
    drinks = ""
    #list
    drinks2 = []
    # string of hotdogs sold
    hotdogs = ""
    #list
    hotdogs2 = []

    # This method sorts out each line into the four seperate strings
    def sortOut(self):
        
        self.itemsTransactions2 = self.itemsTransactions.split('\n')
        
        self.burgers = self.itemsTransactions2[0]
      
        self.fries = self.itemsTransactions2[1]
        
        self.drinks = self.itemsTransactions2[2]
  
        self.hotdogs = self.itemsTransactions2[3]

        print("Finished sorting lines into 4 different strings.")

        # converts the 4 strings into 4 lists containing transaction amounts
        self.burgers2 = self.burgers.split("\t")
        self.fries2 = self.fries.split("\t")
        self.drinks2 = self.drinks.split("\t")
        self.hotdogs2 = self.hotdogs.split("\t")

        print("Finished sorting 4 strings into 4 lists containing transaction amounts")

        # returns the lists
        return self.burgers2, self.fries2, self.drinks2, self.hotdogs2

    
# input function
def inputFunction():
    
    # gets input from the user
    fileName = str(input("Enter the date formatted MMDDYYYY: "))

    # returns the input from the user
    return fileName

    
# inputFile object
class inputFile:
    global fileName
    fileName = ""

    # constructor method for inputFile class
    def __init__(self, fileN):
        self.fileName = fileN

    # this method opens a file and passes it to the readFile method
    def openFile(self):
        # opens the file named the equivalent of whatever is stored in self.fileName, read attribute
        file = open(self.fileName+".txt", "r")
        # passes the file to the readFile method of the inputFile object
        self.readFile(file)
    
    def readFile(self, file):
        #new instance of data class
        global structure
        structure = data()
        # adds the line from the file to the itemsTransactions list in our main
        # data structure
        structure.itemsTransactions = (file.read())
        print("Finished fetching contents from file.")
        self.closeFile(file)

    def closeFile(self, file):
        file.close()

# fileWrite function for writing to a file
def fileWrite(bT, fT, dT, hT):
    file = open(fileName+"#2.txt", "w")
    file.write("Date: "+fileName+"\n")
    file.write("Burger Sales: $"+str(bT)+"\n")
    file.write("Fry Sales: $"+str(fT)+"\n")
    file.write("Drink Sales: $"+str(dT)+"\n")
    file.write("Hotdog Sales: $"+str(hT)+"\n")
    file.close()

# this function will calculate totals
def calculations(Bs, Fs, Ds, Hs):
    # four lists to hold the float equivalents of the string
    # items in the lists passed to this function
    B = []
    F = []
    D = []
    H = []

    # Converts each string item in the list to a float value
    for i in range(Bs.__len__()):
        B.append(float(Bs[i]))

    # Converts each string item in the list to a float value
    for q in range(Fs.__len__()):
        F.append(float(Fs[q]))

    # Converts each string item in the list to a float value
    for j in range(Ds.__len__()):
        D.append(float(Ds[j]))

    # Converts each string item in the list to a float value
    for l in range(Hs.__len__()):
        H.append(float(Hs[l]))

    # assigns the sum of all items in the lists to different variables     
    burgersTotal = sum(B)
    friesTotal = sum(F)
    drinksTotal = sum(D)
    hotDogsTotal = sum(H)

    # returns the totals for each item to be passed to the fileWrite function
    return burgersTotal, friesTotal, drinksTotal, hotDogsTotal

# main function which causes all parts to execute
def main():
    fileN = inputFunction()
    theFile = inputFile(fileN)
    theFile.openFile()
    Bs, Fs, Ds, Hs = structure.sortOut()
    bT, fT, dT, hT = calculations(Bs, Fs, Ds, Hs)
    fileWrite(bT, fT, dT, hT)
    
# calls the main functions causing the program to execute
main()
