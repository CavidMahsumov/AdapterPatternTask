using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
   public class Convertor
    {
        private readonly IAdapter _adapter;

        public Convertor(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public void WriteFile()
        {
            _adapter.Write();
        }

        public void ReadFile()
        {
            _adapter.Read();
        }
    }
}
