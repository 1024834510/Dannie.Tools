using System.IO;
using System.IO.Compression;
using System.Text;

namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：GZipUtils</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>扩展工具类：字符串压缩</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-03 09:15:52</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-03 09:15:52</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：5484a3f6-f333-45b2-9b3a-1e9051eca463</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class GZipUtils
    {
        #region 压缩指定字符串
        /// <summary>
        /// 压缩指定字符串
        /// </summary>
        /// <param name="str">待压缩字符串</param>
        /// <returns>返回压缩后的字节数组</returns>
        public static byte[] Compress(this string str)
        {
            if (string.IsNullOrEmpty(str)) return null;

            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return Compress(bytes);
        }
        #endregion

        #region 压缩指定字节数组
        /// <summary>
        /// 压缩指定字节数组
        /// </summary>
        /// <param name="bytes">待压缩字节数组</param>
        /// <returns>返回压缩后的字节数组</returns>
        public static byte[] Compress(this byte[] bytes)
        {
            if (bytes == null || bytes.Length <= 0) return bytes;

            using (var compressedStream = new MemoryStream())
            {
                using (var compressionStream = new GZipStream(compressedStream, CompressionMode.Compress))
                {
                    compressionStream.Write(bytes, 0, bytes.Length);
                }
                return compressedStream.ToArray();
            }
        }
        #endregion

        #region 压缩指定字符串到指定文件中
        /// <summary>
        /// 压缩指定字符串到指定文件中
        /// </summary>
        /// <param name="compressData">待压缩字符串</param>
        /// <param name="zipFilePath">压缩后的文件路径</param>
        public static void CompressToFile(this string compressData, string zipFilePath)
        {
            if (!string.IsNullOrEmpty(compressData))
                using (MemoryStream originalStream = new MemoryStream(Encoding.UTF8.GetBytes(compressData)))
                using (FileStream compressedStream = File.Create(zipFilePath))
                using (GZipStream compressionStream = new GZipStream(compressedStream, CompressionMode.Compress))
                    originalStream.CopyTo(compressionStream);
        }
        #endregion

        #region 从指定字节数组解压出字符串
        /// <summary>
        /// 从指定字节数组解压出字符串
        /// </summary>
        /// <param name="bytes">待解压的字节数组</param>
        /// <returns>返回解压后的字符串</returns>
        public static string DecompressToString(this byte[] bytes)
        {
            var result = Decompress(bytes);
            if (result == null || result.Length <= 0) return string.Empty;
            return Encoding.UTF8.GetString(result);
        }
        #endregion

        #region 从指定字节数组解压出字节数组
        /// <summary>
        /// 从指定字节数组解压出字节数组
        /// </summary>
        /// <param name="bytes">待解压的字节数组</param>
        /// <returns>返回解压后的字节数组</returns>
        public static byte[] Decompress(this byte[] bytes)
        {
            if (bytes == null || bytes.Length <= 0) return bytes;

            using (var originalStream = new MemoryStream(bytes))
            using (var decompressedStream = new MemoryStream())
            {
                using (var decompressionStream = new GZipStream(originalStream, CompressionMode.Decompress))
                    decompressionStream.CopyTo(decompressedStream);
                return decompressedStream.ToArray();
            }
        }
        #endregion

        #region 从指定文件中解压出字符串
        /// <summary>
        /// 从指定文件中解压出字符串
        /// </summary>
        /// <param name="zipFilePath">待解压的文件路径</param>
        /// <returns>返回解压后的字符串</returns>
        public static string DecompressFromFile(this string zipFilePath)
        {
            if (File.Exists(zipFilePath))
                using (FileStream originalStream = File.Open(zipFilePath, FileMode.Open))
                using (MemoryStream decompressedStream = new MemoryStream())
                {
                    using (GZipStream decompressionStream = new GZipStream(originalStream, CompressionMode.Decompress))
                        decompressionStream.CopyTo(decompressedStream);
                    byte[] bytes = decompressedStream.ToArray();
                    return Encoding.UTF8.GetString(bytes);
                }
            return string.Empty;
        } 
        #endregion
    }
}
