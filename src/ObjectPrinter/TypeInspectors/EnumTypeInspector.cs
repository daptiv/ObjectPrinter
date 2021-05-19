using System;
using System.Collections.Generic;
using System.Linq;
using ObjectPrinter.Utilities;

namespace ObjectPrinter.TypeInspectors
{
    /// <summary>Returns the full name of an enum</summary>
	public class EnumTypeInspector : ITypeInspector
    {
        ///<summary></summary>
        public bool ShouldInspect(object objectToInspect, Type typeOfObjectToInspect)
        {
            return typeof(Enum).IsAssignableFrom(typeOfObjectToInspect);
        }

        ///<summary></summary>
        public IEnumerable<ObjectInfo> GetMemberList(object objectToInspect, Type typeOfObjectToInspect)
        {
            var objAsEnum = (Enum)objectToInspect;
            string enumValues;

            var isFlagEnum = !typeOfObjectToInspect.GetCustomAttributes(typeof(FlagsAttribute), false).IsNullOrEmpty();
            if (isFlagEnum)
            {
                var allValues = Enum.GetValues(typeOfObjectToInspect);
                enumValues = allValues.Cast<Enum>().Where(objAsEnum.HasFlag).JoinToString(" | ");
            }
            else
            {
                enumValues = objectToInspect.ToString();
            }

            return new List<ObjectInfo>
                       {
                           new ObjectInfo(typeOfObjectToInspect.Name + "." + enumValues)
                       };
        }
    }
}