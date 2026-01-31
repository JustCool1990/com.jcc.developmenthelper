using UnityEngine;
using UnityEngine.Scripting;

namespace JCC.DevHelper
{
    [Preserve]
    public class AndroidScreenshotProtector
    {
        public bool ScreenshotsDisabled { get; private set; } = false;

        public void TryDisableScreenshots()
        {
            if (ScreenshotsDisabled)
                return;

            ScreenshotsDisabled = true;

#if UNITY_EDITOR
            Debug.Log("SCREENSHOT PROTECTOR: disable screenshots possibility!");
#elif UNITY_ANDROID
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaObject myActivityHelper = new AndroidJavaObject("com.jcc.androidscreenshotprotector.ScreenshotProtector");
                myActivityHelper.CallStatic("SetSecureFlag", currentActivity);
            }
#endif
        }

        public void TryEnableScreenshots()
        {
            if (ScreenshotsDisabled == false)
                return;

            ScreenshotsDisabled = false;

#if UNITY_EDITOR
            Debug.Log("SCREENSHOT PROTECTOR: enable screenshots possibility!");
#elif UNITY_ANDROID
            using (AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                AndroidJavaObject myActivityHelper = new AndroidJavaObject("com.jcc.androidscreenshotprotector.ScreenshotProtector");
                myActivityHelper.CallStatic("ClearSecureFlag", currentActivity);
            }
#endif
        }
    }
}
