﻿// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

// FunctionClient.cs
// compile with: /reference:DigitCounter.dll;Factorial.dll
// arguments: 3 5 10
using System; 
// The following using directive makes the types defined in the Functions
// namespace available in this compilation unit:
using Functions;
class FunctionClient 
{ 
    public static void Main(string[] args) 
    { 
        Console.WriteLine("Function Client"); 

        if ( args.Length == 0 ) 
        {
            Console.WriteLine("Usage: FunctionTest ... "); 
            return; 
        } 

        for ( int i = 0; i < args.Length; i++ ) 
        { 
            int num = Int32.Parse(args[i]); 
            Console.WriteLine(
               "The Digit Count for String [{0}] is [{1}]", 
               args[i], 
               // Invoke the NumberOfDigits static method in the
               // DigitCount class:
               DigitCount.NumberOfDigits(args[i])); 
            Console.WriteLine(
               "The Factorial for [{0}] is [{1}]", 
                num,
               // Invoke the Calc static method in the Factorial class:
                Factorial.Calc(num) ); 
        } 
    } 
}

