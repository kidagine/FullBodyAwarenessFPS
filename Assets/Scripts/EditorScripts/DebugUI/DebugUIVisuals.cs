#if UNITY_EDITOR
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugUIVisuals : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _lightsToggleText = default;
    [SerializeField] private Slider _moveLightsSlider = default;
    [SerializeField] private Transform _lights = default;
    private Quaternion _defaultLightRotation;
    private Vector2 _moveLightsInput;


    void Start()
    {
        _defaultLightRotation = _lights.rotation;    
    }

    void Update()
    {
        if (_moveLightsInput.x != 0.0f)
        {
            _moveLightsSlider.value += _moveLightsInput.x * 2;
            Vector3 moveLights = new Vector3(_moveLightsSlider.value, 0.0f, 0.0f);
            _lights.rotation = Quaternion.Euler(moveLights);
         }
    }

    public void MoveLights(Vector2 moveLightsInput)
    {
        if (gameObject.activeInHierarchy)
        {
            _moveLightsInput = moveLightsInput;
        }
    }

    public void SetLights()
    {
        if (gameObject.activeInHierarchy)
        {
            if (_lights.gameObject.activeSelf)
            {
                _lightsToggleText.text = "Off";
                _lights.gameObject.SetActive(false);
            }
            else
            {
                _lightsToggleText.text = "On";
                _lights.gameObject.SetActive(true);
            }
        }
    }

    public void ResetToDefault()
    {
        _lightsToggleText.text = "On";
        _lights.gameObject.SetActive(true);

        _moveLightsSlider.value = 0.0f;
        _lights.rotation = _defaultLightRotation;
    }
}
#endif