#if UNITY_EDITOR
using UnityEngine;
using UnityEngine.UI;

public class DebugUIDefault : MonoBehaviour
{
    [SerializeField] private Image _resetFill;
    [SerializeField] private GameObject _gameDebuggerCanvas = default;
    [SerializeField] private GameObject _debugGeneral = default;
    [SerializeField] private GameObject _debugVisuals = default;
    [SerializeField] private DebugUIGeneral _debugUIGeneral = default;
    [SerializeField] private DebugUIVisuals _debugUIVisuals = default;
    [SerializeField] private PlayerInputSystem _playerInputSystem = default;
    private bool _isResetting;


    void Update()
    {
        if (_isResetting)
        {
            _resetFill.fillAmount += Time.unscaledDeltaTime;
            if (_resetFill.fillAmount >= 1.0f)
            {
                _resetFill.fillAmount = 0.0f;
                _isResetting = false;
                ResetToDefault();
            }
        }
    }
    public void StopReset()
    {
        if (gameObject.activeInHierarchy)
        {
            _isResetting = false;
            _resetFill.fillAmount = 0.0f;
        }
    }
    public void StartReset()
    {
        if (gameObject.activeInHierarchy)
        {
            _isResetting = true;
        }
    }

    private void ResetToDefault()
    {
        _debugUIGeneral.ResetToDefault();
        _debugUIVisuals.ResetToDefault();
    }

    public void ExitMenu()
    {
        if (gameObject.activeInHierarchy)
        {
            _playerInputSystem.enabled = true;
            _gameDebuggerCanvas.SetActive(false);
        }
    }

    public void NextOption()
    {
        if (gameObject.activeInHierarchy)
        {
            if (_debugGeneral.activeSelf)
            {
                _debugGeneral.SetActive(false);
                _debugVisuals.SetActive(true);
            }
            else if (_debugVisuals.activeSelf)
            {
                _debugGeneral.SetActive(true);
                _debugVisuals.SetActive(false);
            }
        }
    }
}
#endif