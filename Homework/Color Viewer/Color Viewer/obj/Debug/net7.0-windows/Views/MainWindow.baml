   M S B A M L   `   `   `  ����G  CColor Viewer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Color_ViewerColor_Viewer  5   	       Color_Viewer.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Color_Viewer     5   	     � Title$  Color Viewer��5   	    � SizeToContent$ WidthAndHeight=�5	   	    � 
ResizeMode$ NoResize=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   � $��
5, 5, 5, 0q�6    5      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60    � ColumnDefinitions 5      �� 5      $
��Auto �6#   62   �� 5      $��50��6#   $
��Auto �61   6@   �� 5      $��25��6#   $
��Auto �61   6@   �� 5      $	��300 �6#   61   �� 5       $
��Auto �6#   62   .+�5$      �� -   5        $��AlphaCheckbox��5$      $��0��6,   $��0, 5, 10, 5q�69    d� 	IsChecked$
 TrueY�6N    � Cursor$
 Hand��6_   �� 5%      -   5        $��RedCheckbox��5%      $��1��6*   $��0, 5, 10, 5q�67   $
 TrueY�6L   $
 Hand��6]   �� 5&      -   5        $��GreenCheckbox��5&      $��2��6,   $��0, 5, 10, 5q�69   $
 TrueY�6N   $
 Hand��6_   �� 5'      -   5        $��BlueCheckbox��5'      $��3��6+   $��0, 5, 10, 5q�68   $
 TrueY�6M   $
 Hand��6^   �� 5)      $��Alpha: ��6   $��0��6'   $��1��64   $��Right=�6D   $��Center=�6`   �� 5*      $��Red: ��6   $��1��6%   $��1��62   $��Right=�6B   $��Center=�6^   �� 5+      $��Green: ��6   $��2��6'   $��1��64   $��Right=�6D   $��Center=�6`   �� 5,      $��Blue: ��6   $��3��6&   $��1��63   $��Right=�6C   $��Center=�6_   �� 5.      $��0��6M   $��2��6Z   $��Center=�6j   $��Center=�6�   ��6   ��  �� Path$ Value� �� ElementName$ AlphaSlider��6�   �� 5/      $��1��6K   $��2��6X   $��Center=�6h   $��Center=�6�   ��6   �� $ Value�$ 	RedSlider��6�   �� 50      $��2��6M   $��2��6Z   $��Center=�6j   $��Center=�6�   ��6   �� $ Value�$ GreenSlider��6�   �� 51      $��3��6L   $��2��6Y   $��Center=�6i   $��Center=�6�   ��6   �� $ Value�$ 
BlueSlider��6�   �� 53      -   5        $��AlphaSlider��53      $��0��6@   $��3��6M   	 � Maximum$		 255Q�6]   $��Center=�6k   
 � Value
 6(   �� *Alpha+6k   �� 54      -   5        $��	RedSlider��54      $��1��6<   $��3��6I   $		 255Q�6Y   $��Center=�6g   
 6&   �� *Red+6g   �� 55      -   5        $��GreenSlider��55      $��2��6@   $��3��6M   $		 255Q�6]   $��Center=�6k   
 6(   �� *Green+6k   �� 56      -   5        $��
BlueSlider��56      $��3��6>   $��3��6K   $		 255Q�6[   $��Center=�6i   
 6'   �� *Blue+6i   �� 58      -	   5        $��Color��58      $��4��6"   $��4��63   $��20��6C   $��
5, 0, 0, 0q�6N   ��6b   �� *CurrentColor+59      �� 5;   
   $��1��6   $��5q�6"   $
��Left=�6-   .+�5<      �� $	��Add��62   $��20��6@   $��70��6L   $
 Hand��6W   ��6   �� *
AddColor+6W   5=      �� 5?   
   $��2��62   $��
5, 0, 5, 5q�6?   $	��170��6S   ��6   �� *Colors+6S   5@      5A      