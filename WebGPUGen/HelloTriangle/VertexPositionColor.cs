using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloTriangle
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public readonly struct VertexPositionColor
    {
        public static unsafe readonly int SizeInBytes = sizeof(VertexPositionColor);

        public VertexPositionColor(in Vector3 position, in Vector4 color)
        {
            Position = position;
            Color = color;
        }

        public readonly Vector3 Position;
        public readonly Vector4 Color;
    }
}
