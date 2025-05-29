namespace HelloTriangleWasm
{
    public unsafe static class Helpers
    {
        public static char* ToPointer(this string text)
        {
            return (char*)System.Runtime.InteropServices.Marshal.StringToHGlobalAnsi(text);
        }
    }
}
