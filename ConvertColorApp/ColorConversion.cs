using System;

namespace ConvertColorApp
{
    public static class ColorConversion
    {
        // Convert RGB to CMYK
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

        // Convert RGB to HSV
        public static (int, int, int) RGBtoHSV(int r, int g, int b)
        {
            float R = r / 255f;
            float G = g / 255f;
            float B = b / 255f;
            float max = Math.Max(R, Math.Max(G, B));
            float min = Math.Min(R, Math.Min(G, B));
            float h = 0, s = 0, v = max;

            float delta = max - min;
            if (max != 0)
                s = delta / max;

            if (s == 0)
                h = 0;
            else
            {
                if (R == max)
                    h = (G - B) / delta;
                else if (G == max)
                    h = 2 + (B - R) / delta;
                else
                    h = 4 + (R - G) / delta;

                h *= 60;
                if (h < 0)
                    h += 360;
            }

            h = (float)Math.Round(h);
            s = (float)Math.Round(s * 100);
            v = (float)Math.Round(v * 100);

            return ((int)h, (int)s, (int)v);
        }

        // Convert CMYK to RGB
        public static (int, int, int) CMYKtoRGB(int c, int m, int y, int k)
        {
            c = (int)((1 - Math.Min(1, c / 100f * (1 - k / 100f) + k / 100f)) * 255);
            m = (int)((1 - Math.Min(1, m / 100f * (1 - k / 100f) + k / 100f)) * 255);
            y = (int)((1 - Math.Min(1, y / 100f * (1 - k / 100f) + k / 100f)) * 255);

            return (c, m, y);
        }

        // Convert CMYK to HSV
        public static (int, int, int) CMYKtoHSV(int c, int m, int y, int k)
        {
            // Convert CMYK to RGB first
            var rgb = CMYKtoRGB(c, m, y, k);

            // Then convert RGB to HSV
            return RGBtoHSV(rgb.Item1, rgb.Item2, rgb.Item3);
        }

        // Convert HSV to RGB
        public static(int, int, int) HSVtoRGB(int H, int S, int V)
        {
            if (H > 360 || H < 0 || S > 100 || S < 0 || V > 100 || V < 0)
            {
                Console.WriteLine("The given HSV values are not in valid range");
                return (0, 0, 0);
            }

            float s = S / 100f;
            float v = V / 100f;
            float C = s * v;
            float X = C * (1 - Math.Abs((H / 60f) % 2 - 1));
            float m = v - C;
            float r = 0, g = 0, b = 0;

            if (H >= 0 && H < 60)
            {
                r = C;
                g = X;
            }
            else if (H >= 60 && H < 120)
            {
                r = X;
                g = C;
            }
            else if (H >= 120 && H < 180)
            {
                g = C;
                b = X;
            }
            else if (H >= 180 && H < 240)
            {
                g = X;
                b = C;
            }
            else if (H >= 240 && H < 300)
            {
                r = X;
                b = C;
            }
            else if (H >= 300 && H < 360)
            {
                r = C;
                b = X;
            }

            int R = (int)((r + m) * 255);
            int G = (int)((g + m) * 255);
            int B = (int)((b + m) * 255);

            return (R, G, B);
        }

        // Convert HSV to CMYK
        public static (int, int, int, int) HSVtoCMYK(int h, int s, int v)
        {
            // Convert HSV to RGB first
            var rgb = HSVtoRGB(h, s, v);

            // Then convert RGB to CMYK
            return RGBtoCMYK(rgb.Item1, rgb.Item2, rgb.Item3);
        }
    }
}
