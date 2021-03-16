using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
public class MD5Crypt
{
	static string  MD5Crypt( string source)
	{
        byte[] bytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(source));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            sb.Append(bytes[i].ToString("x2"));
        }

        Encoding.UTF8.GetString(bytes);
        return sb.ToString();
    }
}
