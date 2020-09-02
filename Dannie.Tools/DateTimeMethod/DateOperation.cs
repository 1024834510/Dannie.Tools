using Dannie.Tools.Enum;
using System.Diagnostics;

namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 付冰玉昊 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：DateOperation</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>扩展工具类:日期操作</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 11:00:02</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 11:00:02</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：b29f58bc-27c0-44cd-bbb7-dc617d3b1d0e</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class DateOperation
    {
        #region 属性
        /// <summary>
        /// 获得当前时间戳（秒级）
        /// </summary>
        public static long GetToTotalSecondsNow => DateTime.Now.DateTimeToTotalSeconds();

        /// <summary>
        /// 获得当前时间戳（毫秒级）
        /// </summary>
        public static long GetTotalMillisecondsNow => DateTime.Now.DateTimeToTotalMilliseconds();
        #endregion

        #region 返回相对于当前时间的相对天数
        /// <summary>
        /// 返回相对于当前时间的相对天数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <param name="relativeday">相对天数</param>
        /// <returns>相对于当前时间的相对天数</returns>
        public static string GetDateTime(this DateTime dt, int relativeday) => dt.AddDays(relativeday).ToString("yyyy-MM-dd HH:mm:ss");
        #endregion

        #region 返回标准时间格式string
        /// <summary>
        /// 返回标准时间格式string
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>标准时间格式string</returns>
        public static string GetDateTimeF(this DateTime dt) => dt.ToString("yyyy-MM-dd HH:mm:ss:fffffff");
        #endregion

        #region 返回标准时间
        /// <summary>
        /// 转换日期时间字符串格式
        /// </summary>
        /// <param name="fDateTime">日期时间字符串</param>
        /// <param name="formatStr">格式</param>
        /// <returns>格式化后的时间</returns>
        public static string GetStandardDateTime(this string fDateTime, string formatStr)
        {
            if (fDateTime == "0000-0-0 0:00:00")
                return fDateTime;
            DateTime s = Convert.ToDateTime(fDateTime);
            return s.ToString(formatStr);
        }
        #endregion

        #region 返回通用时间格式 yyyy-MM-dd HH:mm:ss
        /// <summary>
        /// 返回通用时间格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="fDateTime">日期时间字符串</param>
        /// <returns>返回通用时间格式字符串</returns>
        public static string GetStandardDateTime(this string fDateTime) => GetStandardDateTime(fDateTime, "yyyy-MM-dd HH:mm:ss");
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的秒数
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的秒数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>Unix时间戳</returns>
        public static long DateTimeToTotalSeconds(this DateTime dt) {
            // 当地时区
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
            // 相差秒数
            return (long)(dt - startTime).TotalSeconds;
        }
        #endregion

        #region 将该时间戳转换为时间对象(秒数)
        /// <summary>
        /// 将该时间戳转换为时间对象(秒数)
        /// </summary>
        /// <param name="timestamp">秒级时间戳</param>
        /// <returns>时间对象</returns>
        public static DateTime TotalSecondsToDateTime(this long timestamp) {
            // 当地时区
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return startTime.AddSeconds(timestamp);
        }
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的毫秒数
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的毫秒数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>Javascript时间戳</returns>
        public static long DateTimeToTotalMilliseconds(this DateTime dt) {
            // 当地时区
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            // 相差毫秒数
            return (long)(dt - startTime).TotalMilliseconds;
        }
        #endregion

        #region 将该时间戳转换为时间对象(毫秒数)
        /// <summary>
        /// 将该时间戳转换为时间对象(毫秒数)
        /// </summary>
        /// <param name="timestamp">毫秒级时间戳</param>
        /// <returns>时间对象</returns>
        public static DateTime TotalMillisecondsToDateTime(this long timestamp)
        {
            // 当地时区
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return startTime.AddMilliseconds(timestamp);
        }
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的微秒时间戳
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的微秒时间戳
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>微秒时间戳</returns>
        public static long DateTimeToTotalMicroseconds(this DateTime dt) => new DateTimeOffset(dt).Ticks / 10;
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的纳秒时间戳
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的纳秒时间戳
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>纳秒时间戳</returns>
        public static long GetTotalNanoseconds(this DateTime dt) => new DateTimeOffset(dt).Ticks * 100 + Stopwatch.GetTimestamp() % 100;
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的分钟数
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的分钟数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>分钟数时间戳</returns>
        public static double GetTotalMinutes(this DateTime dt) => new DateTimeOffset(dt).Offset.TotalMinutes;
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的小时数
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的小时数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>小时数时间戳</returns>
        public static double GetTotalHours(this DateTime dt) => new DateTimeOffset(dt).Offset.TotalHours;
        #endregion

        #region 获取该时间相对于1970-01-01 00:00:00的天数
        /// <summary>
        /// 获取该时间相对于1970-01-01 00:00:00的天数
        /// </summary>
        /// <param name="dt">当前时间对象</param>
        /// <returns>天数时间戳</returns>
        public static double GetTotalDays(this DateTime dt) => new DateTimeOffset(dt).Offset.TotalDays;
        #endregion

        #region 返回本年有多少天
        /// <summary>
        /// 返回本年有多少天
        /// </summary>
        /// <param name="_"></param>
        /// <param name="iYear">年份</param>
        /// <returns>本年的天数</returns>
        public static int GetDaysOfYear(this DateTime _, int iYear) => IsRuYear(iYear) ? 366 : 365;
        #endregion

        #region 本年有多少天
        /// <summary>本年有多少天</summary>
        /// <param name="dt">日期</param>
        /// <returns>本天在当年的天数</returns>
        public static int GetDaysOfYear(this DateTime dt)
        {
            //取得传入参数的年份部分，用来判断是否是闰年
            int n = dt.Year;
            return IsRuYear(n) ? 366 : 365;
        }
        #endregion

        #region 本月有多少天
        /// <summary>本月有多少天</summary>
        /// <param name="_"></param>
        /// <param name="iYear">年</param>
        /// <param name="month">月</param>
        /// <returns>天数</returns>
        public static int GetDaysOfMonth(this DateTime _,int iYear,int month)
        {
            iYear = _.Year;
            month = _.Month;
            switch (month)
            {
                case 1: month = 31; break;
                case 2: month = IsRuYear(iYear) ? 29 : 28; break;
                case 3: month = 31; break;
                case 4: month = 30; break;
                case 5: month = 31; break;
                case 6: month = 30; break;
                case 7: month = 31; break;
                case 8: month = 31; break;
                case 9: month = 30; break;
                case 10: month = 31; break;
                case 11: month = 30; break;
                case 12: month = 31; break;
                default: month = 0; break;
            }
            return month;
        }
        #endregion

        #region 本月有多少天
        /// <summary>本月有多少天</summary>
        /// <param name="dt">日期</param>
        /// <returns>天数</returns>
        public static int GetDaysOfMonth(this DateTime dt)
        {
            //--利用年月信息，得到当前月的天数信息。

            switch (dt.Month)
            {
                case 1: return 31;
                case 2: return IsRuYear(dt.Year) ? 29 : 28;
                case 3: return 31;
                case 4: return 30;
                case 5: return 31;
                case 6: return 30;
                case 7: return 31;
                case 8: return 31;
                case 9: return 30;
                case 10: return 31;
                case 11: return 30;
                case 12: return 31;
                default: return 0;
            }
        }
        #endregion

        #region 返回当前日期的星期名称
        /// <summary>返回当前日期的星期名称</summary>
        /// <param name="idt">日期</param>
        /// <returns>星期名称</returns>
        public static string GetWeekNameOfDay(this DateTime idt)
        {
            switch (idt.DayOfWeek)
            {
                case DayOfWeek.Sunday:return "星期日";
                case DayOfWeek.Monday: return "星期一";
                case DayOfWeek.Tuesday: return "星期二";
                case DayOfWeek.Wednesday: return "星期三";
                case DayOfWeek.Thursday: return "星期四";
                case DayOfWeek.Friday: return "星期五";
                case DayOfWeek.Saturday: return "星期六";
            }
            return string.Empty;
        }
        #endregion

        #region 返回当前日期的星期编号
        /// <summary>
        /// 返回当前日期的星期编号
        /// </summary>
        /// <param name="idt">日期</param>
        /// <returns>星期数字编号</returns>
        public static int GetWeekNumberOfDay(this DateTime idt) => (int)idt.DayOfWeek;
        #endregion

        #region 判断当前年份是否是闰年
        /// <summary>
        /// 判断当前年份是否是闰年
        /// <para>私有函数</para>
        /// </summary>
        /// <param name="iYear">年份</param>
        /// <returns> 
        ///     <list>
        ///         <item>True:是闰年</item>
        ///         <item>False:不是闰年</item>
        ///     </list>
        /// </returns>
        private static bool IsRuYear(int iYear)
        {
            //形式参数为年份
            //例如：2003
            int n = iYear;
            return n % 400 == 0 || n % 4 == 0 && n % 100 != 0;
        }
        #endregion

        #region 判断是否为合法日期，必须大于1800年1月1日
        /// <summary>
        /// 判断是否为合法日期，必须大于1800年1月1日
        /// </summary>
        /// <param name="strDate">输入日期字符串</param>
        /// <returns><code>True/False</code></returns>
        public static bool IsDateTime(this string strDate)
        {
            DateTime.TryParse(strDate, out DateTime result);
            return result.CompareTo(DateTime.Parse("1800-1-1")) > 0;
        }
        #endregion

        #region 判断时间是否在区间内
        /// <summary>
        /// 判断时间是否在区间内
        /// </summary>
        /// <param name="this"></param>
        /// <param name="start">开始</param>
        /// <param name="end">结束</param>
        /// <param name="mode">模式</param>
        /// <returns></returns>
        public static bool In(this DateTime @this, DateTime start, DateTime end, RangeMode mode = RangeMode.Close)
        {
            switch (mode)
            {
                case RangeMode.Open: return start < @this && end > @this;
                case RangeMode.Close: return start <= @this && end >= @this;
                case RangeMode.OpenClose: return start < @this && end >= @this;
                case RangeMode.CloseOpen: return start <= @this && end > @this;
                default: throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
        #endregion
    }
}
