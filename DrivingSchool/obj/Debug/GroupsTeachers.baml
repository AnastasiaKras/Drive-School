   M S B A M L   `   `   `  ����H  DDrivingSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DrivingSchoolDrivingSchool  5   	   "    DrivingSchool.GroupsTeachers   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DrivingSchool     5   	     � Title$N  HAccounting system for driving school students 2020 – Lists of teachers��5   
   $��496.4��6Y   $��971.2��6h    � WindowStartupLocation$ CenterScreen=�6v    � 
ResizeMode$ CanMinimize=�6�   .��5	      � ��5
   
   �� 5       �� 
StartPoint$ 0.5,1&�6"    �� EndPoint$ 0.5,0&�65   .��5      �  � Color$ 	#FF0C2342��6    � Offset$ 0Q�61   � 5      $ 	#FF4C6F8C��6   $ 1Q�61   5      .+�5   
   �� $��0,0,-0.2,410.4q�6   $��Cambria)�6(   $
��Bold"�6=   $��20(�6O   ���	#FF545252
�������6t   �� 5   
   -   5        $��
Назад��5      $��16(�6!   $
��Left=�6/   $	��Top=�6J   $	��114��6b   $��30��6n   $��Cambria)�6�   $��Normal"�6�   $��	10,13,0,0q�6�   �� 5   
   $��DRIVING SCHOOL��6   $��164,8,9.8,426.4q�6)   $��Cambria)�6B   $
��Bold"�6W   $��20(�6i   ���	#FF545252
�������$��Center=�6�   $��32��6�   �� 5   
   $/��)Список преподавателей��6   $��365,56,365.8,368.4q�60   $��Cambria)�6L   $��20(�6a   
���������6o   Z� 6�   �� 5   
   $��0,98,-0.2,316.4q�6   ���	#FFDDDDDD6)   �� 5   
   -   5        $1��+Добавить преподавателя��5      $��15(�62   $��Cambria)�6W   $��Normal"�6l   ���	#FFF2F2F2$��69,107,700.8,324.4q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DG��5         AutoGenerateColumns . $
��Left=�68   $	��273��6S   $��
10,171,0,0q�6`   $	��Top=�6t   $	��945��6�   $��Cambria)�6�   $��13(�6�   �� 5   
   -   5        $��Документ��5      $
��Left=�6$   $��28��6?   $��751,107,0,0q�6K   $	��Top=�6`   $	��115��6x   6�   �� 5   
   -   5         ��Name$ 
CategoryPr��5      	 �� SelectedIndex$	 0��6'   
 �� Text$1
 +Категория преподавания��69   $
��Left=�6W   $��21��6r   $��400,114,0,0q�6~   $	��Top=�6�   $	��199��6�   .@�5      �� $1��+Категория преподавания��6   $��Center=�6<   $��148.8��6Y   $��Center=�6g   �� 5      -   5        $ ��Преподаватель��5      $��Center=�63   $��148.8��6P   $��Center=�6^   6y   �� 5      -   5        $��Инструктор��5      $��Center=�60   $��148.8��6M   $��Center=�6[   6v   5      5      5      