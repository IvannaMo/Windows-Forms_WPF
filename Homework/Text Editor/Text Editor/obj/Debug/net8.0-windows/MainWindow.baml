   M S B A M L   `   `   `  ����F  BText Editor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Text_EditorText_Editor  5   	       Text_Editor.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Text_Editor     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��5	   	   $	��520��6    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   o� $
��Auto��6   $��0��6   .@�5      m� $
��File��6   .@�5      m� -   5        $��newMenuItem��5       m� Command$	 New��6.   m� 5      -   5        $��openMenuItem��5      $
 Open��6/   m� 5      -   5        $��saveMenuItem��5      $
 Save��6/   �� 5      m� 5      $ Close��6   5      m� 5      $
��Edit��6   .@�5      m� -   5        $��cutMenuItem��5      $	 Cut��6.   m� 5      -   5        $��copyMenuItem��5      $
 Copy��6/   m� 5      -   5        $��pasteMenuItem��5      $ Paste��60   5       m� 5"      -   5        $��Register��5"      6)   5#      �� 5%   
   -	   5        $��textBox��5%      $��1��6!   $��5q�6.    �� TextWrapping$
 Wrap=�69   $��16(�6M   6[   5&      5'      