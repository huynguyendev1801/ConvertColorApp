using OpenCvSharp;
using System;

namespace ConvertColorApp
{
    public static class ColorConversion
    {
        public static (int, int, int, int) RGBtoCMYK(int r, int g, int b)
        {
            float c = 1 - (float)r / 255;
            float m = 1 - (float)g / 255;
            float y = 1 - (float)b / 255;
            float k = Math.Min(c, Math.Min(m, y));

            if (k == 1)
                return (0, 0, 0, 100);
            else
            {
                c = (c - k) / (1 - k);
                m = (m - k) / (1 - k);
                y = (y - k) / (1 - k);
                k *= 100;
                c *= 100;
                m *= 100;
                y *= 100;
                return ((int)c, (int)m, (int)y, (int)k);
            }
        }

        /// <summary>
        /// Chuyển đổi giá trị màu từ không gian màu RGB sang HSV.
        /// </summary>
        /// <param name="r">Giá trị màu đỏ (0-255).</param>
        /// <param name="g">Giá trị màu xanh lá cây (0-255).</param>
        /// <param name="b">Giá trị màu xanh dương (0-255).</param>
        /// <returns>Tuple chứa giá trị Hue (0-360), Saturation (0-100) và Value (0-100) tương ứng.</returns>
        public static (int, int, int) RGBtoHSV(int r, int g, int b)
        {
            // Tạo ma trận RGB từ các giá trị màu đầu vào
            Mat rgbMat = new Mat(1, 1, MatType.CV_8UC3, new Scalar(b, g, r));

            // Tạo ma trận HSV để lưu trữ kết quả
            Mat hsvMat = new Mat();

            // Chuyển đổi không gian màu từ RGB sang HSV
            Cv2.CvtColor(rgbMat, hsvMat, ColorConversionCodes.BGR2HSV);

            // Lấy giá trị màu HSV từ ma trận kết quả
            Vec3b hsv = hsvMat.At<Vec3b>(0, 0);

            // Chia giá trị Hue cho 179 và nhân với 360 để chuyển từ 0-179 sang 0-360
            int hue = (int)((hsv.Item0 / 179.0) * 360.0);

            // Chia giá trị Saturation cho 255 và nhân với 100 để chuyển từ 0-255 sang 0-100
            int saturation = (int)((hsv.Item1 / 255.0) * 100.0);

            // Chia giá trị Value cho 255 và nhân với 100 để chuyển từ 0-255 sang 0-100
            int value = (int)((hsv.Item2 / 255.0) * 100.0);

            // Trả về tuple chứa giá trị Hue, Saturation và Value
            return (hue, saturation, value);
        }


        public static (int, int, int) CMYKtoRGB(int c, int m, int y, int k)
        {
            c = (int)((1 - Math.Min(1, c / 100f * (1 - k / 100f) + k / 100f)) * 255);
            m = (int)((1 - Math.Min(1, m / 100f * (1 - k / 100f) + k / 100f)) * 255);
            y = (int)((1 - Math.Min(1, y / 100f * (1 - k / 100f) + k / 100f)) * 255);

            return (c, m, y);
        }

   
        public static (int, int, int) CMYKtoHSV(int c, int m, int y, int k)
        {
       
            var rgb = CMYKtoRGB(c, m, y, k);

         
            return RGBtoHSV(rgb.Item1, rgb.Item2, rgb.Item3);
        }


        /// <summary>
        /// Chuyển đổi giá trị màu từ không gian màu HSV sang RGB.
        /// </summary>
        /// <param name="H">Giá trị Hue (0-360).</param>
        /// <param name="S">Giá trị Saturation (0-100).</param>
        /// <param name="V">Giá trị Value (0-100).</param>
        /// <returns>Tuple chứa giá trị màu RGB tương ứng.</returns>
        public static (int, int, int) HSVtoRGB(int H, int S, int V)
        {
            // Kiểm tra xem giá trị HSV có nằm trong phạm vi hợp lệ không
            if (H > 360 || H < 0 || S > 100 || S < 0 || V > 100 || V < 0)
            {
                Console.WriteLine("Các giá trị HSV không nằm trong phạm vi hợp lệ");
                return (0, 0, 0);
            }

            // Chuyển đổi giá trị HSV về phạm vi của OpenCV
            float h = H / 2.0f; // Scale hue from 0-360 to 0-180
            float s = S * 2.55f; // Scale saturation from 0-100 to 0-255
            float v = V * 2.55f; // Scale value from 0-100 to 0-255

            // Tạo ma trận HSV từ các giá trị màu đầu vào
            Mat hsvMat = new Mat(1, 1, MatType.CV_8UC3, new Scalar(h, s, v));

            // Tạo ma trận RGB để lưu trữ kết quả
            Mat rgbMat = new Mat();

            // Chuyển đổi không gian màu từ HSV sang RGB
            Cv2.CvtColor(hsvMat, rgbMat, ColorConversionCodes.HSV2BGR);

            // Lấy giá trị màu RGB từ ma trận kết quả
            Vec3b rgb = rgbMat.At<Vec3b>(0, 0);

            // Trả về tuple chứa giá trị màu RGB
            return (rgb.Item2, rgb.Item1, rgb.Item0); // OpenCV sử dụng BGR thay vì RGB
        }




        public static (int, int, int, int) HSVtoCMYK(int h, int s, int v)
        {
            var rgb = HSVtoRGB(h, s, v);

            return RGBtoCMYK(rgb.Item1, rgb.Item2, rgb.Item3);
        }
    }
}
