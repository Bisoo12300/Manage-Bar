using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public static class RegionExtensions
{
    public static void MakeRoundedRect(this Region region, RectangleF rect, SizeF cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();

        float radiusX = cornerRadius.Width;
        float radiusY = cornerRadius.Height;
        float diameterX = 2 * radiusX;
        float diameterY = 2 * radiusY;

        path.AddArc(rect.Left, rect.Top, diameterX, diameterY, 180, 90);
        path.AddArc(rect.Right - diameterX, rect.Top, diameterX, diameterY, 270, 90);
        path.AddArc(rect.Right - diameterX, rect.Bottom - diameterY, diameterX, diameterY, 0, 90);
        path.AddArc(rect.Left, rect.Bottom - diameterY, diameterX, diameterY, 90, 90);
        path.CloseFigure();

        region.MakeEmpty();
        region.Union(path);
    }
}