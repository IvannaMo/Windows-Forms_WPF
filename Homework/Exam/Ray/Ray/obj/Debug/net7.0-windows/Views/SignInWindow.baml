   M S B A M L   `   `   `  ����>  :Ray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Ray.Views	Ray.Views  5   	   /clr-namespace:Ray.ComponentsRay.Components  5   	       Ray.Views.SignInWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   )localclr-namespace:Ray.Views     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3
componentsclr-namespace:Ray.Components     5   	   -   5          � Title$	  Ray��5	   	    � SizeToContent$ WidthAndHeight=�5
   	    � Icon$ 	/Icon.ico��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ CanMinimize=�5   	    � WindowState 5   	   �� *CurrentWindowState+ �� Mode$ TwoWay=�.��5      �� 	 �� CornerRadius$	 44��6   ���#2e393c._�5   
   � 
 � ColumnDefinitions
 5      �� 5      6%   �� 5      6%   .+�5      �� -   5        $��signInImage��5         
authnImage#��[  6(   $	 44, 0, 0, 44��6L   6j   � 5      -   5        $��
signInGrid��5      $��1��6%    � RowDefinitions 5      �� 5       -   5         �Name$ windowBorderRow��5    $   $
��Auto �6;   6K   �� 5!      6&   
 5$      �� 5%      -   5        $ signInGridLeftColumn��5%   '   $	��47* �6C   6Q   �� 5&      $
��349* �6'   66   �� 5'      -   5        $ signInGridRightColumn��5'   '   $	��54* �6D   6R   .+�5+      �� $��3��6   $��25, 24, 25, 0q�61   .+�5,      �  � Orientation$ 
Horizontal=�6    $��Right=�69   .+�5-      �� -   5        $��minimizeButton��5-         windowActionButton#��[ 66   $��0, 0, 12, 0q�6b   $��50��6w   $��50��6�   $��/Icons/Minimize Icon.png��6�    J� InputBindings 5.      d� 5/   "    d� Gesture$ 	LeftClicka�6/    �� Command 6C   �� *MinimizeWindowCommand+$ OneWay=�51      �� 52      -   5        $��closeButton��52       #��[ 63   $��50��6_   $��50��6k   $��/Icons/Close Icon.png��6v    53      d� 54   "   $ 	LeftClicka�6/    6C   �� *CloseWindowCommand+$ OneWay=�56      57      58      �� 5;      $��1��6   $��1��6*   $��0, -12, 0, 0q�6:   .+�5<      ��   authnHeaderText#��[ 6    $
��Auto��6I   $
��Left=�6V   $��Sign in��6q   �� 5=        authnMainText#��[ 6    $��0, -10, 0, 0q�6G   $
��Auto��6]   $
��Left=�6j   $��Not a member yet? Sign up��6�    � Cursor$
 Hand��6�    5>      d� 5?      $ 	LeftClicka�6+    6?   �� *RedirectToSignUpCommand+$ OneWay=�5A      �� 5C      #��[ 6    $��Username��6G   $��0, 15, 0, 0q�6W   �� 5D        authnInputTextBox#��[ 6   $��
0, 2, 0, 0q�6c   ��6I   �� *
Username+6c   �� 5F      #��[ 6    $��Password��6G   $��0, 12, 0, 0q�6W   &    Ray.Components.CustomPasswordBox  5G        authnInputPasswordBox#��[ 6Q   $��
0, 2, 0, 0q�6�      Password 63   �� *
Password+6�   � 5I      $ 
Horizontal=�6    $��Center=�69   $��0, 32, 0, 55q�6V   .+�5J      ��   authnButton#��[ 6!   ��6F   �� *SignInCommand+.��6h   	Sign in6q   5K      5L      5M      5N      5O      5P      