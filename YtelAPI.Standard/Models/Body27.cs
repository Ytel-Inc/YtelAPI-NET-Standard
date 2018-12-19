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
    public class Body27 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private string playDtmf;
        private Models.PlayDtmfDirectionEnum? playDtmfDirection;

        /// <summary>
        /// The unique identifier of each call resource
        /// </summary>
        [JsonProperty("CallSid")]
        public string CallSid 
        { 
            get 
            {
                return this.callSid; 
            } 
            set 
            {
                this.callSid = value;
                onPropertyChanged("CallSid");
            }
        }

        /// <summary>
        /// DTMF digits to play to the call. 0-9, #, *, W, or w
        /// </summary>
        [JsonProperty("PlayDtmf")]
        public string PlayDtmf 
        { 
            get 
            {
                return this.playDtmf; 
            } 
            set 
            {
                this.playDtmf = value;
                onPropertyChanged("PlayDtmf");
            }
        }

        /// <summary>
        /// The leg of the call DTMF digits should be sent to
        /// </summary>
        [JsonProperty("PlayDtmfDirection", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.PlayDtmfDirectionEnum? PlayDtmfDirection 
        { 
            get 
            {
                return this.playDtmfDirection; 
            } 
            set 
            {
                this.playDtmfDirection = value;
                onPropertyChanged("PlayDtmfDirection");
            }
        }
    }
} 