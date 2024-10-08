﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace AntDesign.Core.Helpers.MemberPath
{
    public class InvalidPathException : Exception
    {
        public InvalidPathException()
            : base("Path is invalid")
        { }

        public InvalidPathException(string? message)
            : base(message)
        { }
    }
}
