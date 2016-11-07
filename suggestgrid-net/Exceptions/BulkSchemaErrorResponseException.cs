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
    public class BulkSchemaErrorResponseException : APIException 
    {
        // These fields hold the values for the public properties.
        private string message;
        private List<SchemaErrorResponse> errors;

        /// <summary>
        /// Message of the response.
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("errors")]
        public List<SchemaErrorResponse> Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public BulkSchemaErrorResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 