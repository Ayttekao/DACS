using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zaits.WPF.MVVM.Core.Command;

namespace Controls
{
    public partial class NumericUpDown : UserControl
    {
        private ICommand _downButtonCommand;
        private ICommand _upButtonCommand;
        
        public NumericUpDown()
        {
            InitializeComponent();
        }
        public ICommand LeftButtonCommand =>
            _downButtonCommand ??= new RelayCommand(_ =>
            {
                TargetValue -= TargetValueStep;
            });

        public ICommand RightButtonCommand =>
            _upButtonCommand ??= new RelayCommand(_ =>
            {
                TargetValue += TargetValueStep;
            });
        
        
        public int TargetValueMinBound
        {
            get =>
                (int)GetValue(TargetValueMinBoundProperty);

            set =>
                SetValue(TargetValueMinBoundProperty, value);
        }
        public static readonly DependencyProperty TargetValueMinBoundProperty = DependencyProperty.Register(
            nameof(TargetValueMinBound), typeof(int), typeof(NumericUpDown), new PropertyMetadata(1));

        public int TargetValueMaxBound
        {
            get =>
                (int)GetValue(TargetValueMaxBoundProperty);

            set =>
                SetValue(TargetValueMaxBoundProperty, value);
        }
        public static readonly DependencyProperty TargetValueMaxBoundProperty = DependencyProperty.Register(
            nameof(TargetValueMaxBound), typeof(int), typeof(NumericUpDown), new PropertyMetadata(100));

        public int TargetValueStep
        {
            get =>
                (int)GetValue(TargetValueStepProperty);

            set =>
                SetValue(TargetValueStepProperty, value);
        }
        public static readonly DependencyProperty TargetValueStepProperty = DependencyProperty.Register(
            nameof(TargetValueStep), typeof(int), typeof(NumericUpDown), new PropertyMetadata(1));

        public int TargetValue
        {
            get =>
                (int)GetValue(TargetValueProperty);

            set =>
                SetValue(TargetValueProperty, value);
        }
        public static readonly DependencyProperty TargetValueProperty = DependencyProperty.Register(
            nameof(TargetValue), typeof(int), typeof(NumericUpDown), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                (_, _) => { }, (d, e) =>
                {
                    var targetControl = d as NumericUpDown;
                    if (e is not int @int)
                    {
                        throw new ArgumentException("Invalid value type", nameof(e));
                    }
                
                    if (targetControl != null && @int < targetControl.TargetValueMinBound)
                    {
                        @int = targetControl.TargetValueMinBound;
                    }
                    else if (targetControl != null && @int > targetControl.TargetValueMaxBound)
                    {
                        @int = targetControl.TargetValueMaxBound;
                    }
                
                    return @int;
                }, true, System.Windows.Data.UpdateSourceTrigger.PropertyChanged), targetValue =>
            {
                if (targetValue is not int @int)
                {
                    return false;
                }

                return true;
            }
            );

    }
}