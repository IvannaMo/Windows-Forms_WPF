   M S B A M L   `   `   `  ����B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	       Binding.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	     � Title$  	Calculate��5   	   $	��200��6   $	��350��6(    � 	Resources 5	         CustomTextBox �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� RelativeSource	 �� Path
 �� UpdateSourceTrigger��%�  &	        �� 5
   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 5��6!   
�������._�5      � .+�5   "   �� $��1��6,   �� 5   "   $ InputBox��6  $��1q�6*   $��0q�6�   
������ $��5q�6�   
���   �$��/Fonts/#Axiforma)�6�   $��15(�6  ��65   ��  �� *TemplatedParent+$
	 Text�$
 PropertyChanged=�6  5      5      5      5      5      5      .��5      � ���#f6b511 � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��* �6   �� 5      $��7 �6   �� 5      $��* �6   �� 5      $��10 �6   �� 5       $��* �6   �� 5!      $��30 �6    � ColumnDefinitions 5$   
   �� 5%      $��20 �6   �� 5&      $��* �6   �� 5'      $��5 �6   �� 5(      $��* �6   �� 5)      $��20 �6   .+�5-   
   �� $��1��6   $��1��6!   $��Center=�61   
�������$��/Fonts/#Axiforma Medium)�6_   $��20(�6�   $��Число А:��6�   �� 5.   
   $��3��6   $��1��6!   $��Center=�61   
�������$��/Fonts/#Axiforma Medium)�6_   $��20(�6�   $��Число B:��6�   �� 50   
   -   5        $��1��50      $��3��6   #��[  6/   ��6V   �� $	 Number1�6�   �� 51   
   -   5        $��3��51      $��3��6   #��[  6/   ��6V   �� $	 Number2�6�   �� 54   
   $��5��6   $��1��6!   $��Center=�61   
���   �$��/Fonts/#Axiforma Bold)�6_   $��20(�6�   $��Результат:��6�   �� 55   
   $��5��6   $��3��6   #��[  6/    �� 
IsReadOnly$
 True��6V   ��6h   �� $	 Result� �� Mode$ OneWay=�56      57      