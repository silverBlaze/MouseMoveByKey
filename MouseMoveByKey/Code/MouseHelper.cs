using System;
using System.Runtime.InteropServices;

namespace MouseMoveByKey {
    public class MouseHelper {

        private const uint MOUSEEVENTF_MOVE = 0x0001;
        private static int _moveFactor = 2;

        public static void MoveMouse(MouseMoveDirection direction, int magnitude) {
            switch(direction) {
                case MouseMoveDirection.Left:
                    mouse_event(MOUSEEVENTF_MOVE, -1 * _moveFactor * magnitude, 0, 0, (UIntPtr)0);
                    return;
                case MouseMoveDirection.Right:
                    mouse_event(MOUSEEVENTF_MOVE, 1 * _moveFactor * magnitude, 0, 0, (UIntPtr)0);
                    return;
                case MouseMoveDirection.Up:
                    mouse_event(MOUSEEVENTF_MOVE, 0, -1 * _moveFactor * magnitude, 0, (UIntPtr)0);
                    return;
                case MouseMoveDirection.Down:
                    mouse_event(MOUSEEVENTF_MOVE, 0, 1 * _moveFactor * magnitude, 0, (UIntPtr)0);
                    return;
            }
        }
        
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);
    }
}
