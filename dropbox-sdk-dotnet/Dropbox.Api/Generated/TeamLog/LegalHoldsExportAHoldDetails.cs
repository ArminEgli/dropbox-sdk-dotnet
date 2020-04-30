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
    /// <para>Exported hold.</para>
    /// </summary>
    public class LegalHoldsExportAHoldDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsExportAHoldDetails> Encoder = new LegalHoldsExportAHoldDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsExportAHoldDetails> Decoder = new LegalHoldsExportAHoldDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsExportAHoldDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="legalHoldId">Hold ID.</param>
        /// <param name="name">Hold name.</param>
        /// <param name="exportName">Export name.</param>
        public LegalHoldsExportAHoldDetails(string legalHoldId,
                                            string name,
                                            string exportName = null)
        {
            if (legalHoldId == null)
            {
                throw new sys.ArgumentNullException("legalHoldId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            this.LegalHoldId = legalHoldId;
            this.Name = name;
            this.ExportName = exportName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsExportAHoldDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LegalHoldsExportAHoldDetails()
        {
        }

        /// <summary>
        /// <para>Hold ID.</para>
        /// </summary>
        public string LegalHoldId { get; protected set; }

        /// <summary>
        /// <para>Hold name.</para>
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// <para>Export name.</para>
        /// </summary>
        public string ExportName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsExportAHoldDetails" />.</para>
        /// </summary>
        private class LegalHoldsExportAHoldDetailsEncoder : enc.StructEncoder<LegalHoldsExportAHoldDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsExportAHoldDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("legal_hold_id", value.LegalHoldId, writer, enc.StringEncoder.Instance);
                WriteProperty("name", value.Name, writer, enc.StringEncoder.Instance);
                if (value.ExportName != null)
                {
                    WriteProperty("export_name", value.ExportName, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsExportAHoldDetails" />.</para>
        /// </summary>
        private class LegalHoldsExportAHoldDetailsDecoder : enc.StructDecoder<LegalHoldsExportAHoldDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsExportAHoldDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsExportAHoldDetails Create()
            {
                return new LegalHoldsExportAHoldDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LegalHoldsExportAHoldDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "legal_hold_id":
                        value.LegalHoldId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "name":
                        value.Name = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "export_name":
                        value.ExportName = enc.StringDecoder.Instance.Decode(reader);
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