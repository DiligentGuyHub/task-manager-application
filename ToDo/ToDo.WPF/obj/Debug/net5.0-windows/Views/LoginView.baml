   M S B A M L   `   `   `  ����J  FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components  5      C ?ToDo.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ToDo.WPF.ViewsToDo.WPF.Views 5      9!clr-namespace:ToDo.WPF.ViewModelsToDo.WPF.ViewModels 5	         ToDo.WPF.Views.LoginView   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ToDo.WPF.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      8
viewmodels!clr-namespace:ToDo.WPF.ViewModels     5	      ��5      �� 5   
     �� ImageSource$+  %/Resources/Backgrounds/night-view.jpg��6    j� Stretch$ UniformToFill=�6I    � 	Resources 5         BooleanToVisibility�� 5   
   %   &	        �� 5      6+   5      .��5      ��  �� Padding$ 25q�5   	   $��Center=�5   	   $��Center=�5   	   ��5   
   �� 5       �� Opacity$	 0.8Q�6    �� Color$ Black��6,   ._�5   
   �  � IsSharedSizeScope$
 True��6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5       $
��auto �6    �� 5!      $
��auto �6    �� 5"      $
��auto �6    .+�5%      �� $��0��5&      $��Center=�5'      $��48(�5(        BrushForeground#��[ 5)      $��Get Done��5*      �� 5+      $��1��5,      $��Center=�5-      $��16(�5.      #��[ 5/      $ ��Your tasks - your business��50      � 52      $��2��6   $
��0,20q�6     53      �� 54      $
��auto �6$   �� 55      $
��auto �6$   �� 56      $
��auto �6$   �� 57      $
��auto �6$   .+�5:      � $��0��6   $
��5,10q�6$    � ColumnDefinitions 5;      �� 5<      $
��auto �6+   	 z� SharedSizeGroup$	 Label��68   �� 5=      $	��300 �6+   .+�5@      �� $��0��5A      $��16(�5B      #��[ 5C      $��Username��5D      �� 5E      $��1��5F      $
��20,0q�5G      #��[ 5H      $��0,0,0,2q�5I      ._�5J      �� 
������ 
������ $��14(�5M      #��[ 5N      ��5O      �� *
Username+
 �� UpdateSourceTrigger$
 PropertyChanged=�5P      5Q      � 5S      $��1��6   $
��5,10q�6$    5T      �� 5U      $
��auto �6+   $	 Label��68   �� 5V      $	��300 �6+   .+�5Y      �� $��0��5Z      $��16(�5[      #��[ 5\      $��Password��5]      �� 5^      $��1��5_      $
��20,0q�5`      #��[ 5a      $��0,0,0,2q�5b      ._�5c      4   .PasswordBoxMVVM.Components.BindablePasswordBox  $��1��5d      $��1��5e      
������ 
������ $��14(�5h      #��[ 5i         Password 5j      �� *
Password+5k      5l      �� 5n      $��2��5o      $��2��5p      $	��380��5q      $
��0,10q�5r      $	��0,5q�5s      $��Center=�5t      
������ $��Login��5w      $��16(�5x      #��[ 5y       �� 	IsDefault$
 True��5z      ��5v      �� *LoginCommand+��5{      �� 5|      $	 0.8Q�6*   $ #004771��68   5~      �� 5�      $��3��5�      $	��380��5�      $��Center=�5�      
������ 
������ $��Don't have an account��5�      $��16(�5�      #��[ 5�      ��5�      �� *ViewRegisterCommand+5�      5�      �� 5�      $��3��5�      $��10,0,0,0q�5�      $��Center=�5�      $��16(�5�      $��SemiBold"�5�      ���#fb2323 � DataContext 5�      �� *ErrorMessageViewModel+��5�      �� *	Message+y�5�      �� *
HasMessage+ �� 	Converter# [  5�      5�      5�      