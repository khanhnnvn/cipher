#!/usr/bin/env python
# -*- coding: utf-8 -*-
class Caesar():
    key = u" aáàạảãăắằặẳẵâấầậẩẫbcdđeéẹẻẽêếềệểễfghiíìịỉĩjklmnoóòọỏõôốồộổỗơớờợởỡpqrstuúùụủũưứừựửữvwxyýỳỵỷỹAÁÀẠẢÃĂẮẰẶẲẴÂẤẦẬẨẪBCDĐEÉẸẺẼÊẾỀỆỂỄFGHIÍÌỊỈĨJKLMNOÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠPQRSTUÚÙỤỦŨƯỨỪỰỬỮVWXYÝỲỴỶỸ0123456789`~!@#$%^&*()"

    def encrypt(self, n, plaintext):
        """Encrypt the string and return the ciphertext"""
        result = "".encode("utf8")

        for l in plaintext:
            i = (self.key.index(l) + n) % len(self.key)
            result += self.key[i]

        return result


    def decrypt(self, n, ciphertext):
        """Decrypt the string and return the plaintext"""
        result = "".encode("utf8")

        for l in ciphertext:
            try:
                i = (self.key.index(l) - n) % len(self.key)
                result += self.key[i]
            except ValueError:
                result += l

        return result


    def show_result(self, plaintext, n):
        """Generate a resulting cipher with elements shown"""
        encrypted = self.encrypt(n, plaintext)
        decrypted = self.decrypt(n, encrypted)

        print 'Rotation: ' + str(n)
        print 'Plaintext: ' + plaintext.encode("utf8")
        print 'Encrytped: ' + encrypted
        print 'Decrytped: ' + decrypted.encode("utf8")

if __name__ == '__main__':
    caesar = Caesar()
    input_text = raw_input("Please enter your text: ")
    real_input = input_text.decode("utf8")
    caesar.show_result(real_input, 1)

