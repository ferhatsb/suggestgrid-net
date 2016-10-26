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
    public class UsersResponse : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private long? count;
        private List<Metadata<string,object>> users;

        /// <summary>
        /// The number of users in the response.
        /// </summary>
        [JsonProperty("count")]
        public long? Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
                onPropertyChanged("Count");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("users")]
        public List<Metadata<string,object>> Users
        {
            get
            {
                return this.users;
            }
            set
            {
                this.users = value;
                onPropertyChanged("Users");
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
