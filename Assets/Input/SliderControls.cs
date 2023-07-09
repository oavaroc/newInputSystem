using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class SliderControls : MonoBehaviour
{
    private SliderInputActions _input;
    [SerializeField]
    private Slider _slider;

    private bool _isCharging = false;

    // Start is called before the first frame update
    void Start()
    {
        _input = new SliderInputActions();
        _input.Slider.Enable();
        _input.Slider.Charge.started += Charge_started;
        _input.Slider.Charge.canceled += Charge_canceled;
    }

    private void Charge_canceled(InputAction.CallbackContext obj)
    {
        _isCharging = false;
    }

    private void Charge_started(InputAction.CallbackContext obj)
    {
        _isCharging = true;
        StartCoroutine(ChargeBarRoutine());
    }

    IEnumerator ChargeBarRoutine()
    {
        while (_isCharging)
        {
            _slider.value += Time.deltaTime;
            yield return null;
        }
        while (_slider.value > 0 && !_isCharging)
        {
            _slider.value -= Time.deltaTime;
            yield return null;

        }
    }

}
