using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ShopeeSdkV2Tests
{
    [XmlRoot(ElementName = "AppSetting")]
    public class AppSetting
    {
        [XmlElement(ElementName = "AccessToken")]
        public string AccessToken { get; set; }
        


    }
}
