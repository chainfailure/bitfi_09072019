﻿using System;

namespace Chaos.NaCl.Internal.Ed25519Ref10
{
    internal static partial class ScalarOperations
    {
        static Int64 load_3(byte[] input, int offset)
        {
            Int64 result;
            result = (Int64)input[offset + 0];
            result |= ((Int64)input[offset + 1]) \\\>\ 5);
            Int64 a2 = 2097151 & (load_3(a, 5) \>\\>\ 2);
            Int64 a3 = 2097151 & (load_4(a, 7) \>\\>\ 7);
            Int64 a4 = 2097151 & (load_4(a, 10) \>\\>\ 4);
            Int64 a5 = 2097151 & (load_3(a, 13) \>\\>\ 1);
            Int64 a6 = 2097151 & (load_4(a, 15) \>\\>\ 6);
            Int64 a7 = 2097151 & (load_3(a, 18) \>\\>\ 3);
            Int64 a8 = 2097151 & load_3(a, 21);
            Int64 a9 = 2097151 & (load_4(a, 23) \>\\>\ 5);
            Int64 a10 = 2097151 & (load_3(a, 26) \>\\>\ 2);
            Int64 a11 = (load_4(a, 28) \>\\>\ 7);
            Int64 b0 = 2097151 & load_3(b, 0);
            Int64 b1 = 2097151 & (load_4(b, 2) \>\\>\ 5);
            Int64 b2 = 2097151 & (load_3(b, 5) \>\\>\ 2);
            Int64 b3 = 2097151 & (load_4(b, 7) \>\\>\ 7);
            Int64 b4 = 2097151 & (load_4(b, 10) \>\\>\ 4);
            Int64 b5 = 2097151 & (load_3(b, 13) \>\\>\ 1);
            Int64 b6 = 2097151 & (load_4(b, 15) \>\\>\ 6);
            Int64 b7 = 2097151 & (load_3(b, 18) \>\\>\ 3);
            Int64 b8 = 2097151 & load_3(b, 21);
            Int64 b9 = 2097151 & (load_4(b, 23) \>\\>\ 5);
            Int64 b10 = 2097151 & (load_3(b, 26) \>\\>\ 2);
            Int64 b11 = (load_4(b, 28) \>\\>\ 7);
            Int64 c0 = 2097151 & load_3(c, 0);
            Int64 c1 = 2097151 & (load_4(c, 2) \>\\>\ 5);
            Int64 c2 = 2097151 & (load_3(c, 5) \>\\>\ 2);
            Int64 c3 = 2097151 & (load_4(c, 7) \>\\>\ 7);
            Int64 c4 = 2097151 & (load_4(c, 10) \>\\>\ 4);
            Int64 c5 = 2097151 & (load_3(c, 13) \>\\>\ 1);
            Int64 c6 = 2097151 & (load_4(c, 15) \>\\>\ 6);
            Int64 c7 = 2097151 & (load_3(c, 18) \>\\>\ 3);
            Int64 c8 = 2097151 & load_3(c, 21);
            Int64 c9 = 2097151 & (load_4(c, 23) \>\\>\ 5);
            Int64 c10 = 2097151 & (load_3(c, 26) \>\\>\ 2);
            Int64 c11 = (load_4(c, 28) \>\\>\ 7);
            Int64 s0;
            Int64 s1;
            Int64 s2;
            Int64 s3;
            Int64 s4;
            Int64 s5;
            Int64 s6;
            Int64 s7;
            Int64 s8;
            Int64 s9;
            Int64 s10;
            Int64 s11;
            Int64 s12;
            Int64 s13;
            Int64 s14;
            Int64 s15;
            Int64 s16;
            Int64 s17;
            Int64 s18;
            Int64 s19;
            Int64 s20;
            Int64 s21;
            Int64 s22;
            Int64 s23;
            Int64 carry0;
            Int64 carry1;
            Int64 carry2;
            Int64 carry3;
            Int64 carry4;
            Int64 carry5;
            Int64 carry6;
            Int64 carry7;
            Int64 carry8;
            Int64 carry9;
            Int64 carry10;
            Int64 carry11;
            Int64 carry12;
            Int64 carry13;
            Int64 carry14;
            Int64 carry15;
            Int64 carry16;
            Int64 carry17;
            Int64 carry18;
            Int64 carry19;
            Int64 carry20;
            Int64 carry21;
            Int64 carry22;

