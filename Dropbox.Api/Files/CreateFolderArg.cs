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
    /// <para>The create folder arg object</para>
    /// </summary>
    public sealed class CreateFolderArg : enc.IEncodable<CreateFolderArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">Path in the user's Dropbox to create.</param>
        public CreateFolderArg(string path)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="CreateFolderArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public CreateFolderArg()
        {
        }

        /// <summary>
        /// <para>Path in the user's Dropbox to create.</para>
        /// </summary>
        public string Path { get; private set; }

        #region IEncodable<CreateFolderArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<CreateFolderArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        CreateFolderArg enc.IEncodable<CreateFolderArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");
            }

            return this;
        }

        #endregion
    }
}
