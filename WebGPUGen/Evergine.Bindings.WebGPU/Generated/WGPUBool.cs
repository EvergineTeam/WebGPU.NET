using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evergine.Bindings.WebGPU
{
    /// <summary>
    /// A boolean value stored in a 4-byte unsigned integer.
    /// </summary>
    public struct WGPUBool : IEquatable<WGPUBool>
    {
        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 1.
        /// </summary>
        public static readonly WGPUBool True = new WGPUBool(1);

        /// <summary>
        /// Represents the boolean "true" value. Has a raw value of 0.
        /// </summary>
        public static readonly WGPUBool False = new WGPUBool(0);

        /// <summary>
        /// The raw value of the <see cref="VkBool32"/>. A value of 0 represents "false", all other values represent "true".
        /// </summary>
        public uint Value;

        /// <summary>
        /// Constructs a new <see cref="WGPUBool"/> with the given raw value. 
        /// </summary>
        /// <param name="value"></param>
        public WGPUBool(uint value)
        {
            if (value != 0 && value != 1)
                throw new System.InvalidOperationException("Invalid value for WGPUBool");

            Value = value;
        }

        /// <summary>
        /// Returns whether another <see cref="VkBool32"/> value is considered equal to this one.
        /// Two <see cref="VkBool32"/>s are considered equal when their raw values are equal.
        /// </summary>
        /// <param name="other">The value to compare to.</param>
        /// <returns>True if the other value's underlying raw value is equal to this instance's. False otherwise.</returns>
        public bool Equals(WGPUBool other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            return obj is WGPUBool b && Equals(b);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return $"{(this ? "True" : "False")} ({Value})";
        }

        public static implicit operator bool(WGPUBool b) => b.Value != 0;
        public static implicit operator uint(WGPUBool b) => b.Value;
        public static implicit operator WGPUBool(bool b) => b ? True : False;
        public static implicit operator WGPUBool(uint value) => new WGPUBool(value);

        public static bool operator ==(WGPUBool left, WGPUBool right) => left.Value == right.Value;
        public static bool operator !=(WGPUBool left, WGPUBool right) => left.Value != right.Value;
    }
}
