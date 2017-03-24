#
# Sample implementation of RSA algorithm
# rsa_algorithm.py
# Author: Khanh Nguyen -- khanhnnvn@gmail.com
#

def gcd (a, b):
    "Tim uoc chung lon nhat"
    
    if b == 0: return a
    else: return gcd(b, a % b)

def multiplicative_inverse(a, b):
    """ Tim nhan nghich dao cua phep modulo b (a > b)
        pheo dong du """
    
    origA = a
    X = 0
    prevX = 1
    Y = 1
    prevY = 0

    while b != 0:

        temp = b
        quotient = a/b
        b = a % b
        a = temp

        temp = X
        a = prevX - quotient * X
        prevX = temp

        temp = Y
        Y = prevY - quotient * Y
        prevY = temp

    return origA + prevY

def generateRSAKeys(p, q):
    "Tao khoa cong khai va bi mat tu so nguyen to p & q"

    n = p * q
    m = (p - 1) * (q - 1)

    # Generate a number e so that gcd(n, e) = 1, start with e = 3
    e = 3
    
    while 1:
        
        if gcd(m, e) == 1: break
        else: e = e + 2

    # start with a number d = m/e will be atleast 1
    
    d = multiplicative_inverse(m, e)   

    # Return a tuple of public and private keys 
    return ((n,e), (n,d))           
    
if __name__ == "__main__":

    print "RSA Encryption algorithm by Khanh Nguyen"
    p = long(raw_input("Enter the value of p (prime number):"))
    q = long(raw_input("Enter the value of q (prime number):"))

    print "Generating public and private keys.... pls wait ..."
    (publickey, privatekey) = generateRSAKeys(p, q)

    print "Public Key (n, e) =", publickey
    print "Private Key (n, d) =", privatekey

    n, e = publickey
    n, d = privatekey

    input_num = long(raw_input("Enter a number to be encrypted:"))
    encrypted_num = (input_num ** e) % n
    print "Encrypted number using public key =", encrypted_num
    decrypted_num = encrypted_num ** d % n
    print "Decrypted (Original) number using private key =", decrypted_num
    print "Finish all. Thanks :)"
