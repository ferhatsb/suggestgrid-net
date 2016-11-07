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
    public class TypeRequestBody : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string rating;

        /// <summary>
        /// The rating type of the type to be created.
        /// Could be "explicit" or "implicit"
        /// The default is "implicit".
        /// </summary>
        [JsonProperty("rating")]
        public string Rating 
        { 
            get 
            {
                return this.rating; 
            } 
            set 
            {
                this.rating = value;
                onPropertyChanged("Rating");
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