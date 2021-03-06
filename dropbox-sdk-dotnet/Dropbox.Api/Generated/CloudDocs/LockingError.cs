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
    /// <para>The locking error object</para>
    /// </summary>
    public class LockingError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LockingError> Encoder = new LockingErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LockingError> Decoder = new LockingErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockingError" /> class.</para>
        /// </summary>
        /// <param name="lockingErrorTag">The locking error tag</param>
        public LockingError(LockingErrorTagUnion lockingErrorTag = null)
        {
            this.LockingErrorTag = lockingErrorTag;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockingError" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LockingError()
        {
        }

        /// <summary>
        /// <para>Gets the locking error tag of the locking error</para>
        /// </summary>
        public LockingErrorTagUnion LockingErrorTag { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LockingError" />.</para>
        /// </summary>
        private class LockingErrorEncoder : enc.StructEncoder<LockingError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LockingError value, enc.IJsonWriter writer)
            {
                if (value.LockingErrorTag != null)
                {
                    WriteProperty("locking_error_tag", value.LockingErrorTag, writer, global::Dropbox.Api.CloudDocs.LockingErrorTagUnion.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LockingError" />.</para>
        /// </summary>
        private class LockingErrorDecoder : enc.StructDecoder<LockingError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LockingError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LockingError Create()
            {
                return new LockingError();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LockingError value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "locking_error_tag":
                        value.LockingErrorTag = global::Dropbox.Api.CloudDocs.LockingErrorTagUnion.Decoder.Decode(reader);
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
