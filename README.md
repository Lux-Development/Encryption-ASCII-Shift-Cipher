# Encryption-ASCII-Shift-Cipher

![enc_github](https://github.com/joelb-services/Encryption-ASCII-Shift-Cipher/assets/144958989/8c3c3a88-5427-4eb0-903f-da2b12d256c3)

## What is a Shift Cipher?

A shift cipher, also known as a Caesar cipher, is a substitution cipher where each letter in the plaintext is shifted a certain number of places down or up the alphabet. In this application, the shift cipher is used to encrypt and decrypt files by shifting the ASCII values of their characters.

## Features

- **File Encryption and Decryption:** Encrypt your files for added security and decrypt them when needed.

- **Customizable Security Levels:** Choose from different security levels to control the strength of encryption:
  - Low: Shifts +2
  - Medium: Shifts +4
  - High: Shifts +6
  - Extreme: Shifts +9 (Caution: May cause issues)

- **Backspace:** Correct input errors by removing the last entered character.

- **Reset:** Clear the current encryption or decryption process and start fresh.

## Folders Required

Please ensure that the following folders exist on your system for the program to function correctly. You can create these folders manually:

- `C:\Encryption\[Level] # Low`
- `C:\Encryption\[Level] # Medium`
- `C:\Encryption\[Level] # High`
- `C:\Encryption\[Level] # Extreme`

### How Encryption Works

```csharp
string encryptedText = "";
for (int i = 0; i < input.Length; i++)
{
    encryptedText += (char)(input[i] + shift); // Replace 'shift' with the selected shift value.
}
```

### How Decryption Works
```csharp
string decryptedText = "";
for (int i = 0; i < input.Length; i++)
{
    decryptedText += (char)(input[i] - shift); // Replace 'shift' with the original shift value used to encrypt.
}
```

# How to use source?

1. Clone or Download: Clone this repository or download the source code to your local machine.
2. Build the Project: Use Visual Studio 2022 or your preferred C# development environment to build the project.

### Add SiticoneUI Reference:

1. Open your project in Visual Studio 2022.
2. Right-click on "References" in the Solution Explorer and choose "Add Reference..."
3. Click the "Browse" button and locate the downloaded SiticoneUI DLL.
4. Click "Add" and then "OK" to add the SiticoneUI reference to your project.

### Using application:
1. Launch the Application: Open the generated executable.
2. Select Encryption Level: Choose a security level (Low, Medium, High, or Extreme) from the dropdown menu.
3. Encrypt or Decrypt Files: Click the "Encrypt File" or "Decrypt File" button to select a file for encryption or decryption.
4. View Results: The encrypted or decrypted file will be saved in the corresponding folder based on the selected security level.
5. Correct or Start Over: Use the "Backspace" button to correct input errors or the "Reset" button to clear and begin a new operation.
