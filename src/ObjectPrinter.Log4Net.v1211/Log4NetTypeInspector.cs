using System;
using ObjectPrinter.TypeInspectors;

namespace ObjectPrinter.Log4Net
{
    /// <summary>
    /// returns the ToString() representation for every object in the "log4net*" namespaces, 
    /// as log4net intended.
    /// </summary>
    public class Log4NetTypeInspector : ToStringTypeInspector
    {
        ///<summary></summary>
        public Log4NetTypeInspector()
        {
            ShouldInspectType = NamespaceIsLog4Net;
        }

        private static bool NamespaceIsLog4Net(object objectToInspect, Type typeOfObjectToInspect)
        {
            return typeOfObjectToInspect.Namespace != null
                   && typeOfObjectToInspect.Namespace.StartsWith("log4net");
        }
    }
}