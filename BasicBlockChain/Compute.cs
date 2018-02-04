using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;

namespace BasicBlockChain
{
    class Compute
    {
        public static string BlockHash(object obj)
        {
            using (SHA256Managed sha265 = new SHA256Managed())
            {
                var hash = sha265.ComputeHash(ObjectByte(obj)); // lepas tu baru di hash kan
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString(); // selepas hash, pulang kan resultnya
            }
        }

        // function ini untuk tukar class kepada binary
        private static byte[] ObjectByte(object obj)
        {
            var bf = new BinaryFormatter();

            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
    }
}
