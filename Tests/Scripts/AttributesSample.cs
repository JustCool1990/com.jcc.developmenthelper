using UnityEngine;
#if UNITY_EDITOR
using JCC.DevHelper.AttributesScripts;
#endif

namespace JCC.DevHelper.Tests
{
    public class AttributesSample : MonoBehaviour
    {
#if UNITY_EDITOR 
        [ReadOnly]
#endif
        [SerializeField] private string _blockedField = "The field is blocked for editing";
        [Space(20)]
        [SerializeField] private bool _lockSwitch;
#if UNITY_EDITOR 
        [ManagedReadOnly(nameof(_lockSwitch))]
#endif 
        [SerializeField] private string _managedBlockedField = "After you set the switch, you can edit the field.";
    }
}
