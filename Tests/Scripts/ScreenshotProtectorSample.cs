using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace JCC.DevHelper.Tests
{
    public class ScreenshotProtectorSample : MonoBehaviour
    {
        private const string Enabled = nameof(Enabled);
        private const string Disabled = nameof(Disabled);

        [SerializeField] private TMP_Text _statusText;
        [SerializeField] private Color _enabledColor = Color.green;
        [SerializeField] private Color _disabledColor = Color.red;
        [SerializeField] private Button _enableButton;
        [SerializeField] private Button _disableButton;

        private readonly AndroidScreenshotProtector _androidScreenshotProtector = new();

        private void OnEnable()
        {
            _enableButton.onClick.AddListener(TryEnableScreenshots);
            _disableButton.onClick.AddListener(TryDisableScreenshots);
        }

        private void OnDisable()
        {
            _enableButton.onClick.RemoveListener(TryEnableScreenshots);
            _disableButton.onClick.RemoveListener(TryDisableScreenshots);
        }

        private void TryEnableScreenshots()
        {
            _androidScreenshotProtector.TryEnableScreenshots();
            _statusText.color = _enabledColor;
            _statusText.text = Enabled;
        }

        private void TryDisableScreenshots()
        {
            _androidScreenshotProtector.TryDisableScreenshots();
            _statusText.color = _disabledColor;
            _statusText.text = Disabled;
        }
    }
}
