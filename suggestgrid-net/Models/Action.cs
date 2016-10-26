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
    public class ActionModel : INotifyPropertyChanged
    {
        // These fields hold the values for the public properties.
        private string type;
        private string userId;
        private string itemId;
        private double? rating;

        /// <summary>
        /// The type that the action belongs to.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The user id of the performer of the action.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId
        {
            get
            {
                return this.userId;
            }
            set
            {
                this.userId = value;
                onPropertyChanged("UserId");
            }
        }

        /// <summary>
        /// The item id of the item the action is performed on.
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId
        {
            get
            {
                return this.itemId;
            }
            set
            {
                this.itemId = value;
                onPropertyChanged("ItemId");
            }
        }

        /// <summary>
        /// The optional rating given by the user, if the type is explicit.
        /// </summary>
        [JsonProperty("rating")]
        public double? Rating
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
