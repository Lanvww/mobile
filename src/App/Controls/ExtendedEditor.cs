﻿using System;
using Xamarin.Forms;

namespace Bit.App.Controls
{
    public class ExtendedEditor : Editor
    {
        public ExtendedEditor()
        {
            TextColor = Color.FromHex("333333");
        }

        public static readonly BindableProperty HasBorderProperty =
            BindableProperty.Create(nameof(HasBorder), typeof(bool), typeof(ExtendedEditor), true);

        public bool HasBorder
        {
            get { return (bool)GetValue(HasBorderProperty); }
            set { SetValue(HasBorderProperty, value); }
        }
    }
}
