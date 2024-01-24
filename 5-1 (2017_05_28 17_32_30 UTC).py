# 5.1

#This is the input function
def i_fun():
    L = float(input("Enter the length of a rectangle in feet: "))
    W = float(input("Enter the width of a rectangle in feet: "))
    H = float(input("Enter the height of a rectangle in feet: "))
    return L, W, H

# Processing Fucntion that multiplies the length, width, and height together to
# get the cubic feet
def p_fun(L,W,H):
    result = L*W*H
    return result


#Output Function
def o_fun(result):
    print("Cubic Feet:", result, "ft.")



# Function main() which everything executes from
def main():
    L,W,H = i_fun()
    result = p_fun(L,W,H)
    o_fun(result)

    
# Calls the function main()   
main()
