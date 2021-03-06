﻿// Remote Terminal, an SSH/Telnet terminal emulator for Microsoft Windows
// Copyright (C) 2012-2015 Stefan Podskubka
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace RemoteTerminal.Screens
{
    /// <summary>
    /// The interface for a writable screen.
    /// </summary>
    public interface IWritableScreen : IRenderableScreen
    {
        /// <summary>
        /// Gets the screen modifier.
        /// </summary>
        /// <returns>The screen modifier.</returns>
        IScreenModifier GetModifier();

        /// <summary>
        /// Gets the row position of the cursor (zero-based).
        /// </summary>
        int CursorRow { get; }

        /// <summary>
        /// Gets the column position of the cursor (zero-based).
        /// </summary>
        int CursorColumn { get; }
    }
}
