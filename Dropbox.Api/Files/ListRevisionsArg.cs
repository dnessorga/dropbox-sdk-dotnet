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
    /// <para>The list revisions arg object</para>
    /// </summary>
    public sealed class ListRevisionsArg : enc.IEncodable<ListRevisionsArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsArg" />
        /// class.</para>
        /// </summary>
        /// <param name="path">The path to the file you want to see the revisions of.</param>
        /// <param name="limit">The maximum number of revision entries returned.</param>
        public ListRevisionsArg(string path,
                                ulong limit = 10)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"/.*"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            if (limit < 1UL || limit > 100UL)
            {
                throw new sys.ArgumentOutOfRangeException("limit");
            }

            this.Path = path;
            this.Limit = limit;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListRevisionsArg()
        {
            this.Limit = 10;
        }

        /// <summary>
        /// <para>The path to the file you want to see the revisions of.</para>
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// <para>The maximum number of revision entries returned.</para>
        /// </summary>
        public ulong Limit { get; private set; }

        #region IEncodable<ListRevisionsArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListRevisionsArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
                obj.AddField<ulong>("limit", this.Limit);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListRevisionsArg enc.IEncodable<ListRevisionsArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");
                if (obj.HasField("limit"))
                {
                    this.Limit = obj.GetField<ulong>("limit");
                }
            }

            return this;
        }

        #endregion
    }
}
