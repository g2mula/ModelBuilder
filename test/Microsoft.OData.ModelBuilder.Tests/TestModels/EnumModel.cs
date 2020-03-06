﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Tests
{
    public class EnumModel
    {
        public int Id { get; set; }
        public SimpleEnum Simple { get; set; }
        public SimpleEnum? SimpleNullable { get; set; }
        public LongEnum Long { get; set; }
        public ByteEnum Byte { get; set; }
        public SByteEnum SByte { get; set; }
        public ShortEnum Short { get; set; }
        public UShortEnum UShort { get; set; }
        public UIntEnum UInt { get; set; }
        public FlagsEnum Flag { get; set; }
        public FlagsEnum? FlagNullable { get; set; }
    }
}