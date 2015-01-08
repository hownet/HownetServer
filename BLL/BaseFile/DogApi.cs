using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Hownet.BLL
{
    class DogAPI
    {
        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxFind(int appID, int[] keyHandles, int[] keyNumber);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxGetDevCaps(int[] keyHandles, int[] keyMode, int[] version, int[] e2size, int[] ramSize);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxOpen(int keyHandle, string userPin);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxReadStorage(int keyHandle, StringBuilder pBuffer);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxReadMem(int keyHandle, StringBuilder pBuffer);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxWriteMem(int keyHandle, string pBuffer);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxClose(int keyHandle);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxGetLastError();

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxGenRequestFile(int nKeyHandle, string szReqInfo, string szReqFile);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxUnlock(int nKeyHandle, string szUnlockFile);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxGetExpiryDateTime(int nKeyHandle, int[] tmMode, int[] endYear, int[] endMonth, int[] endDay, int[] endHour, int[] endMin);

        [DllImport("NoxTApp.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int NoxGetRemnantCount(int nKeyHandle, int[] nRemnant, int[] nMax, int[] Mode);
    }
}
