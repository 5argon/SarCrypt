# SarCrypt - Stupid one-way text encryption.

## Features
- One by one character substitution, kind of like Caesar Cipher but with a constrained character set and a string key instead of an offset value.
- Encrypt with key and alphabet set, the result will only use characters from the alphabet set. This makes encrypted text easy to type. So you can exclude easily mistaken characters in some fonts like 1, i, L, l or 0, o, O.
- Unlike Caesar Cipher this Encryption is one-way because it may loops over the character set multiple times resulting in the same character.
- The text before encryption must also use characters from the same set, so a Generate(length) function is also included.

## Example Situation
- A : I uploaded the file and the program says XSa34! What should I do to download them?
- B : Use this code : 9Qr7g
- A : No registration system? So I must ask you every time?
- B : Yes.

## Sample Encryption
- Input : eXc7v
- Character Set : "abcdefghjklmnpqrstuvwyxzABCDEFGHJKLMNPQRSTUVWXYZ23456789"
- Key : 5argondesu
- Output : qVtbH

## Sample Program
Please see Sample.cs
