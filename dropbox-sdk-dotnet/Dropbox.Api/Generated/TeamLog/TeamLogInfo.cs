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
    /// <para>Team's logged information.</para>
    /// </summary>
    public class TeamLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamLogInfo> Encoder = new TeamLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamLogInfo> Decoder = new TeamLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamLogInfo" /> class.</para>
        /// </summary>
        /// <param name="displayName">Team display name.</param>
        public TeamLogInfo(string displayName)
        {
            if (displayName == null)
            {
                throw new sys.ArgumentNullException("displayName");
            }

            this.DisplayName = displayName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TeamLogInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamLogInfo()
        {
        }

        /// <summary>
        /// <para>Team display name.</para>
        /// </summary>
        public string DisplayName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamLogInfo" />.</para>
        /// </summary>
        private class TeamLogInfoEncoder : enc.StructEncoder<TeamLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamLogInfo" />.</para>
        /// </summary>
        private class TeamLogInfoDecoder : enc.StructDecoder<TeamLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TeamLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamLogInfo Create()
            {
                return new TeamLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
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
