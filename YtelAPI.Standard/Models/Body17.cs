/*
 * YtelAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities;


namespace YtelAPI.Standard.Models
{
    public class Body17 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string email;

        /// <summary>
        /// A valid email address that is to be remove from the spam list.
        /// </summary>
        [JsonProperty("Email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }
    }
} 