﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw12.Models
{
    public class FileTextInfo
    {
        private string[] contentFile;

        public int GetCountLines() {
            return contentFile.Length;
        }
        public int GetCountWords()
        {
            int count = 0;
            foreach (var line in contentFile)
            {
                count += line.Split(' ').Length;//ilosc slow w lini
            }
            return count;
        }
        public FileTextInfo(string[] lines) {
            contentFile = lines;
        }
    }
}