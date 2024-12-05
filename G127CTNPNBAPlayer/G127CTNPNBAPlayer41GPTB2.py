import time

def thapHaNoi(n, toaMot, toaHai, toaBa):
    if n == 1:
        print("chuyen tu", toaMot, "sang", toaBa)

    else:
	    thapHaNoi(n-1, toaMot, toaBa, toaHai)
	    print("chuyen tu", toaMot, "sang", toaBa)
	    thapHaNoi(n-1, toaHai, toaMot, toaBa)
	    
n = int(input("Nhap so Dia: "))
#..
thapHaNoi(n,"1","2","3")
