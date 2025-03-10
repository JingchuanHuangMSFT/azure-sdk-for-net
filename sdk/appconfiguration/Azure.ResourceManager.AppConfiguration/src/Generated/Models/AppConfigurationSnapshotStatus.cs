// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> The current status of the snapshot. </summary>
    public readonly partial struct AppConfigurationSnapshotStatus : IEquatable<AppConfigurationSnapshotStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppConfigurationSnapshotStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProvisioningValue = "Provisioning";
        private const string ReadyValue = "Ready";
        private const string ArchivedValue = "Archived";
        private const string FailedValue = "Failed";

        /// <summary> Provisioning. </summary>
        public static AppConfigurationSnapshotStatus Provisioning { get; } = new AppConfigurationSnapshotStatus(ProvisioningValue);
        /// <summary> Ready. </summary>
        public static AppConfigurationSnapshotStatus Ready { get; } = new AppConfigurationSnapshotStatus(ReadyValue);
        /// <summary> Archived. </summary>
        public static AppConfigurationSnapshotStatus Archived { get; } = new AppConfigurationSnapshotStatus(ArchivedValue);
        /// <summary> Failed. </summary>
        public static AppConfigurationSnapshotStatus Failed { get; } = new AppConfigurationSnapshotStatus(FailedValue);
        /// <summary> Determines if two <see cref="AppConfigurationSnapshotStatus"/> values are the same. </summary>
        public static bool operator ==(AppConfigurationSnapshotStatus left, AppConfigurationSnapshotStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppConfigurationSnapshotStatus"/> values are not the same. </summary>
        public static bool operator !=(AppConfigurationSnapshotStatus left, AppConfigurationSnapshotStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppConfigurationSnapshotStatus"/>. </summary>
        public static implicit operator AppConfigurationSnapshotStatus(string value) => new AppConfigurationSnapshotStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppConfigurationSnapshotStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppConfigurationSnapshotStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
