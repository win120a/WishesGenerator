/*
    The MIT License (MIT)

    Copyright (c) 2011-2015 Andy Cheung

    Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
  SOFTWARE.
*/

using AC.WishesGenerator.Data;
using AC.WishesGenerator.Data.Common;
using AC.WishesGenerator.Data.NewYearsDay;
using AC.WishesGenerator.Data.SpringFestival;
using System;

namespace LanguageBaseTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonLanguage cl = new CommonLanguage();
            NewYearsDayLanguage nl = new NewYearsDayLanguage();
            SheepYear sy = new SheepYear();

            Console.WriteLine("======== CL ===========");
            Console.WriteLine(cl.GetType().ToString());
            Console.WriteLine(cl.ConstructLanguage(3));

            Console.WriteLine("======== NL ===========");
            Console.WriteLine(nl.GetType().ToString());
            Console.WriteLine(nl.ConstructLanguage(0));

            Console.WriteLine("======== SY ===========");
            Console.WriteLine(sy.GetType().ToString());
            Console.WriteLine(sy.ConstructLanguage(0));

            Console.WriteLine("======== SM-SY ===========");
            Console.WriteLine(SentenseMaker.MakeSentense("Test", sy));

            Console.WriteLine("======== SM-MY ===========");
            Console.WriteLine(SentenseMaker.MakeSentense("Test", new MouseYear()));

            Console.WriteLine("======== SM-DY ===========");
            Console.WriteLine(SentenseMaker.MakeSentense("Test", new DragonYear()));

            Console.ReadLine();
        }
    }
}
