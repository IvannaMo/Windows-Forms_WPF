   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � SizeToContent$  WidthAndHeight=�5   	    � Title$ 
MainWindow��5	   	   .��5
      � ���#faf7f5 � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   o� ���#f89545$��5q�6$   
���������60   ��  �� ElementName$
 sldr�� �� Path$ Value�.@�5      m� $
��File��6   5      m� 5      $��About��6   5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��15 �6#   60   �� 5      $��1* �6#   60   �� 5      $��10 �6#   60   �� 5      $	��200 �6#   61   �� 5      $��15 �6#   60    5"      �� 5#      $��15 �6    6.   �� 5$      $��* �6    6-   �� 5%      $
��Auto �6    60   �� 5&      $��15 �6    6.   .+�5*      �  � Orientation$ Vertical=�6   $��Center=�6/   $��1��6L   $��1��6\   ���#ee7e25.+�5+      �� $��10q�6   
���������6$   �� $
 sldr��$ Value�.��6i   Lorem ipsum6v   �� 5-      $��Click Me��6   $��10q�6,   $��5q�68   ���#fbb549
�������$��0q�6�   ��6D   �� $
 sldr��$ Value�6�   5.      �� 51      $��3��6   $��1��6&   $��10q�63   ���#f2ece2 �� TextWrapping$
 Wrap=�6�   $��0q�6�   ��6@   �� $
 sldr��$ Value�6�   �� 54      -   5        $
��sldr��54      $��1��6!   $��3��61   $��2��6E   $��10q�6R    � Minimum$ 12Q�6^   	 � Maximum$	 50Q�6k   56      57      58      59      