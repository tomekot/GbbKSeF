// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;

namespace KSeFAPI.Models
{
    /// <summary> The HashSHAType. </summary>
    public partial class HashSHAType
    {
        /// <summary> Initializes a new instance of HashSHAType. </summary>
        /// <param name="algorithm"></param>
        /// <param name="encoding"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="algorithm"/>, <paramref name="encoding"/> or <paramref name="value"/> is null. </exception>
        public HashSHAType(string algorithm, string encoding, /*Stream*/ string value)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm));
            }
            if (encoding == null)
            {
                throw new ArgumentNullException(nameof(encoding));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Algorithm = algorithm;
            Encoding = encoding;
            Value = value;
        }

        /// <summary> Gets or sets the algorithm. </summary>
        public string Algorithm { get; set; }
        /// <summary> Gets or sets the encoding. </summary>
        public string Encoding { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public /*Stream*/ string Value { get; set; }
    }
}