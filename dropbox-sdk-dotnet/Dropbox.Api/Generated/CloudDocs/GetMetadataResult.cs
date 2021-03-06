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
    /// <para>The get metadata result object</para>
    /// </summary>
    public class GetMetadataResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GetMetadataResult> Encoder = new GetMetadataResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GetMetadataResult> Decoder = new GetMetadataResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataResult" />
        /// class.</para>
        /// </summary>
        /// <param name="fileId">The file id</param>
        /// <param name="title">Title of the Cloud Doc without extension.</param>
        /// <param name="mimeType">MIME type of the Cloud Doc.</param>
        /// <param name="version">Opaque string representing the version of the document stored
        /// in Dropbox (only set for Dropbox-stored Documents).</param>
        /// <param name="providerVersion">Application specific string representing the revision
        /// of a document (only set for App-stored Documents).</param>
        /// <param name="user">User identified by the auth token.</param>
        /// <param name="isDeleted">true if the document is deleted or purged.</param>
        /// <param name="userPermissions">Actions that the user identified by the auth token
        /// can performn. This message will not be populated for deleted documents.</param>
        public GetMetadataResult(string fileId = "",
                                 string title = "",
                                 string mimeType = "",
                                 string version = "",
                                 string providerVersion = "",
                                 UserInfo user = null,
                                 bool isDeleted = false,
                                 UserPermissions userPermissions = null)
        {
            if (fileId == null)
            {
                throw new sys.ArgumentNullException("fileId");
            }

            if (title == null)
            {
                throw new sys.ArgumentNullException("title");
            }

            if (mimeType == null)
            {
                throw new sys.ArgumentNullException("mimeType");
            }

            if (version == null)
            {
                throw new sys.ArgumentNullException("version");
            }

            if (providerVersion == null)
            {
                throw new sys.ArgumentNullException("providerVersion");
            }

            this.FileId = fileId;
            this.Title = title;
            this.MimeType = mimeType;
            this.Version = version;
            this.ProviderVersion = providerVersion;
            this.User = user;
            this.IsDeleted = isDeleted;
            this.UserPermissions = userPermissions;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GetMetadataResult()
        {
            this.FileId = "";
            this.Title = "";
            this.MimeType = "";
            this.Version = "";
            this.ProviderVersion = "";
            this.IsDeleted = false;
        }

        /// <summary>
        /// <para>Gets the file id of the get metadata result</para>
        /// </summary>
        public string FileId { get; protected set; }

        /// <summary>
        /// <para>Title of the Cloud Doc without extension.</para>
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// <para>MIME type of the Cloud Doc.</para>
        /// </summary>
        public string MimeType { get; protected set; }

        /// <summary>
        /// <para>Opaque string representing the version of the document stored in Dropbox
        /// (only set for Dropbox-stored Documents).</para>
        /// </summary>
        public string Version { get; protected set; }

        /// <summary>
        /// <para>Application specific string representing the revision of a document (only set
        /// for App-stored Documents).</para>
        /// </summary>
        public string ProviderVersion { get; protected set; }

        /// <summary>
        /// <para>User identified by the auth token.</para>
        /// </summary>
        public UserInfo User { get; protected set; }

        /// <summary>
        /// <para>true if the document is deleted or purged.</para>
        /// </summary>
        public bool IsDeleted { get; protected set; }

        /// <summary>
        /// <para>Actions that the user identified by the auth token can performn. This message
        /// will not be populated for deleted documents.</para>
        /// </summary>
        public UserPermissions UserPermissions { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GetMetadataResult" />.</para>
        /// </summary>
        private class GetMetadataResultEncoder : enc.StructEncoder<GetMetadataResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GetMetadataResult value, enc.IJsonWriter writer)
            {
                WriteProperty("file_id", value.FileId, writer, enc.StringEncoder.Instance);
                WriteProperty("title", value.Title, writer, enc.StringEncoder.Instance);
                WriteProperty("mime_type", value.MimeType, writer, enc.StringEncoder.Instance);
                WriteProperty("version", value.Version, writer, enc.StringEncoder.Instance);
                WriteProperty("provider_version", value.ProviderVersion, writer, enc.StringEncoder.Instance);
                if (value.User != null)
                {
                    WriteProperty("user", value.User, writer, global::Dropbox.Api.CloudDocs.UserInfo.Encoder);
                }
                WriteProperty("is_deleted", value.IsDeleted, writer, enc.BooleanEncoder.Instance);
                if (value.UserPermissions != null)
                {
                    WriteProperty("user_permissions", value.UserPermissions, writer, global::Dropbox.Api.CloudDocs.UserPermissions.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GetMetadataResult" />.</para>
        /// </summary>
        private class GetMetadataResultDecoder : enc.StructDecoder<GetMetadataResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GetMetadataResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GetMetadataResult Create()
            {
                return new GetMetadataResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GetMetadataResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_id":
                        value.FileId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "title":
                        value.Title = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "mime_type":
                        value.MimeType = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "version":
                        value.Version = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "provider_version":
                        value.ProviderVersion = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "user":
                        value.User = global::Dropbox.Api.CloudDocs.UserInfo.Decoder.Decode(reader);
                        break;
                    case "is_deleted":
                        value.IsDeleted = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "user_permissions":
                        value.UserPermissions = global::Dropbox.Api.CloudDocs.UserPermissions.Decoder.Decode(reader);
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
