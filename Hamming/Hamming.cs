﻿using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
        int hammingDistance=0, i=0;
        if(original==null)
        {
            throw new ArgumentNullException("original");
        }
        else if(current==null)
        {
            throw new ArgumentNullException("current");
        }
        else if(original.Length!=current.Length)
        {
            throw new ArgumentException("Hamming Distance can only be calculated over strings of equal length");
        }
        else{
        for(i=0; i<original.Length; i++)
        {
            if(original[i]!=current[i])
            {
                hammingDistance++;
            }
        }
        }
        return hammingDistance;
        }
    }
}
