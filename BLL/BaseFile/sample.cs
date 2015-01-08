////////////////////////////////////////////////////////////////////
// Demo program for SuperDog licensing functions
//
// Copyright (C) 2013 SafeNet, Inc. All rights reserved.
//
// SuperDog(R) is a trademark of SafeNet, Inc.
//
////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using SuperDog;


namespace Hownet.BLL.BaseFile
{
   public class sample
    {
        public static EncryptionArray1 encryptArr1 = new EncryptionArray1();
        public static EncryptedString1 encrString1 = new EncryptedString1();
       // public static EncryptedConst1 encrConst1 = new EncryptedConst1();
        string scope = "<dogscope />";

        public DogStatus CheckKey()
        {
            DogStatus status;
            int i, j;
            i = j = 0; 

            Dog curDog = new Dog(new DogFeature(DogFeature.FromFeature(EncryptionArray1.GenArrFeatureID).Feature));

            /************************************************************************
             * Login
             *   establishes a context for SuperDog
             */
            status = curDog.Login(VendorCode.Code, scope);
            if (status != DogStatus.StatusOk)
            {
                if (status == DogStatus.InvalidVendorCode)
                {
                    Console.WriteLine("Invalid vendor code.\n");
                }
                else if (status == DogStatus.UnknownVcode)
                {
                    Console.WriteLine("Vendor Code not recognized by API.\n");
                }
                else
                {
                    Console.WriteLine("Login to feature failed with status: " + status);
                }
                return status;
            }


            //Generate a random index number
            Random random = new Random();
            i = random.Next(EncryptionArray1.GenerateCount);

            byte[] queryData = new byte[EncryptionArray1.EncryptDataLen];
            for (j = 0; j < EncryptionArray1.EncryptDataLen; ++j)
            {
                queryData[j] = encryptArr1.encryptionArray[i, 0][j];
            }

            /**********************************************************************
            * dog_encrypt encrypts a block of data using SuperDog (minimum buffer
            * size is 16 bytes)
            */
            status = curDog.Encrypt(queryData);
            if (DogStatus.StatusOk != status)
            {
                Console.WriteLine("Dog encrypt failed with status: " + status);
                return status;
            } 

            for (j = 0; j < EncryptionArray1.EncryptDataLen; ++j)
            {
                if (0 != (queryData[j] ^ encryptArr1.encryptionArray[i, 1][j]))
                {
                    Console.WriteLine("Encrypted data is wrong.");
                    curDog.Logout();
                    return DogStatus.InternalError;
                }
            }

            Console.WriteLine("Check Dog using encryption array success.");

            status = curDog.Logout(); 
            return status;
        }

        public DogStatus DecryptString()
        {
            DogStatus status;
            UInt32 i = 0;
            byte[] bufData;
            byte[] strTmp;
            string strContents; 

            Dog curDog = new Dog(new DogFeature(DogFeature.FromFeature(EncryptedString1.EncryptBufFeatureID).Feature));

            /************************************************************************
             * Login
             *   establishes a context for SuperDog
             */
            status = curDog.Login(VendorCode.Code, scope); 
            if (status != DogStatus.StatusOk)
            {
                if (status == DogStatus.InvalidVendorCode)
                {
                    Console.WriteLine("Invalid vendor code.\n");
                }
                else if (status == DogStatus.UnknownVcode)
                {
                    Console.WriteLine("Vendor Code not recognized by API.\n");
                }
                else
                {
                    Console.WriteLine("Login to feature failed with status: " + status);
                }
                return status;
            }

            bufData = new byte[encrString1.EncryptBufLen];
            for (i = 0; i < encrString1.EncryptBufLen; ++i)
            {
                bufData[i] = encrString1.encryptStrArr[i];
            }

            // decrypt the data.
            // on success we convert the data back into a 
            // human readable string.
            status = curDog.Decrypt(bufData);
            if (DogStatus.StatusOk != status)
            {
                Console.WriteLine("Dog decrypt failed with status: " + status);
                curDog.Logout();
                return status;
            }
            
            //If source string length is less than 16, we need cut the needless buffer
            if (encrString1.EncryptBufLen > encrString1.SourceBufLen)
            {
                strTmp = new byte[encrString1.SourceBufLen];
                for (i = 0; i < encrString1.SourceBufLen; ++i)
                {
                    strTmp[i] = bufData[i];
                }
                strContents = UTF8Encoding.UTF8.GetString(strTmp);
            }
            else
            {
                strContents = UTF8Encoding.UTF8.GetString(bufData);
            }

            //Use the decrypted string do some operation    
            if (0 == encrString1.isString)
            {
                DumpBytes(bufData, encrString1.SourceBufLen);
            }
            else
            { 
                Console.WriteLine("The decrypted string is: \"" + strContents + "\"."); 
            } 

            status = curDog.Logout();
            return status;
        }

        /// <summary>
        /// Dumps a bunch of bytes into the referenced TextBox.
        /// </summary>
        protected void DumpBytes(byte[] bytes, int ilen)
        {
            Console.WriteLine("The decrypted buffer data is below :");
            int index = 0;

            for (index = 0; index < ilen; index++)
            {
                if (0 == (index % 8))
                {
                    if (0 == index)
                    {
                        Console.Write("          ");
                    }
                    else
                    {
                        Console.Write("\r\n          "); 
                    } 
                } 
                Console.Write("0x" + bytes[index].ToString("X2") + " "); 
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("A simple program for the SuperDog licensing functions");
            Console.WriteLine("Copyright (C) SafeNet, Inc. All rights reserved.");
            Console.WriteLine("");

            sample testSample = new sample();

            // check key using encryption array
            testSample.CheckKey();


            // decrypt string or raw data using SuperDog
            testSample.DecryptString();

            Console.ReadKey();
        }
    }
}