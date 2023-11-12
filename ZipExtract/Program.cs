using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.Json;

namespace ZipExtract
{
    public class ZipExtracter
    {
        public static void Main(string[] args)
        {
            // string zipPath = @"C:\Users\User\Desktop\testZip";
            // string CurrentZIPFile = @"C:\Users\User\Desktop\testZip\myProductsZip.zip";
            // string CurrentTXTFile = @"C:\Users\User\Desktop\testZip\myProducts.txt";
            // //ZipFile.ExtractToDirectory(CurrentZIPFile, zipPath);
            //
            // bool existFile = File.Exists(CurrentTXTFile);
            //
            // string text;
            // try
            // {
            //     StreamReader sr = new StreamReader(CurrentTXTFile);
            //     text = sr.ReadToEnd();
            //
            //     
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            //     throw;
            // }
            
            var people = new Dictionary<string, string>()
            {
                { "33", "Tom"},
                { "53", "Sam"},
                { "63", "Bob"}
            };

            foreach (var key in people.Keys)
            {
                Console.WriteLine($"{key} : {people[key]}");
            }
        }
    }

}