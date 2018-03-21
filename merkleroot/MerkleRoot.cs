using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace merkleroot
{
    public class MerkleRoot
    {

       public static string merkle(string[] transactions)
        {
            while (true)
            {
                if (transactions.Length == 1) return transactions[0];
                List<string> newHashList = new List<string>();
                int len = (transactions.Length % 2 != 0) ? transactions.Length - 1 : transactions.Length;
                for (int i = 0; i < len; i += 2) newHashList.Add(Hash2(transactions[i], transactions[i + 1]));
                if (len < transactions.Length) newHashList.Add(Hash2(transactions[transactions.Length - 1], transactions[transactions.Length - 1]));
                transactions = newHashList.ToArray();               
            }
        }


        static string Hash2(string a, string b)
        {
            byte[] a1 = Enumerable.Range(0, a.Length / 2).Select(x => Convert.ToByte(a.Substring(x * 2, 2), 16)).ToArray();
            Array.Reverse(a1);
            byte[] b1 = Enumerable.Range(0, b.Length / 2).Select(x => Convert.ToByte(b.Substring(x * 2, 2), 16)).ToArray();
            Array.Reverse(b1);
            var c = a1.Concat(b1).ToArray();
            SHA256 sha256 = SHA256.Create();
            byte[] firstHash = sha256.ComputeHash(c);
            byte[] hashOfHash = sha256.ComputeHash(firstHash);
            Array.Reverse(hashOfHash);
            return BitConverter.ToString(hashOfHash).Replace("-", "").ToLower();
        }

    }
}

