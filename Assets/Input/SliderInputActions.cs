//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/SliderInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @SliderInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SliderInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SliderInputActions"",
    ""maps"": [
        {
            ""name"": ""Slider"",
            ""id"": ""a2611c75-de94-4a3f-9bcf-c22dd880c34b"",
            ""actions"": [
                {
                    ""name"": ""Charge"",
                    ""type"": ""Button"",
                    ""id"": ""160fdb54-9c65-4372-bc12-92fa8272d430"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b3de9cd-67ec-4bfe-b42e-cc273b265ef1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Charge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Slider
        m_Slider = asset.FindActionMap("Slider", throwIfNotFound: true);
        m_Slider_Charge = m_Slider.FindAction("Charge", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Slider
    private readonly InputActionMap m_Slider;
    private ISliderActions m_SliderActionsCallbackInterface;
    private readonly InputAction m_Slider_Charge;
    public struct SliderActions
    {
        private @SliderInputActions m_Wrapper;
        public SliderActions(@SliderInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Charge => m_Wrapper.m_Slider_Charge;
        public InputActionMap Get() { return m_Wrapper.m_Slider; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SliderActions set) { return set.Get(); }
        public void SetCallbacks(ISliderActions instance)
        {
            if (m_Wrapper.m_SliderActionsCallbackInterface != null)
            {
                @Charge.started -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
                @Charge.performed -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
                @Charge.canceled -= m_Wrapper.m_SliderActionsCallbackInterface.OnCharge;
            }
            m_Wrapper.m_SliderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Charge.started += instance.OnCharge;
                @Charge.performed += instance.OnCharge;
                @Charge.canceled += instance.OnCharge;
            }
        }
    }
    public SliderActions @Slider => new SliderActions(this);
    public interface ISliderActions
    {
        void OnCharge(InputAction.CallbackContext context);
    }
}
