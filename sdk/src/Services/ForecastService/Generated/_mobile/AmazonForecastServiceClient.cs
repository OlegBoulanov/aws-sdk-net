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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ForecastService.Model;
using Amazon.ForecastService.Model.Internal.MarshallTransformations;
using Amazon.ForecastService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ForecastService
{
    /// <summary>
    /// Implementation for accessing ForecastService
    ///
    /// Provides APIs for creating and managing Amazon Forecast resources.
    /// </summary>
    public partial class AmazonForecastServiceClient : AmazonServiceClient, IAmazonForecastService
    {
        private static IServiceMetadata serviceMetadata = new AmazonForecastServiceMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonForecastServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(AmazonForecastServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonForecastServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonForecastServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Credentials and an
        /// AmazonForecastServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(AWSCredentials credentials, AmazonForecastServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonForecastServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonForecastServiceClient Configuration Object</param>
        public AmazonForecastServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonForecastServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
        /// helps Forecast understand how to consume the data for model training. This includes
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
        /// data is collected. Amazon Forecast uses this information when training the model and
        /// generating a forecast.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Domain</code> </i> and <i> <code>DatasetType</code> </i> - Each dataset
        /// has an associated dataset domain and a type within the domain. Amazon Forecast provides
        /// a list of predefined domains and types within each domain. For each unique dataset
        /// domain and type within the domain, Amazon Forecast requires your data to include a
        /// minimum set of predefined fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Schema</code> </i> - A schema specifies the fields of the dataset, including
        /// the field name and data type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After creating a dataset, you import your training data into the dataset and add the
        /// dataset to a dataset group. You then use the dataset group to create a predictor.
        /// For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets, use the <a>ListDatasets</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
        /// training data. Use the <a>DescribeDataset</a> operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatasetGroup

        internal virtual CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Forecast dataset group, which holds a collection of related datasets.
        /// You can add datasets to the dataset group when you create the dataset group, or you
        /// can add datasets later with the <a>UpdateDatasetGroup</a> operation.
        /// 
        ///  
        /// <para>
        /// After creating a dataset group and adding datasets, you use the dataset group when
        /// you create a predictor. For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets groups, use the <a>ListDatasetGroups</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
        /// can create a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        public virtual Task<CreateDatasetGroupResponse> CreateDatasetGroupAsync(CreateDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatasetImportJob

        internal virtual CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Imports your training data to an Amazon Forecast dataset. You provide the location
        /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
        /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataSource</a> object that includes an AWS Identity and Access
        /// Management (IAM) role that Amazon Forecast can assume to access the data. For more
        /// information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// Two properties of the training data are optionally specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The delimiter that separates the data fields.
        /// </para>
        ///  
        /// <para>
        /// The default delimiter is a comma (,), which is the only supported delimiter in this
        /// release.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The format of timestamps.
        /// </para>
        ///  
        /// <para>
        /// If the format is not specified, Amazon Forecast expects the format to be "yyyy-MM-dd
        /// HH:mm:ss".
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When Amazon Forecast uploads your training data, it verifies that the data was collected
        /// at the <code>DataFrequency</code> specified when the target dataset was created. For
        /// more information, see <a>CreateDataset</a> and <a>howitworks-datasets-groups</a>.
        /// Amazon Forecast also verifies the delimiter and timestamp format.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>ListDatasetImportJobs</a> operation to get a list of all your dataset
        /// import jobs, filtered by specified criteria.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your dataset import jobs, filtered by the specified criteria,
        /// use the <a>ListDatasetGroups</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        public virtual Task<CreateDatasetImportJobResponse> CreateDatasetImportJobAsync(CreateDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateForecast

        internal virtual CreateForecastResponse CreateForecast(CreateForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastResponseUnmarshaller.Instance;

            return Invoke<CreateForecastResponse>(request, options);
        }



        /// <summary>
        /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
        /// was used to train the predictor. This is known as inference. To retrieve the forecast
        /// for a single item at low latency, use the operation. To export the complete forecast
        /// into your Amazon Simple Storage Service (Amazon S3), use the <a>CreateForecastExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// The range of the forecast is determined by the <code>ForecastHorizon</code>, specified
        /// in the <a>CreatePredictor</a> request, multiplied by the <code>DataFrequency</code>,
        /// specified in the <a>CreateDataset</a> request. When you query a forecast, you can
        /// request a specific date range within the complete forecast.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
        /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
        /// status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        public virtual Task<CreateForecastResponse> CreateForecastAsync(CreateForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastResponseUnmarshaller.Instance;

            return InvokeAsync<CreateForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateForecastExportJob

        internal virtual CreateForecastExportJobResponse CreateForecastExportJob(CreateForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateForecastExportJobResponse>(request, options);
        }



        /// <summary>
        /// Exports a forecast created by the <a>CreateForecast</a> operation to your Amazon Simple
        /// Storage Service (Amazon S3) bucket.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an AWS Identity and
        /// Access Management (IAM) role that Amazon Forecast can assume to access the Amazon
        /// S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecast export jobs, use the <a>ListForecastExportJobs</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. Use the <a>DescribeForecastExportJob</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        public virtual Task<CreateForecastExportJobResponse> CreateForecastExportJobAsync(CreateForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateForecastExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateForecastExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePredictor

        internal virtual CreatePredictorResponse CreatePredictor(CreatePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorResponseUnmarshaller.Instance;

            return Invoke<CreatePredictorResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Forecast predictor.
        /// 
        ///  
        /// <para>
        /// In the request, you provide a dataset group and either specify an algorithm or let
        /// Amazon Forecast choose the algorithm for you using AutoML. If you specify an algorithm,
        /// you also can override algorithm-specific hyperparameters.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast uses the chosen algorithm to train a model using the latest version
        /// of the datasets in the specified dataset group. The result is called a predictor.
        /// You then generate a forecast using the <a>CreateForecast</a> operation.
        /// </para>
        ///  
        /// <para>
        /// After training a model, the <code>CreatePredictor</code> operation also evaluates
        /// it. To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. Always
        /// review the evaluation metrics before deciding to use the predictor to generate a forecast.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can specify a featurization configuration to fill and aggragate the
        /// data fields in the <code>TARGET_TIME_SERIES</code> dataset to improve model training.
        /// For more information, see <a>FeaturizationConfig</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>AutoML</b> 
        /// </para>
        ///  
        /// <para>
        /// If you set <code>PerformAutoML</code> to <code>true</code>, Amazon Forecast evaluates
        /// each algorithm and chooses the one that minimizes the <code>objective function</code>.
        /// The <code>objective function</code> is defined as the mean of the weighted p10, p50,
        /// and p90 quantile losses. For more information, see <a>EvaluationResult</a>.
        /// </para>
        ///  
        /// <para>
        /// When AutoML is enabled, the following properties are disallowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HPOConfig</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformHPO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrainingParameters</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of all your predictors, use the <a>ListPredictors</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the predictor must be <code>ACTIVE</code>, signifying that
        /// training has completed, before you can use the predictor to create a forecast. Use
        /// the <a>DescribePredictor</a> operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        public virtual Task<CreatePredictorResponse> CreatePredictorAsync(CreatePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePredictorResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePredictorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Forecast dataset created using the <a>CreateDataset</a> operation.
        /// To be deleted, the dataset must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeDataset</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatasetGroup

        internal virtual DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset group created using the <a>CreateDatasetGroup</a> operation. To
        /// be deleted, the dataset group must have a status of <code>ACTIVE</code>, <code>CREATE_FAILED</code>,
        /// or <code>UPDATE_FAILED</code>. Use the <a>DescribeDatasetGroup</a> operation to get
        /// the status.
        /// 
        ///  
        /// <para>
        /// The operation deletes only the dataset group, not the datasets in the group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        public virtual Task<DeleteDatasetGroupResponse> DeleteDatasetGroupAsync(DeleteDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatasetImportJob

        internal virtual DeleteDatasetImportJobResponse DeleteDatasetImportJob(DeleteDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset import job created using the <a>CreateDatasetImportJob</a> operation.
        /// To be deleted, the import job must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeDatasetImportJob</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        public virtual Task<DeleteDatasetImportJobResponse> DeleteDatasetImportJobAsync(DeleteDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteForecast

        internal virtual DeleteForecastResponse DeleteForecast(DeleteForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastResponseUnmarshaller.Instance;

            return Invoke<DeleteForecastResponse>(request, options);
        }



        /// <summary>
        /// Deletes a forecast created using the <a>CreateForecast</a> operation. To be deleted,
        /// the forecast must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeForecast</a> operation to get the status.
        /// 
        ///  
        /// <para>
        /// You can't delete a forecast while it is being exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        public virtual Task<DeleteForecastResponse> DeleteForecastAsync(DeleteForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteForecastExportJob

        internal virtual DeleteForecastExportJobResponse DeleteForecastExportJob(DeleteForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<DeleteForecastExportJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// To be deleted, the export job must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeForecastExportJob</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        public virtual Task<DeleteForecastExportJobResponse> DeleteForecastExportJobAsync(DeleteForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteForecastExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteForecastExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePredictor

        internal virtual DeletePredictorResponse DeletePredictor(DeletePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorResponseUnmarshaller.Instance;

            return Invoke<DeletePredictorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a predictor created using the <a>CreatePredictor</a> operation. To be deleted,
        /// the predictor must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribePredictor</a> operation to get the status.
        /// 
        ///  
        /// <para>
        /// Any forecasts generated by the predictor will no longer be available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        public virtual Task<DeletePredictorResponse> DeletePredictorAsync(DeletePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePredictorResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePredictorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Describes an Amazon Forecast dataset created using the <a>CreateDataset</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDataset</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDatasetGroup

        internal virtual DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Describes a dataset group created using the <a>CreateDatasetGroup</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDatasetGroup</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetArns</code> - The datasets belonging to the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        public virtual Task<DescribeDatasetGroupResponse> DescribeDatasetGroupAsync(DescribeDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDatasetImportJob

        internal virtual DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetImportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes a dataset import job created using the <a>CreateDatasetImportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDatasetImportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldStatistics</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        public virtual Task<DescribeDatasetImportJobResponse> DescribeDatasetImportJobAsync(DescribeDatasetImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetImportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeForecast

        internal virtual DescribeForecastResponse DescribeForecast(DescribeForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastResponseUnmarshaller.Instance;

            return Invoke<DescribeForecastResponse>(request, options);
        }



        /// <summary>
        /// Describes a forecast created using the <a>CreateForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecast</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The dataset group that provided the training data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        public virtual Task<DescribeForecastResponse> DescribeForecastAsync(DescribeForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeForecastExportJob

        internal virtual DescribeForecastExportJobResponse DescribeForecastExportJob(DescribeForecastExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeForecastExportJobResponse>(request, options);
        }



        /// <summary>
        /// Describes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecastExportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        public virtual Task<DescribeForecastExportJobResponse> DescribeForecastExportJobAsync(DescribeForecastExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeForecastExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeForecastExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeForecastExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePredictor

        internal virtual DescribePredictorResponse DescribePredictor(DescribePredictorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorResponseUnmarshaller.Instance;

            return Invoke<DescribePredictorResponse>(request, options);
        }



        /// <summary>
        /// Describes a predictor created using the <a>CreatePredictor</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreatePredictor</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetImportJobArns</code> - The dataset import jobs used to import training
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutoMLAlgorithmArns</code> - If AutoML is performed, the algorithms evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        public virtual Task<DescribePredictorResponse> DescribePredictorAsync(DescribePredictorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePredictorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePredictorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePredictorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccuracyMetrics

        internal virtual GetAccuracyMetricsResponse GetAccuracyMetrics(GetAccuracyMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccuracyMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccuracyMetricsResponseUnmarshaller.Instance;

            return Invoke<GetAccuracyMetricsResponse>(request, options);
        }



        /// <summary>
        /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
        /// operation. Use metrics to see how well the model performed and to decide whether to
        /// use the predictor to generate a forecast.
        /// 
        ///  
        /// <para>
        /// Metrics are generated for each backtest window evaluated. For more information, see
        /// <a>EvaluationParameters</a>.
        /// </para>
        ///  
        /// <para>
        /// The parameters of the <code>filling</code> method determine which items contribute
        /// to the metrics. If <code>zero</code> is specified, all items contribute. If <code>nan</code>
        /// is specified, only those items that have complete data in the range being evaluated
        /// contribute. For more information, see <a>FeaturizationMethod</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to train a model and review metrics, see <a>getting-started</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccuracyMetrics service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        public virtual Task<GetAccuracyMetricsResponse> GetAccuracyMetricsAsync(GetAccuracyMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccuracyMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccuracyMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccuracyMetricsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasetGroups

        internal virtual ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of dataset groups created using the <a>CreateDatasetGroup</a> operation.
        /// For each dataset group, a summary of its properties, including its Amazon Resource
        /// Name (ARN), is returned. You can retrieve the complete set of properties by using
        /// the ARN with the <a>DescribeDatasetGroup</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        public virtual Task<ListDatasetGroupsResponse> ListDatasetGroupsAsync(ListDatasetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasetImportJobs

        internal virtual ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of dataset import jobs created using the <a>CreateDatasetImportJob</a>
        /// operation. For each import job, a summary of its properties, including its Amazon
        /// Resource Name (ARN), is returned. You can retrieve the complete set of properties
        /// by using the ARN with the <a>DescribeDatasetImportJob</a> operation. You can filter
        /// the list by providing an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        public virtual Task<ListDatasetImportJobsResponse> ListDatasetImportJobsAsync(ListDatasetImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetImportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of datasets created using the <a>CreateDataset</a> operation. For each
        /// dataset, a summary of its properties, including its Amazon Resource Name (ARN), is
        /// returned. You can retrieve the complete set of properties by using the ARN with the
        /// <a>DescribeDataset</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListForecastExportJobs

        internal virtual ListForecastExportJobsResponse ListForecastExportJobs(ListForecastExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListForecastExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of forecast export jobs created using the <a>CreateForecastExportJob</a>
        /// operation. For each forecast export job, a summary of its properties, including its
        /// Amazon Resource Name (ARN), is returned. You can retrieve the complete set of properties
        /// by using the ARN with the <a>DescribeForecastExportJob</a> operation. The list can
        /// be filtered using an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListForecastExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        public virtual Task<ListForecastExportJobsResponse> ListForecastExportJobsAsync(ListForecastExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListForecastExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListForecasts

        internal virtual ListForecastsResponse ListForecasts(ListForecastsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastsResponseUnmarshaller.Instance;

            return Invoke<ListForecastsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of forecasts created using the <a>CreateForecast</a> operation. For
        /// each forecast, a summary of its properties, including its Amazon Resource Name (ARN),
        /// is returned. You can retrieve the complete set of properties by using the ARN with
        /// the <a>DescribeForecast</a> operation. The list can be filtered using an array of
        /// <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        public virtual Task<ListForecastsResponse> ListForecastsAsync(ListForecastsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListForecastsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListForecastsResponseUnmarshaller.Instance;

            return InvokeAsync<ListForecastsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPredictors

        internal virtual ListPredictorsResponse ListPredictors(ListPredictorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorsResponseUnmarshaller.Instance;

            return Invoke<ListPredictorsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of predictors created using the <a>CreatePredictor</a> operation. For
        /// each predictor, a summary of its properties, including its Amazon Resource Name (ARN),
        /// is returned. You can retrieve the complete set of properties by using the ARN with
        /// the <a>DescribePredictor</a> operation. The list can be filtered using an array of
        /// <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPredictors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        public virtual Task<ListPredictorsResponse> ListPredictorsAsync(ListPredictorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPredictorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPredictorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPredictorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatasetGroup

        internal virtual UpdateDatasetGroupResponse UpdateDatasetGroup(UpdateDatasetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetGroupResponse>(request, options);
        }



        /// <summary>
        /// Replaces any existing datasets in the dataset group with the specified datasets.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the dataset group must be <code>ACTIVE</code> before creating
        /// a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a> operation
        /// to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        public virtual Task<UpdateDatasetGroupResponse> UpdateDatasetGroupAsync(UpdateDatasetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}