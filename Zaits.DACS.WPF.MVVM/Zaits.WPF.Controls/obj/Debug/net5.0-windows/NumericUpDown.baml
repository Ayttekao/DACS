   M S B A M L   `   `   `  ����M  IZaits.WPF.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ControlsControls  5          Controls.NumericUpDown   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Controls     5        � 	Resources  5	       �� 
TargetType �� Property �� Value �� RelativeSource �� Mode �� AncestorType   Controls.NumericUpDown��%�   '��       �� 5
   
   " ��6   �5      �� 5       � �� 5      �� *
FontSize+ �� $ FindAncestor=�"  5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��80 �6   .+�5   
   �� $��1��6   $��0��6%   .+�5      �� $��30��6   $��0 10 0 0q�5      $��20(�5      $
��Bold"�5      
�������$��0q�5      $��+��5       ��5!      �� *RightButtonCommand+ �� $ FindAncestor=�"  �� 5#      $��30��6   $��0 0 0 10q�5$      $
��Bold"�5%      
�������$��20(�5'      $��-��5(      $��0q�5)      ��5*      �� *LeftButtonCommand+ �� $ FindAncestor=�"  5,      �� 5.   
   $��0��6   $��0��6$   $��Center=�5/      	 �� TextAlignment$	 Center=�50      $��5q�51      ��52      �� *TargetValue+
 �� Mode$
 OneWay=� �� StringFormat$ D�� �� $ FindAncestor=�"  54      55      