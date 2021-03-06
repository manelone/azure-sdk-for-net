// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The external security solution properties for AAD solutions
    /// </summary>
    public partial class AadSolutionProperties
    {
        /// <summary>
        /// Initializes a new instance of the AadSolutionProperties class.
        /// </summary>
        public AadSolutionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AadSolutionProperties class.
        /// </summary>
        /// <param name="connectivityState">The connectivity state of the
        /// external AAD solution </param>
        public AadSolutionProperties(string deviceVendor = default(string), string deviceType = default(string), ConnectedWorkspace workspace = default(ConnectedWorkspace), string connectivityState = default(string))
        {
            DeviceVendor = deviceVendor;
            DeviceType = deviceType;
            Workspace = workspace;
            ConnectivityState = connectivityState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceVendor")]
        public string DeviceVendor { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workspace")]
        public ConnectedWorkspace Workspace { get; set; }

        /// <summary>
        /// Gets or sets the connectivity state of the external AAD solution
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Discovered', 'NotLicensed', 'Connected'
        /// </remarks>
        [JsonProperty(PropertyName = "connectivityState")]
        public string ConnectivityState { get; set; }

    }
}
