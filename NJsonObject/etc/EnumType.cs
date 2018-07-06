using System;

namespace NJsonObject
{
    [Flags]
    public enum DeclareOption
    {
        NormalField = 0x1,
        Property = 0x2,
        Public = 0x4,
        Protected = 0x8,
        Default = 0x10,
        Private = 0x20,
        Nullable = 0x30,
        CustomFormat = 0x40,
        UpperFirstWord = 0x50
    }
}