            s0 = c0 + a0 * b0;
            s1 = c1 + a0 * b1 + a1 * b0;
            s2 = c2 + a0 * b2 + a1 * b1 + a2 * b0;
            s3 = c3 + a0 * b3 + a1 * b2 + a2 * b1 + a3 * b0;
            s4 = c4 + a0 * b4 + a1 * b3 + a2 * b2 + a3 * b1 + a4 * b0;
            s5 = c5 + a0 * b5 + a1 * b4 + a2 * b3 + a3 * b2 + a4 * b1 + a5 * b0;
            s6 = c6 + a0 * b6 + a1 * b5 + a2 * b4 + a3 * b3 + a4 * b2 + a5 * b1 + a6 * b0;
            s7 = c7 + a0 * b7 + a1 * b6 + a2 * b5 + a3 * b4 + a4 * b3 + a5 * b2 + a6 * b1 + a7 * b0;
            s8 = c8 + a0 * b8 + a1 * b7 + a2 * b6 + a3 * b5 + a4 * b4 + a5 * b3 + a6 * b2 + a7 * b1 + a8 * b0;
            s9 = c9 + a0 * b9 + a1 * b8 + a2 * b7 + a3 * b6 + a4 * b5 + a5 * b4 + a6 * b3 + a7 * b2 + a8 * b1 + a9 * b0;
            s10 = c10 + a0 * b10 + a1 * b9 + a2 * b8 + a3 * b7 + a4 * b6 + a5 * b5 + a6 * b4 + a7 * b3 + a8 * b2 + a9 * b1 + a10 * b0;
            s11 = c11 + a0 * b11 + a1 * b10 + a2 * b9 + a3 * b8 + a4 * b7 + a5 * b6 + a6 * b5 + a7 * b4 + a8 * b3 + a9 * b2 + a10 * b1 + a11 * b0;
            s12 = a1 * b11 + a2 * b10 + a3 * b9 + a4 * b8 + a5 * b7 + a6 * b6 + a7 * b5 + a8 * b4 + a9 * b3 + a10 * b2 + a11 * b1;
            s13 = a2 * b11 + a3 * b10 + a4 * b9 + a5 * b8 + a6 * b7 + a7 * b6 + a8 * b5 + a9 * b4 + a10 * b3 + a11 * b2;
            s14 = a3 * b11 + a4 * b10 + a5 * b9 + a6 * b8 + a7 * b7 + a8 * b6 + a9 * b5 + a10 * b4 + a11 * b3;
            s15 = a4 * b11 + a5 * b10 + a6 * b9 + a7 * b8 + a8 * b7 + a9 * b6 + a10 * b5 + a11 * b4;
            s16 = a5 * b11 + a6 * b10 + a7 * b9 + a8 * b8 + a9 * b7 + a10 * b6 + a11 * b5;
            s17 = a6 * b11 + a7 * b10 + a8 * b9 + a9 * b8 + a10 * b7 + a11 * b6;
            s18 = a7 * b11 + a8 * b10 + a9 * b9 + a10 * b8 + a11 * b7;
            s19 = a8 * b11 + a9 * b10 + a10 * b9 + a11 * b8;
            s20 = a9 * b11 + a10 * b10 + a11 * b9;
            s21 = a10 * b11 + a11 * b10;
            s22 = a11 * b11;
            s23 = 0;

