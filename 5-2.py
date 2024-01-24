# 5.2

# input
def inputF():
    r = float(input("Enter the radius in feet of a cylinder: "))
    h = float(input("Enter the height in feet of a cylinder: "))
    return r, h

# processing - this function will follow the function vol = pi*(r^2)*h
# where vol is the volume in cubic feet, pi is pi, r is radius, and h is height
def processF(r,h):
    pi = 3.14159
    vol = pi * (r**2) * h
    return vol

# output
def output(vol):
    print("Your volume is:",vol,"cubic feet")

# main
def main():
    r,h = inputF()
    vol = processF(r,h)
    output(vol)
    
# Executes main()
main()
