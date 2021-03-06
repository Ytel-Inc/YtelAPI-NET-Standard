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
    public class Body48 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? page;
        private int? pagesize;
        private string datecreated;
        private string callsid;

        /// <summary>
        /// The page count to retrieve from the total results in the collection. Page indexing starts at 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page 
        { 
            get 
            {
                return this.page; 
            } 
            set 
            {
                this.page = value;
                onPropertyChanged("Page");
            }
        }

        /// <summary>
        /// The count of objects to return per page.
        /// </summary>
        [JsonProperty("pagesize")]
        public int? Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }

        /// <summary>
        /// Filter results by creation date
        /// </summary>
        [JsonProperty("Datecreated")]
        public string Datecreated 
        { 
            get 
            {
                return this.datecreated; 
            } 
            set 
            {
                this.datecreated = value;
                onPropertyChanged("Datecreated");
            }
        }

        /// <summary>
        /// The unique identifier for a call.
        /// </summary>
        [JsonProperty("callsid")]
        public string Callsid 
        { 
            get 
            {
                return this.callsid; 
            } 
            set 
            {
                this.callsid = value;
                onPropertyChanged("Callsid");
            }
        }
    }
} 