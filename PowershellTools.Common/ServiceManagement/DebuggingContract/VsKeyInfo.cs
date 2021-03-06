﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PowerShellTools.Common.ServiceManagement.DebuggingContract
{
    [Serializable]
    public class VsKeyInfo
    {
        private VsKeyInfo()
        {
        }

        public static VsKeyInfo Create(Key key,
            char keyChar,
            byte virtualKey,
            KeyStates keyStates = default(KeyStates),
            bool shiftPressed = false,
            bool controlPressed = false,
            bool altPressed = false,
            bool capsLockToggled = false,
            bool numLockToggled = false)
        {

            return new VsKeyInfo
            {
                Key = key,
                KeyChar = keyChar,
                VirtualKey = virtualKey,
                KeyStates = keyStates,
                ShiftPressed = shiftPressed,
                ControlPressed = controlPressed,
                AltPressed = altPressed,
                CapsLockToggled = capsLockToggled,
                NumLockToggled = numLockToggled
            };
        }

        public Key Key { get; private set; }
        public char KeyChar { get; private set; }
        public byte VirtualKey { get; private set; }
        public KeyStates KeyStates { get; private set; }
        public bool ShiftPressed { get; private set; }
        public bool ControlPressed { get; private set; }
        public bool AltPressed { get; private set; }
        public bool CapsLockToggled { get; private set; }
        public bool NumLockToggled { get; private set; }
    }
}
