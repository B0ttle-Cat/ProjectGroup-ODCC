//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.1
//     from Packages/com.b0ttlecat.base/Scritps/Base/Input/BCInputSystem.inputactions
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
using UnityEngine;

namespace BC.BCInput
{
    public partial class @BCInputSystem: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @BCInputSystem()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""BCInputSystem"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""03392d42-5ddf-46ce-9ee3-fa1a8e237d06"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e622ce39-d3af-4d43-b6a2-c07ce467d237"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""700cc1bf-9062-4d6d-a4a3-d493da9d9870"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""ed072567-a123-4ba6-bdd1-07c28682aeae"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c9c72497-b96a-4280-bdb0-f23b2bc342e3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c3d2f71-d10d-43a5-a2fe-651c3e18f010"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f26d70a4-5c56-47f4-b74e-c029d79b1024"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""222505bd-a9e4-4c00-8dbc-8336d2eef5d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50ceb71b-eb41-4d2b-bf9d-4741ce7d81d9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Scroll"",
                    ""id"": ""0dc0d49d-04d6-4db4-a7c5-4d1e56b1ea39"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dff56302-aa42-441f-98fd-d40a6c4bedfd"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""88627556-6d31-4085-917e-67559712b273"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""QE"",
                    ""id"": ""d3c678d0-f61d-444b-ae3f-a0fb760531a3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""45a2bc4d-79b2-48ea-8211-d00cb88774d6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2b6ea148-3f35-485f-9d9f-3ae96d2bb79d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CursorPointer"",
            ""id"": ""b0f11db0-4c12-4f16-8274-f505936c3da3"",
            ""actions"": [
                {
                    ""name"": ""Drag"",
                    ""type"": ""Value"",
                    ""id"": ""38e49024-cc1e-46a5-9657-bb076f249c7f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""a8b6b869-de3d-4505-a512-1337e2cbafc3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""7f3969a1-95b0-4f38-9b56-f2f497eb3bad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""a6e1cb7b-62d1-4894-b233-6215c97d9cfc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1bf55822-230e-46c9-9492-60fdd6204959"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b5ea509-ff9e-4b5c-800e-93cf913ffba8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76ab8b3e-dc1f-488a-a2bf-3c2ac712be5f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81f65c85-80ef-46a5-8c3b-bbe17a2254b3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Camera
            m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
            m_Camera_Move = m_Camera.FindAction("Move", throwIfNotFound: true);
            m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
            m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
            // CursorPointer
            m_CursorPointer = asset.FindActionMap("CursorPointer", throwIfNotFound: true);
            m_CursorPointer_Drag = m_CursorPointer.FindAction("Drag", throwIfNotFound: true);
            m_CursorPointer_Position = m_CursorPointer.FindAction("Position", throwIfNotFound: true);
            m_CursorPointer_Action = m_CursorPointer.FindAction("Action", throwIfNotFound: true);
            m_CursorPointer_Select = m_CursorPointer.FindAction("Select", throwIfNotFound: true);
        }

        ~@BCInputSystem()
        {
            Debug.Assert(!m_Camera.enabled, "This will cause a leak and performance issues, BCInputSystem.Camera.Disable() has not been called.");
            Debug.Assert(!m_CursorPointer.enabled, "This will cause a leak and performance issues, BCInputSystem.CursorPointer.Disable() has not been called.");
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

        // Camera
        private readonly InputActionMap m_Camera;
        private List<ICameraActions> m_CameraActionsCallbackInterfaces = new List<ICameraActions>();
        private readonly InputAction m_Camera_Move;
        private readonly InputAction m_Camera_Rotate;
        private readonly InputAction m_Camera_Zoom;
        public struct CameraActions
        {
            private @BCInputSystem m_Wrapper;
            public CameraActions(@BCInputSystem wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Camera_Move;
            public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
            public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
            public InputActionMap Get() { return m_Wrapper.m_Camera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
            public void AddCallbacks(ICameraActions instance)
            {
                if (instance == null || m_Wrapper.m_CameraActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_CameraActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }

            private void UnregisterCallbacks(ICameraActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Rotate.started -= instance.OnRotate;
                @Rotate.performed -= instance.OnRotate;
                @Rotate.canceled -= instance.OnRotate;
                @Zoom.started -= instance.OnZoom;
                @Zoom.performed -= instance.OnZoom;
                @Zoom.canceled -= instance.OnZoom;
            }

            public void RemoveCallbacks(ICameraActions instance)
            {
                if (m_Wrapper.m_CameraActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ICameraActions instance)
            {
                foreach (var item in m_Wrapper.m_CameraActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_CameraActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public CameraActions @Camera => new CameraActions(this);

        // CursorPointer
        private readonly InputActionMap m_CursorPointer;
        private List<ICursorPointerActions> m_CursorPointerActionsCallbackInterfaces = new List<ICursorPointerActions>();
        private readonly InputAction m_CursorPointer_Drag;
        private readonly InputAction m_CursorPointer_Position;
        private readonly InputAction m_CursorPointer_Action;
        private readonly InputAction m_CursorPointer_Select;
        public struct CursorPointerActions
        {
            private @BCInputSystem m_Wrapper;
            public CursorPointerActions(@BCInputSystem wrapper) { m_Wrapper = wrapper; }
            public InputAction @Drag => m_Wrapper.m_CursorPointer_Drag;
            public InputAction @Position => m_Wrapper.m_CursorPointer_Position;
            public InputAction @Action => m_Wrapper.m_CursorPointer_Action;
            public InputAction @Select => m_Wrapper.m_CursorPointer_Select;
            public InputActionMap Get() { return m_Wrapper.m_CursorPointer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CursorPointerActions set) { return set.Get(); }
            public void AddCallbacks(ICursorPointerActions instance)
            {
                if (instance == null || m_Wrapper.m_CursorPointerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_CursorPointerActionsCallbackInterfaces.Add(instance);
                @Drag.started += instance.OnDrag;
                @Drag.performed += instance.OnDrag;
                @Drag.canceled += instance.OnDrag;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }

            private void UnregisterCallbacks(ICursorPointerActions instance)
            {
                @Drag.started -= instance.OnDrag;
                @Drag.performed -= instance.OnDrag;
                @Drag.canceled -= instance.OnDrag;
                @Position.started -= instance.OnPosition;
                @Position.performed -= instance.OnPosition;
                @Position.canceled -= instance.OnPosition;
                @Action.started -= instance.OnAction;
                @Action.performed -= instance.OnAction;
                @Action.canceled -= instance.OnAction;
                @Select.started -= instance.OnSelect;
                @Select.performed -= instance.OnSelect;
                @Select.canceled -= instance.OnSelect;
            }

            public void RemoveCallbacks(ICursorPointerActions instance)
            {
                if (m_Wrapper.m_CursorPointerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ICursorPointerActions instance)
            {
                foreach (var item in m_Wrapper.m_CursorPointerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_CursorPointerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public CursorPointerActions @CursorPointer => new CursorPointerActions(this);
        private int m_PCSchemeIndex = -1;
        public InputControlScheme PCScheme
        {
            get
            {
                if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
                return asset.controlSchemes[m_PCSchemeIndex];
            }
        }
        private int m_TouchSchemeIndex = -1;
        public InputControlScheme TouchScheme
        {
            get
            {
                if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
                return asset.controlSchemes[m_TouchSchemeIndex];
            }
        }
        public interface ICameraActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
            void OnZoom(InputAction.CallbackContext context);
        }
        public interface ICursorPointerActions
        {
            void OnDrag(InputAction.CallbackContext context);
            void OnPosition(InputAction.CallbackContext context);
            void OnAction(InputAction.CallbackContext context);
            void OnSelect(InputAction.CallbackContext context);
        }
    }
}