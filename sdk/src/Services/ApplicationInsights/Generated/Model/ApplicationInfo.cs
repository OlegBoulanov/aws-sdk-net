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
    /// Describes the status of the application.
    /// </summary>
    public partial class ApplicationInfo
    {
        private string _lifeCycle;
        private bool? _opsCenterEnabled;
        private string _opsItemSNSTopicArn;
        private string _remarks;
        private string _resourceGroupName;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The lifecycle of the application. 
        /// </para>
        /// </summary>
        public string LifeCycle
        {
            get { return this._lifeCycle; }
            set { this._lifeCycle = value; }
        }

        // Check to see if LifeCycle property is set
        internal bool IsSetLifeCycle()
        {
            return this._lifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property OpsCenterEnabled. 
        /// <para>
        ///  Indicates whether Application Insights will create opsItems for any problem detected
        /// by Application Insights for an application. 
        /// </para>
        /// </summary>
        public bool OpsCenterEnabled
        {
            get { return this._opsCenterEnabled.GetValueOrDefault(); }
            set { this._opsCenterEnabled = value; }
        }

        // Check to see if OpsCenterEnabled property is set
        internal bool IsSetOpsCenterEnabled()
        {
            return this._opsCenterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpsItemSNSTopicArn. 
        /// <para>
        ///  The SNS topic provided to Application Insights that is associated to the created
        /// opsItems to receive SNS notifications for opsItem updates. 
        /// </para>
        /// </summary>
        public string OpsItemSNSTopicArn
        {
            get { return this._opsItemSNSTopicArn; }
            set { this._opsItemSNSTopicArn = value; }
        }

        // Check to see if OpsItemSNSTopicArn property is set
        internal bool IsSetOpsItemSNSTopicArn()
        {
            return this._opsItemSNSTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property Remarks. 
        /// <para>
        /// The issues on the user side that block Application Insights from successfully monitoring
        /// an application.
        /// </para>
        /// </summary>
        public string Remarks
        {
            get { return this._remarks; }
            set { this._remarks = value; }
        }

        // Check to see if Remarks property is set
        internal bool IsSetRemarks()
        {
            return this._remarks != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group used for the application.
        /// </para>
        /// </summary>
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

    }
}