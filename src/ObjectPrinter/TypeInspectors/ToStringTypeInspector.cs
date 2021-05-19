using System;
using System.Collections.Generic;

namespace ObjectPrinter.TypeInspectors
{
    /// <summary>
    /// returns the ToString() representation for every object.
    /// </summary>
    public class ToStringTypeInspector : ITypeInspector
    {
        /// <summary>If ShouldInspectType returns true, this inspector will handle the type</summary>
        public Func<object, Type, bool> ShouldInspectType { get; set; }

        ///<summary></summary>
        public virtual bool ShouldInspect(object objectToInspect, Type typeOfObjectToInspect)
        {
            return ShouldInspectType != null && ShouldInspectType(objectToInspect, typeOfObjectToInspect);
        }

        ///<summary></summary>
        public IEnumerable<ObjectInfo> GetMemberList(object objectToInspect, Type typeOfObjectToInspect)
        {
            return new List<ObjectInfo>
                       {
                           new ObjectInfo(objectToInspect.ToString())
                       };
        }
    }
}