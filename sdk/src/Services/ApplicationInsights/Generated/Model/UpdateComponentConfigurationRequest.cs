/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateComponentConfiguration operation.
    /// Updates the monitoring configurations for the component. The configuration input parameter
    /// is an escaped JSON of the configuration and should match the schema of what is returned
    /// by <code>DescribeComponentConfigurationRecommendation</code>.
    /// </summary>
    public partial class UpdateComponentConfigurationRequest : AmazonApplicationInsightsRequest
    {
        private string _componentConfiguration;
        private string _componentName;
        private bool? _monitor;
        private string _resourceGroupName;
        private string _tier;

        /// <summary>
        /// Gets and sets the property ComponentConfiguration. 
        /// <para>
        /// The configuration settings of the component. The value is the escaped JSON of the
        /// configuration. For more information about the JSON format, see <a href="https://docs.aws.amazon.com/sdk-for-javascript/v2/developer-guide/working-with-json.html">Working
        /// with JSON</a>. You can send a request to <code>DescribeComponentConfigurationRecommendation</code>
        /// to see the recommended configuration for a component.
        /// </para>
        /// </summary>
        public string ComponentConfiguration
        {
            get { return this._componentConfiguration; }
            set { this._componentConfiguration = value; }
        }

        // Check to see if ComponentConfiguration property is set
        internal bool IsSetComponentConfiguration()
        {
            return this._componentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property Monitor. 
        /// <para>
        /// Indicates whether the application component is monitored.
        /// </para>
        /// </summary>
        public bool Monitor
        {
            get { return this._monitor.GetValueOrDefault(); }
            set { this._monitor = value; }
        }

        // Check to see if Monitor property is set
        internal bool IsSetMonitor()
        {
            return this._monitor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the application component. Supported tiers include <code>DOT_NET_WORKER</code>,
        /// <code>DOT_NET_WEB</code>, <code>SQL_SERVER</code>, and <code>DEFAULT</code>.
        /// </para>
        /// </summary>
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}