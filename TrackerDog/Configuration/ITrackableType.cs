﻿namespace TrackerDog.Configuration
{
    using System;
    using System.Collections.Immutable;
    using System.Reflection;

    /// <summary>
    /// Defines the configuration of a trackable type
    /// </summary>
    public interface ITrackableType
    {
        /// <summary>
        /// Gets the type being tracked
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Gets which properties should be tracked for the tracked type.
        /// </summary>
        IImmutableSet<PropertyInfo> IncludedProperties { get; }
    }
}