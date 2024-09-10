﻿using System;
using Xunit.Sdk;

namespace Xunit.OpenCategories
{
    [TraitDiscoverer(BugDiscoverer.DiscovererTypeName, DiscovererUtil.AssemblyName)]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class BugAttribute:Attribute,ITraitAttribute
    {
        public BugAttribute(string id)
        {
            this.Id = id;
        }

        public BugAttribute(long id)
        {
            this.Id = id.ToString();
        }

        public BugAttribute()
        {

        }

        public string Id { get; private set; }
    }
}