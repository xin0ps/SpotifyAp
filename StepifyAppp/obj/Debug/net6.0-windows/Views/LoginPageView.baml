   M S B A M L   `   `   `  ����F  BStepifyAppp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StepifyAppp.ViewsStepifyAppp.Views  5      %    StepifyAppp.Views.LoginPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:StepifyAppp.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  LoginPageView��5
      $	��400��6   $	��500��6+   .��5      � ��5   
   �� 5       �� ImageSource$ ../StaticFiles/image.jpg��6   .+�5   
   �� $ ��../StaticFiles/spotify.png��6   $��
0,-350,0,0q�5      $	��100��6/   $��80��6;   �� 5   
   $��STEPIFY��6   
�������$��25(�5       $��
Montserrat)�5       $��Medium"�5       $��Center=�5       $��
10,120,0,0q�5       �� 5   
   
������� J� Opacity$	 0.7Q�6%   $��2q�63   $	��200��6G   $	��200��6S   ._�5      �� $	��200��6   $	��100��6(   $��0,0,0,0q�66   .+�5       �� 
���   �$��1q�6-   ._�5!      �� $	��200��6"   $��40��6.   .+�5"      �� $
��Bold"�6k   $��14(�6}   
���   �
���   �)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��5#       %  !MaterialDesignFloatingHintTextBox#��[  5$      $��Center=�5%      ��5"   "   �� *Email+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5%      5&      5'      �� 5)      
���   �$��1q�6-   ._�5*      �� $	��200��6!   $��40��6-   .+�5+      �� $
��Bold"�6n   $��14(�6�   
���   �
���   �$ Password��5,      #��[  5-      $��Center=�5.      ��5+   "   �� *
Password+$ TwoWay=�$ PropertyChanged=�5.      5/      53      57      5:      �� 5;   
   $��-100,120,0,0q�5>      $��Login��5?      
�������$��90��68   
���   ���5;      �� *LoginCommand+��5=      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �5?   D   �� 5C   
   $��100,120,0,0q�5D      $��Register��5E      
�������$��90��5I       
���   ���5E   )   �� *RegisterCommand+��5F      ��  �� *FindAncestor+" N�5I   +   5L      5P      