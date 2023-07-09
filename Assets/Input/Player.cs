using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _input;
    private Material _playerMaterial;

    // Start is called before the first frame update
    void Start()
    {
        _playerMaterial = gameObject.GetComponent<Renderer>().material;
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Player.ColorChange.performed += ColorChange_performed;
        _input.Player.Swap.performed += Swap_performed;
        _input.Car.Swap.performed += Swap_performed1;

    }

    private void Swap_performed1(InputAction.CallbackContext obj)
    {
        _input.Player.Enable();
        _input.Car.Disable();
    }

    private void Swap_performed(InputAction.CallbackContext obj)
    {
        _input.Player.Disable();
        _input.Car.Enable();
    }

    private void ColorChange_performed(InputAction.CallbackContext obj)
    {
        _playerMaterial.color = Random.ColorHSV();
    }

    private void Update()
    {
        CalculateMovement();
    }

    private void CalculateMovement()
    {
        var rotation = _input.Player.Rotate.ReadValue<float>();
        transform.Rotate( Vector3.up * rotation * Time.deltaTime * 30f);

        var move = _input.Car.Movement.ReadValue<Vector2>();
        transform.Translate(move * Time.deltaTime * 5f);
    }

}
