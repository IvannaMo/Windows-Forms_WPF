   M S B A M L   `   `   `  ����>  :Ray, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Ray.ComponentsRay.Components  5   	   %clr-namespace:Ray.Views	Ray.Views  5   	       Ray.Views.MainAppWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3
componentsclr-namespace:Ray.Components     5   	   )localclr-namespace:Ray.Views     5   	   -   5          � Title$	  Ray��5	   	    � Icon$ 	/Icon.ico��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   
������  � 
ResizeMode$ CanMinimize=�5   	   ��5
   	   ��  �� Source# Z�� � WindowState 5   	   �� *CurrentWindowState+ �� Mode$ TwoWay=�.��5      ��  
  header#���   6   ._�5   
   � 	 � RowDefinitions	 5      �� 5      $
��Auto �6    60   �� 5      6"   .+�5      � -   5        $��mainAppHeader��5      $��Center=�6(   $��Center=�6E   
 � ColumnDefinitions
 5      �� 5      $
��Auto �6'   66   �� 5      6)   .+�5"      � -   5        $��mainAppUser��5"      $
��Left=�6/   $��Center=�6J   $��22, 0, 0, 0q�6e   
������  � Cursor$
 Hand��6�   .+�5#         Ray.Components.UserIcon  -   5          Name$ mainAppUserIcon��5#   *     mainAppUserIcon#��[ 6C      Source$ /Images/Default Photo.png��6l   6�   �� 5$      $��10, 0, 0, 0q�6!   $��Center=�66   .+�5%      ��   mainAppText#��[ 6$    �� Padding$ 
0, 5, 0, 0q�6I   ��6^   �� *
Username+5&      5'      �� 5*      $��1��6   $��Center=�6-   $��0, 0, 22, 0q�6H   .+�5+      �  � Orientation$ 
Horizontal=�6    $��Right=�69   .+�5,      �� -   5        $��minimizeButton��5,         windowActionButton#��[ 66   $��0, 0, 18, 0q�6b   $��50��6w   $��50��6�   $��/Icons/Minimize Icon.png��6�    J� InputBindings 5-      d� 5.   "    d� Gesture$ 	LeftClicka�6/    �� Command 6C   �� *MinimizeWindowCommand+$ OneWay=�50      �� 51      -   5        $��closeButton��51       #��[ 63   $��50��6_   $��50��6k   $��/Icons/Close Icon.png��6v    52      d� 53   "   $ 	LeftClicka�6/    6C   �� *CloseWindowCommand+$ OneWay=�55      56      57      58      � 5;      -   5        $��mainAppGrid��5;      $��1��6&     
background#���  63   
 5<      �� 5=      -   5         �Name$ mainAppSettingsColumn��5=   '   $��0 �6D   6P   �� 5>      6)   �� 5?      $
��Auto �6'   66   �� 5@      6)   .+�5D      �� -	   5        $��mainAppSettingsGrid��5D        
containers#���  64   ._�5E      �� $��36, 50, 36, 50q�6!   .+�5F      � $��0, 0, 0, 23q�6$   .+�5G        -
   5        $ mainAppSettingsUserPhoto��5G   2   #��[ 6T   $ /Images/Default Photo.png��6}   $
 Hand��6�   6�   �� 5H      $��17, 0, 0, 0q�6)   $��Center=�6>   .+�5I   "   ��  �� Orientation$ 
Horizontal=�6-   $��
0, 0, 0, 5q�6F   .+�5J   &   �� -   5        $��mainAppUserRedColor��5J   -     mainAppUsernameColor#��[ 6H   $��
0, 0, 8, 0q�6v   ���#ec9c896�   �� 5K   &   -   5        $��mainAppUserOrangeColor��5K   -   #��[ 6K   $��
0, 0, 8, 0q�6y   ���#ecc8896�   �� 5L   &   -   5        $��mainAppUserYellowColor��5L   -   #��[ 6K   $��
0, 0, 8, 0q�6y   ���#f1ea9d6�   �� 5M   &   -   5        $��mainAppUserGreenColor��5M   -   #��[ 6J   $��
0, 0, 8, 0q�6x   ���#b3cd8e6�   �� 5N   &   -   5        $��mainAppUserCyanColor��5N   -   #��[ 6I   $��
0, 0, 8, 0q�6w   ���#79c0cf6�   5O   #   �� 5P   "   $ 
Horizontal=�6-   .+�5Q   &   �� -   5        $��mainAppUserBlueColor��5Q   -   #��[ 6I   $��
0, 0, 8, 0q�6w   ���#6996c16�   �� 5R   &   -   5        $��mainAppUserVioletColor��5R   -   #��[ 6K   $��
0, 0, 8, 0q�6y   ���#987eac6�   �� 5S   &   -   5        $��mainAppUserPinkColor��5S   -   #��[ 6I   $��
0, 0, 8, 0q�6w   ���#e8a2b06�   �� 5T   &   -   5        $��mainAppUserBrownColor��5T   -   #��[ 6J   $��
0, 0, 8, 0q�6x   ���#a07d616�   �� 5U   &   -   5        $��mainAppUserDefaultColor��5U   -   #��[ 6L   $��
0, 0, 8, 0q�6z     text#���  6�   6�   5V   #   5W      5X      �� 5Z      $��0, 0, 0, 26q�6%   .+�5[      ��   mainAppUsernameEdit#��[ 6&   ��6S   �� *
Username+�� 5\      $��1��6&    	 mainAppBioEdit#��[	 63   $��0, -12, 0, 0q�6[   ��6q   �� *Bio+5]      �� 5_      .+�5`      ��  
 mainAppSubtitleText#��[
 6(   $��Themes��6U      Ray.Components.Toggle  5a      -   5          Name$ mainAppThemesToggle��5a   0      Ray.Components.Toggle   Checked$  mainAppThemesToggleChecked��6M     mainAppThemesToggle#��[ 6r   $
��Left=�6�   $��0, -5, 0, 0q�6�   $
 Hand��6�   5b      5c      5d      �� 5g      -   5        $��mainAppScrollViewer��5g      $��2��6:   $��Hidden=�6J   .��5h      �� .+�5i      � -   5        $��mainAppScreenFrame��5i      $��0, 50, 0, 56q�69     mainAppScreenClosedFrame#���  6O   $��Center=�6�   $��Center=�6�   .+�5j      �� -   5        $��mainAppScreen��5j   %    
 screen#���  6:    �� CornerRadius$ 44��6`   ._�5k   "   � 	 5l   &   �� 5m   *   6:   �� 5n   *   6:   �� 5o   *   6:   
 5r   &   �� 5s   *   6=   �� 5t   *   6=   �� 5u   *   6=   .+�5y   &   �� -   5        $��mainAppScreenImageBorder��5y   -   $��3��6M   $��3��6^    K� ZIndex$ 0��6r   $ 44��6�   ��5z   *   �� 5{   .   -   5        mainAppScreenImage�� j� Stretch$
 Fill=�5{   U   5}   '   � 5�   &   $��1��60   $��1��6=   $ 3��6M   $��Center=�6^   $��Center=�6{   .+�5�   *   �� -   5        $��mainAppStreamButton��5�   1     streamButton#��[ 6L   $��Stream��6r   $
 Hand��6�   6�   5�   '   � 5�   &   -   5        $ ��mainAppStopButtonWrapPanel��5�   0   $��1��6R   $��1��6_   $ 2��6o   $y�Hidden=�6�   $��Center=�6�   $��Center=�6�   .+�5�   *   �� -   5        $��mainAppStopButton��5�   1     stopStreamButton#��[ 6J   $
��Stop��6t   $
 Hand��6�   6�   5�   '   � 5�   &   $��2��60   $��2��6=   $ 1��6M   $��Right=�6^   $��Bottom=�6z   .+�5�   *   �� -   5        $��mainAppFullScreenIcon��5�   0   $y�Hidden=�6M   $ ��/Icons/FullScreen Icon.png��6a   $��0, 0, 20, 20q�6�   $
 Hand��6�   6�   5�   '   5�   #   5�      5�      �� 5�      -   5        $"��mainAppBorderStreamContainer��5�   !     mainAppBorderContainer#��[ 6E   $��0, 0, 0, 24q�6u   $
��Auto��6�   ._�5�      �� $��36, 30, 36, 44q�6)   .+�5�   "   ��   mainAppTitleText#��[ 6,   $��Stream 18.01.2024��6V   � 5�   "   $
��Left=�6,   
������ $
 Hand��6`   .+�5�   &     -    5        $ mainAppStreamerUser��5�   :     mainAppStreamerUserIcon#��[ 6W   $ /Images/Default Photo.png��6�   6�   �� 5�   &   $��17, 0, 0, 0q�61   .+�5�   *   ��   mainAppMainSubtitleText#��[ 64   $��AdminCat��6e   �� 5�   *   $��1��64   #��[ 6A   $��0, -12, 0, 0q�6f   $��Admin | Cat��6|   5�   '   5�   #   5�      5�      �� 5�      -!   5        $!��mainAppBorderUsersContainer��5�   !   #��[ 6D   $��0, 0, 0, 87q�6t   $
��Auto��6�   ._�5�      �� -"   5        $��mainAppUsersStackPanel��5�   )   $��36, 35, 36, 44q�6G   .+�5�   "   �� -#   5        $��mainAppUsersCount��5�   ,   #��[
 6E   $��0 Cats are watching now:��6r   �� 5�   "   -$   5        $��mainAppUsersList��5�   +   $	��600��6C   
������ $��0q�6h   $��Disabled=�6|   $��Disabled=�6�   ��5�   &   �� 5�   *   .R�5�   .   � 5�   +   ��5�   &   �� 5�   *    �� 
TargetType" ��60   .�5�   .   ��  �� Property � �� �� Value
 � ���6K   �� 5�   .    � ��$ 0, 0, 114, 12q�6G   �� 5�   .    �@��
IsSelected 6K   �� *Content.IsSelected+$ TwoWay=� �� RelativeSource �� *Self+�� 5�   .    � �� 5�   2   �� 5�   6    �� 
TargetType" ��6F   .R�5�   :   �� 5�   7   5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      