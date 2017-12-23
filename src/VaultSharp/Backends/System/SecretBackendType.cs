﻿using System;
using Newtonsoft.Json;
using VaultSharp.Core;

namespace VaultSharp.Backends.System
{
    /// <summary>
    /// A helper class for retrieving and comparing Secret Backend types.
    /// </summary>
    [JsonConverter(typeof(SecretBackendTypeJsonConverter))]
    public class SecretBackendType : IEquatable<SecretBackendType>
    {
        /// <summary>
        /// Gets the system type.
        /// </summary>
        /// <value>
        /// The system.
        /// </value>
        public static SecretBackendType System { get; } = new SecretBackendType(SecretBackendDefaultPaths.System);

        /// <summary>
        /// Gets the aws type.
        /// </summary>
        /// <value>
        /// The aws.
        /// </value>
        public static SecretBackendType AWS { get; } = new SecretBackendType(SecretBackendDefaultPaths.AWS);

        /// <summary>
        /// Gets the consul type.
        /// </summary>
        /// <value>
        /// The consul.
        /// </value>
        public static SecretBackendType Consul { get; } = new SecretBackendType(SecretBackendDefaultPaths.Consul);

        /// <summary>
        /// Gets the cubby hole type.
        /// </summary>
        /// <value>
        /// The cubby hole.
        /// </value>
        public static SecretBackendType CubbyHole { get; } = new SecretBackendType(SecretBackendDefaultPaths.Cubbyhole);

        /// <summary>
        /// Gets the generic type.
        /// </summary>
        /// <value>
        /// The generic.
        /// </value>
        public static SecretBackendType KeyValue { get; } = new SecretBackendType(SecretBackendDefaultPaths.KeyValue);

        /// <summary>
        /// Gets the Identity type.
        /// </summary>
        /// <value>
        /// The Identity.
        /// </value>
        public static SecretBackendType Identity { get; } = new SecretBackendType(SecretBackendDefaultPaths.Identity);

        /// <summary>
        /// Gets the Nomad type.
        /// </summary>
        /// <value>
        /// The Nomad.
        /// </value>
        public static SecretBackendType Nomad { get; } = new SecretBackendType(SecretBackendDefaultPaths.Nomad);

        /// <summary>
        /// Gets the pki type.
        /// </summary>
        /// <value>
        /// The pki.
        /// </value>
        public static SecretBackendType PKI { get; } = new SecretBackendType(SecretBackendDefaultPaths.PKI);

        /// <summary>
        /// Gets the rabbit mq type.
        /// </summary>
        /// <value>
        /// The rabbit mq.
        /// </value>
        public static SecretBackendType RabbitMQ { get; } = new SecretBackendType(SecretBackendDefaultPaths.RabbitMQ);

        /// <summary>
        /// Gets the SSH type.
        /// </summary>
        /// <value>
        /// The SSH.
        /// </value>
        public static SecretBackendType SSH { get; } = new SecretBackendType(SecretBackendDefaultPaths.SSH);

        /// <summary>
        /// Gets the TOTP type.
        /// </summary>
        /// <value>
        /// The TOTP.
        /// </value>
        public static SecretBackendType TOTP { get; } = new SecretBackendType(SecretBackendDefaultPaths.TOTP);

        /// <summary>
        /// Gets the transit type.
        /// </summary>
        /// <value>
        /// The transit.
        /// </value>
        public static SecretBackendType Transit { get; } = new SecretBackendType(SecretBackendDefaultPaths.Transit);

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretBackendType"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public SecretBackendType(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(SecretBackendType left, SecretBackendType right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)left == null) || ((object)right == null))
            {
                return false;
            }

            return string.Equals(left.Type, right.Type, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(SecretBackendType left, SecretBackendType right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(SecretBackendType other)
        {
            if ((object)other == null)
                return false;

            return string.Compare(Type, other.Type, StringComparison.OrdinalIgnoreCase) == 0;
        }

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as SecretBackendType);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return Type.ToUpperInvariant().GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Type;
        }
    }
}