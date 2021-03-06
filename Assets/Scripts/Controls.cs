// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MoveJump"",
            ""id"": ""e6c76587-99e2-4ee8-885c-4292abecc48c"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b2427abb-d752-4ce7-9037-717e699d88ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLR"",
                    ""type"": ""Value"",
                    ""id"": ""552e8b62-62fa-466d-a402-624081827deb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportRight"",
                    ""type"": ""Button"",
                    ""id"": ""990d2a7f-ea26-4587-83a3-a06db43a969c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0611eb9b-7411-4e78-8f51-c2ddc6ac7ee6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1f3048e4-4322-47fb-bde0-13d9ba079ab9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d26f6887-3dac-45d7-b6e0-5410be8b8606"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a954106f-77f8-4489-b77e-004d4f555956"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d94c27fc-15f3-4448-ae45-38ea673dff9e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""71af2edd-1d7f-437f-9b9d-775055961a9d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d455fdd-5d4b-4df2-a39f-145b5548d6ec"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveJump
        m_MoveJump = asset.FindActionMap("MoveJump", throwIfNotFound: true);
        m_MoveJump_Jump = m_MoveJump.FindAction("Jump", throwIfNotFound: true);
        m_MoveJump_MoveLR = m_MoveJump.FindAction("MoveLR", throwIfNotFound: true);
        m_MoveJump_TeleportRight = m_MoveJump.FindAction("TeleportRight", throwIfNotFound: true);
        m_MoveJump_TeleportLeft = m_MoveJump.FindAction("TeleportLeft", throwIfNotFound: true);
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

    // MoveJump
    private readonly InputActionMap m_MoveJump;
    private IMoveJumpActions m_MoveJumpActionsCallbackInterface;
    private readonly InputAction m_MoveJump_Jump;
    private readonly InputAction m_MoveJump_MoveLR;
    private readonly InputAction m_MoveJump_TeleportRight;
    private readonly InputAction m_MoveJump_TeleportLeft;
    public struct MoveJumpActions
    {
        private @Controls m_Wrapper;
        public MoveJumpActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_MoveJump_Jump;
        public InputAction @MoveLR => m_Wrapper.m_MoveJump_MoveLR;
        public InputAction @TeleportRight => m_Wrapper.m_MoveJump_TeleportRight;
        public InputAction @TeleportLeft => m_Wrapper.m_MoveJump_TeleportLeft;
        public InputActionMap Get() { return m_Wrapper.m_MoveJump; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveJumpActions set) { return set.Get(); }
        public void SetCallbacks(IMoveJumpActions instance)
        {
            if (m_Wrapper.m_MoveJumpActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnJump;
                @MoveLR.started -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnMoveLR;
                @MoveLR.performed -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnMoveLR;
                @MoveLR.canceled -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnMoveLR;
                @TeleportRight.started -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportRight;
                @TeleportRight.performed -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportRight;
                @TeleportRight.canceled -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportRight;
                @TeleportLeft.started -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportLeft;
                @TeleportLeft.performed -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportLeft;
                @TeleportLeft.canceled -= m_Wrapper.m_MoveJumpActionsCallbackInterface.OnTeleportLeft;
            }
            m_Wrapper.m_MoveJumpActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLR.started += instance.OnMoveLR;
                @MoveLR.performed += instance.OnMoveLR;
                @MoveLR.canceled += instance.OnMoveLR;
                @TeleportRight.started += instance.OnTeleportRight;
                @TeleportRight.performed += instance.OnTeleportRight;
                @TeleportRight.canceled += instance.OnTeleportRight;
                @TeleportLeft.started += instance.OnTeleportLeft;
                @TeleportLeft.performed += instance.OnTeleportLeft;
                @TeleportLeft.canceled += instance.OnTeleportLeft;
            }
        }
    }
    public MoveJumpActions @MoveJump => new MoveJumpActions(this);
    public interface IMoveJumpActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLR(InputAction.CallbackContext context);
        void OnTeleportRight(InputAction.CallbackContext context);
        void OnTeleportLeft(InputAction.CallbackContext context);
    }
}
