﻿using System.Collections.Generic;
using System.Text;

namespace NJsonObject.ObjectInfo
{
    public class JClassInfo : JInfo
    {
        public List<JInfo> Properties { get; set; }
        public JInfo Parent { get; set; }
        public string ClassCode { get; set; }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;

            if (GetType() != other.GetType())
                return false;


            foreach (var p in Properties)
            {
                if (! ((JClassInfo) other).Properties.Contains(p) )
                    return false;
            }

            foreach (var p in ((JClassInfo)other).Properties)
            {
                if (! (Properties.Contains(p)) ) 
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

        public override string ToString()
        {
            return $"{Type} {Name}";
        }
    }
}
