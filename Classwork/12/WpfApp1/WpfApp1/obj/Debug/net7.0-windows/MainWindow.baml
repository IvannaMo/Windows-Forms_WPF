   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Buttons��5   	   $	��500��6   $	��350��6&    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5	         CustomButtonTemplate �� 
TargetType � RowDefinitions ��Name � ColumnDefinitions �� CornerRadius �� Padding	 �� RadiusX
 �� RadiusY �� StrokeDashArray �� Triggers P� Property P� Value �� 
TargetName �� Property �� Value��%�  &	        �� 5
   
   " ��67   .R�5      �  5      �� 5      $ CustomButtonGridInside��6$   $��0.74* �6D   6U   �� 5      $ CustomButtonGridSide��6$   $��0.16* �6B   6S   �� 5      $
��0.1* �6$   64    5      �� 5      $��0.01* �6'   67   �� 5      $��0.98* �6'   67   �� 5      $��0.01* �6'   67   .+�5      �� $��Shadow��6n   $��0��6   $��3��6&   $��1��67   $ 20��6G   ���#ffe3e35      �� 5      $��
BorderSide��6�   $��0��6   $��2��6&   $��0��67   $��3��6G   ���#b08697$��3q�6q   $ 20��6�   ���#f8c5d25      �� 5      $��BorderInside��6  $��0��6   $��0��6&   $��3��66   ���#b08697$��3q�6`   $ 20��6t   ���#fff0f0$ 25q�6�   $��/Fonts/#Golca Extra Bold)�6�   ���#68485f$
��Bold"�6�   ._�5      � $��Center=�6   $��Center=�66   .+�5      �� $��CustomButtonInside��6$   $y�Hidden=�6>   
���   �$	 10��6a   $
 10��6n   $��1��6{   $	 1 2R�6�   6�   �� 5       $
��True��6+   #��z��6F   6k   5!      5"      5#       5&      P� 5'       �@J�IsMouseOver$
 True��61   . �5(      �� $ BorderInside��6    � �� �#fff7f76M   �� 5)      $ BorderInside��6    � �� �#7e5a746W   5*      P� 5+       � {�$ False��6/   . �5,      �� $ BorderInside��6    � �� �#fbf3f36M   �� 5-      $ BorderInside��6    � �� �#a68f986N   �� 5.      $ BorderInside��6    � �� �#7e6d776W   �� 5/      $ 
BorderSide��6    � �� �#ecd0d76K   �� 50      $ 
BorderSide��6    � �� �#a68f986L   �� 51      $ Shadow��6    � �� �#f8e9e96G   52      54      55      .��56      �� $��Center=�6   .+�57   
   �� $��10q�6   $	��150��6   $��25(�6*   #��[  68    � Cursor$
 Hand��6i   .��6w   BUTTON6   �� 58   
   $��10q�6   $	��150��6   $��25(�6*   ${�False��68   #��[  6J   $
 Hand��6{   .��6�   DISABLED BUTTON6�   �� 59   
   $��10q�6   $	��100��6   $��15(�6*   #��[  68   $
 Hand��6i   .��6w   SMALL BUTTON6�   5:      5;      