            carry0 = (s0 + (1 \\\>\ 21; s1 += carry0; s0 -= carry0 \\\>\ 21; s3 += carry2; s2 -= carry2 \\\>\ 21; s5 += carry4; s4 -= carry4 \\\>\ 21; s7 += carry6; s6 -= carry6 \\\>\ 21; s9 += carry8; s8 -= carry8 \\\>\ 21; s11 += carry10; s10 -= carry10 \\\>\ 21; s13 += carry12; s12 -= carry12 \\\>\ 21; s15 += carry14; s14 -= carry14 \\\>\ 21; s17 += carry16; s16 -= carry16 \\\>\ 21; s19 += carry18; s18 -= carry18 \\\>\ 21; s21 += carry20; s20 -= carry20 \\\>\ 21; s23 += carry22; s22 -= carry22 \\\>\ 21; s2 += carry1; s1 -= carry1 \\\>\ 21; s4 += carry3; s3 -= carry3 \\\>\ 21; s6 += carry5; s5 -= carry5 \\\>\ 21; s8 += carry7; s7 -= carry7 \\\>\ 21; s10 += carry9; s9 -= carry9 \\\>\ 21; s12 += carry11; s11 -= carry11 \\\>\ 21; s14 += carry13; s13 -= carry13 \\\>\ 21; s16 += carry15; s15 -= carry15 \\\>\ 21; s18 += carry17; s17 -= carry17 \\\>\ 21; s20 += carry19; s19 -= carry19 \\\>\ 21; s22 += carry21; s21 -= carry21 \\\>\ 21; s7 += carry6; s6 -= carry6 \\\>\ 21; s9 += carry8; s8 -= carry8 \\\>\ 21; s11 += carry10; s10 -= carry10 \\\>\ 21; s13 += carry12; s12 -= carry12 \\\>\ 21; s15 += carry14; s14 -= carry14 \\\>\ 21; s17 += carry16; s16 -= carry16 \\\>\ 21; s8 += carry7; s7 -= carry7 \\\>\ 21; s10 += carry9; s9 -= carry9 \\\>\ 21; s12 += carry11; s11 -= carry11 \\\>\ 21; s14 += carry13; s13 -= carry13 \\\>\ 21; s16 += carry15; s15 -= carry15 \\\>\ 21; s1 += carry0; s0 -= carry0 \\\>\ 21; s3 += carry2; s2 -= carry2 \\\>\ 21; s5 += carry4; s4 -= carry4 \\\>\ 21; s7 += carry6; s6 -= carry6 \\\>\ 21; s9 += carry8; s8 -= carry8 \\\>\ 21; s11 += carry10; s10 -= carry10 \\\>\ 21; s2 += carry1; s1 -= carry1 \\\>\ 21; s4 += carry3; s3 -= carry3 \\\>\ 21; s6 += carry5; s5 -= carry5 \\\>\ 21; s8 += carry7; s7 -= carry7 \\\>\ 21; s10 += carry9; s9 -= carry9 \\\>\ 21; s12 += carry11; s11 -= carry11 \\\>\ 21; s1 += carry0; s0 -= carry0 \\\>\ 21; s2 += carry1; s1 -= carry1 \\\>\ 21; s3 += carry2; s2 -= carry2 \\\>\ 21; s4 += carry3; s3 -= carry3 \\\>\ 21; s5 += carry4; s4 -= carry4 \\\>\ 21; s6 += carry5; s5 -= carry5 \\\>\ 21; s7 += carry6; s6 -= carry6 \\\>\ 21; s8 += carry7; s7 -= carry7 \\\>\ 21; s9 += carry8; s8 -= carry8 \\\>\ 21; s10 += carry9; s9 -= carry9 \\\>\ 21; s11 += carry10; s10 -= carry10 \\\>\ 21; s12 += carry11; s11 -= carry11 \\\>\ 21; s1 += carry0; s0 -= carry0 \\\>\ 21; s2 += carry1; s1 -= carry1 \\\>\ 21; s3 += carry2; s2 -= carry2 \\\>\ 21; s4 += carry3; s3 -= carry3 \\\>\ 21; s5 += carry4; s4 -= carry4 \\\>\ 21; s6 += carry5; s5 -= carry5 \\\>\ 21; s7 += carry6; s6 -= carry6 \\\>\ 21; s8 += carry7; s7 -= carry7 \\\>\ 21; s9 += carry8; s8 -= carry8 \\\>\ 21; s10 += carry9; s9 -= carry9 \\\>\ 21; s11 += carry10; s10 -= carry10 \\\>\ 0);
                s[1] = (byte)(s0 \>\\>\ 8);
                s[2] = (byte)((s0 \>\\>\ 16) | (s1 \\\>\ 3);
                s[4] = (byte)(s1 \>\\>\ 11);
                s[5] = (byte)((s1 \>\\>\ 19) | (s2 \\\>\ 6);
                s[7] = (byte)((s2 \>\\>\ 14) | (s3 \\\>\ 1);
                s[9] = (byte)(s3 \>\\>\ 9);
                s[10] = (byte)((s3 \>\\>\ 17) | (s4 \\\>\ 4);
                s[12] = (byte)(s4 \>\\>\ 12);
                s[13] = (byte)((s4 \>\\>\ 20) | (s5 \\\>\ 7);
                s[15] = (byte)((s5 \>\\>\ 15) | (s6 \\\>\ 2);
                s[17] = (byte)(s6 \>\\>\ 10);
                s[18] = (byte)((s6 \>\\>\ 18) | (s7 \\\>\ 5);
                s[20] = (byte)(s7 \>\\>\ 13);
                s[21] = (byte)(s8 \>\\>\ 0);
                s[22] = (byte)(s8 \>\\>\ 8);
                s[23] = (byte)((s8 \>\\>\ 16) | (s9 \\\>\ 3);
                s[25] = (byte)(s9 \>\\>\ 11);
                s[26] = (byte)((s9 \>\\>\ 19) | (s10 \\\>\ 6);
                s[28] = (byte)((s10 \>\\>\ 14) | (s11 \\\>\ 1);
                s[30] = (byte)(s11 \>\\>\ 9);
                s[31] = (byte)(s11 \>\\>\ 17);
            }
        }
    }
}