   M S B A M L   `   `   `  ����F  BStepifyAppp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StepifyAppp.ViewsStepifyAppp.Views  5   	        StepifyAppp.Views.Register   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StepifyAppp.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     N� Title$  Register��5	   	   $	��500��6   $	��400��6'   .��5      ��  �� CornerRadius$ 10��6   $��3q�5       J� Opacity$
 0.90Q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 1,1&�6;   .��5      �  � Color$ #52b69a��6'    � Offset$ 0Q�67   � 5      $ #216869��6'   $
 0.75Q�67   � 5      $ #52b788��6'   $ 1Q�67   5      ��5      �� 5      $	 0,1&�6*   $	 1,0&�6;   .��5      � $ #2b9348��6'   $ 0Q�67   � 5      $ #216869��6'   $
 0.75Q�67   5      ._�5!      � .+�5%   
   �� $��STEPIFY��6   
�������$��25(�5'       $��
Montserrat)�5(       $��Medium"�5)       $��Center=�5*       $��	10,80,0,0q�5+       �� 5,   
   -   5        $��st��5,      .+�5-      �� $��	0,100,0,0q�6   $	��200��6,   $��40��68   .+�5.      �� $
��Bold"�6g   $��14(�6y   
�������
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��5/       %  !MaterialDesignFloatingHintTextBox#��[  50      $��Center=�51      ��5.      �� *	User.Name+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�51      52      �� 54      $	��200��6   $��40��6%   .+�55      �� $
��Bold"�6j   $��14(�6|   
�������
�������$ Surname��56      #��[  57      $��Center=�58      ��55      �� *User.Surname+$ TwoWay=�$	 PropertyChanged=�58      59      �� 5;      $	��200��6   $��40��6%   .+�5<      �� $
��Bold"�6i   $��14(�6{   
�������
�������$ Email��5=      #��[  5>      $��Center=�5?      ��5<      �� *
User.Email+$ TwoWay=�$	 PropertyChanged=�5?      5@      �� 5B      $	��200��6   $��40��6%   .+�5C      �� $
��Bold"�6l   $��14(�6~   
�������
�������$ Password��5D      #��[  5E      $��Center=�5F      ��5C      �� *User.Password+$ TwoWay=�$	 PropertyChanged=�5F      5G      5I      �� 5K   
   $��Register��5N      
���   �$	��100��6;   $��-100,200,0,0q�6G   
���������5K      �� *SaveCommand+��5L      �� 
 �� RelativeSource
 �� *FindAncestor+ �� AncestorType" N�5N   ]   �� 5R   
   $��Cancel��5V      
���   �$	��100��69   $��150,200,0,0q�6E   
���������5R      �� *CancelCommand+��5S      �� 
 �� *FindAncestor+" N�5V   Z   �� 5Y      -   5        $��error��5Y      $	��300��6;   $��40��6G   $��100,100,0,0q�5Z      
���������5Y   !   �� *Error+5Z   #   5`      5f      5h      