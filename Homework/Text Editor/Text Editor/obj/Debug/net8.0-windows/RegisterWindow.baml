   M S B A M L   `   `   `  ����F  BText Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Text_EditorText_Editor  5   	        Text_Editor.RegisterWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Text_Editor     5   	     � 
ResizeMode$  NoResize=�5   	   $	��120��5	   	   $	��290��6   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��
Enter key:��6   $��10q�6&   $��Right=�62   $	��Top=�6N   �� 5   
   -   5        $��textBox��5      $��1��6!   $��10, 0q�61   $��25��6@   $��Center=�6L   6n   �� 5   
   $��1��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   $��Center=�6l   .+�5      �� -   5        $��registerButton��5      $��Register��6+   ${�False��6>   $��30��6P   $��70��6\   $��0, 0, 10 ,0q�6g    � Cursor$
 Hand��6|   6�   �� 5      -   5        $��cancelButton��5      $��Cancel��6)   $��30��6:   $��70��6F   $
 Hand��6Q   6_   5      5      5      