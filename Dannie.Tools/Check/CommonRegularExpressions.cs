using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dannie.Tools.Check
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 付冰玉昊  版权所有。</para>
    /// <para>命名空间：Dannie.Tools.Check</para>
    /// <para>文件名：CommonRegularExpressions</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>工具类：常用正则表达式</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 10:02:21</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 10:02:21</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：5a8e9130-187a-47df-a5aa-6dea1eeaaea3</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    internal static class CommonRegularExpressions
    {
        /// <summary>
        /// 纯数字
        /// </summary>
        public const string CheckNumber = "^[0-9]*$";

        /// <summary>
        /// n位的数字
        /// </summary>
        public const string CheckNDigitNumbers = @"^\d{5}$";

        /// <summary>
        /// 至少n位的数字
        /// </summary>
        public const string CheckAtLeastNDigits= @"^\d{n,}$";

        /// <summary>
        /// m-n位的数字
        /// </summary>
        public const string CheckMMinusNDigits = @"^\d{m,n}$";

        /// <summary>
        /// 零和非零开头的数字
        /// </summary>
        public const string CheckZeroAndBonzeroDigits = "^(0|[1-9][0-9]*)$";

        /// <summary>
        /// 非零开头的最多带两位小数的数字
        /// </summary>
        public const string NonZeroStart = "^([1-9][0-9]*)+(.[0-9]{1,2})?$";

        /// <summary>
        /// 带1-2位小数的正数或负数
        /// </summary>
        public const string PositiveOrNegative = @"^(\-)?\d+(\.\d{1,2})?$";

        /// <summary>
        /// 正数、负数、和小数
        /// </summary>
        public const string RealNumber  = @"^(\-|\+)?\d+(\.\d+)?$";

        /// <summary>
        /// 有两位小数的正实数
        /// </summary>
        public const string RealNumber2 = @"^[0-9]+(.[0-9]{2})?$";

        /// <summary>
        /// 有1 ~3位小数的正实数
        /// </summary>
        public const string RealNumber3 = "^[0-9]+(.[0-9]{1,3})?$";

        /// <summary>
        /// 非零的正整数
        /// </summary>
        public const string PositiveIntegersThatAreNotZero = @"^[1 - 9]\d*$";

        /// <summary>
        /// 非零的正整数
        /// </summary>
        public const string PositiveIntegersThatAreNotZero2 = @"^([1-9][0-9]*){1,3}$";

        /// <summary>
        /// 非零的正整数
        /// </summary>
        public const string PositiveIntegersThatAreNotZero3 = @"^\+?[1-9][0-9]*$";

        /// <summary>
        /// 非零的负整数
        /// </summary>
        public const string NegativeIntegersThatAreNotZero = @"^-[1-9]\d*$";

        /// <summary>
        /// 非零的负整数
        /// </summary>
        public const string NegativeIntegersThatAreNotZero2 = @"^-[1-9]\d*$";

        /// <summary>
        /// 非负整数
        /// </summary>
        public const string NonNegativeInteger = @"^\d+$";

        /// <summary>
        /// 非负整数
        /// </summary>
        public const string NonNegativeInteger2 = @"^[1-9]\d*|0$";

        /// <summary>
        /// 非正整数
        /// </summary>
        public const string PositiveInteger = @"^-[1-9]\d*|0$";

        /// <summary>
        /// 非正整数
        /// </summary>
        public const string PositiveInteger2 = @"^((-\d+)|(0+))$";

        /// <summary>
        /// 非负浮点数
        /// </summary>
        public const string NonNegativeFloatingPointNumber = @"^\d+(\.\d+)?$";

        /// <summary>
        /// 非负浮点数
        /// </summary>
        public const string NonNegativeFloatingPointNumber2 = @"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0$";

        /// <summary>
        /// 非正浮点数
        /// </summary>
        public const string NonPositiveFloatingPointNumber = @"^((-\d+(\.\d+)?)|(0+(\.0+)?))$";

        /// <summary>
        /// 非正浮点数
        /// </summary>
        public const string NonPositiveFloatingPointNumber2 = @"^(-([1-9]\d*\.\d*|0\.\d*[1-9]\d*))|0?\.0+|0$";

        /// <summary>
        /// 正浮点数
        /// </summary>
        public const string AreFloatingPointNumbers = @"^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$";

        /// <summary>
        /// 正浮点数
        /// </summary>
        public const string AreFloatingPointNumbers2 = @"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$";

        /// <summary>
        /// 负浮点数
        /// </summary>
        public const string NegativeFloatingPointNumber = @"^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$";

        /// <summary>
        /// 负浮点数
        /// </summary>
        public const string NegativeFloatingPointNumber2 = @"^(-(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*)))$";

        /// <summary>
        /// 浮点数
        /// </summary>
        public const string FloatingPointNumber = @"^(-?\d+)(\.\d+)?$";

        /// <summary>
        /// 浮点数
        /// </summary>
        public const string FloatingPointNumber2 = @"^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$";

        /// <summary>
        /// 汉字
        /// </summary>
        public const string ChineseCharacters = @"^[\u4E00-\u9FFC]*$";

        /// <summary>
        /// 英文和数字
        /// </summary>
        public const string EnglishAndNumbers = @"^[A-Za-z0-9]+$";

        /// <summary>
        /// 检查字符串长度
        /// </summary>
        public const string CharacterSize = @"^[\s\S]{n,m}$";

        /// <summary>
        /// 由26个英文字母组成的字符串
        /// </summary>
        public const string StringOf26EnglishLetters = @"^[A-Za-z]+$";

        /// <summary>
        /// 由26个大写英文字母组成的字符串
        /// </summary>
        public const string StringOf26UppercaseLetters = @"^[A-Z]+$";

        /// <summary>
        /// 由26个小写英文字母组成的字符串
        /// </summary>
        public const string StringOf26LowercaseEnglishLetters = @"^[a-z]+$";


    }
}
