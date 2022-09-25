#### [Русский](https://github.com/DenisSolicen/Solicen.SEncrypt) | English

## English
* Class for simple realize encrypt file.
* May and encrypt, and else decrypt file, also give his decrypt bytes to string.

### Usage:
* Determine which offset you will use (offset is the number of additional zero bytes to encrypt the file)

* For Encrypt: use `Encrypt(filePath)` or `EncryptWithOffset(filePath,offset)`
* For Decrypt: use `Decrypt(filePath)` or `DecryptWithOffset(filePath,offset)`
  * If file creation is not necessary, then `DecryptToStringWithOffset(filePath,offset)` this return decrypt as string.

#### Author of classes - [Denis Solicen](https://github.com/DenisSolicen)
