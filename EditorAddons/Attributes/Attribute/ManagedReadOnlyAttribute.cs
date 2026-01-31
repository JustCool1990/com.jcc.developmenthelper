using UnityEngine;

namespace JCC.DevHelper.AttributesScripts
{
    public class ManagedReadOnlyAttribute : PropertyAttribute
    {
        public string ConditionFieldName;

        public ManagedReadOnlyAttribute(string conditionFieldName) => ConditionFieldName = conditionFieldName;
    }
}
