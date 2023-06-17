using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FloatLrc
{
    internal class SerializeUtil
    {
        /// <summary>
        /// 对象序列化
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] Encode(object value)
        {
            //创建编码解码的内存流对象
            MemoryStream ms = new MemoryStream();
            //二进制流序列化对象
            BinaryFormatter bw = new BinaryFormatter();
            //将obj对象序列化成二进制数据 写入到 内存流
            bw.Serialize(ms, value);
            byte[] result = new byte[ms.Length];
            //将流数据 拷贝到结果数组
            Buffer.BlockCopy(ms.GetBuffer(), 0, result, 0, (int)ms.Length);
            ms.Close();
            return result;
        }

        /// <summary>
        /// 反序列化对象
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Decode(byte[] value)
        {
            //创建编码解码的内存流对象 并将需要反序列化的数据写入其中
            MemoryStream ms = new MemoryStream(value);
            //二进制流序列化对象
            BinaryFormatter bw = new BinaryFormatter();
            //将流数据反序列化为obj对象
            object result = bw.Deserialize(ms);
            ms.Close();
            return result;
        }

        public static byte[] FileToByte(string fileUrl)
        {
            using (FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.Read))
            {
                byte[] byteArray = new byte[fs.Length];
                fs.Read(byteArray, 0, byteArray.Length);
                return byteArray;
            }
        }
        public static bool ByteToFile(byte[] byteArray, string fileName)
        {
            bool result = false;
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }


    }
}
