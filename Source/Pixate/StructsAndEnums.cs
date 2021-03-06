/*
 *	Copyright (c) 2012-2013, Pixate, Inc
 *	All rights reserved.
 *
 *	This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

//
// Structures and enums for Pixate Framework API version 2 or greater
//

namespace PixateFramework
{
	public enum PXStylesheetOrigin
	{
		PXStylesheetOriginApplication,
		PXStylesheetOriginUser,
		PXStylesheetOriginView
	}

	public enum PXParseErrorDestination
	{
		PXParseErrorDestinationNone,
		PXParseErrorDestinationConsole,
	}

	public enum PXCacheStylesType
	{
		PXCacheStylesTypeAuto,
		PXCacheStylesTypeNone,
	}

	public enum PXStylingMode
	{
		PXStylingUndefined = 0,
		PXStylingNormal,
		PXStylingNone,
	}
}

