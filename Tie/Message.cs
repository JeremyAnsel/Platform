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

namespace Idmr.Platform.Tie
{
	/// <summary>Object for individual in-flight messages</summary>
	/// <remarks>Class is serializable to allow copy and paste functionality</remarks>
	[Serializable] public class Message : BaseMessage
	{
		string _short = "";
		Mission.Trigger[] _triggers = new Mission.Trigger[2];

		/// <summary>Creates a new Message object</summary>
		public Message()
		{
			_triggers[0] = new Mission.Trigger();
			_triggers[1] = new Mission.Trigger();
		}

		/// <summary>Gets or sets the string used as editor notes</summary>
		/// <remarks>Value is restricted to 12 characters</remarks>
		public string Short
		{
			get { return _short; }
			set { _short = Idmr.Common.StringFunctions.GetTrimmed(value, 0xC); }
		}
		/// <summary>Gets or sets the seconds after trigger is fired divided by five</summary>
		/// <remarks>Default is <b>zero</b>. Value of 1 is 5s, 2 is 10s, etc.</remarks>
		public byte Delay { get; set; }
		/// <summary>Gets or sets if both triggers must be completed</summary>
		/// <remarks><b>false</b> is "And", <b>true</b> is "Or", defaults to <b>false</b></remarks>
		public bool Trig1AndOrTrig2 { get; set; }

		/// <summary>Gets the Triggers that control the Message behaviour</summary>
		/// <remarks>Array length is 2</remarks>
		public Mission.Trigger[] Triggers { get { return _triggers; } }
	}
}
