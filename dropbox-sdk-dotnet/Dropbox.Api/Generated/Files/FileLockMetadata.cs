// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The file lock metadata object</para>
    /// </summary>
    public class FileLockMetadata
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileLockMetadata> Encoder = new FileLockMetadataEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileLockMetadata> Decoder = new FileLockMetadataDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLockMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="isLockholder">True if caller holds the file lock.</param>
        /// <param name="lockholderName">The display name of the lock holder.</param>
        /// <param name="lockholderAccountId">The account ID of the lock holder if
        /// known.</param>
        /// <param name="created">The timestamp of the lock was created.</param>
        public FileLockMetadata(bool? isLockholder = null,
                                string lockholderName = null,
                                string lockholderAccountId = null,
                                sys.DateTime? created = null)
        {
            if (lockholderAccountId != null)
            {
                if (lockholderAccountId.Length < 40)
                {
                    throw new sys.ArgumentOutOfRangeException("lockholderAccountId", "Length should be at least 40");
                }
                if (lockholderAccountId.Length > 40)
                {
                    throw new sys.ArgumentOutOfRangeException("lockholderAccountId", "Length should be at most 40");
                }
            }

            this.IsLockholder = isLockholder;
            this.LockholderName = lockholderName;
            this.LockholderAccountId = lockholderAccountId;
            this.Created = created;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLockMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileLockMetadata()
        {
        }

        /// <summary>
        /// <para>True if caller holds the file lock.</para>
        /// </summary>
        public bool? IsLockholder { get; protected set; }

        /// <summary>
        /// <para>The display name of the lock holder.</para>
        /// </summary>
        public string LockholderName { get; protected set; }

        /// <summary>
        /// <para>The account ID of the lock holder if known.</para>
        /// </summary>
        public string LockholderAccountId { get; protected set; }

        /// <summary>
        /// <para>The timestamp of the lock was created.</para>
        /// </summary>
        public sys.DateTime? Created { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileLockMetadata" />.</para>
        /// </summary>
        private class FileLockMetadataEncoder : enc.StructEncoder<FileLockMetadata>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileLockMetadata value, enc.IJsonWriter writer)
            {
                if (value.IsLockholder != null)
                {
                    WriteProperty("is_lockholder", value.IsLockholder.Value, writer, enc.BooleanEncoder.Instance);
                }
                if (value.LockholderName != null)
                {
                    WriteProperty("lockholder_name", value.LockholderName, writer, enc.StringEncoder.Instance);
                }
                if (value.LockholderAccountId != null)
                {
                    WriteProperty("lockholder_account_id", value.LockholderAccountId, writer, enc.StringEncoder.Instance);
                }
                if (value.Created != null)
                {
                    WriteProperty("created", value.Created.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileLockMetadata" />.</para>
        /// </summary>
        private class FileLockMetadataDecoder : enc.StructDecoder<FileLockMetadata>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileLockMetadata" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileLockMetadata Create()
            {
                return new FileLockMetadata();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileLockMetadata value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "is_lockholder":
                        value.IsLockholder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "lockholder_name":
                        value.LockholderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "lockholder_account_id":
                        value.LockholderAccountId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "created":
                        value.Created = enc.DateTimeDecoder.Instance.Decode(reader);
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