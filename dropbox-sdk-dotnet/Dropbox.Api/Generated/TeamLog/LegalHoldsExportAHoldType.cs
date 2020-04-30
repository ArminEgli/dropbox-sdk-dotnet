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
    /// <para>The legal holds export a hold type object</para>
    /// </summary>
    public class LegalHoldsExportAHoldType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsExportAHoldType> Encoder = new LegalHoldsExportAHoldTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsExportAHoldType> Decoder = new LegalHoldsExportAHoldTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsExportAHoldType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public LegalHoldsExportAHoldType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsExportAHoldType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsExportAHoldType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the legal holds export a hold type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsExportAHoldType" />.</para>
        /// </summary>
        private class LegalHoldsExportAHoldTypeEncoder : enc.StructEncoder<LegalHoldsExportAHoldType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsExportAHoldType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsExportAHoldType" />.</para>
        /// </summary>
        private class LegalHoldsExportAHoldTypeDecoder : enc.StructDecoder<LegalHoldsExportAHoldType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsExportAHoldType"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsExportAHoldType Create()
            {
                return new LegalHoldsExportAHoldType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsExportAHoldType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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