using System;
using System.Diagnostics;

namespace HelloTriangle
{
    public unsafe static class Helpers
    {
        public static char* ToPointer(this string text)
        {
            return (char*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
        }

        public static unsafe string GetString(char* stringStart)
        {
            int characters = 0;
            while (stringStart[characters] != 0)
            {
                characters++;
            }

            return System.Text.Encoding.UTF8.GetString((byte*)stringStart, characters);
        }
    }
}
