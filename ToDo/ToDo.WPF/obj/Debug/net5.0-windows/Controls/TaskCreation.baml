   M S B A M L   `   `   `  ����C  ?ToDo.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ToDo.WPF.ControlsToDo.WPF.Controls  5      9!clr-namespace:ToDo.WPF.ViewModelsToDo.WPF.ViewModels  5	      $    ToDo.WPF.Controls.TaskCreation   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QWpfAnimatedGif, Version=2.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com  5      +localclr-namespace:ToDo.WPF.Controls  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      /todayvm!clr-namespace:ToDo.WPF.ViewModels  5	        J� InputBindings  5      �� 5   
   
 �� Key$ Enter��5       �� Command 5      �� *CreateTaskCommand+ �� CommandParameter 5      �� *SelectedTask+ � 	Resources 5       �� MergedDictionaries �� Source   BooleanToVisibility�� 5   
    5      �� 5      $ /Styles/TaskCreation.xaml?�6%   %   &	        �� 5      6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��35 �6   .+�5"   
   � $��1��6   .+�5#      �� $��10,0,0,0q�5$      
���  �� � DataContext 5%      �� *ErrorMessageViewModel+��5'      �� *	Message+y�5(      �� *
HasMessage+	 �� 	Converter#	 [  5)      �� 5*   
   ._�5+      � $��0��6   
 � ColumnDefinitions
 5,      �� 5-      $��* �6'   .+�5/      � $��0��6   
 50      �� 51      $	��200��6+   �� 52      $	��105 �6+   �� 53      $��54 �6+   .+�56      �� $��0��57      $
��10,0q�58      ��59      �� *Task+ �� UpdateSourceTrigger$ PropertyChanged=��� 5:      $��1��5;       �� SelectedValuePath$
 Text��5=       �� SelectedValue 5<      �� *
Category+$ PropertyChanged=�.@�5>      �� $��Inbox��6$   �� 5?      $��
Category 1��6$   �� 5@      $��
Category 2��6$   �� 5A      $��
Category 3��6$   5B      �� 5C      $��2��5D      $
 Text��5F       5E      �� *
Priority+$ PropertyChanged=�.@�5G      �� $��1,0,0,0q�5H      $��Center=�5I      $
��High��5J      �� 5K      $��1,0,0,0q�5L      $��Center=�5M      $��Medium��5N      �� 5O      $��1,0,0,0q�5P      $��Center=�5Q      $	��Low��5R      5e      5g      5o      5p      5r      5s      