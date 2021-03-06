﻿namespace Olive.Security
{
    using System.Security.Cryptography;
    using System.Text;
    using System.Xml.Serialization;

    public static class EncryptionExtensions
    {
        static XmlSerializer RSAParametersSerializer = new XmlSerializer(typeof(RSAParameters));

        public static string ToKey(this RSAParameters @this)
        {
            var xml = RSAParametersSerializer.Serialize(@this);
            return xml.ToBytes(Encoding.ASCII).ToBase64String();
        }

        public static RSACryptoServiceProvider FromKey(this RSACryptoServiceProvider @this, string key)
        {
            var xml = key.ToBytesFromBase64().ToString(Encoding.ASCII);
            var parameters = RSAParametersSerializer.Deserialize<RSAParameters>(xml);
            @this.ImportParameters(parameters);

            return @this;
        }
    }
}