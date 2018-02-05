﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactTracing.Controls
{
    public class LightOnDarkCircleButton : Button
    {
        static LightOnDarkCircleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LightOnDarkCircleButton), new FrameworkPropertyMetadata(typeof(LightOnDarkCircleButton)));
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(LightOnDarkCircleButton), new PropertyMetadata(String.Empty));
        public string Text
        {
            get
            {
                return (this.GetValue(TextProperty)).ToString();
            }
            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData", typeof(string), typeof(LightOnDarkCircleButton));
        public string PathData
        {
            get
            {
                return (this.GetValue(PathDataProperty)).ToString();
            }
            set
            {
                this.SetValue(PathDataProperty, value);
            }
        }
    }
}
