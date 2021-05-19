using System.Collections.Generic;

namespace ObjectPrinter.TypeInspectors
{
    internal static class TypeInspectorExtensions
    {
        internal static IEnumerable<ObjectInfo> GetMemberList(this ITypeInspector inspector, ObjectInfo objectInfo)
        {
            return inspector.GetMemberList(objectInfo.Value, objectInfo.Type);
        }
    }
}