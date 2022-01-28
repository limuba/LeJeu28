// GENERATED AUTOMATICALLY FROM 'Assets/Player2/Controls.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""02d8aced-edb5-4247-a875-48e436142e47"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""69a9b58b-7c4b-4dc6-95fb-faebf454bf98"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4f2dba6f-108f-46c5-88d9-24c180a29278"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportRight"",
                    ""type"": ""Button"",
                    ""id"": ""5b089393-5dae-4fbe-b516-4a6baee5b1cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6493e771-0bf4-4360-87d4-36e7ffed26c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e46fd407-ddb3-4197-97e5-19e234e6f61e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""32ce5263-d4c1-42fd-8639-1a8ea1ae197b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b643b8d3-300d-42f3-a059-f8a8beb9e883"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e012625-e9e8-45dd-bc2e-a8b01ffff829"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4602c10-c006-472c-8171-12384e879e90"",
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
                    ""id"": ""6c1b118a-84f5-4d9d-b2e3-d67b15ef3479"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Newaction = m_Player.FindAction("New action", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_TeleportRight = m_Player.FindAction("TeleportRight", throwIfNotFound: true);
        m_Player_TeleportLeft = m_Player.FindAction("TeleportLeft", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Newaction;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_TeleportRight;
    private readonly InputAction m_Player_TeleportLeft;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Player_Newaction;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @TeleportRight => m_Wrapper.m_Player_TeleportRight;
        public InputAction @TeleportLeft => m_Wrapper.m_Player_TeleportLeft;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNewaction;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @TeleportRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportRight;
                @TeleportRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportRight;
                @TeleportRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportRight;
                @TeleportLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportLeft;
                @TeleportLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportLeft;
                @TeleportLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportLeft;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TeleportRight.started += instance.OnTeleportRight;
                @TeleportRight.performed += instance.OnTeleportRight;
                @TeleportRight.canceled += instance.OnTeleportRight;
                @TeleportLeft.started += instance.OnTeleportLeft;
                @TeleportLeft.performed += instance.OnTeleportLeft;
                @TeleportLeft.canceled += instance.OnTeleportLeft;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTeleportRight(InputAction.CallbackContext context);
        void OnTeleportLeft(InputAction.CallbackContext context);
    }
}
