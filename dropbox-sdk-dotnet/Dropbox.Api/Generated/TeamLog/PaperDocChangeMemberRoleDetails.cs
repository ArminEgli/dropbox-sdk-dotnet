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
    /// <para>Changed member permissions for Paper doc.</para>
    /// </summary>
    public class PaperDocChangeMemberRoleDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperDocChangeMemberRoleDetails> Encoder = new PaperDocChangeMemberRoleDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperDocChangeMemberRoleDetails> Decoder = new PaperDocChangeMemberRoleDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocChangeMemberRoleDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        /// <param name="accessType">Paper doc access type.</param>
        public PaperDocChangeMemberRoleDetails(string eventUuid,
                                               PaperAccessType accessType)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            if (accessType == null)
            {
                throw new sys.ArgumentNullException("accessType");
            }

            this.EventUuid = eventUuid;
            this.AccessType = accessType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperDocChangeMemberRoleDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperDocChangeMemberRoleDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        /// <summary>
        /// <para>Paper doc access type.</para>
        /// </summary>
        public PaperAccessType AccessType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperDocChangeMemberRoleDetails" />.</para>
        /// </summary>
        private class PaperDocChangeMemberRoleDetailsEncoder : enc.StructEncoder<PaperDocChangeMemberRoleDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperDocChangeMemberRoleDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
                WriteProperty("access_type", value.AccessType, writer, global::Dropbox.Api.TeamLog.PaperAccessType.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperDocChangeMemberRoleDetails" />.</para>
        /// </summary>
        private class PaperDocChangeMemberRoleDetailsDecoder : enc.StructDecoder<PaperDocChangeMemberRoleDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperDocChangeMemberRoleDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperDocChangeMemberRoleDetails Create()
            {
                return new PaperDocChangeMemberRoleDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperDocChangeMemberRoleDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "access_type":
                        value.AccessType = global::Dropbox.Api.TeamLog.PaperAccessType.Decoder.Decode(reader);
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
