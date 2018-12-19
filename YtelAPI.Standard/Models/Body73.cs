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
    public class Body73 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.NumberType2Enum numberType;
        private string areaCode;
        private string quantity;
        private string leftover;

        /// <summary>
        /// The capability the number supports.
        /// </summary>
        [JsonProperty("NumberType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.NumberType2Enum NumberType 
        { 
            get 
            {
                return this.numberType; 
            } 
            set 
            {
                this.numberType = value;
                onPropertyChanged("NumberType");
            }
        }

        /// <summary>
        /// Specifies the area code for the returned list of available numbers. Only available for North American numbers.
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode 
        { 
            get 
            {
                return this.areaCode; 
            } 
            set 
            {
                this.areaCode = value;
                onPropertyChanged("AreaCode");
            }
        }

        /// <summary>
        /// A positive integer that tells how many number you want to buy at a time.
        /// </summary>
        [JsonProperty("Quantity")]
        public string Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// If desired quantity is unavailable purchase what is available .
        /// </summary>
        [JsonProperty("Leftover")]
        public string Leftover 
        { 
            get 
            {
                return this.leftover; 
            } 
            set 
            {
                this.leftover = value;
                onPropertyChanged("Leftover");
            }
        }
    }
} 