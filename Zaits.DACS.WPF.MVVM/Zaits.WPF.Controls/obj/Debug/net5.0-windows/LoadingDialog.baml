   M S B A M L   `   `   `  ����M  IZaits.WPF.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ControlsControls  5          Controls.LoadingDialog   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Controls     5      ��5	      �� 5
   
   .R�5      � .+�5         Controls.DialogHost  $	��250��6&   $	��250��5   )       DialogHostOpacity$	  0.7Q�5   )      DialogHostCornerRadius$ 20��5   )   $��Center=�5   )   .��5      �  � ColumnDefinitions 5      �� 5      $��10 �6/   �� 5      $��* �6/   �� 5      $��30 �6/    � RowDefinitions 5      �� 5      $��10 �6,   �� 5      $��* �6,   �� 5      $��* �6,   .+�5         Controls.Spinner  $��1��6(   $��1��5   +      CircleBrush
 ��d�   CircleNumber$ 6��5!   +      CircleOpacity$	 0.8Q�5"   +      CircleRotation$ 	Clockwise=�5#   +      
CircleSize$ 15Q�5$   +   5&      �� 5(      $��0��6%   $��2��5)   !   $��3��5*   !   $��Center=�5+   !   $��
10 50 10 0q�5,   !   $
��Wrap=�5-   !   ��5.   !   �� *LoadingDialogText+	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType   Controls.LoadingDialog"  ��5/   !   �� *LoadingFontSize+	 �� $
 FindAncestor=�"  ��50   !   �� *LoadingFontFamily+	 �� $
 FindAncestor=�"  ��51   !   �� *LoadingFontWeight+	 �� $
 FindAncestor=�"  ��52   !   �� *LoadingForegroundColor+	 �� $
 FindAncestor=�"  56      57      58      59      5;      