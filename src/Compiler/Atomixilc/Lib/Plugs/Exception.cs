﻿/*
* PROJECT:          Atomix Development
* LICENSE:          Copyright (C) Atomix Development, Inc - All Rights Reserved
*                   Unauthorized copying of this file, via any medium is
*                   strictly prohibited Proprietary and confidential.
* PURPOSE:          System.Exception Plugs
* PROGRAMMERS:      Aman Priyadarshi (aman.eureka@gmail.com)
*/

using Atomixilc.Attributes;

namespace Atomixilc.Lib.Plugs
{
    internal unsafe static class ExceptionImpl
    {
        [Plug("System_Void_System_Exception__cctor__")]
        internal static void ctor(uint* aException)
        {

        }

        [Plug("System_Void_System_Exception__ctor_System_String_")]
        internal static void ctor(uint* aException, uint aMessage)
        {
            *(aException + 0x3) = aMessage;
        }

        [Plug("System_String_System_Exception_get_Message__")]
        internal static uint GetMessage(uint* aAddress)
        {
            return *(aAddress + 0x3);
        }
    }
}
