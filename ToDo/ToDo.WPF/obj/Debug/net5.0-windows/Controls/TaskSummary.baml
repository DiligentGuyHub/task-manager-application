   M S B A M L   `   `   `  ����C  ?ToDo.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ToDo.WPF.ControlsToDo.WPF.Controls  5      U QSystem.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5      #    ToDo.WPF.Controls.TaskSummary   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:ToDo.WPF.Controls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      <sys,clr-namespace:System;assembly=System.Runtime     5        J� InputBindings  5      �� 5   
   
 �� Key$ Enter��6    �� Command 6!   �� *UpdateTaskCommand+.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��5      $��10q�5      $
��Left=�5      $��30(�5         BrushActivated#��[  5      $��Your tasks for today��5      � 5   
   $��1��6   .+�5@      �� -   5         ��Name$ TaskViewBox��5A      $��Disabled=�5C       %� 
ScrollUnit$ Pixel=�5D      ��5B      �� *Tasks+ � ContextMenu 5E      �� 5F      .@�5G      m� $��Update��6I    m� Command 6#   �� *UpdateTaskCommand+6I   m� 5H      $��	Duplicate��67    6#   �� 67   m� 5I      $��Delete��67    6#   �� 67   5J      ��5L      �� 5M      .R�5N      � $��0��6$   .+�5O      �� $��0��5P   !   $	��Top=�5Q   !    d� 	IsChecked 5R   !   �� *IsCompleted+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 � LayoutTransform
 5S   "   �� 5T   &    �� ScaleX$ 2Q�65    �� ScaleY$ 2Q�6@   5V      � 5W      $	��350��6#    5X   "   �� 5Y   &   $��2* �64   �� 5Z   &   $��* �64   .+�5\   "   �� $��0��5]   %   $	��5,0q�5^   %   
������ $��0q�5`   %   $��18(�5a   %   $��SemiBold"�5b   %    �� TextWrapping$
 Wrap=�5d   %   ��5c   %   �� *Header+$	 PropertyChanged=�5d   %   �� 5e   "   $��1��5f   %   $	��5,0q�5g   %   
������ $��0q�5i   %   $��12(�5j   %   $
 Wrap=�5l   %   ��5k   %   �� *Description+$	 PropertyChanged=�5l   %   5m      � 5n      $	��120��6#   .+�5o   "   �� $	��Top=�5p   %   $��18(�5q   %   ��5r   %   �� *
Category+$	 PropertyChanged=�5s      � 5t      $	��120��6#   .+�5u   "   o� $	��Top=�6'   
������ .@�5v   &   m� ��6/   �� *
Deadline+$	 PropertyChanged=�.@�5w   *   &   System.Windows.Controls.Calendar     FirstDayOfWeek$ Monday=�63      SelectedDate 6K   �� *
Deadline+$	 PropertyChanged=�5x   '   5y   #   5z      � 5{      $
��auto��5|   !   $��Right=�5}   !   $	��Top=�5~   !   .+�5   "   �� $��35��6(   ��63   �� *PriorityStatus+5�      5�      5�      5�      5�      5�      5�      