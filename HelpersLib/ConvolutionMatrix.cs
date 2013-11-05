﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2008-2013 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpersLib
{
    public class ConvolutionMatrix
    {
        public int Size { get; private set; }
        public int[,] Matrix { get; set; }
        public int Factor { get; set; }
        public int Offset { get; set; }

        public ConvolutionMatrix()
            : this(3)
        {
        }

        public ConvolutionMatrix(int size)
        {
            Size = size;
            Matrix = new int[Size, Size];
            Factor = 1;
        }

        public void SetAll(int value)
        {
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    Matrix[x, y] = value;
                }
            }
        }
    }
}