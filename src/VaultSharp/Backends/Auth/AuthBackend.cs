﻿using Newtonsoft.Json;

namespace VaultSharp.Backends.Auth
{
    /// <summary>
    /// Represents an auth backend.
    /// </summary>
    public class AuthBackend : AbstractBackendBase
    {
        /// <summary>
        /// Gets or sets the type of the backend.
        /// </summary>
        /// <value>
        /// The type of the backend.
        /// </value>
        [JsonProperty("type")]
        public AuthBackendType Type { get; set; }
    }
}