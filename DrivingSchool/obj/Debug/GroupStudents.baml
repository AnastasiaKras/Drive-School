   M S B A M L   `   `   `  ����H  DDrivingSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DrivingSchoolDrivingSchool  5   	   !    DrivingSchool.GroupStudents   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DrivingSchool     5   	     � Title$N  HAccounting system for driving school students 2020 – Group of students��5   	   $��489.774��6X   $��854.848��6i    � WindowStartupLocation$ CenterScreen=�6y    � 
ResizeMode$ CanMinimize=�6�   .��5	      � -   5        $��D��5	      ��5
   
   �� 5       �� 
StartPoint$ 0.5,1&�6"    �� EndPoint$ 0.5,0&�65   .��5      �  � Color$ 	#FF0C2342��6    � Offset$ 0Q�61   � 5      $ 	#FF4C6F8C��6   $ 1Q�61   5      .+�5   
   �� $��	0,0,0,398q�6   $��Cambria)�6#   $
��Bold"�68   $��20(�6J   ���	#FF545252
�������6o   �� 5   
   -   5        $��
Назад��5      $��16(�6!   $
��Left=�6/   $	��Top=�6J   $	��114��6b   $��30��6n   $��Cambria)�6�   $��Normal"�6�   $��	10,15,0,0q�6�   �� 5   
   $��DRIVING SCHOOL��6   $��164,11,0,414q�6)   $��Cambria)�6?   $
��Bold"�6T   $��20(�6f   ���	#FF545252
�������$��Center=�6�   $
��Left=�6�   $��35��6�   �� 5   
   $��0,113,-0.2,283q�6   ���	#FFDDDDDD6(   �� 5   
   $#��Группы учеников��6   $��302,67,300.8,352q�6*   $��Cambria)�6D   $��20(�6Y   
���������6g   Z� 6}   �� 5   
   -   5        $��Category��5       �� SelectedIndex$ 0��6#    �� Text$ Категория��65   $
��Left=�6F   $��21��6a   $��258,132,0,0q�6m   $	��Top=�6�   $	��151��6�   	 J� RenderTransformOrigin$	 0.531,1.556&�6�   .@�5      �� $��Категория��6   $��Center=�6/   $��148.8��6L   $��Center=�6Z   �� 5      -   5        $��A��5      $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   �� 5      -   5        $��B��5      $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   �� 5      -   5        $��C��5      $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   �� 5      -   5        $��D��5      $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   5      �� 5   
   -   5        $��Group��5      $ 0��6    $ Группа��62   $
��Left=�6@   $��21��6[   $��508,132,0,0q�6g   $	��Top=�6|   $	��151��6�   .@�5      �� $��Группа��6   $��Center=�6,   $��148.8��6I   $��Center=�6W   �� 5      -	   5        $��1��5      $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   �� 5       -
   5        $��2��5       $��Center=�6'   $��148.8��6D   $��Center=�6R   6m   5!      &   System.Windows.Controls.DataGrid  5"   
   -   5        $��DG��5"      
   AutoGenerateColumns
 . $
��Left=�68   $	��258��6S   $��131,191,0,0q�6`   $	��Top=�6u   $	��582��6�   $��Cambria)�6�   $��18(�6�      CanUserReorderColumns .  6�   �� 5#   
   -   5        $#��Добавить группу��5#      $��14(�6+   $��Cambria)�6P   $��Normal"�6e   ���	#FFF2F2F2$��19,132,684,299q�6�   �� 5$   
   -   5        $#��Список учеников��5$      $��14(�6+   $��Cambria)�6P   $��Normal"�6e   ���	#FFF2F2F2$��691,132,22,299q�6�   5%      5&      