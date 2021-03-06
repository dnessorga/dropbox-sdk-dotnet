// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Representations for a person's name to assist with internationalization.</para>
    /// </summary>
    /// <seealso cref="Account" />
    /// <seealso cref="BasicAccount" />
    /// <seealso cref="FullAccount" />
    public sealed class Name : enc.IEncodable<Name>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Name" /> class.</para>
        /// </summary>
        /// <param name="givenName">Also known as a first name.</param>
        /// <param name="surname">Also known as a last name or family name.</param>
        /// <param name="familiarName">Locale-dependent name. In the US, a person's familiar
        /// name is their <paramref name="givenName" />, but elsewhere, it could be any
        /// combination of a person's <paramref name="givenName" /> and <paramref
        /// name="surname" />.</param>
        /// <param name="displayName">A name that can be used directly to represent the name of
        /// a user's Dropbox account.</param>
        public Name(string givenName,
                    string surname,
                    string familiarName,
                    string displayName)
        {
            if (givenName == null)
            {
                throw new sys.ArgumentNullException("givenName");
            }

            if (surname == null)
            {
                throw new sys.ArgumentNullException("surname");
            }

            if (familiarName == null)
            {
                throw new sys.ArgumentNullException("familiarName");
            }

            if (displayName == null)
            {
                throw new sys.ArgumentNullException("displayName");
            }

            this.GivenName = givenName;
            this.Surname = surname;
            this.FamiliarName = familiarName;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="Name" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public Name()
        {
        }

        /// <summary>
        /// <para>Also known as a first name.</para>
        /// </summary>
        public string GivenName { get; private set; }

        /// <summary>
        /// <para>Also known as a last name or family name.</para>
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// <para>Locale-dependent name. In the US, a person's familiar name is their <see
        /// cref="GivenName" />, but elsewhere, it could be any combination of a person's <see
        /// cref="GivenName" /> and <see cref="Surname" />.</para>
        /// </summary>
        public string FamiliarName { get; private set; }

        /// <summary>
        /// <para>A name that can be used directly to represent the name of a user's Dropbox
        /// account.</para>
        /// </summary>
        public string DisplayName { get; private set; }

        #region IEncodable<Name> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<Name>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("given_name", this.GivenName);
                obj.AddField<string>("surname", this.Surname);
                obj.AddField<string>("familiar_name", this.FamiliarName);
                obj.AddField<string>("display_name", this.DisplayName);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        Name enc.IEncodable<Name>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.GivenName = obj.GetField<string>("given_name");
                this.Surname = obj.GetField<string>("surname");
                this.FamiliarName = obj.GetField<string>("familiar_name");
                this.DisplayName = obj.GetField<string>("display_name");
            }

            return this;
        }

        #endregion
    }
}
