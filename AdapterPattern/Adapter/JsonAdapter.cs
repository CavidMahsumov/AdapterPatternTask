using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
   public  class JsonAdapter:IAdapter
    {
        JSON _JSON_File;
        public void Read()
        {
            _JSON_File.JSON_Deserialize();
        }

        public JsonAdapter(JSON JSON_File)
        {
            _JSON_File = JSON_File;
        }
        public void Write()
        {
            _JSON_File.JSON_Serialize();
        }
    }
}
