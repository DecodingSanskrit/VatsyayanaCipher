﻿

const all_letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

const dictionary = {};

function init(key) {
    for (let i = 0; i < all_letters.length; i++) {
        dictionary[all_letters[i]] = all_letters[(i + key) % all_letters.length];
    }
}

function encrypt(textToEncrypt, key) {
    init(key);
    let cipher_txt = "";

    // loop to generate ciphertext
    for (let i = 0; i < textToEncrypt.length; i++) {
        const char = textToEncrypt[i];
        if (all_letters.includes(char)) {
            const temp = dictionary[char];
            cipher_txt += temp;
        } else {
            cipher_txt += char;
        }
    }

    return cipher_txt;
}

function getKeyByValue(object, value) {
    return Object.keys(object).find(key => object[key] === value);
}

function decrypt(textToDecrypt, key) {
    init(key);
    let decrypt_txt = "";

    for (let i = 0; i < textToDecrypt.length; i++) {
        const char = textToDecrypt[i];
        if (all_letters.includes(char)) {
            const temp = getKeyByValue(dictionary, char);
            decrypt_txt += temp;
        } else {
            decrypt_txt += char;
        }
    }

    return decrypt_txt;
}