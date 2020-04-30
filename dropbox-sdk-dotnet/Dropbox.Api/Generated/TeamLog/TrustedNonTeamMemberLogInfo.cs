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
    /// <para>User that is not a member of the team but considered trusted.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.TeamLog.UserLogInfo" />
    public class TrustedNonTeamMemberLogInfo : UserLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TrustedNonTeamMemberLogInfo> Encoder = new TrustedNonTeamMemberLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TrustedNonTeamMemberLogInfo> Decoder = new TrustedNonTeamMemberLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TrustedNonTeamMemberLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="trustedNonTeamMemberType">Indicates the type of the member of a
        /// trusted team.</param>
        /// <param name="accountId">User unique ID. Might be missing due to historical data
        /// gap.</param>
        /// <param name="displayName">User display name. Might be missing due to historical
        /// data gap.</param>
        /// <param name="email">User email address. Might be missing due to historical data
        /// gap.</param>
        /// <param name="team">Details about this useru2019s trusted team.</param>
        public TrustedNonTeamMemberLogInfo(TrustedNonTeamMemberType trustedNonTeamMemberType,
                                           string accountId = null,
                                           string displayName = null,
                                           string email = null,
                                           TeamLogInfo team = null)
            : base(accountId, displayName, email)
        {
            if (trustedNonTeamMemberType == null)
            {
                throw new sys.ArgumentNullException("trustedNonTeamMemberType");
            }

            this.TrustedNonTeamMemberType = trustedNonTeamMemberType;
            this.Team = team;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TrustedNonTeamMemberLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TrustedNonTeamMemberLogInfo()
        {
        }

        /// <summary>
        /// <para>Indicates the type of the member of a trusted team.</para>
        /// </summary>
        public TrustedNonTeamMemberType TrustedNonTeamMemberType { get; protected set; }

        /// <summary>
        /// <para>Details about this useru2019s trusted team.</para>
        /// </summary>
        public TeamLogInfo Team { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TrustedNonTeamMemberLogInfo" />.</para>
        /// </summary>
        private class TrustedNonTeamMemberLogInfoEncoder : enc.StructEncoder<TrustedNonTeamMemberLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TrustedNonTeamMemberLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("trusted_non_team_member_type", value.TrustedNonTeamMemberType, writer, global::Dropbox.Api.TeamLog.TrustedNonTeamMemberType.Encoder);
                if (value.AccountId != null)
                {
                    WriteProperty("account_id", value.AccountId, writer, enc.StringEncoder.Instance);
                }
                if (value.DisplayName != null)
                {
                    WriteProperty("display_name", value.DisplayName, writer, enc.StringEncoder.Instance);
                }
                if (value.Email != null)
                {
                    WriteProperty("email", value.Email, writer, enc.StringEncoder.Instance);
                }
                if (value.Team != null)
                {
                    WriteProperty("team", value.Team, writer, global::Dropbox.Api.TeamLog.TeamLogInfo.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TrustedNonTeamMemberLogInfo" />.</para>
        /// </summary>
        private class TrustedNonTeamMemberLogInfoDecoder : enc.StructDecoder<TrustedNonTeamMemberLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TrustedNonTeamMemberLogInfo"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TrustedNonTeamMemberLogInfo Create()
            {
                return new TrustedNonTeamMemberLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TrustedNonTeamMemberLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "trusted_non_team_member_type":
                        value.TrustedNonTeamMemberType = global::Dropbox.Api.TeamLog.TrustedNonTeamMemberType.Decoder.Decode(reader);
                        break;
                    case "account_id":
                        value.AccountId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "display_name":
                        value.DisplayName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "email":
                        value.Email = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "team":
                        value.Team = global::Dropbox.Api.TeamLog.TeamLogInfo.Decoder.Decode(reader);
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
