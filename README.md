# Solicen.SEncrypt

## На русском
* Класс для реализации простого шифрования файла
* Может как зашифровать файл, так и расшифровать файл, и передать его расшифровку в строку.

### Использование:
* Определить какое смещение вы будете использовать (смещение - это количество дополнительных нулевых байтов, для зашифровки файла)

* Для зашифровки: использовать метод `Encrypt(файл)` или `EncryptWithOffset(файл,смещение)`
* Для расшифровки: использовать метод `Decrypt(файл)` или `DecryptWithOffset(файл,смещение)`
  * Если создание файла не нужно, то `DecryptToStringWithOffset(файл,смещение)` это вернет вам расшифровку как строку.

## English
* Class for simple realize encrypt file.
* May and encrypt, and else decrypt file, also give his decrypt bytes to string.

### Usage:
* Determine which offset you will use (offset is the number of additional zero bytes to encrypt the file)

* For Encrypt: use `Encrypt(filePath)` or `EncryptWithOffset(filePath,offset)`
* For Decrypt: use `Decrypt(filePath)` or `DecryptWithOffset(filePath,offset)`
  * If file creation is not necessary, then `DecryptToStringWithOffset(filePath,offset)` this return decrypt as string.
