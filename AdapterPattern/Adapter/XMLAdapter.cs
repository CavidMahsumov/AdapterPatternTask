using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
   public class XMLAdapter:IAdapter
    {
        XML _XML_File;
        public void Read()
        {
            _XML_File.XML_Deserialize();
        }

        public XMLAdapter(XML XML_File)
        {
            _XML_File = XML_File;
        }
        public void Write()
        {
            _XML_File.XML_Serialize();
        }
    }
}
