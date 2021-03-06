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
    /// <para>The collection share type object</para>
    /// </summary>
    public class CollectionShareType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<CollectionShareType> Encoder = new CollectionShareTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<CollectionShareType> Decoder = new CollectionShareTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CollectionShareType" />
        /// class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public CollectionShareType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CollectionShareType" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public CollectionShareType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the collection share type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="CollectionShareType" />.</para>
        /// </summary>
        private class CollectionShareTypeEncoder : enc.StructEncoder<CollectionShareType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(CollectionShareType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="CollectionShareType" />.</para>
        /// </summary>
        private class CollectionShareTypeDecoder : enc.StructDecoder<CollectionShareType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="CollectionShareType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override CollectionShareType Create()
            {
                return new CollectionShareType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(CollectionShareType value, string fieldName, enc.IJsonReader reader)
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
