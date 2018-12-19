/*
 * YtelAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YtelAPI.Standard;
using YtelAPI.Standard.Utilities;

namespace YtelAPI.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum GroupConfirmFileEnum
    {
        MP3, //TODO: Write general description for this method
        WAV, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type GroupConfirmFileEnum
    /// </summary>
    public static class GroupConfirmFileEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "mp3", "wav" };

        /// <summary>
        /// Converts a GroupConfirmFileEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The GroupConfirmFileEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(GroupConfirmFileEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case GroupConfirmFileEnum.MP3:
                case GroupConfirmFileEnum.WAV:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of GroupConfirmFileEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of GroupConfirmFileEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<GroupConfirmFileEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into GroupConfirmFileEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed GroupConfirmFileEnum value</returns>
        public static GroupConfirmFileEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type GroupConfirmFileEnum", value));

            return (GroupConfirmFileEnum) index;
        }
    }
} 