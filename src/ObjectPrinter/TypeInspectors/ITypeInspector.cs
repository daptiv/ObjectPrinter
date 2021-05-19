using System;
using System.Collections.Generic;

namespace ObjectPrinter.TypeInspectors
{
    /// <summary>
    /// Type inspectors determine how a type should be inspected.
    /// </summary>
    public interface ITypeInspector
    {
        /// <summary>If ShouldInspect returns true, this type inspector will be used to inspect the type</summary>
        bool ShouldInspect(object objectToInspect, Type typeOfObjectToInspect);

        /// <summary>Returns the members to be printed</summary>
        IEnumerable<ObjectInfo> GetMemberList(object objectToInspect, Type typeOfObjectToInspect);
    }
}