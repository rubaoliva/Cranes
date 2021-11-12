//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/ActionMaps/GruaBrazoControls.inputactions
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

public partial class @GruaBrazoControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GruaBrazoControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GruaBrazoControls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""50949077-9d11-4777-9fa1-f418bca9fdf0"",
            ""actions"": [
                {
                    ""name"": ""RotateR"",
                    ""type"": ""Button"",
                    ""id"": ""a6b92b5d-781f-41f0-96cc-a8835ea91c58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RotateL"",
                    ""type"": ""Button"",
                    ""id"": ""7f7e9bfd-fe2c-4596-942f-4f41f16d8f5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e4abff03-a9a9-43a6-9c82-6937076de119"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70216392-bba5-4e56-b4ba-09213dfa23d7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffa90b5e-feaa-48f4-b7a0-5fac21d23977"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a765f6a-0d00-4226-b9be-42f5f31c6a20"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_RotateR = m_Land.FindAction("RotateR", throwIfNotFound: true);
        m_Land_RotateL = m_Land.FindAction("RotateL", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_RotateR;
    private readonly InputAction m_Land_RotateL;
    public struct LandActions
    {
        private @GruaBrazoControls m_Wrapper;
        public LandActions(@GruaBrazoControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateR => m_Wrapper.m_Land_RotateR;
        public InputAction @RotateL => m_Wrapper.m_Land_RotateL;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @RotateR.started -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateR;
                @RotateR.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateR;
                @RotateR.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateR;
                @RotateL.started -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateL;
                @RotateL.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateL;
                @RotateL.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnRotateL;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateR.started += instance.OnRotateR;
                @RotateR.performed += instance.OnRotateR;
                @RotateR.canceled += instance.OnRotateR;
                @RotateL.started += instance.OnRotateL;
                @RotateL.performed += instance.OnRotateL;
                @RotateL.canceled += instance.OnRotateL;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnRotateR(InputAction.CallbackContext context);
        void OnRotateL(InputAction.CallbackContext context);
    }
}