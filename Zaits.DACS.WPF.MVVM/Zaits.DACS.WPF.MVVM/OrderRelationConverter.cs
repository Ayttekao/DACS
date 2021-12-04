using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using Zaits.WPF.MVVM.Core.Annotations;
using Zaits.WPF.MVVM.Core.Converter;

namespace Zaits.DACS.WPF.MVVM
{
    // 0 left 1 right 2 comparator (2 is IComparable)
    // if (values.Lenght == 3)
    //{
    //if (values[3]
    public class OrderRelationConverter : MultiConverterBase<OrderRelationConverter>
    {
        public enum OrderRelationOperations
        {
            More,
            MoreOrEqual,
            Less,
            LessOrEqual
        }
        public override object Convert([NotNull] object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null) 
                throw new ArgumentNullException(nameof(values));
            
            if (values.Length == 0) 
                throw new ArgumentException("Value cannot be an empty collection.", nameof(values));
            
            if (!(Enum.IsDefined(typeof(OrderRelationOperations), parameter)))
            {
                throw new ArgumentException("parameter should be of type Order Relation Operations", 
                    nameof(parameter));
            }

            if (values[0] == DependencyProperty.UnsetValue ||
                values[1] == DependencyProperty.UnsetValue)
            {
                return DependencyProperty.UnsetValue;
            }

            int comparationResult;
            var leftOperand = (dynamic)values[0];
            var rightOperand = (dynamic)values[1];
            
            if (values.Length == 3 && values[2] is IComparer<object>)
            {
                var comparator = (dynamic)values[2];
                comparationResult = comparator.Compare(leftOperand, rightOperand);
            }
            else
                comparationResult = leftOperand.CompareTo(rightOperand);

            return parameter switch
            {
                OrderRelationOperations.More => comparationResult > 0,
                OrderRelationOperations.MoreOrEqual => comparationResult >= 0,
                OrderRelationOperations.Less => comparationResult < 0,
                OrderRelationOperations.LessOrEqual => comparationResult <= 0,
                _ => throw new ArgumentException("Invalid operation", nameof(parameter))
            };
        }
    }
}