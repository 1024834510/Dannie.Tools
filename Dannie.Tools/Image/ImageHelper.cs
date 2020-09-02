using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace System.Drawing
{
    /// <summary>
    /// ----------------------------------------------------------------
    /// <para>Copyright(©) 2020 Reserved by 常德市隆宝软件开发有限公司 版权所有。</para>
    /// <para>命名空间：System.Drawing</para>
    /// <para>文件名：ImageHelper</para>
    /// <para>
    ///     文件功能描述：
    ///         <para>扩展工具类：图像操作</para>
    /// </para>
    /// <para>创建者：付冰玉昊 (Administrator)</para>
    /// <para>创建时间：2020-09-02 14:27:55</para>
    /// <para>修改人：付冰玉昊 (Administrator)</para>
    /// <para>修改时间：2020-09-02 14:27:55</para>
    /// <para>修改说明：</para>
    /// <para>测试人：</para>
    /// <para>测试时间：</para>
    /// <para>测试描述：</para>
    /// <para>审核人：</para>
    /// <para>审核时间：</para>
    /// <para>审核意见：</para>
    /// <para>系统CLR版本号:4.0.30319.42000</para>
    /// <para>编号：805e7492-fef5-4269-bb91-fd0bb9b1c814</para>
    /// <para>机器名：TIANKONGCHENGZH</para>
    /// <para>组织名：</para>
    /// <para>用户域：TIANKONGCHENGZH</para>
    /// <para>版本：V1.0.0</para>
    /// <para>----------------------------------------------------------------</para>
    /// </summary>
    public static class ImageHelper
    {
        #region 将图片修改至指定尺寸
        /// <summary>
        /// 将图片修改至指定尺寸
        /// <para>适用于放大与缩小</para>
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <param name="size">指定尺寸</param>
        /// <returns>按指定尺寸缩小后的图片</returns>
        public static Image ModifySize(this Image image, Size size)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.Resize(src, src, new OpenCvSharp.Size(size.Width, size.Height), 0, 0, InterpolationFlags.Linear);
                return src.ToBitmap();
            }
        }
        #endregion

        #region 旋转
        /// <summary>
        /// 旋转
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <param name="angle">角度</param>
        /// <returns>旋转后的图像</returns>
        public static Image Rotate(this Image image, float angle)
        {
            using (Mat dst = new Bitmap(image).ToMat())
            {
                Point2f center = new Point2f(dst.Cols / 2, dst.Rows / 2);
                using (Mat rot = Cv2.GetRotationMatrix2D(center, -angle, 1))
                {
                    Size2f s2f = new Size2f(dst.Size().Width, dst.Size().Height);
                    Rect box = new RotatedRect(new Point2f(0, 0), s2f, -angle).BoundingRect();
                    double xx = rot.At<double>(0, 2) + box.Width / 2 - dst.Cols / 2, zz = rot.At<double>(1, 2) + box.Height / 2 - dst.Rows / 2;
                    rot.Set(0, 2, xx);
                    rot.Set(1, 2, zz);
                    Cv2.WarpAffine(dst, dst, rot, box.Size);
                    GC.SuppressFinalize(s2f);
                    GC.SuppressFinalize(box);
                    GC.SuppressFinalize(xx);
                    GC.SuppressFinalize(zz);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    return dst.ToBitmap();
                }
            }
        }
        #endregion

        #region 翻转
        /// <summary>
        /// 翻转
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <param name="FlipMode">指定如何翻转</param>
        /// <returns>翻转后的图像</returns>
        public static Image Rolling_Over(this Image image, FlipMode FlipMode)
        {
            try
            {
                using (Mat src = new Bitmap(image).ToMat())
                {
                    Cv2.Flip(src, src, FlipMode);
                    return src.ToBitmap();
                }
            }
            catch (Exception)
            {
                return image;
            }
        }
        #endregion

        #region 方框滤波
        /// <summary>
        /// 方框滤波
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image BoxFiltering(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.BoxFilter(src, src, -1, new OpenCvSharp.Size(5, 5));
                return src.ToBitmap();
            }
        }
        #endregion

        #region 均值滤波
        /// <summary>
        /// 均值滤波
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image AverageFiltering(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.Blur(src, src, new OpenCvSharp.Size(5, 5));
                return src.ToBitmap();
            }
        }
        #endregion

        #region 高斯滤波
        /// <summary>
        /// 高斯滤波
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image GaussianFilter(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.GaussianBlur(src, src, new OpenCvSharp.Size(5, 5), 0, 0);
                return src.ToBitmap();
            }
        }
        #endregion

        #region 中值滤波
        /// <summary>
        /// 中值滤波
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image MedianFilter(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.MedianBlur(src, src, 5);
                return src.ToBitmap();
            }
        }
        #endregion

        #region 双边滤波
        /// <summary>
        /// 双边滤波
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image BilateralFilter(this Bitmap bmp)
        {
            try
            {
                using (Mat src = bmp.ToMat())
                {
                    using (Mat result = new Mat())
                    {
                        Cv2.BilateralFilter(src, result, 25, 25 * 2, 25 / 2);
                        return result.ToBitmap();
                    }
                }
            }
            catch (OpenCVException)
            {
                return bmp;
            }
        }
        #endregion

        #region 膨胀
        /// <summary>
        /// 膨胀
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image Swell(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.Dilate(src, src, new Mat());
                return src.ToBitmap();
            }
        }
        #endregion

        #region 腐蚀
        /// <summary>
        /// 腐蚀
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image Corrosion(Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                Cv2.Erode(src, src, new Mat());
                return src.ToBitmap();
            }
        }
        #endregion

        #region 开运算
        /// <summary>
        /// 开运算
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image OpenOperation(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                using (Mat element5 = new Mat(5, 5, MatType.CV_8U, new Scalar(1)))
                {
                    Cv2.MorphologyEx(src, src, MorphTypes.Open, element5);
                    return src.ToBitmap();
                }
            }
        }
        #endregion

        #region 闭运算
        /// <summary>
        /// 闭运算
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image ClosedPperation(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                using (Mat element5 = new Mat(5, 5, MatType.CV_8U, new Scalar(1)))
                {
                    Cv2.MorphologyEx(src, src, MorphTypes.Close, element5);
                    return src.ToBitmap();
                }
            }
        }
        #endregion

        #region 形态性梯度
        /// <summary>
        /// 形态性梯度
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image MorphologicGradientMorphologicGradient(this Bitmap image)
        {
            using (Mat src = image.ToMat())
            {
                using (Mat element5 = new Mat(5, 5, MatType.CV_8U, new Scalar(1)))
                {
                    Cv2.MorphologyEx(src, src, MorphTypes.Gradient, element5);
                    return src.ToBitmap();
                }
            }
        }
        #endregion

        #region 顶帽
        /// <summary>
        /// 顶帽
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image TopHat(this Bitmap image)
        {
            using (Mat src = image.ToMat())
            {
                using (Mat element5 = new Mat(5, 5, MatType.CV_8U, new Scalar(1)))
                {
                    Cv2.MorphologyEx(src, src, MorphTypes.TopHat, element5);
                    return src.ToBitmap();
                }
            }
        }
        #endregion

        #region 黑帽
        /// <summary>
        /// 黑帽
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image BlackHat(this Bitmap image)
        {
            using (Mat src = image.ToMat())
            {
                using (Mat element5 = new Mat(5, 5, MatType.CV_8U, new Scalar(1)))
                {
                    Cv2.MorphologyEx(src, src, MorphTypes.BlackHat, element5);
                    return src.ToBitmap();
                }
            }
        }
        #endregion

        #region 灰度化
        /// <summary>
        /// 灰度化
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image Graying(this Bitmap image)
        {
            using (Mat src = image.ToMat())
                return src.CvtColor(ColorConversionCodes.BGR2GRAY).ToBitmap();
        }
        #endregion

        #region sobelX
        /// <summary>
        /// sobel算子(sobelX)
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image sobelX(this Image image) {
            using (Mat src = new Bitmap(image).ToMat())
            {
                using (Mat sobelX = new Mat())
                {
                    Cv2.Sobel(src, sobelX, MatType.CV_8U, 1, 0, 3, 0.4, 128);
                    return sobelX.ToBitmap();
                }
            }
        }
        #endregion

        #region sobelY
        /// <summary>
        /// sobel算子(sobelX)
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image sobelY(this Image image)
        {
            using (Mat src = new Bitmap(image).ToMat())
            {
                using (Mat sobelY = new Mat())
                {
                    Cv2.Sobel(src, sobelY, MatType.CV_8U, 0, 1, 3, 0.4, 128);
                    return sobelY.ToBitmap();
                }
            }
        }
        #endregion

        #region 模
        /// <summary>
        /// 模
        /// </summary>
        /// <param name="image">图片对象</param>
        /// <returns></returns>
        public static Image Model(this Bitmap image) {
            using (Mat src = image.ToMat())
            {
                using (Mat sobelX = new Mat())
                {
                    Cv2.Sobel(src, sobelX, MatType.CV_8U, 1, 0, 3, 0.4, 128);
                    using (Mat sobelY = new Mat())
                    {
                        Cv2.Sobel(src, sobelY, MatType.CV_8U, 0, 1, 3, 0.4, 128);

                        Cv2.Sobel(src, sobelX, MatType.CV_16S, 1, 0);
                        Cv2.Sobel(src, sobelY, MatType.CV_16S, 0, 1);

                        // 计算L1模
                        using (Mat sobel = sobelX.Abs() + sobelY.Abs())
                        {
                            double sobmin, sobmax;
                            OpenCvSharp.Point minLoc, maxLoc;
                            Cv2.MinMaxLoc(sobel, out sobmin, out sobmax, out minLoc, out maxLoc);

                            using (Mat sobelL1Image = new Mat())
                            {
                                sobel.ConvertTo(sobelL1Image, MatType.CV_8U, -255.0 / sobmax, 255);
                                return sobelL1Image.ToBitmap();
                            }
                        }
                    }
                    
                }
            }
        }
        #endregion
    }
}

