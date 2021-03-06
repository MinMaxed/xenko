// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Xenko.Input
{
    /// <summary>
    /// Event for a button changing state on a device
    /// </summary>
    public abstract class ButtonEvent : InputEvent
    {
        /// <summary>
        /// The new state of the button
        /// </summary>
        public bool IsDown;
    }
}