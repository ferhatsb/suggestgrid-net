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
using SuggestGrid;

namespace SuggestGrid.Models
{
    public class DeleteSuccessResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string message;
        private int? found;
        private int? deleted;
        private int? failed;

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
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// The number of records found for the delete query.
        /// </summary>
        [JsonProperty("found")]
        public int? Found 
        { 
            get 
            {
                return this.found; 
            } 
            set 
            {
                this.found = value;
                onPropertyChanged("Found");
            }
        }

        /// <summary>
        /// The number of records deleted for the delete query.
        /// </summary>
        [JsonProperty("deleted")]
        public int? Deleted 
        { 
            get 
            {
                return this.deleted; 
            } 
            set 
            {
                this.deleted = value;
                onPropertyChanged("Deleted");
            }
        }

        /// <summary>
        /// The number of records found but not deleted for the delete query.
        /// </summary>
        [JsonProperty("failed")]
        public int? Failed 
        { 
            get 
            {
                return this.failed; 
            } 
            set 
            {
                this.failed = value;
                onPropertyChanged("Failed");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 