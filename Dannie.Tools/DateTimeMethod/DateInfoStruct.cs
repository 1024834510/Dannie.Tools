namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 付冰玉昊  版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：DateInfoStruct</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>结构体：日期信息</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 12:35:32</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 12:35:32</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：e5868761-53a1-419a-8ef4-9e87d26ebcfc</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public struct DateInfoStruct
    {
        /// <summary>
        /// 月
        /// </summary>
        public readonly int Month;

        /// <summary>
        /// 日
        /// </summary>
        public readonly int Day;

        /// <summary>
        /// 假期长度
        /// </summary>
        public readonly int Recess;

        /// <summary>
        /// 节假日名
        /// </summary>
        public readonly string HolidayName;

        /// <summary>
        /// 日期信息
        /// </summary>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="recess"></param>
        /// <param name="name"></param>
        public DateInfoStruct(int month, int day, int recess, string name)
        {
            Month = month;
            Day = day;
            Recess = recess;
            HolidayName = name;
        }
    }
}
