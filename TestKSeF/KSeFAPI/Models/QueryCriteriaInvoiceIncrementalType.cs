// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace KSeFAPI.Models
{
    /// <summary> The QueryCriteriaInvoiceIncrementalType. </summary>
    public partial class QueryCriteriaInvoiceIncrementalType : QueryCriteriaInvoiceType
    {
        /// <summary> Initializes a new instance of QueryCriteriaInvoiceIncrementalType. </summary>
        /// <param name="subjectType"></param>
        /// <param name="acquisitionTimestampThresholdFrom"></param>
        /// <param name="acquisitionTimestampThresholdTo"></param>
        public QueryCriteriaInvoiceIncrementalType(QueryCriteriaInvoiceTypeSubjectType subjectType, DateTimeOffset acquisitionTimestampThresholdFrom, DateTimeOffset acquisitionTimestampThresholdTo) : base(subjectType)
        {
            AcquisitionTimestampThresholdFrom = acquisitionTimestampThresholdFrom;
            AcquisitionTimestampThresholdTo = acquisitionTimestampThresholdTo;
            Type = "incremental";
        }

        /// <summary> Gets the acquisition timestamp threshold from. </summary>
        public DateTimeOffset AcquisitionTimestampThresholdFrom { get; }
        /// <summary> Gets the acquisition timestamp threshold to. </summary>
        public DateTimeOffset AcquisitionTimestampThresholdTo { get; }
    }
}