//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/InputActionsCreator.inputactions
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

public partial class @PlayerInputActoins: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActoins()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionsCreator"",
    ""maps"": [
        {
            ""name"": ""CharacterControl"",
            ""id"": ""1cb9407b-594c-4a13-972d-c06ea40ba7c6"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""3725a810-e59f-48c3-a234-ee78e67e42fc"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseDirection"",
                    ""type"": ""Value"",
                    ""id"": ""f3035280-1fa3-4168-9a85-168955aa6235"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8e4d62af-cd88-4fc4-be2b-e1df8d93ac6f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MouseDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""b18d5cfc-faa8-4464-9737-d110c9f4c6e2"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f68c68e9-913b-4324-b6e7-3dff7ad4a574"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""378ffccd-85e3-4da1-8cfe-03c886e0f89e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e556890-8d27-4434-a62f-8f109f20dddf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""17f7916d-bd2e-4870-acf4-8f17b9169837"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""fa46ccf2-3248-4db9-9aa2-cf355e39a566"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""d7c0aae3-1037-47cb-9189-53c46cb5b7c9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // CharacterControl
        m_CharacterControl = asset.FindActionMap("CharacterControl", throwIfNotFound: true);
        m_CharacterControl_MoveDirection = m_CharacterControl.FindAction("MoveDirection", throwIfNotFound: true);
        m_CharacterControl_MouseDirection = m_CharacterControl.FindAction("MouseDirection", throwIfNotFound: true);
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

    // CharacterControl
    private readonly InputActionMap m_CharacterControl;
    private List<ICharacterControlActions> m_CharacterControlActionsCallbackInterfaces = new List<ICharacterControlActions>();
    private readonly InputAction m_CharacterControl_MoveDirection;
    private readonly InputAction m_CharacterControl_MouseDirection;
    public struct CharacterControlActions
    {
        private @PlayerInputActoins m_Wrapper;
        public CharacterControlActions(@PlayerInputActoins wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_CharacterControl_MoveDirection;
        public InputAction @MouseDirection => m_Wrapper.m_CharacterControl_MouseDirection;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterControlActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Add(instance);
            @MoveDirection.started += instance.OnMoveDirection;
            @MoveDirection.performed += instance.OnMoveDirection;
            @MoveDirection.canceled += instance.OnMoveDirection;
            @MouseDirection.started += instance.OnMouseDirection;
            @MouseDirection.performed += instance.OnMouseDirection;
            @MouseDirection.canceled += instance.OnMouseDirection;
        }

        private void UnregisterCallbacks(ICharacterControlActions instance)
        {
            @MoveDirection.started -= instance.OnMoveDirection;
            @MoveDirection.performed -= instance.OnMoveDirection;
            @MoveDirection.canceled -= instance.OnMoveDirection;
            @MouseDirection.started -= instance.OnMouseDirection;
            @MouseDirection.performed -= instance.OnMouseDirection;
            @MouseDirection.canceled -= instance.OnMouseDirection;
        }

        public void RemoveCallbacks(ICharacterControlActions instance)
        {
            if (m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterControlActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterControlActions @CharacterControl => new CharacterControlActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface ICharacterControlActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
        void OnMouseDirection(InputAction.CallbackContext context);
    }
}
