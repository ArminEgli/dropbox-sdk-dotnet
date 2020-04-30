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
    /// <para>The legal holds get policy error object</para>
    /// </summary>
    public class LegalHoldsGetPolicyError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LegalHoldsGetPolicyError> Encoder = new LegalHoldsGetPolicyErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LegalHoldsGetPolicyError> Decoder = new LegalHoldsGetPolicyErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LegalHoldsGetPolicyError" />
        /// class.</para>
        /// </summary>
        public LegalHoldsGetPolicyError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// LegalHoldPolicyNotFound</para>
        /// </summary>
        public bool IsLegalHoldPolicyNotFound
        {
            get
            {
                return this is LegalHoldPolicyNotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a LegalHoldPolicyNotFound, or <c>null</c>.</para>
        /// </summary>
        public LegalHoldPolicyNotFound AsLegalHoldPolicyNotFound
        {
            get
            {
                return this as LegalHoldPolicyNotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnknownLegalHoldError</para>
        /// </summary>
        public bool IsUnknownLegalHoldError
        {
            get
            {
                return this is UnknownLegalHoldError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnknownLegalHoldError, or <c>null</c>.</para>
        /// </summary>
        public UnknownLegalHoldError AsUnknownLegalHoldError
        {
            get
            {
                return this as UnknownLegalHoldError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// InsufficientPermissions</para>
        /// </summary>
        public bool IsInsufficientPermissions
        {
            get
            {
                return this is InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientPermissions, or <c>null</c>.</para>
        /// </summary>
        public InsufficientPermissions AsInsufficientPermissions
        {
            get
            {
                return this as InsufficientPermissions;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LegalHoldsGetPolicyError" />.</para>
        /// </summary>
        private class LegalHoldsGetPolicyErrorEncoder : enc.StructEncoder<LegalHoldsGetPolicyError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LegalHoldsGetPolicyError value, enc.IJsonWriter writer)
            {
                if (value is LegalHoldPolicyNotFound)
                {
                    WriteProperty(".tag", "legal_hold_policy_not_found", writer, enc.StringEncoder.Instance);
                    LegalHoldPolicyNotFound.Encoder.EncodeFields((LegalHoldPolicyNotFound)value, writer);
                    return;
                }
                if (value is UnknownLegalHoldError)
                {
                    WriteProperty(".tag", "unknown_legal_hold_error", writer, enc.StringEncoder.Instance);
                    UnknownLegalHoldError.Encoder.EncodeFields((UnknownLegalHoldError)value, writer);
                    return;
                }
                if (value is InsufficientPermissions)
                {
                    WriteProperty(".tag", "insufficient_permissions", writer, enc.StringEncoder.Instance);
                    InsufficientPermissions.Encoder.EncodeFields((InsufficientPermissions)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LegalHoldsGetPolicyError" />.</para>
        /// </summary>
        private class LegalHoldsGetPolicyErrorDecoder : enc.UnionDecoder<LegalHoldsGetPolicyError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LegalHoldsGetPolicyError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LegalHoldsGetPolicyError Create()
            {
                return new LegalHoldsGetPolicyError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LegalHoldsGetPolicyError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "legal_hold_policy_not_found":
                        return LegalHoldPolicyNotFound.Decoder.DecodeFields(reader);
                    case "unknown_legal_hold_error":
                        return UnknownLegalHoldError.Decoder.DecodeFields(reader);
                    case "insufficient_permissions":
                        return InsufficientPermissions.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Legal hold policy does not exist for <see
        /// cref="Dropbox.Api.Team.LegalHoldsGetPolicyArg.Id" />.</para>
        /// </summary>
        public sealed class LegalHoldPolicyNotFound : LegalHoldsGetPolicyError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<LegalHoldPolicyNotFound> Encoder = new LegalHoldPolicyNotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<LegalHoldPolicyNotFound> Decoder = new LegalHoldPolicyNotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="LegalHoldPolicyNotFound" />
            /// class.</para>
            /// </summary>
            private LegalHoldPolicyNotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of LegalHoldPolicyNotFound</para>
            /// </summary>
            public static readonly LegalHoldPolicyNotFound Instance = new LegalHoldPolicyNotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="LegalHoldPolicyNotFound" />.</para>
            /// </summary>
            private class LegalHoldPolicyNotFoundEncoder : enc.StructEncoder<LegalHoldPolicyNotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(LegalHoldPolicyNotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="LegalHoldPolicyNotFound" />.</para>
            /// </summary>
            private class LegalHoldPolicyNotFoundDecoder : enc.StructDecoder<LegalHoldPolicyNotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="LegalHoldPolicyNotFound"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override LegalHoldPolicyNotFound Create()
                {
                    return LegalHoldPolicyNotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>There has been an unknown legal hold error.</para>
        /// </summary>
        public sealed class UnknownLegalHoldError : LegalHoldsGetPolicyError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnknownLegalHoldError> Encoder = new UnknownLegalHoldErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnknownLegalHoldError> Decoder = new UnknownLegalHoldErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnknownLegalHoldError" />
            /// class.</para>
            /// </summary>
            private UnknownLegalHoldError()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnknownLegalHoldError</para>
            /// </summary>
            public static readonly UnknownLegalHoldError Instance = new UnknownLegalHoldError();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnknownLegalHoldError" />.</para>
            /// </summary>
            private class UnknownLegalHoldErrorEncoder : enc.StructEncoder<UnknownLegalHoldError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnknownLegalHoldError value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnknownLegalHoldError" />.</para>
            /// </summary>
            private class UnknownLegalHoldErrorDecoder : enc.StructDecoder<UnknownLegalHoldError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnknownLegalHoldError"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnknownLegalHoldError Create()
                {
                    return UnknownLegalHoldError.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>You don't have permissions to perform this action.</para>
        /// </summary>
        public sealed class InsufficientPermissions : LegalHoldsGetPolicyError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientPermissions> Encoder = new InsufficientPermissionsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientPermissions> Decoder = new InsufficientPermissionsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientPermissions" />
            /// class.</para>
            /// </summary>
            private InsufficientPermissions()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsufficientPermissions</para>
            /// </summary>
            public static readonly InsufficientPermissions Instance = new InsufficientPermissions();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsEncoder : enc.StructEncoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientPermissions value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientPermissions" />.</para>
            /// </summary>
            private class InsufficientPermissionsDecoder : enc.StructDecoder<InsufficientPermissions>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientPermissions"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientPermissions Create()
                {
                    return InsufficientPermissions.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LegalHoldsGetPolicyError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
