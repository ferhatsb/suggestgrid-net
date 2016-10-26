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
using Newtonsoft.Json;

namespace SuggestGrid.Controllers
{
    public partial class ActionController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ActionController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ActionController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ActionController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get Actions
        /// </summary>
        /// <param name="type">Optional parameter: The type of the actions.</param>
        /// <param name="userId">Optional parameter: The user id of the actions.</param>
        /// <param name="itemId">Optional parameter: The item id of the actions.</param>
        /// <param name="olderThan">Optional parameter: Delete all actions of a type older than the given timestamp or time. Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195).</param>
        /// <return>Returns the CountResponse response from the API call</return>
        public CountResponse GetActions(
                string type = null,
                string userId = null,
                string itemId = null,
                string olderThan = null)
        {
            Task<CountResponse> t = GetActionsAsync(type, userId, itemId, olderThan);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get Actions
        /// </summary>
        /// <param name="type">Optional parameter: The type of the actions.</param>
        /// <param name="userId">Optional parameter: The user id of the actions.</param>
        /// <param name="itemId">Optional parameter: The item id of the actions.</param>
        /// <param name="olderThan">Optional parameter: Delete all actions of a type older than the given timestamp or time. Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195).</param>
        /// <return>Returns the CountResponse response from the API call</return>
        public async Task<CountResponse> GetActionsAsync(
                string type = null,
                string userId = null,
                string itemId = null,
                string olderThan = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/actions");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "type", type },
                { "user_id", userId },
                { "item_id", itemId },
                { "older_than", olderThan }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "SUGGESTGRID" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Required `user_id` or `item_id` parameters are missing from the request body.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<CountResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Post an Action
        /// </summary>
        /// <param name="action">Required parameter: The action to be posted.</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        public MessageResponse PostAction(ActionModel action)
        {
            Task<MessageResponse> t = PostActionAsync(action);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Post an Action
        /// </summary>
        /// <param name="action">Required parameter: The action to be posted.</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        public async Task<MessageResponse> PostActionAsync(ActionModel action)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/actions");


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
            var _body = APIHelper.JsonSerialize(action);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Required `user_id` or `item_id` parameters are missing from the request body.", _context);

            else if (_response.StatusCode == 402)
                throw new ErrorResponseException(@"Action limit exceeded.", _context);

            else if (_response.StatusCode == 404)
                throw new ErrorResponseException(@"Type does not exists.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<MessageResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Delete Actions
        /// </summary>
        /// <param name="type">Optional parameter: The type of the actions.</param>
        /// <param name="userId">Optional parameter: The user id of the actions.</param>
        /// <param name="itemId">Optional parameter: The item id of the actions.</param>
        /// <param name="olderThan">Optional parameter: Delete all actions of a type older than the given timestamp or time. Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195).</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        public MessageResponse DeleteActions(
                string type = null,
                string userId = null,
                string itemId = null,
                string olderThan = null)
        {
            Task<MessageResponse> t = DeleteActionsAsync(type, userId, itemId, olderThan);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Delete Actions
        /// </summary>
        /// <param name="type">Optional parameter: The type of the actions.</param>
        /// <param name="userId">Optional parameter: The user id of the actions.</param>
        /// <param name="itemId">Optional parameter: The item id of the actions.</param>
        /// <param name="olderThan">Optional parameter: Delete all actions of a type older than the given timestamp or time. Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195).</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        public async Task<MessageResponse> DeleteActionsAsync(
                string type = null,
                string userId = null,
                string itemId = null,
                string olderThan = null)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/actions");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "type", type },
                { "user_id", userId },
                { "item_id", itemId },
                { "older_than", olderThan }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "SUGGESTGRID" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Required `user_id` or `item_id` parameters are missing from the request body.", _context);

            else if (_response.StatusCode == 404)
                throw new ErrorResponseException(@"Type does not exists.", _context);

            else if (_response.StatusCode == 422)
                throw new ErrorResponseException(@"No query parameter (`user_id`, `item_id`, or `older_than`) is given.  In order to delete all actionsdelete the type.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 505)
                throw new ErrorResponseException(@"Request timed out.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<MessageResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Post Bulk Actions
        /// </summary>
        /// <param name="actions">Required parameter: A number of action objects separated with newlines. Note that this is not a valid JSON data structure. The body size is limited to 10 thousand lines.</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        public MessageResponse PostBulkActions(List<ActionModel> actions)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ActionModel action in actions)
            {
                sb.Append(JsonConvert.SerializeObject(action, Formatting.None));
                sb.Append(Environment.NewLine);
            }
            Task<MessageResponse> t = PostBulkActionsAsync(sb.ToString());
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Post Bulk Actions
        /// </summary>
        /// <param name="actions">Required parameter: A number of action objects separated with newlines. Note that this is not a valid JSON data structure. The body size is limited to 10 thousand lines.</param>
        /// <return>Returns the MessageResponse response from the API call</return>
        private async Task<MessageResponse> PostBulkActionsAsync(string actions)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/actions/_bulk");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "SUGGESTGRID" },
                { "accept", "application/json" },
                { "content-type", "text/plain; charset=utf-8" }
            };

            //append body params
             var _body = actions;

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 209)
                throw new BulkSchemaErrorResponseException(@"Some metadata is not uploaded successfully.", _context);

            else if (_response.StatusCode == 400)
                throw new ErrorResponseException(@"Body is missing.", _context);

            else if (_response.StatusCode == 402)
                throw new ErrorResponseException(@"Action limit exceeded.", _context);

            else if (_response.StatusCode == 429)
                throw new ErrorResponseException(@"Too many requests.", _context);

            else if (_response.StatusCode == 500)
                throw new APIException(@"Unexpected internal error.", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<MessageResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
}
