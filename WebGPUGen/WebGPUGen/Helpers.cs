using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CppAst;

namespace WebGPUGen
{
    public static class Helpers
    {
        public static List<CppTypedef> delegates;

        private static readonly Dictionary<string, string> s_csNameMappings = new Dictionary<string, string>()
        {
            { "uint8_t", "byte" },
            { "uint16_t", "ushort" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int8_t", "sbyte" },
            { "int32_t", "int" },
            { "int16_t", "short" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "char", "byte" },
            { "size_t", "uint" },
            { "DWORD", "uint" },

            { "WGPUSubmissionIndex", "ulong" },
        };

        public static string ConvertToCSharpType(CppType type, bool isPointer = false)
        {
            if (type is CppPrimitiveType primitiveType)
            {
                return GetCsTypeName(primitiveType, isPointer);
            }

            if (type is CppQualifiedType qualifiedType)
            {
                return GetCsTypeName(qualifiedType.ElementType, isPointer);
            }

            if (type is CppEnum enumType)
            {
                var enumCsName = GetCsCleanName(enumType.Name);
                if (isPointer)
                    return enumCsName + "*";

                return enumCsName;
            }

            if (type is CppTypedef typedef)
            {
                var typeDefCsName = GetCsCleanName(typedef.Name);
                if (isPointer)
                    return typeDefCsName + "*";

                return typeDefCsName;
            }

            if (type is CppClass @class)
            {
                var className = GetCsCleanName(@class.Name);
                if (isPointer)
                    return className + "*";

                return className;
            }

            if (type is CppPointerType pointerType)
            {
                return GetCsTypeName(pointerType);
            }

            if (type is CppArrayType arrayType)
            {
                return GetCsTypeName(arrayType.ElementType, isPointer);
            }

            return string.Empty;
        }

        public static object GetParametersSignature(CppFunction command, bool useTypes = true)
        {
            StringBuilder signature = new StringBuilder();
            foreach (var parameter in command.Parameters)
            {
                string convertedType = ConvertToCSharpType(parameter.Type);
                //// Hack for structs that are not bittable
                //// https://stackoverflow.com/questions/32110152/c-sharp-marshalling-bool
                //if (convertedType == "WGPURenderPipelineDescriptor*" || convertedType == "WGPUBufferDescriptor*")
                //{
                //    signature.Append("ref ");
                //    convertedType = convertedType.Remove(convertedType.Length-1);
                //}
                string convertedName = parameter.Name;

                if (useTypes)
                    signature.Append($"{convertedType} ");

                signature.Append($"{convertedName}, ");
            }

            if(signature.Length > 0)
                signature.Length -= 2;

            return signature.ToString();
        }

        private static string GetCsTypeName(CppPrimitiveType primitiveType, bool isPointer)
        {
            string result = string.Empty;

            switch (primitiveType.Kind)
            {
                case CppPrimitiveKind.Void:
                    result = "void";
                    break;
                case CppPrimitiveKind.Bool:
                    result = "bool";
                    break;
                case CppPrimitiveKind.Char:
                    result = "char";
                    break;
                case CppPrimitiveKind.Short:
                    result = "short";
                    break;
                case CppPrimitiveKind.Int:
                    result = "int";
                    break;
                case CppPrimitiveKind.UnsignedShort:
                    result = "ushort";
                    break;
                case CppPrimitiveKind.UnsignedInt:
                    result = "uint";
                    break;
                case CppPrimitiveKind.Float:
                    result = "float";
                    break;
                case CppPrimitiveKind.Double:
                    result = "double";
                    break;
                case CppPrimitiveKind.UnsignedChar:
                case CppPrimitiveKind.LongLong:
                case CppPrimitiveKind.UnsignedLongLong:
                case CppPrimitiveKind.LongDouble:
                case CppPrimitiveKind.WChar:
                default:
                    break;
            }

            if (isPointer)
            {
                result += "*";
            }

            return result;
        }

        private static string GetCsTypeName(CppPointerType pointerType)
        {
            if (pointerType.ElementType is CppQualifiedType qualifiedType)
            {
                if (qualifiedType.ElementType is CppPrimitiveType primitiveType)
                {
                    return GetCsTypeName(primitiveType, true);
                }
                else if (qualifiedType.ElementType is CppClass @classType)
                {
                    return GetCsTypeName(@classType, true);
                }
                else if (qualifiedType.ElementType is CppPointerType subPointerType)
                {
                    return GetCsTypeName(subPointerType, true) + "*";
                }
                else if (qualifiedType.ElementType is CppTypedef typedef)
                {
                    return GetCsTypeName(typedef, true);
                }
                else if (qualifiedType.ElementType is CppEnum @enum)
                {
                    return GetCsTypeName(@enum, true);
                }

                return GetCsTypeName(qualifiedType.ElementType, true);
            }

            return GetCsTypeName(pointerType.ElementType, true);
        }

        private static string GetCsTypeName(CppType type, bool isPointer = false)
        {
            if (type is CppPrimitiveType primitiveType)
            {
                return GetCsTypeName(primitiveType, isPointer);
            }

            if (type is CppQualifiedType qualifiedType)
            {
                return GetCsTypeName(qualifiedType.ElementType, isPointer);
            }

            if (type is CppEnum enumType)
            {
                var enumCsName = GetCsCleanName(enumType.Name);
                if (isPointer)
                    return enumCsName + "*";

                return enumCsName;
            }

            if (type is CppTypedef typedef)
            {
                var typeDefCsName = GetCsCleanName(typedef.Name);
                if (isPointer)
                    return typeDefCsName + "*";

                return typeDefCsName;
            }

            if (type is CppClass @class)
            {
                var className = GetCsCleanName(@class.Name);
                if (isPointer)
                    return className + "*";

                return className;
            }

            if (type is CppPointerType pointerType)
            {
                return GetCsTypeName(pointerType);
            }

            if (type is CppArrayType arrayType)
            {
                return GetCsTypeName(arrayType.ElementType, isPointer);
            }

            return string.Empty;
        }

        private static string GetCsCleanName(string name)
        {
            var typedef = delegates.Find(d => d.Name == name);
            if (typedef != null)
            {
                return GetDelegatePointer(typedef);
            }

            if (s_csNameMappings.TryGetValue(name, out string mappedName))
            {
                return GetCsCleanName(mappedName);
            }

            if (name.Contains("Flags"))
            {
                return name.Remove(name.Count() - 5);
            }

            return name;
        }

        public static string GetConstantType(string value)
        {
            string constType = "string";
            if (value.EndsWith("UL", StringComparison.OrdinalIgnoreCase))
                constType = "ulong";
            else if (value.EndsWith("U", StringComparison.OrdinalIgnoreCase))
                constType = "uint";
            else if (value.EndsWith("F", StringComparison.OrdinalIgnoreCase))
                constType = "float";
            else if (uint.TryParse(value, out _) || value.StartsWith("0x"))
                constType = "float";
            return constType;
        }

        public static bool SkipConstant(CppMacro constant)
        {
            string[] skippingValues = new[] { "_H_", "WGPU_EXPORT", "WGPU_SHARED_LIBRARY", "WGPU_IMPLEMENTATION", "_VGPU_EXTERN", "VGPU_API", "_WIN32", "WGPU_SKIP_PROCS" };
            if (string.IsNullOrEmpty(constant.Value)
                || skippingValues.Contains(constant.Name))
                return true;

            return false;
        }

        public static string NormalizeConstantValue(string constantValue)
        {
            if(constantValue.StartsWith("(") && constantValue.EndsWith(")"))
                constantValue = constantValue.Substring(1, constantValue.Length - 2);

            return constantValue.Replace("ULL", "UL");

        }

        private static string GetDelegatePointer(CppTypedef type)
        {
            CppFunctionType pointerType = ((CppPointerType)type.ElementType).ElementType as CppFunctionType;
            StringBuilder result = new StringBuilder();

            result.Append("delegate* unmanaged<");
            for (int i = 0; i < pointerType.Parameters.Count; i++)
            {
                result.Append(ConvertToCSharpType(pointerType.Parameters[i].Type) + ", ");
            }
            result.Append(ConvertToCSharpType(pointerType.ReturnType) + ">");

            return result.ToString();
        }
    }
}
