import threading
import time
import sys
def write():
    print('Tao mot tap tin moi') 

    try:
        file = open('khanh.txt','w')
        file.write("Day la chuong trinh thu nghiem Day la chuong trinh thu nghiem  \n")   
        file.close()

    except:
        print('Co loi roi ....')
#        sys.exit(0)
def read():
    print('Doc tap tin da tao') 

    try:
        file = open('khanh.txt','r')
        for line in file:
            print(line)   
        file.close()

    except:
        print('Co loi khi doc tap tin ....')
#        sys.exit(0) 
t = time.time()

#write()
#read()
t1= threading.Thread(target=write)
t2= threading.Thread(target=read)

t1.start()
t2.start()

t1.join()
t2.join()
print('Thoi gian doc tap tin la : ',time.time()-t)
print('Finish !')
