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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the ListArtifacts operation.
    /// List artifacts with an app, a branch, a job and an artifact type.
    /// </summary>
    public partial class ListArtifactsRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private ArtifactType _artifactType;
        private string _branchName;
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  Unique Id for an Amplify App. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        ///  Type for an artifact. 
        /// </para>
        /// </summary>
        public ArtifactType ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  Name for a branch, part of an Amplify App. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  Unique Id for an Job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Maximum number of records to list in a single response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  Pagination token. Set to null to start listing artifacts from start. If non-null
        /// pagination token is returned in a result, then pass its value in here to list more
        /// artifacts. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}