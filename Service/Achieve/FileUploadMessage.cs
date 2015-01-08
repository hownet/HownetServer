using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.IO;

namespace MessageContract
{
    [MessageContract]
    public class FileUploadMessage
    {
        [MessageHeader(MustUnderstand = true)]
        public string FileName;
        [MessageBodyMember(Order = 1)]
        public Stream FileData;
    }
}
