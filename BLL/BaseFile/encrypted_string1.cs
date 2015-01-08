using System;
using System.Collections.Generic;
using System.Text;

namespace Hownet.BLL.BaseFile
{

    //    Source string:
    //sy-soft.com

    public class EncryptedString1
    {
        public const int EncryptBufFeatureID = 0;    //feature id which is selected
        public int SourceBufLen = 11;    //length of source string
        public int EncryptBufLen = 16;    //length of encrypt string

        public int isString = 1;    //This is a string buffer
        /*The encrypted array is in UTF-8 format. Please convert it to proper format before using it.*/

        public byte[] encryptStrArr = new byte[16]{ 0xE9, 0x29, 0x4F, 0x4F, 0x94, 0xB1, 0xD3, 0x36, 0x44, 0x45, 0x69, 0x59, 0x91, 0x30, 0xE3, 0xF7 };
    }
}