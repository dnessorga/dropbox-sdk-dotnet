// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The list folder longpoll error object</para>
    /// </summary>
    public class ListFolderLongpollError : enc.IEncodable<ListFolderLongpollError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderLongpollError" />
        /// class.</para>
        /// </summary>
        public ListFolderLongpollError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Reset</para>
        /// </summary>
        public bool IsReset
        {
            get
            {
                return this is Reset;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Reset, or <c>null</c>.</para>
        /// </summary>
        public Reset AsReset
        {
            get
            {
                return this as Reset;
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

        #region IEncodable<ListFolderLongpollError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListFolderLongpollError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsReset)
            {
                ((enc.IEncodable<Reset>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListFolderLongpollError enc.IEncodable<ListFolderLongpollError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "reset":
                return Reset.Instance;
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>Indicates that the cursor has been invalidated. Call <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderAsync" /> to obtain a new
        /// cursor.</para>
        /// </summary>
        public sealed class Reset : ListFolderLongpollError, enc.IEncodable<Reset>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Reset" /> class.</para>
            /// </summary>
            private Reset()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Reset</para>
            /// </summary>
            public static readonly Reset Instance = new Reset();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Reset>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "reset");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Reset enc.IEncodable<Reset>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListFolderLongpollError, enc.IEncodable<Other>
        {
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

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "other");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
