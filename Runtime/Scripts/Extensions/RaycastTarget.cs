using UnityEngine.UI;
using UnityEngine.Scripting;

namespace JCC.DevHelper
{
    [Preserve]
    public class RaycastTarget : Graphic
    {
        public override void SetMaterialDirty() { return; }
        public override void SetVerticesDirty() { return; }
    }
}
