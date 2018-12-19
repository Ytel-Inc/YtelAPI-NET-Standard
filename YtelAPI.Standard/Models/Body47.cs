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
    public class Body47 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string phoneNumber;
        private string voiceUrl;
        private string friendlyName;
        private string voiceMethod;
        private string voiceFallbackUrl;
        private string voiceFallbackMethod;
        private string hangupCallback;
        private string hangupCallbackMethod;
        private string heartbeatUrl;
        private string heartbeatMethod;
        private string smsUrl;
        private string smsMethod;
        private string smsFallbackUrl;
        private string smsFallbackMethod;

        /// <summary>
        /// A valid Ytel number (E.164 format).
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber; 
            } 
            set 
            {
                this.phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// URL requested once the call connects
        /// </summary>
        [JsonProperty("VoiceUrl")]
        public string VoiceUrl 
        { 
            get 
            {
                return this.voiceUrl; 
            } 
            set 
            {
                this.voiceUrl = value;
                onPropertyChanged("VoiceUrl");
            }
        }

        /// <summary>
        /// Phone number friendly name description
        /// </summary>
        [JsonProperty("FriendlyName")]
        public string FriendlyName 
        { 
            get 
            {
                return this.friendlyName; 
            } 
            set 
            {
                this.friendlyName = value;
                onPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("VoiceMethod")]
        public string VoiceMethod 
        { 
            get 
            {
                return this.voiceMethod; 
            } 
            set 
            {
                this.voiceMethod = value;
                onPropertyChanged("VoiceMethod");
            }
        }

        /// <summary>
        /// URL requested if the voice URL is not available
        /// </summary>
        [JsonProperty("VoiceFallbackUrl")]
        public string VoiceFallbackUrl 
        { 
            get 
            {
                return this.voiceFallbackUrl; 
            } 
            set 
            {
                this.voiceFallbackUrl = value;
                onPropertyChanged("VoiceFallbackUrl");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("VoiceFallbackMethod")]
        public string VoiceFallbackMethod 
        { 
            get 
            {
                return this.voiceFallbackMethod; 
            } 
            set 
            {
                this.voiceFallbackMethod = value;
                onPropertyChanged("VoiceFallbackMethod");
            }
        }

        /// <summary>
        /// callback url after a hangup occurs
        /// </summary>
        [JsonProperty("HangupCallback")]
        public string HangupCallback 
        { 
            get 
            {
                return this.hangupCallback; 
            } 
            set 
            {
                this.hangupCallback = value;
                onPropertyChanged("HangupCallback");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("HangupCallbackMethod")]
        public string HangupCallbackMethod 
        { 
            get 
            {
                return this.hangupCallbackMethod; 
            } 
            set 
            {
                this.hangupCallbackMethod = value;
                onPropertyChanged("HangupCallbackMethod");
            }
        }

        /// <summary>
        /// URL requested once the call connects
        /// </summary>
        [JsonProperty("HeartbeatUrl")]
        public string HeartbeatUrl 
        { 
            get 
            {
                return this.heartbeatUrl; 
            } 
            set 
            {
                this.heartbeatUrl = value;
                onPropertyChanged("HeartbeatUrl");
            }
        }

        /// <summary>
        /// URL that can be requested every 60 seconds during the call to notify of elapsed time
        /// </summary>
        [JsonProperty("HeartbeatMethod")]
        public string HeartbeatMethod 
        { 
            get 
            {
                return this.heartbeatMethod; 
            } 
            set 
            {
                this.heartbeatMethod = value;
                onPropertyChanged("HeartbeatMethod");
            }
        }

        /// <summary>
        /// URL requested when an SMS is received
        /// </summary>
        [JsonProperty("SmsUrl")]
        public string SmsUrl 
        { 
            get 
            {
                return this.smsUrl; 
            } 
            set 
            {
                this.smsUrl = value;
                onPropertyChanged("SmsUrl");
            }
        }

        /// <summary>
        /// Post or Get
        /// </summary>
        [JsonProperty("SmsMethod")]
        public string SmsMethod 
        { 
            get 
            {
                return this.smsMethod; 
            } 
            set 
            {
                this.smsMethod = value;
                onPropertyChanged("SmsMethod");
            }
        }

        /// <summary>
        /// URL used if any errors occur during execution of InboundXML from an SMS or at initial request of the SmsUrl.
        /// </summary>
        [JsonProperty("SmsFallbackUrl")]
        public string SmsFallbackUrl 
        { 
            get 
            {
                return this.smsFallbackUrl; 
            } 
            set 
            {
                this.smsFallbackUrl = value;
                onPropertyChanged("SmsFallbackUrl");
            }
        }

        /// <summary>
        /// The HTTP method Ytel will use when URL requested if the SmsUrl is not available.
        /// </summary>
        [JsonProperty("SmsFallbackMethod")]
        public string SmsFallbackMethod 
        { 
            get 
            {
                return this.smsFallbackMethod; 
            } 
            set 
            {
                this.smsFallbackMethod = value;
                onPropertyChanged("SmsFallbackMethod");
            }
        }
    }
} 