/*
 * SuggestGrid.PCL
 *
 * This file was automatically generated for SuggestGrid by APIMATIC v2.0 ( https://apimatic.io ) on 10/24/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuggestGrid;
using SuggestGrid.Http.Request;
using SuggestGrid.Http.Response;
using SuggestGrid.Http.Client;
using SuggestGrid.Exceptions;
using SuggestGrid.Models;

namespace SuggestGrid.Controllers
{
    public partial class SimilarityController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SimilarityController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SimilarityController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SimilarityController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get Similar Users
        /// </summary>
        /// <param name="query">Required parameter: The query for similar users.</param>
        /// <return>Returns the UsersResponse response from the API call</return>
        public UsersResponse GetSimilarUsers(GetSimilarUsersBody query)
        {
            Task<UsersResponse> t = GetSimilarUsersAsync(query);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get Similar Users
        /// </summary>
        /// <param name="query">Required parameter: The query for similar users.</param>
        /// <return>Returns the UsersResponse response from the API call</return>
        public async Task<UsersResponse> GetSimilarUsersAsync(GetSimilarUsersBody query)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/similar/users");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "SUGGESTGRID" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(query);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Request body is invalid.", _context);

            else if (_response.StatusCode == 422)
                throw new ErrorResponseException(@"Required parameters are missing.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<UsersResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get Similar Items
        /// </summary>
        /// <param name="query">Required parameter: The query for similar items.</param>
        /// <return>Returns the ItemsResponse response from the API call</return>
        public ItemsResponse GetSimilarItems(GetSimilarItemsBody query)
        {
            Task<ItemsResponse> t = GetSimilarItemsAsync(query);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get Similar Items
        /// </summary>
        /// <param name="query">Required parameter: The query for similar items.</param>
        /// <return>Returns the ItemsResponse response from the API call</return>
        public async Task<ItemsResponse> GetSimilarItemsAsync(GetSimilarItemsBody query)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/similar/items");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "SUGGESTGRID" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(query);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Request body is invalid.", _context);

            else if (_response.StatusCode == 422)
                throw new ErrorResponseException(@"Required parameters are missing.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<ItemsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 