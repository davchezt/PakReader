﻿using PakReader.Parsers.Objects;

namespace PakReader.Parsers.PropertyTagData
{
    public sealed class DoubleProperty : BaseProperty<double>
    {
        internal DoubleProperty(PackageReader reader, FPropertyTag tag)
        {
            Value = reader.ReadDouble();
        }
    }
}
