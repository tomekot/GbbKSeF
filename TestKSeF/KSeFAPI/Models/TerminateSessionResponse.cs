// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KSeFAPI.Models
{
    /// <summary> The TerminateSessionResponse. </summary>
    public partial class TerminateSessionResponse
    {
        /// <summary> Initializes a new instance of TerminateSessionResponse. </summary>
        /// <param name="timestamp"></param>
        /// <param name="referenceNumber"></param>
        /// <param name="processingCode"></param>
        /// <param name="processingDescription"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceNumber"/> or <paramref name="processingDescription"/> is null. </exception>
        internal TerminateSessionResponse(DateTimeOffset timestamp, string referenceNumber, int processingCode, string processingDescription)
        {
            if (referenceNumber == null)
            {
                throw new ArgumentNullException(nameof(referenceNumber));
            }
            if (processingDescription == null)
            {
                throw new ArgumentNullException(nameof(processingDescription));
            }

            Timestamp = timestamp;
            ReferenceNumber = referenceNumber;
            ProcessingCode = processingCode;
            ProcessingDescription = processingDescription;
        }

        /// <summary> Gets the timestamp. </summary>
        public DateTimeOffset Timestamp { get; }
        /// <summary> Gets the reference number. </summary>
        public string ReferenceNumber { get; }
        /// <summary> Gets the processing code. </summary>
        public int ProcessingCode { get; }
        /// <summary> Gets the processing description. </summary>
        public string ProcessingDescription { get; }
    }
}