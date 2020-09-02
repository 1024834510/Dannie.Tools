using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Dannie.Tools.Image
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：Dannie.Tools.Image</para>
    /// <para>文件名：ValidateCode</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>工具类：绘制验证码</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 14:21:34</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 14:21:34</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：f68bc9ad-9755-4cd4-8307-550a4e50cf99</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class ValidateCode
    {
        #region 生成验证码
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="length">指定验证码的长度</param>
        /// <returns>验证码字符串</returns>
        public static string CreateValidateCode(int length)
        {
            string ch = "abcdefghjkmnpqrstuvwxyzABCDEFGHJKMNPQRSTUVWXYZ1234567890@#$%&?";
            byte[] b = new byte[4];
            using (RNGCryptoServiceProvider cpt = new RNGCryptoServiceProvider())
            {
                cpt.GetBytes(b);
                var r = new Random(BitConverter.ToInt32(b, 0));
                var sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                    sb.Append(ch[r.Next(ch.Length)]);
                return sb.ToString();
            }
        } 
        #endregion

        #region 创建验证码的图片
        /// <summary>
        /// 创建验证码的图片
        /// </summary>
        /// <param name="validateCode">验证码序列</param>
        /// <param name="context">当前的HttpContext上下文对象</param>
        /// <param name="fontSize">字体大小，默认值22px</param>
        /// <param name="lineHeight">行高，默认36px</param>
        /// <exception cref="Exception">The operation failed.</exception>
        public static byte[] CreateValidateGraphic(this HttpContext context, string validateCode, int fontSize = 22, int lineHeight = 36)
        {
            using (Bitmap image = new Bitmap((int)Math.Ceiling(validateCode.Length * (fontSize + 2.0)), lineHeight))
            {
                using (Graphics g = Graphics.FromImage(image))
                {
                    //生成随机生成器
                    Random random = new Random();
                    //清空图片背景色
                    g.Clear(Color.White);
                    //画图片的干扰线
                    for (int i = 0; i < 75; i++)
                    {
                        int x1 = random.Next(image.Width);
                        int x2 = random.Next(image.Width);
                        int y1 = random.Next(image.Height);
                        int y2 = random.Next(image.Height);
                        g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                    }

                    Font[] fonts =
                    {
                        new Font("Arial", fontSize, FontStyle.Bold | FontStyle.Italic),
                        new Font("微软雅黑", fontSize, FontStyle.Bold | FontStyle.Italic),
                        new Font("黑体", fontSize, FontStyle.Bold | FontStyle.Italic),
                        new Font("宋体", fontSize, FontStyle.Bold | FontStyle.Italic),
                        new Font("楷体", fontSize, FontStyle.Bold | FontStyle.Italic)
                     };
                    //渐变.
                    using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true))
                    {
                        g.DrawString(validateCode, fonts[new Random().Next(fonts.Length)], brush, 3, 2);

                        //画图片的前景干扰点
                        for (int i = 0; i < 300; i++)
                        {
                            int x = random.Next(image.Width);
                            int y = random.Next(image.Height);
                            image.SetPixel(x, y, Color.FromArgb(random.Next()));
                        }

                        //画图片的边框线
                        g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                        //保存图片数据
                        using (MemoryStream stream = new MemoryStream())
                        {
                            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            //输出图片流
                            context.Response.Clear();
                            context.Response.ContentType = "image/jpeg";
                            return stream.ToArray();
                        }
                    }
                }
            }
        } 
        #endregion
    }
}
