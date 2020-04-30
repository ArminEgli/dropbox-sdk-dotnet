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
    /// <para>The legal holds list policies result object</para>
    /// </summary>
    public class LegalHoldsListPoliciesResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsListPoliciesResult> Encoder = new LegalHoldsListPoliciesResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsListPoliciesResult> Decoder = new LegalHoldsListPoliciesResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsListPoliciesResult" />
        /// class.</para>
        /// </summary>
        /// <param name="policies">The policies</param>
        public LegalHoldsListPoliciesResult(col.IEnumerable<LegalHoldPolicy> policies)
        {
            var policiesList = enc.Util.ToList(policies);

            if (policies == null)
            {
                throw new sys.ArgumentNullException("policies");
            }

            this.Policies = policiesList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsListPoliciesResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsListPoliciesResult()
        {
        }

        /// <summary>
        /// <para>Gets the policies of the legal holds list policies result</para>
        /// </summary>
        public col.IList<LegalHoldPolicy> Policies { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsListPoliciesResult" />.</para>
        /// </summary>
        private class LegalHoldsListPoliciesResultEncoder : enc.StructEncoder<LegalHoldsListPoliciesResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsListPoliciesResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("policies", value.Policies, writer, global::Dropbox.Api.Team.LegalHoldPolicy.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsListPoliciesResult" />.</para>
        /// </summary>
        private class LegalHoldsListPoliciesResultDecoder : enc.StructDecoder<LegalHoldsListPoliciesResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsListPoliciesResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsListPoliciesResult Create()
            {
                return new LegalHoldsListPoliciesResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsListPoliciesResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "policies":
                        value.Policies = ReadList<LegalHoldPolicy>(reader, global::Dropbox.Api.Team.LegalHoldPolicy.Decoder);
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
