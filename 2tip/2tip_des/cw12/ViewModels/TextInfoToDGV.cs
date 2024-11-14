using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cw12.Models;

namespace cw12.ViewModels
{
    public  class TextInfoToDGV
    {
        private FileTextInfo _fileTextInfo;

        public TextInfoToDGV(FileTextInfo fileTextInfo) {
            _fileTextInfo = fileTextInfo;
        }

        public List<string[]> GetInfo() {
            var rows = new List<string[]>();
            string[] row = new[] { "Ilość linii", 
                _fileTextInfo.GetCountLines().ToString() };
            rows.Add(row);
            rows.Add(new[]{"Ilość wyrazów",
                _fileTextInfo.GetCountWords().ToString()});
            return rows;
        }
    }
}
