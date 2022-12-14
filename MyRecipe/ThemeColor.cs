using System.Collections.Generic;
using System.Drawing;

public static class ThemeColor
{
    public static Color PrimaryColor { get; set; }
    public static Color SecondaryColor { get; set; }
    public static List<string> ColorList = new List<string>() {
                                                                    "#9AD9D3",
                                                                    "#A5F2EB",
                                                                    "#ADCBD9",
                                                                    "#F7DBB2",
                                                                    "#E7BBED",
                                                                    
                                                                    };
    public static Color ChangeColorBrightness(Color color, double correctionFactor)
    {
        double red = color.R;
        double green = color.G;
        double blue = color.B;
        //If correction factor is less than 0, darken color.
        if (correctionFactor < 0)
        {
            correctionFactor = 1 + correctionFactor;
            red *= correctionFactor;
            green *= correctionFactor;
            blue *= correctionFactor;
        }
        //If correction factor is greater than zero, lighten color.
        else
        {
            red = (255 - red) * correctionFactor + red;
            green = (255 - green) * correctionFactor + green;
            blue = (255 - blue) * correctionFactor + blue;
        }
        return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
    }
}