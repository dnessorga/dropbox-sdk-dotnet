// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get shared links arg object</para>
    /// </summary>
    public sealed class GetSharedLinksArg : enc.IEncodable<GetSharedLinksArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedLinksArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">See <see
        /// cref="Dropbox.Api.Sharing.Routes.SharingRoutes.GetSharedLinksAsync" />
        /// description.</param>
        public GetSharedLinksArg(string path = null)
        {
            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetSharedLinksArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetSharedLinksArg()
        {
        }

        /// <summary>
        /// <para>See <see cref="Dropbox.Api.Sharing.Routes.SharingRoutes.GetSharedLinksAsync"
        /// /> description.</para>
        /// </summary>
        public string Path { get; private set; }

        #region IEncodable<GetSharedLinksArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<GetSharedLinksArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                if (this.Path != null)
                {
                    obj.AddField<string>("path", this.Path);
                }
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        GetSharedLinksArg enc.IEncodable<GetSharedLinksArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                if (obj.HasField("path"))
                {
                    this.Path = obj.GetField<string>("path");
                }
            }

            return this;
        }

        #endregion
    }
}
