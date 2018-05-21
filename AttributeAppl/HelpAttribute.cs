using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[AttributeUsage(AttributeTargets.All)]

namespace AttributeAppl
{
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic   // Topic is a named parameter {
      get {
         return topic;
      }
    set {
         topic = value;
      }
   }
   public HelpAttribute(string url)   // url is a positional parameter {
      this.Url = url;
   }
private string topic;
}

[HelpAttribute("Information on the class MyClass")]
class MyClass
{

}
}
