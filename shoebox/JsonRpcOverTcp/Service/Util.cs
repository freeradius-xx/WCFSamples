﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    static class Util
    {
        public static void PrintBytes(byte[] bytes)
        {
            PrintBytes(bytes, bytes.Length);
        }

        public static void PrintBytes(byte[] bytes, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i > 0 && ((i % 16) == 0))
                {
                    Console.WriteLine("   {0}", sb.ToString());
                    sb.Length = 0;
                }
                else if (i > 0 && ((i % 8) == 0))
                {
                    Console.Write(" ");
                    sb.Append(' ');
                }

                Console.Write(" {0:X2}", (int)bytes[i]);
                if (' ' <= bytes[i] && bytes[i] <= '~')
                {
                    sb.Append((char)bytes[i]);
                }
                else
                {
                    sb.Append('.');
                }
            }

            if ((count % 16) > 0)
            {
                int spacesToPrint = 3 * (16 - (count % 16));
                if ((bytes.Length % 16) <= 8)
                {
                    spacesToPrint++;
                }

                Console.Write(new string(' ', spacesToPrint));
            }

            Console.WriteLine("   {0}", sb.ToString());
        }
    }
}
