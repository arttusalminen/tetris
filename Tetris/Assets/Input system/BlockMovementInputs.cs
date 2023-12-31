//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input system/BlockMovementInputs.inputactions
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

public partial class @BlockMovementInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BlockMovementInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BlockMovementInputs"",
    ""maps"": [
        {
            ""name"": ""BlockControls"",
            ""id"": ""bb100fa0-deb6-46ef-8a92-a69d8a2a25b5"",
            ""actions"": [
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""790c485d-a149-4722-b4fd-6ae5d9ca42e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move Left"",
                    ""type"": ""Button"",
                    ""id"": ""3aa675a2-7d89-498b-8e84-0a379017e58a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate Block"",
                    ""type"": ""Button"",
                    ""id"": ""7c356afd-5fe9-4bf6-9630-7c7d32c22150"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c260eb2-16df-4286-ac96-999886495dd1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f1a472-e1b4-4574-a67f-cc754ae53370"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26f7f463-753f-403b-a9f7-6ae303b6b38f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BlockControls
        m_BlockControls = asset.FindActionMap("BlockControls", throwIfNotFound: true);
        m_BlockControls_MoveRight = m_BlockControls.FindAction("MoveRight", throwIfNotFound: true);
        m_BlockControls_MoveLeft = m_BlockControls.FindAction("Move Left", throwIfNotFound: true);
        m_BlockControls_RotateBlock = m_BlockControls.FindAction("Rotate Block", throwIfNotFound: true);
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

    // BlockControls
    private readonly InputActionMap m_BlockControls;
    private List<IBlockControlsActions> m_BlockControlsActionsCallbackInterfaces = new List<IBlockControlsActions>();
    private readonly InputAction m_BlockControls_MoveRight;
    private readonly InputAction m_BlockControls_MoveLeft;
    private readonly InputAction m_BlockControls_RotateBlock;
    public struct BlockControlsActions
    {
        private @BlockMovementInputs m_Wrapper;
        public BlockControlsActions(@BlockMovementInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveRight => m_Wrapper.m_BlockControls_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_BlockControls_MoveLeft;
        public InputAction @RotateBlock => m_Wrapper.m_BlockControls_RotateBlock;
        public InputActionMap Get() { return m_Wrapper.m_BlockControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BlockControlsActions set) { return set.Get(); }
        public void AddCallbacks(IBlockControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_BlockControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BlockControlsActionsCallbackInterfaces.Add(instance);
            @MoveRight.started += instance.OnMoveRight;
            @MoveRight.performed += instance.OnMoveRight;
            @MoveRight.canceled += instance.OnMoveRight;
            @MoveLeft.started += instance.OnMoveLeft;
            @MoveLeft.performed += instance.OnMoveLeft;
            @MoveLeft.canceled += instance.OnMoveLeft;
            @RotateBlock.started += instance.OnRotateBlock;
            @RotateBlock.performed += instance.OnRotateBlock;
            @RotateBlock.canceled += instance.OnRotateBlock;
        }

        private void UnregisterCallbacks(IBlockControlsActions instance)
        {
            @MoveRight.started -= instance.OnMoveRight;
            @MoveRight.performed -= instance.OnMoveRight;
            @MoveRight.canceled -= instance.OnMoveRight;
            @MoveLeft.started -= instance.OnMoveLeft;
            @MoveLeft.performed -= instance.OnMoveLeft;
            @MoveLeft.canceled -= instance.OnMoveLeft;
            @RotateBlock.started -= instance.OnRotateBlock;
            @RotateBlock.performed -= instance.OnRotateBlock;
            @RotateBlock.canceled -= instance.OnRotateBlock;
        }

        public void RemoveCallbacks(IBlockControlsActions instance)
        {
            if (m_Wrapper.m_BlockControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBlockControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_BlockControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BlockControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BlockControlsActions @BlockControls => new BlockControlsActions(this);
    public interface IBlockControlsActions
    {
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnRotateBlock(InputAction.CallbackContext context);
    }
}
