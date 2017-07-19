// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceBus.Fluent;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Defines values for UnavailableReason.
    /// </summary>
    public class UnavailableReason : ExpandableStringEnum<UnavailableReason>
    {
        public static readonly UnavailableReason None = Parse("None");
        public static readonly UnavailableReason InvalidName = Parse("InvalidName");
        public static readonly UnavailableReason SubscriptionIsDisabled = Parse("SubscriptionIsDisabled");
        public static readonly UnavailableReason NameInUse = Parse("NameInUse");
        public static readonly UnavailableReason NameInLockdown = Parse("NameInLockdown");
        public static readonly UnavailableReason TooManyNamespaceInCurrentSubscription = Parse("TooManyNamespaceInCurrentSubscription");
    }
}