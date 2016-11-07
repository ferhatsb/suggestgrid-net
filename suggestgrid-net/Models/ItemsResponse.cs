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
    public class ItemsResponse : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private long? count;
        private List<Metadata<string,object>> items;

        /// <summary>
        /// The number of items in the response.
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
        [JsonProperty("items")]
        public List<Metadata<string,object>> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
                onPropertyChanged("Items");
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
