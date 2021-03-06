// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.CloudDocs
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The get metadata arg object</para>
    /// </summary>
    public class GetMetadataArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetMetadataArg> Encoder = new GetMetadataArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetMetadataArg> Decoder = new GetMetadataArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <param name="fileId">API ID ("id:...") associated with the Cloud Doc.</param>
        public GetMetadataArg(string fileId = "")
        {
            if (fileId == null)
            {
                throw new sys.ArgumentNullException("fileId");
            }

            this.FileId = fileId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetMetadataArg()
        {
            this.FileId = "";
        }

        /// <summary>
        /// <para>API ID ("id:...") associated with the Cloud Doc.</para>
        /// </summary>
        public string FileId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetMetadataArg" />.</para>
        /// </summary>
        private class GetMetadataArgEncoder : enc.StructEncoder<GetMetadataArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetMetadataArg value, enc.IJsonWriter writer)
            {
                WriteProperty("file_id", value.FileId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetMetadataArg" />.</para>
        /// </summary>
        private class GetMetadataArgDecoder : enc.StructDecoder<GetMetadataArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetMetadataArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetMetadataArg Create()
            {
                return new GetMetadataArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetMetadataArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_id":
                        value.FileId = enc.StringDecoder.Instance.Decode(reader);
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
