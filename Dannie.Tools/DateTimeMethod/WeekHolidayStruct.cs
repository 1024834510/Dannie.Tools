namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 付冰玉昊 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：WeekHolidayStruct</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>结构体：节假日信息</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 12:36:43</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 12:36:43</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：5a4bd91b-46a8-4ac2-8929-7d299afa4b98</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public struct WeekHolidayStruct
    {
        /// <summary>
        /// 月
        /// </summary>
        public readonly int Month;

        /// <summary>
        /// 这个月第几周
        /// </summary>
        public readonly int WeekAtMonth;

        /// <summary>
        /// 周末日
        /// </summary>
        public readonly int WeekDay;

        /// <summary>
        /// 假日名
        /// </summary>
        public readonly string HolidayName;

        /// <summary>
        /// 节假日信息
        /// </summary>
        /// <param name="month"></param>
        /// <param name="weekAtMonth"></param>
        /// <param name="weekDay"></param>
        /// <param name="name"></param>
        public WeekHolidayStruct(int month, int weekAtMonth, int weekDay, string name)
        {
            Month = month;
            WeekAtMonth = weekAtMonth;
            WeekDay = weekDay;
            HolidayName = name;
        }
    }
}
