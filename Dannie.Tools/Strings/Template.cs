using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace System
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：System</para>
    /// <para>文件名：Template</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>工具类：模板引擎</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 13:56:21</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 13:56:21</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：4060f63a-0843-4a3c-990a-e731265704f5</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public class Template
    {
        #region 字段
        private string Content { get; set; }
        #endregion

        #region 构造函数
        /// <summary>
        /// 模版引擎
        /// </summary>
        /// <param name="content"></param>
        public Template(string content) =>  Content = content;
        #endregion

        #region 创建模板
        /// <summary>
        /// 创建模板
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static Template Create(string content) => new Template(content);
        #endregion

        #region 设置变量
        /// <summary>
        /// 设置变量
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Template Set(string key, string value)
        {
            Content = Content.Replace("{{" + key + "}}", value);
            return this;
        }
        #endregion

        #region 渲染模板
        /// <summary>
        /// 渲染模板
        /// </summary>
        /// <param name="check">是否检查未使用的模板变量</param>
        /// <returns></returns>
        public string Render(bool check = false)
        {
            var mc = Regex.Matches(Content, @"\{\{.+?\}\}");
            if (check)
                foreach (Match m in mc)
                    throw new ArgumentException($"模版变量{m.Value}未被使用");
            return Content;
        } 
        #endregion
    }
}
