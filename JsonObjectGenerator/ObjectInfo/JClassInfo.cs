using System.Collections.Generic;
using System.Text;

namespace NJsonObject.ObjectInfo
{
    public class JClassInfo : JInfo
    {
        public List<JInfo> Properties { get; set; }
        public JInfo Parent { get; set; }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (this.GetType() != other.GetType())

            foreach (var p in Properties)
            {
                if (!((JClassInfo) other).Properties.Contains(p))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Name);
            str.Append(Type);

            foreach (JInfo jInfo in Properties)
            {
                str.Append(jInfo.ToString());
            }

            return str.ToString().GetHashCode();
        }
    }
}
