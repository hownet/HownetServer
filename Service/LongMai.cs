using System;
using System.Collections.Generic;
using System.Text;
using Nox2DotNet2Lib;

namespace Service
{
    public class LongMai
    {
        private Nox2AppApis noxApi = new Nox2AppApis();
        byte[] rand = new byte[16];

        public bool checkLongMai(byte[] rand)
        {
            int[] keyHandles = new int[8];
            int[] keyNum = new int[1] { 0 };
            int appID = 0x19800327;
            int nRet = noxApi.NoxFind((appID), keyHandles, keyNum);
            if (nRet != 0)
            {
                return false;
            }
            sbyte[] guid = new sbyte[32];
            if (0 != noxApi.NoxGetUID(keyHandles[0], guid))
            {
                return false;
            }
            int a = noxApi.NoxGetUID(keyHandles[0], guid);
            String userPin = "b10c3efb3363d2d3364b33fc38153205"; 
            if (0 != noxApi.NoxOpen(keyHandles[0], userPin))
            {
                return false;
            }
            if (0 != noxApi.NoxWriteMem(keyHandles[0], rand))
            {
                return false;
            }
            if (0 != noxApi.NoxReadMem(keyHandles[0], rand))
            {
                return false;
            }
            noxApi.NoxClose(keyHandles[0]);
            return true;
        }
    }
}
