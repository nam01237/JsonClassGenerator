﻿using System;

namespace NJsonObject.Generate
{
    [Flags]
    public enum DeclareContent
    {
        Filed = 0x1,
        Property = 0x2,
        Constructor = 0x03
    }
}