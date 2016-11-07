/*
 * SuggestGrid.PCL
 *
 * This file was automatically generated for SuggestGrid by APIMATIC v2.0 ( https://apimatic.io ) on 10/24/2016
 */
using System;
using SuggestGrid.Controllers;
using SuggestGrid.Http.Client;

namespace SuggestGrid
{
    public partial class SuggestGridClient
    {

        /// <summary>
        /// Singleton access to Type controller
        /// </summary>
        public TypeController Type
        {
            get
            {
                return SuggestGrid.Controllers.TypeController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Action controller
        /// </summary>
        public ActionController Action
        {
            get
            {
                return SuggestGrid.Controllers.ActionController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Metadata controller
        /// </summary>
        public MetadataController Metadata
        {
            get
            {
                return SuggestGrid.Controllers.MetadataController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Recommendation controller
        /// </summary>
        public RecommendationController Recommendation
        {
            get
            {
                return SuggestGrid.Controllers.RecommendationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Similarity controller
        /// </summary>
        public SimilarityController Similarity
        {
            get
            {
                return SuggestGrid.Controllers.SimilarityController.Instance;
            }
        }

        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public SuggestGridClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public SuggestGridClient(String uri)
        {
            var url = new Uri(uri);
            String baseUri = url.Scheme + "://" + url.Host + ":" + url.Port;

            if (url.AbsolutePath != "/") {
                baseUri += url.AbsolutePath;
            }

            Configuration.BaseUri = baseUri;

            string userInfo = url.UserInfo;

            if (!String.IsNullOrEmpty(userInfo)) {
                string[] userInfoA = userInfo.Split (':');
                Configuration.BasicAuthUserName = userInfoA[0];
                Configuration.BasicAuthPassword = userInfoA[1];
            }
        }
    }
}
