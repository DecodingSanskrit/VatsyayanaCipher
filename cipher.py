# Python program to demonstrate
# Substitution Cipher
 
  
import string
    
class cipher:
    # A list containing all characters
    all_letters = string.ascii_letters

    dictionary = {}
    dict2 = {}    

    def __init__(self, keyvalues):
        if all_letters.len
            dictionary = keyvalues

    def __init__(self, key):
        for i in range(len(all_letters)):
                dictionary[all_letters[i]] = all_letters[(i+key)%len(all_letters)]
        
        for i in range(len(all_letters)):
            dict2[all_letters[i]] = all_letters[(i-key)%(len(all_letters))]

    def encrypt(textToEncrypt):
        for char in plain_txt:
                if char in all_letters:
                        temp = dictionary[char]
                        cipher_txt.append(temp)
                else:
                    temp =char
                    cipher_txt.append(temp)
                                                             
        cipher_txt= "".join(cipher_txt)
        return cipher_txt

    def decrypt(textToDecrypt):
        for char in cipher_txt:
            if char in all_letters:
                key = [k for k,v in a.items() if v == char]
                #temp = dict2[char]
                decrypt_txt.append(key)
            else:
                temp = char
                decrypt_txt.append(temp)
                                                             
        decrypt_txt = "".join(decrypt_txt)
        return decrypt_txt
