﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Runtime.Serialization;

namespace ICSharpCode.Profiler.Controller.Data
{
	/// <summary>
	/// Thrown when the database used to internally store the usage data is incompatible with the DB version
	/// expected by the UsageDataCollector library.
	/// </summary>
	[Serializable]
	public class IncompatibleDatabaseException : Exception
	{
		/// <summary>
		/// Expected database version.
		/// </summary>
		public Version ExpectedVersion { get; set; }
		
		/// <summary>
		/// Actual database version.
		/// </summary>
		public Version ActualVersion { get; set; }
		
		/// <summary>
		/// Creates a new IncompatibleDatabaseException instance.
		/// </summary>
		public IncompatibleDatabaseException() {}
		
		/// <summary>
		/// Creates a new IncompatibleDatabaseException instance.
		/// </summary>
		public IncompatibleDatabaseException(Version expectedVersion, Version actualVersion)
			: base("Expected DB version " + expectedVersion + " but found " + actualVersion)
		{
			this.ExpectedVersion = expectedVersion;
			this.ActualVersion = actualVersion;
		}
		
		/// <summary>
		/// Deserializes an IncompatibleDatabaseException instance.
		/// </summary>
		protected IncompatibleDatabaseException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info != null) {
				this.ExpectedVersion = (Version)info.GetValue("ExpectedVersion", typeof(Version));
				this.ActualVersion = (Version)info.GetValue("ActualVersion", typeof(Version));
			}
		}
		
		/// <inheritdoc/>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			if (info != null) {
				info.AddValue("ExpectedVersion", ExpectedVersion, typeof(Version));
				info.AddValue("ActualVersion", ActualVersion, typeof(Version));
			}
		}
	}
}
