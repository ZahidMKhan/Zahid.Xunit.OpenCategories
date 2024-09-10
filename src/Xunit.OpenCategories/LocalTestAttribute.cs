﻿using System;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
	/// <summary>
	/// For tests that should only be executed locally and excluded from automated pipeline runs
	/// </summary>
	/// <example>trying out LINQ for the first time, writing a piece of code to understand IEnumerable.Take and Skip.</example>
	[TraitDiscoverer(LocalTestDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
	public class LocalTestAttribute:Attribute,ITraitAttribute
	{
		public LocalTestAttribute(string id)
		{
			this.Id = id;
		}

		public LocalTestAttribute(long id)
		{
			this.Id = id.ToString();
		}

		public LocalTestAttribute()
		{

		}

		public string Id { get; }
	}
}