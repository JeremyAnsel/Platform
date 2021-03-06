﻿/*
 * Idmr.Platform.dll, X-wing series mission library file, TIE95-XWA
 * Copyright (C) 2009-2014 Michael Gaisser (mjgaisser@gmail.com)
 * Licensed under the MPL v2.0 or later
 * 
 * Full notice in ../help/Idmr.Platform.chm
 * Version: 2.1
 */

/* CHANGELOG
 * v2.1, 141214
 * [UPD] change to MPL
 */

using System;
using System.Collections.Generic;

namespace Idmr.Platform.Xwa
{
	/// <summary>Object to hold all Briefings</summary>
	/// <remarks>Two briefings in total, first being used for single-player</remarks>
	public class BriefingCollection : Idmr.Common.FixedSizeCollection<Briefing>
	{
		/// <summary>Create a new Collection with 2 Briefings</summary>
		public BriefingCollection()
		{
			_items = new List<Briefing>(2);
			for (int i = 0; i < _items.Capacity; i++) _items.Add(new Briefing());
		}

		/// <summary>Resets selected Briefing to defaults</summary>
		/// <param name="index">Briefing index</param>
		public void Clear(int index) { _setItem(index, new Briefing()); }

		/// <summary>Resets all Briefings to defaults</summary>
		public void ClearAll() { for (int i = 0; i < Count; i++) _setItem(i, new Briefing()); }
	}
}