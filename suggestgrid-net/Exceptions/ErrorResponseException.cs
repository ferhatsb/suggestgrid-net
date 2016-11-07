/*
 * SuggestGrid.PCL
 *
 * This file was automatically generated for SuggestGrid by APIMATIC v2.0 ( https://apimatic.io ) on 10/24/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SuggestGrid.Http.Client;

using SuggestGrid.Models;
using SuggestGrid;

namespace SuggestGrid.Exceptions
{
    public class ErrorResponseException : APIException 
    {
        // These fields hold the values for the public properties.
        private string errorText;
        private string errorDescription;
        private string errorUri;

        /// <summary>
        /// Message of the response.
        /// </summary>
        [JsonProperty("error_text")]
        public string ErrorText 
        { 
            get 
            {
                return this.errorText; 
            } 
            private set 
            {
                this.errorText = value;
            }
        }

        /// <summary>
        /// Description of the response.
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription 
        { 
            get 
            {
                return this.errorDescription; 
            } 
            private set 
            {
                this.errorDescription = value;
            }
        }

        /// <summary>
        /// URI of the response for more details.
        /// </summary>
        [JsonProperty("error_uri")]
        public string ErrorUri 
        { 
            get 
            {
                return this.errorUri; 
            } 
            private set 
            {
                this.errorUri = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 