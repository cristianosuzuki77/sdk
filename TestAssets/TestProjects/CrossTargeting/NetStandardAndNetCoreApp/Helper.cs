﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace TestLibrary
{
    public static class Helper
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello there!");
        }

#if NETCOREAPP
        static void Main() => SayHi();
#endif		
    }
}
