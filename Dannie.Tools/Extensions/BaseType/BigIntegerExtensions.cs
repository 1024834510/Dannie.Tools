using System.Numerics;

namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：BigIntegerExtensions</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>扩展：BigInteger扩展</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 13:32:49</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 13:32:49</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：6c1d2273-deea-4c88-a5cc-e72af04c2bf8</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class BigIntegerExtensions
    {
        #region 十进制转任意进制
        /// <summary>
        /// 十进制转任意进制
        /// </summary>
        /// <param name="num"></param>
        /// <param name="bin">进制</param>
        /// <returns></returns>
        public static string ToBinary(this BigInteger num, int bin)
        {
            var nf = new NumberFormater(bin);
            return nf.ToString(num);
        } 
        #endregion
    }
}
