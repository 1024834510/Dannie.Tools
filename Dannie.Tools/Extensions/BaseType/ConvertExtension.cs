using System.Numerics;

namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：ConvertExtension</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>扩展工具类：将一个基本数据类型转换为另一个基本数据类型</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-03 11:12:05</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-03 11:12:05</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：a8abec4c-e783-471b-8c6c-34b4d2ccd515</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class ConvertExtension
    {
        #region 将对象转换为Int
        /// <summary>
        /// 将对象转换为Int
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static int ToInt(this object Data)
        {
            if (Data == null)
                return 0;
            int.TryParse(Data.ToString(), out int result);
            return result;
        }
        #endregion

        #region 将对象转换为Uint
        /// <summary>
        /// 将对象转换为Uint
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static uint ToUint(this object Data)
        {
            if (Data == null)
                return 0;
            uint.TryParse(Data.ToString(), out uint result);
            return result;
        }
        #endregion

        #region 将对象转换为Long
        /// <summary>
        /// 将对象转换为Long
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static long ToLong(this object Data)
        {
            if (Data == null)
                return 0;
            long.TryParse(Data.ToString(), out long result);
            return result;
        }
        #endregion

        #region 将对象转换为Ulong
        /// <summary>
        /// 将对象转换为Ulong
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static ulong ToUlong(this object Data)
        {
            if (Data == null)
                return 0;
            ulong.TryParse(Data.ToString(), out ulong result);
            return result;
        }
        #endregion

        #region 将对象转换为Short
        /// <summary>
        /// 将对象转换为Short
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static short ToShort(this object Data)
        {
            if (Data == null)
                return 0;
            short.TryParse(Data.ToString(), out short result);
            return result;
        }
        #endregion

        #region 将对象转换为Ushort
        /// <summary>
        /// 将对象转换为Ushort
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static ushort ToUshort(this object Data)
        {
            if (Data == null)
                return 0;
            ushort.TryParse(Data.ToString(), out ushort result);
            return result;
        }
        #endregion

        #region 将对象转换为Float
        /// <summary>
        /// 将对象转换为Float
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static float ToFloat(this object Data)
        {
            if (Data == null)
                return 0;
            float.TryParse(Data.ToString(), out float result);
            return result;
        }
        #endregion

        #region 将对象转换为Double
        /// <summary>
        /// 将对象转换为Double
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static double ToDouble(this object Data)
        {
            if (Data == null)
                return 0;
            double.TryParse(Data.ToString(), out double result);
            return result;
        }
        #endregion

        #region 将对象转换为Decimal
        /// <summary>
        /// 将对象转换为Decimal
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static decimal ToDecimal(this object Data)
        {
            if (Data == null)
                return 0;
            decimal.TryParse(Data.ToString(), out decimal result);
            return result;
        }
        #endregion

        #region 将对象转换为BigInteger
        /// <summary>
        /// 将对象转换为BigInteger
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static BigInteger ToBigInteger(this object Data)
        {
            if (Data == null)
                return 0;
            BigInteger.TryParse(Data.ToString(), out BigInteger result);
            return result;
        }
        #endregion

        #region 将对象转换为Bool
        /// <summary>
        /// 将对象转换为BigInteger
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回false</item>
        ///     </list>
        /// </returns>
        public static bool ToBool(this object Data)
        {
            if (Data == null)
                return false;
            if (Data is string)
            {
                string Ts = (string)Data;
                if (Ts == "Yes" || Ts == "yes" || Ts == "Y" || Ts == "y" || Ts == "T" || Ts == "t")
                    return true;
                else if (Ts == "No" || Ts == "no" || Ts == "N" || Ts == "n" || Ts == "F" || Ts == "f")
                    return false;
                else
                {
                    bool.TryParse(Ts, out bool result);
                    return result;
                }
            }
            else if (Data is int || Data is long || Data is short || Data is uint || Data is ulong || Data is ushort)
                return (int)Data > 0;
            else
            {
                try
                {
                   return Convert.ToBoolean(Data);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region 将对象转换为DateTime
        /// <summary>
        /// 将对象转换为DateTime
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回DateTime.MinValue</item>
        ///     </list>
        /// </returns>
        public static DateTime ToDateTime(this object Data)
        {
            if (Data == null)
                return DateTime.MinValue;
            DateTime.TryParse(Data.ToString(), out DateTime result);
            return result;
        }
        #endregion

        #region 将int?转换为Int
        /// <summary>
        /// 将int?转换为Int
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static int ToInt(this int? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将uint?转换为Uint
        /// <summary>
        /// 将uint?转换为Uint
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static uint ToInt(this uint? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将Long?转换为Long
        /// <summary>
        /// 将Long?转换为Long
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static long ToLong(this long? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将Ulong?转换为Ulong
        /// <summary>
        /// 将Ulong?转换为Ulong
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static ulong ToUlong(this ulong? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将Short?转换为Short
        /// <summary>
        /// 将Short?转换为Short
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static short ToShort(this short? Data) => Data.HasValue ? Data.Value : (short)0;
        #endregion

        #region 将Ushort?转换为Ushort
        /// <summary>
        /// 将Ushort?转换为Ushort
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static ushort ToUshort(this ushort? Data) => Data.HasValue ? Data.Value : (ushort)0;
        #endregion

        #region 将Float?转换为Float
        /// <summary>
        /// 将Float?转换为Float
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static float ToFloat(this float? Data) => Data.HasValue ? Data.Value : 0f;
        #endregion

        #region 将Double?转换为Double
        /// <summary>
        /// 将Double?转换为Double
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static double ToDouble(this double? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将Decimal?转换为Decimal
        /// <summary>
        /// 将Decimal?转换为Decimal
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static decimal ToDecimal(this decimal? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将BigInteger?转换为BigInteger
        /// <summary>
        /// 将BigInteger?转换为BigInteger
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回0</item>
        ///     </list>
        /// </returns>
        public static BigInteger ToBigInteger(this BigInteger? Data) => Data.HasValue ? Data.Value : 0;
        #endregion

        #region 将Bool?转换为Bool
        /// <summary>
        /// 将Bool?转换为Bool
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回false</item>
        ///     </list>
        /// </returns>
        public static bool ToBool(this bool? Data) => Data.HasValue ? Data.Value : false;
        #endregion

        #region 将DateTime?转换为DateTime
        /// <summary>
        /// 将DateTime?转换为DateTime
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns>
        ///     <list>
        ///         <item>成功返回转换后的对象</item>
        ///         <item>失败返回DateTime.MinValue</item>
        ///     </list>
        /// </returns>
        public static DateTime ToDateTime(this DateTime? Data) => Data.HasValue ? Data.Value : DateTime.MinValue;
        #endregion

        #region 将Bool转换为int
        /// <summary>
        /// 将Bool转换为int
        /// </summary>
        /// <param name="Data">需转换对象</param>
        /// <returns></returns>
        public static int BoolToInt(this bool Data) => Data ? 1 : 0;
        #endregion
    }
}
