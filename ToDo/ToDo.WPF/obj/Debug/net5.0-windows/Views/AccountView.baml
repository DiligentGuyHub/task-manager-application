   M S B A M L   `   `   `  ����C  ?ToDo.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ToDo.WPF.ViewsToDo.WPF.Views  5      9!clr-namespace:ToDo.WPF.ViewModelsToDo.WPF.ViewModels  5           ToDo.WPF.Views.AccountView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ToDo.WPF.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      8
viewmodels!clr-namespace:ToDo.WPF.ViewModels     5        � 	Resources  5         BooleanToVisibility�� 5   
   %   &	        �� 5      6+   5      .��5      �   BrushBackgroundReversed#��[ 6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��5      $��10,10q�5        BrushActivated#��[ 5      $��0,0,0,2q�5      ._�5      ��  �� Padding$ 0,0,0,10q�5      $��48(�5      $��Account��5      5       � 5!   
   $��1��5"      $��10q�5#       � IsSharedSizeScope$
 True��5$       5%      �� 5&      $
��auto �6    �� 5'      $
��auto �6    �� 5(      $
��auto �6    �� 5)      $
��auto �6    �� 5*      $
��auto �6    �� 5+      $
��auto �6     � ColumnDefinitions 5-      �� 5.      $
��auto �6#   �� 5/      $
��auto �6#   �� 50      $
��auto �6#   �� 51      $
��auto �6#   �� 52      $
��auto �6#   �� 53      $
��auto �6#   .+�55      �� $��0��56      $��0��57      $
��10,5q�58      $��16(�59      $��Email��5:      �� 5;      $��0��5<      $��1��5=      $
��10,5q�5>      $��16(�5?      ��5@      �� *CurrentUser.Email+�� 5A      $��1��5B      $��0��5C      $
��10,5q�5D      $��16(�5E      $��Username��5F      �� 5G      $��1��5H      $��1��5I      $
��10,5q�5J      $��16(�5K      ��5L      �� *CurrentUser.Username+�� 5M      $��2��5N      $��0��5O      $
��10,5q�5P      $��16(�5Q      $��Account rights��5R      �� 5S      $��2��5T      $��1��5U      $
��10,5q�5V      
������ $��16(�5X      ${�False��5Y      ��5Z      �� *CurrentUser.Role+�� 5[      $��3��5\      $��0��5]      $
��10,5q�5^      $��16(�5_      $��Registration date��5`      �� 5a      $��3��5b      $��1��5c      $
��10,5q�5d      
������ $��16(�5f      ${�False��5g      ��5h      �� *CurrentUser.DateJoined+�� 5i      $��4��5j      $��2��5k      $
��10,5q�5l      $��Update��5o      $��16(�5p      ��5m      �� *UpdateAccountCommand+��5n      �� *CurrentUser+5p      �� 5q      $��5��5r      $��2��5s      $��10,0,0,0q�5t      $��Center=�5u      $��16(�5w      $��SemiBold"�5x        
BrushHover#��[ 5y       � DataContext 5v      �� *ResultMessageViewModel+��5z      �� *	Message+y�5{      �� *
HasMessage+ �� 	Converter# [  5|      5}      5~      