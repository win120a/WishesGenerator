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

using System;
using System.Collections.Generic;
using System.Text;

namespace AC.WishesGenerator.Data
{
    public abstract class AbstractLanguage
    {
        protected List<String> data;

        public List<String> Data
        {
            get
            {
                return data;
            }
        }

        public int GetSize()
        {
            return data.Count;
        }

        public virtual String ConstructLanguage(int num)
        {
            InitData();
            StringBuilder sb = new StringBuilder();
            List<int> posList = GenerateNumbers(num);

            int count = 0;
            foreach (int ti in posList)
            {
                sb.Append(Data[ti]);
                if (count != (posList.Count - 1))
                {
                    sb.Append("，");
                }
                count++;
            }

            return sb.ToString();
        }

        public List<int> GenerateNumbers(int num)
        {
            StringBuilder sb = new StringBuilder();
            List<int> posList = new List<int>();

            for (int i = 0; i < num; i++)
            {
                Random r = new Random();
                int tPos = r.Next(0, Data.Count);
            loopTag:
                foreach (int ti in posList)
                {
                    if (tPos == ti)
                    {
                        if (tPos >= (Data.Count - 1))
                        {
                            goto loopTag;
                        }
                        tPos += 1;
                        continue;
                    }
                }
                posList.Add(tPos);
            }
            return posList;
        }

        protected abstract void InitData();
    }
}
