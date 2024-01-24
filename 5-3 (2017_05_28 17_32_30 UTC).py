# 5.3
# Johnathan Burgess
# input
def Input():
    r = float(input("Enter the radius of a sphere in feet: "))
    return r
# processing function - this will calculate the volume in feet by using the formula
# vol = 4/3 * pi * r^3 where vol is the volume, pi is pi, and r is the radius
def processing(r):
    pi = 3.14159
    vol = (4/3) * pi * (r**3)
    return vol
# output
def output(vol):
    print("The volume of the sphere is:",vol,"Cubic Feet")
# main
def main():
    r = Input()
    vol = processing(r)
    output(vol)


# Executes main()
main()
