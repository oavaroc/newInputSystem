using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    private BallInputActions _input;
    private Rigidbody _rigidbody;
    private bool _isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _input = new BallInputActions();
        _input.Ball.Enable();
        _input.Ball.Bounce.canceled += Bounce_canceled;

    }

    private void Bounce_canceled(InputAction.CallbackContext obj)
    {
        if (_isGrounded) 
        { 
            var length = Mathf.Clamp((float)obj.duration, 0f, 1f);
            Debug.Log("Held for: " + obj.duration + "; Using time of: " + length + "; Using force of:" + (Vector3.up * length * 10));
            _rigidbody.AddForce(Vector3.up * length * 10, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Gounded");
            _isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("UnGounded");
            _isGrounded = false;
        }
    }

}
