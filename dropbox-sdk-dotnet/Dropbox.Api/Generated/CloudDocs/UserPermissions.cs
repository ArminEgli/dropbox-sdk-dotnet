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
    /// <para>The user permissions object</para>
    /// </summary>
    public class UserPermissions
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserPermissions> Encoder = new UserPermissionsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserPermissions> Decoder = new UserPermissionsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserPermissions" />
        /// class.</para>
        /// </summary>
        /// <param name="canEdit">true if the user can edit the content of this
        /// document</param>
        /// <param name="canRename">true if the user can edit the title of this
        /// document</param>
        /// <param name="canComment">true if the user can comment on this document</param>
        /// <param name="canDownload">true if the user can download the contents of this
        /// document. currently always true if the user has view access to the
        /// document.</param>
        public UserPermissions(bool canEdit = false,
                               bool canRename = false,
                               bool canComment = false,
                               bool canDownload = false)
        {
            this.CanEdit = canEdit;
            this.CanRename = canRename;
            this.CanComment = canComment;
            this.CanDownload = canDownload;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserPermissions" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UserPermissions()
        {
            this.CanEdit = false;
            this.CanRename = false;
            this.CanComment = false;
            this.CanDownload = false;
        }

        /// <summary>
        /// <para>true if the user can edit the content of this document</para>
        /// </summary>
        public bool CanEdit { get; protected set; }

        /// <summary>
        /// <para>true if the user can edit the title of this document</para>
        /// </summary>
        public bool CanRename { get; protected set; }

        /// <summary>
        /// <para>true if the user can comment on this document</para>
        /// </summary>
        public bool CanComment { get; protected set; }

        /// <summary>
        /// <para>true if the user can download the contents of this document. currently always
        /// true if the user has view access to the document.</para>
        /// </summary>
        public bool CanDownload { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserPermissions" />.</para>
        /// </summary>
        private class UserPermissionsEncoder : enc.StructEncoder<UserPermissions>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserPermissions value, enc.IJsonWriter writer)
            {
                WriteProperty("can_edit", value.CanEdit, writer, enc.BooleanEncoder.Instance);
                WriteProperty("can_rename", value.CanRename, writer, enc.BooleanEncoder.Instance);
                WriteProperty("can_comment", value.CanComment, writer, enc.BooleanEncoder.Instance);
                WriteProperty("can_download", value.CanDownload, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserPermissions" />.</para>
        /// </summary>
        private class UserPermissionsDecoder : enc.StructDecoder<UserPermissions>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserPermissions" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserPermissions Create()
            {
                return new UserPermissions();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserPermissions value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "can_edit":
                        value.CanEdit = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "can_rename":
                        value.CanRename = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "can_comment":
                        value.CanComment = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "can_download":
                        value.CanDownload = enc.BooleanDecoder.Instance.Decode(reader);
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
