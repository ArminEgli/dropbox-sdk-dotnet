// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The legal holds get policy arg object</para>
    /// </summary>
    public class LegalHoldsGetPolicyArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsGetPolicyArg> Encoder = new LegalHoldsGetPolicyArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsGetPolicyArg> Decoder = new LegalHoldsGetPolicyArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsGetPolicyArg" />
        /// class.</para>
        /// </summary>
        /// <param name="id">The legal hold Id.</param>
        public LegalHoldsGetPolicyArg(string id)
        {
            if (id == null)
            {
                throw new sys.ArgumentNullException("id");
            }
            if (!re.Regex.IsMatch(id, @"\A(?:^pid_dbhid:.+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("id", @"Value should match pattern '\A(?:^pid_dbhid:.+)\z'");
            }

            this.Id = id;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsGetPolicyArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsGetPolicyArg()
        {
        }

        /// <summary>
        /// <para>The legal hold Id.</para>
        /// </summary>
        public string Id { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsGetPolicyArg" />.</para>
        /// </summary>
        private class LegalHoldsGetPolicyArgEncoder : enc.StructEncoder<LegalHoldsGetPolicyArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsGetPolicyArg value, enc.IJsonWriter writer)
            {
                WriteProperty("id", value.Id, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsGetPolicyArg" />.</para>
        /// </summary>
        private class LegalHoldsGetPolicyArgDecoder : enc.StructDecoder<LegalHoldsGetPolicyArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsGetPolicyArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsGetPolicyArg Create()
            {
                return new LegalHoldsGetPolicyArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsGetPolicyArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "id":
                        value.Id = enc.StringDecoder.Instance.Decode(reader);
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
