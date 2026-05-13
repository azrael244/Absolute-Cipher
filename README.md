# Absolute Cipher: User Manual & Technical Documentation

## 1. Overview
Absolute Cipher is a multi-layered encryption system designed for English text. It features a dynamic key-based offset and a triple-logic rotation cycle. The system ensures high security by masking word structures and injecting randomized noise.

## 2. Core Features
* Dynamic Macro Cycle: A 36-step sequence that determines which encryption logic is applied to each character.
* Dynamic Key: A password-based offset that shifts the starting point of all internal cycles.
* Space Masking: Randomly replaces spaces with ?, !, /, \, or | while using hidden markers to ensure 100% decryption accuracy.
* Noise Injection: Optional obfuscation using the $ symbol to break visual patterns.

## 3. The Triple-Logic System
Each character is processed through one of three logics based on its position in the cycle:

### Logic 1: ROT13 (Alphabetical Shift)
Characters are shifted by 13 positions in the Latin alphabet.
Example: A <-> N, B <-> O.

### Logic 2: Symbol Mapping
Characters are replaced by a unique 2-symbol pair:
A: /* B: */   C: //   D: ** E: \\   F: \/   G: /\
H: ++   I: --   J: [* K: *]   L: [^   M: ^]   N: {#
O: #}   P: <>   Q: ><   R: ~\   S: +/   T: /-   U: =%
V: &?   W: !|   X: ()   Y: _~   Z: @#

### Logic 3: Mathematical Shift
The character is converted to its alphabet position (A=1, Z=26) and added to a shifting value from the Math Cycle: {5, 6, 7, 6, 5}.
Example: A (1) + Shift (5) = 6.

## 4. Encryption Cycles
The Macro Cycle follows this 36-step sequence:
1, 2, 3 | 1, 2, 3 | 1, 3, 2 | 1, 3, 2 | 3, 2, 1 | 3, 2, 1
3, 1, 2 | 3, 1, 2 | 2, 1, 3 | 2, 1, 3 | 2, 3, 1 | 2, 3, 1

Note: The Key shifts the starting index of both the Macro Cycle and the Math Cycle.

## 5. Instructions for Use

### How to Encrypt:
1. Enter your text in the Text box.
2. (Optional) Enter a password in the Key box.
3. Click ENCRYPT.
4. (Optional) Click ADD NOISE to insert random $ symbols for extra protection.

### How to Decrypt:
1. Copy the encrypted text into the Text box.
2. If the text contains $ symbols, click CLEAN CODE first.
3. Enter the same Key used for encryption.
4. Click DECIPHER.

## 6. Security Notes
* The Key Matters: If the key is incorrect, Logic 1 and Logic 3 will produce wrong characters, and the entire cycle alignment will fail.
* Zero-Width Markers: The cipher uses invisible markers to distinguish between a "space symbol" and an "encryption symbol". Do not manually edit the encrypted string unless you are only adding/removing $ noise.
