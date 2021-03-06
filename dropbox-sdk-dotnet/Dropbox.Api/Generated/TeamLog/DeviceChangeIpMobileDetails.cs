// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed IP address associated with active mobile session.</para>
    /// </summary>
    public class DeviceChangeIpMobileDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeviceChangeIpMobileDetails> Encoder = new DeviceChangeIpMobileDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeviceChangeIpMobileDetails> Decoder = new DeviceChangeIpMobileDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceChangeIpMobileDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="deviceSessionInfo">Device's session logged information.</param>
        public DeviceChangeIpMobileDetails(DeviceSessionLogInfo deviceSessionInfo = null)
        {
            this.DeviceSessionInfo = deviceSessionInfo;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeviceChangeIpMobileDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DeviceChangeIpMobileDetails()
        {
        }

        /// <summary>
        /// <para>Device's session logged information.</para>
        /// </summary>
        public DeviceSessionLogInfo DeviceSessionInfo { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeviceChangeIpMobileDetails" />.</para>
        /// </summary>
        private class DeviceChangeIpMobileDetailsEncoder : enc.StructEncoder<DeviceChangeIpMobileDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeviceChangeIpMobileDetails value, enc.IJsonWriter writer)
            {
                if (value.DeviceSessionInfo != null)
                {
                    WriteProperty("device_session_info", value.DeviceSessionInfo, writer, global::Dropbox.Api.TeamLog.DeviceSessionLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeviceChangeIpMobileDetails" />.</para>
        /// </summary>
        private class DeviceChangeIpMobileDetailsDecoder : enc.StructDecoder<DeviceChangeIpMobileDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeviceChangeIpMobileDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeviceChangeIpMobileDetails Create()
            {
                return new DeviceChangeIpMobileDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeviceChangeIpMobileDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "device_session_info":
                        value.DeviceSessionInfo = global::Dropbox.Api.TeamLog.DeviceSessionLogInfo.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
