﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;

namespace ChordnomiconWebApplication.Images
{
    public static class RandomColorFactory
    {
        public static Brush GetRandomColor()
        {
            Random seed = new Random();
            List<Brush> brushes = new List<Brush>();
            
            brushes.Add(Brushes.AliceBlue);
            brushes.Add(Brushes.Aqua);
            brushes.Add(Brushes.Aquamarine);
            brushes.Add(Brushes.Azure);
            brushes.Add(Brushes.Bisque);
            brushes.Add(Brushes.Blue);
            brushes.Add(Brushes.BlueViolet);
            brushes.Add(Brushes.BurlyWood);
            brushes.Add(Brushes.CadetBlue);
            brushes.Add(Brushes.Chartreuse);
            brushes.Add(Brushes.Chocolate);
            brushes.Add(Brushes.Coral);
            brushes.Add(Brushes.CornflowerBlue);
            brushes.Add(Brushes.Cornsilk);
            brushes.Add(Brushes.Crimson);
            brushes.Add(Brushes.Cyan);
            brushes.Add(Brushes.DarkBlue);
            brushes.Add(Brushes.DarkCyan);
            brushes.Add(Brushes.DarkGoldenrod);
            brushes.Add(Brushes.DarkGreen);
            brushes.Add(Brushes.DarkMagenta);
            brushes.Add(Brushes.DarkOliveGreen);
            brushes.Add(Brushes.DarkOrange);
            brushes.Add(Brushes.DarkOrchid);
            brushes.Add(Brushes.DarkRed);
            brushes.Add(Brushes.DarkSalmon);
            brushes.Add(Brushes.DarkSeaGreen);
            brushes.Add(Brushes.DarkSlateBlue);
            brushes.Add(Brushes.DarkTurquoise);
            brushes.Add(Brushes.DarkViolet);
            brushes.Add(Brushes.DeepPink);
            brushes.Add(Brushes.DeepSkyBlue);
            brushes.Add(Brushes.DodgerBlue);
            brushes.Add(Brushes.Firebrick);
            brushes.Add(Brushes.ForestGreen);
            brushes.Add(Brushes.Fuchsia);
            brushes.Add(Brushes.Gainsboro);
            brushes.Add(Brushes.Gold);
            brushes.Add(Brushes.Goldenrod);
            brushes.Add(Brushes.Green);
            brushes.Add(Brushes.GreenYellow);
            brushes.Add(Brushes.Honeydew);
            brushes.Add(Brushes.HotPink);
            brushes.Add(Brushes.IndianRed);
            brushes.Add(Brushes.Indigo);
            brushes.Add(Brushes.Lavender);
            brushes.Add(Brushes.LavenderBlush);
            brushes.Add(Brushes.LawnGreen);
            brushes.Add(Brushes.LemonChiffon);
            brushes.Add(Brushes.LightBlue);
            brushes.Add(Brushes.LightCoral);
            brushes.Add(Brushes.LightCyan);
            brushes.Add(Brushes.LightGoldenrodYellow);
            brushes.Add(Brushes.LightGreen);
            brushes.Add(Brushes.LightPink);
            brushes.Add(Brushes.LightSalmon);
            brushes.Add(Brushes.LightSeaGreen);
            brushes.Add(Brushes.LightSkyBlue);
            brushes.Add(Brushes.LightSteelBlue);
            brushes.Add(Brushes.LightYellow);
            brushes.Add(Brushes.Lime);
            brushes.Add(Brushes.LimeGreen);
            brushes.Add(Brushes.Linen);
            brushes.Add(Brushes.Magenta);
            brushes.Add(Brushes.Maroon);
            brushes.Add(Brushes.MediumAquamarine);
            brushes.Add(Brushes.MediumBlue);
            brushes.Add(Brushes.MediumOrchid);
            brushes.Add(Brushes.MediumPurple);
            brushes.Add(Brushes.MediumSeaGreen);
            brushes.Add(Brushes.MediumSlateBlue);
            brushes.Add(Brushes.MediumSpringGreen);
            brushes.Add(Brushes.MediumTurquoise);
            brushes.Add(Brushes.MediumVioletRed);
            brushes.Add(Brushes.MidnightBlue);
            brushes.Add(Brushes.MintCream);
            brushes.Add(Brushes.MistyRose);
            brushes.Add(Brushes.Navy);
            brushes.Add(Brushes.OldLace);
            brushes.Add(Brushes.Olive);
            brushes.Add(Brushes.OliveDrab);
            brushes.Add(Brushes.Orange);
            brushes.Add(Brushes.OrangeRed);
            brushes.Add(Brushes.Orchid);
            brushes.Add(Brushes.PaleGoldenrod);
            brushes.Add(Brushes.PaleGreen);
            brushes.Add(Brushes.PaleTurquoise);
            brushes.Add(Brushes.PaleVioletRed);
            brushes.Add(Brushes.PapayaWhip);
            brushes.Add(Brushes.PeachPuff);
            brushes.Add(Brushes.Peru);
            brushes.Add(Brushes.Pink);
            brushes.Add(Brushes.Plum);
            brushes.Add(Brushes.PowderBlue);
            brushes.Add(Brushes.Purple);
            brushes.Add(Brushes.Red);
            brushes.Add(Brushes.RosyBrown);
            brushes.Add(Brushes.RoyalBlue);
            brushes.Add(Brushes.SaddleBrown);
            brushes.Add(Brushes.Salmon);
            brushes.Add(Brushes.SandyBrown);
            brushes.Add(Brushes.SeaGreen);
            brushes.Add(Brushes.SeaShell);
            brushes.Add(Brushes.Sienna);
            brushes.Add(Brushes.Silver);
            brushes.Add(Brushes.SkyBlue);
            brushes.Add(Brushes.SlateBlue);
            brushes.Add(Brushes.SpringGreen);
            brushes.Add(Brushes.SteelBlue);
            brushes.Add(Brushes.Teal);
            brushes.Add(Brushes.Thistle);
            brushes.Add(Brushes.Tomato);
            brushes.Add(Brushes.Turquoise);
            brushes.Add(Brushes.Violet);
            brushes.Add(Brushes.Wheat);
            brushes.Add(Brushes.Yellow);
            brushes.Add(Brushes.YellowGreen);

            return brushes.ElementAt(seed.Next(brushes.Count()));
        }
    }
}