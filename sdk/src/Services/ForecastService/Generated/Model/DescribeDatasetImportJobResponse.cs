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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDatasetImportJob operation.
    /// </summary>
    public partial class DescribeDatasetImportJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _datasetArn;
        private string _datasetImportJobArn;
        private string _datasetImportJobName;
        private double? _dataSize;
        private DataSource _dataSource;
        private Dictionary<string, Statistics> _fieldStatistics = new Dictionary<string, Statistics>();
        private DateTime? _lastModificationTime;
        private string _message;
        private string _status;
        private string _timestampFormat;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the dataset import job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset that the training data was imported
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobArn. 
        /// <para>
        /// The ARN of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DatasetImportJobArn
        {
            get { return this._datasetImportJobArn; }
            set { this._datasetImportJobArn = value; }
        }

        // Check to see if DatasetImportJobArn property is set
        internal bool IsSetDatasetImportJobArn()
        {
            return this._datasetImportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobName. 
        /// <para>
        /// The name of the dataset import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DatasetImportJobName
        {
            get { return this._datasetImportJobName; }
            set { this._datasetImportJobName = value; }
        }

        // Check to see if DatasetImportJobName property is set
        internal bool IsSetDatasetImportJobName()
        {
            return this._datasetImportJobName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSize. 
        /// <para>
        /// The size of the dataset in gigabytes (GB) after completion of the import job.
        /// </para>
        /// </summary>
        public double DataSize
        {
            get { return this._dataSize.GetValueOrDefault(); }
            set { this._dataSize = value; }
        }

        // Check to see if DataSize property is set
        internal bool IsSetDataSize()
        {
            return this._dataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The location of the training data to import. The training data must be stored in an
        /// Amazon S3 bucket.
        /// </para>
        /// </summary>
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property FieldStatistics. 
        /// <para>
        /// Statistical information about each field in the input data.
        /// </para>
        /// </summary>
        public Dictionary<string, Statistics> FieldStatistics
        {
            get { return this._fieldStatistics; }
            set { this._fieldStatistics = value; }
        }

        // Check to see if FieldStatistics property is set
        internal bool IsSetFieldStatistics()
        {
            return this._fieldStatistics != null && this._fieldStatistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// Dependent on the status as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code> - same as <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_IN_PROGRESS</code> - the current timestamp
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> or <code>CREATE_FAILED</code> - when the job finished or failed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the dataset import job. The status is reflected in the status of the
        /// dataset. For example, when the import job status is <code>CREATE_IN_PROGRESS</code>,
        /// the status of the dataset is <code>UPDATE_IN_PROGRESS</code>. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampFormat. 
        /// <para>
        /// The format of timestamps in the dataset. Two formats are supported dependent on the
        /// <code>DataFrequency</code> specified when the dataset was created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// "yyyy-MM-dd"
        /// </para>
        ///  
        /// <para>
        /// For data frequencies: Y, M, W, and D
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// "yyyy-MM-dd HH:mm:ss"
        /// </para>
        ///  
        /// <para>
        /// For data frequencies: H, 30min, 15min, and 1min; and optionally, for: Y, M, W, and
        /// D
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string TimestampFormat
        {
            get { return this._timestampFormat; }
            set { this._timestampFormat = value; }
        }

        // Check to see if TimestampFormat property is set
        internal bool IsSetTimestampFormat()
        {
            return this._timestampFormat != null;
        }

    }
}