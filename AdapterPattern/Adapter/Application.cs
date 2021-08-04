using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
   public class Application1
    {
        private readonly Convertor _converter;

        public Application1(IAdapter adapter)
        {
            _converter = new Convertor(adapter);
        }

        public void Start()
        {
            _converter.WriteFile();
            _converter.ReadFile();

        }

    }
}
