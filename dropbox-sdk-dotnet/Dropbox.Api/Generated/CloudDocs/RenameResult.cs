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
    /// <para>The rename result object</para>
    /// </summary>
    public class RenameResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RenameResult> Encoder = new RenameResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RenameResult> Decoder = new RenameResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RenameResult" /> class.</para>
        /// </summary>
        /// <param name="title">The updated title of the doc without extension, which could be
        /// different from the supplied title in the request because Dropbox may remove/replace
        /// charaters that are not supported in Dropbox Filesystem.</param>
        public RenameResult(string title = "")
        {
            if (title == null)
            {
                throw new sys.ArgumentNullException("title");
            }

            this.Title = title;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RenameResult" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RenameResult()
        {
            this.Title = "";
        }

        /// <summary>
        /// <para>The updated title of the doc without extension, which could be different from
        /// the supplied title in the request because Dropbox may remove/replace charaters that
        /// are not supported in Dropbox Filesystem.</para>
        /// </summary>
        public string Title { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RenameResult" />.</para>
        /// </summary>
        private class RenameResultEncoder : enc.StructEncoder<RenameResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RenameResult value, enc.IJsonWriter writer)
            {
                WriteProperty("title", value.Title, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RenameResult" />.</para>
        /// </summary>
        private class RenameResultDecoder : enc.StructDecoder<RenameResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RenameResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RenameResult Create()
            {
                return new RenameResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RenameResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "title":
                        value.Title = enc.StringDecoder.Instance.Decode(reader);
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
