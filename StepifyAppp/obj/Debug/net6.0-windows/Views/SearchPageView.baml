   M S B A M L   `   `   `  ����F  BStepifyAppp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StepifyAppp.ViewsStepifyAppp.Views  5      &     StepifyAppp.Views.SearchPageView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:StepifyAppp.Views     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f4661fontaw$http://schemas.fontawesome.io/icons/  5        N� Title$  SearchPageView��5
      .��5      � ��5   
   �� 5       �� ImageSource$+ %../StaticFiles/spotify_background.jpg��6   .+�5   
   �� $��10q�6   .+�5      �� -   5        $��searchTextBox��5   K   
�������
�������$��20(�6=   $	��300��6`   $��0,40,0,0q�6l   6~   �� 5      -   5        
���   �
�������$��Search��5   ;   $��80��6L   $��0,10,0,0q�6W   6i   �� 5      -   5        $��resultListBox��5   L   ���#72777d J� Opacity$	 0.7Q�6+   
�������$	��800��6a   $	��600��6m   $��0,10,0,0q�6z   ��5      �� 5      .R�5      �� 
������� �� Orientation$ 
Horizontal=�68   .+�5      �� $��60��6@   $��60��6K   $��0,0,10,0q�6W   ��6$   �� *
ImageUrl+6W   �� 5      
���   �$��14(�6;   $��	ExtraBold"�6I   $��Center=�6x   ��6`   �� *Artist+6x   �� 5      
���   �$��14(�6;   $��	ExtraBold"�6I   $��10,0,0,0q�6v   $��Center=�6�   ��6`   �� *Name+6�   �� 5      
���   �$��14(�6;   $��	ExtraBold"�6I   $��40,0,0,0q�6~   $��Center=�6�   ��6`   �� *DurationTime+6�   �� 5      $��center=�6%   $��60��6I   $��50��6T   
������ $��0q�6z   
������ $
��Left=�6�   $	��Top=�6�   .��5   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5   &   !  FontAwesome.WPF.FontAwesome  $��LikeIcon��69   
���   �   Icon$ Heart=�6\   $��0,10,0,0q�6i   $��18(�6{   5   #   5      �� 5       $��center=�6&   $��60��6J   $��50��6U   
������ $��0q�6{   
������ $
��Left=�6�   $	��Top=�6�   .��5!   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5"   &     $��PlusIcon��69   
���   �$
 Plus=�6\   $��0,10,0,0q�6h   $��18(�6z   5#   #   5$      �� 5%      $��center=�6%   $��60��6I   $��50��6T   
������ $��0q�6z   
������ $
��Left=�6�   $	��Top=�6�   .��5&   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5'   &     $��PlayIcon��69   
���   �$
 Play=�6\   $��0,10,0,0q�6h   $��18(�6z   5(   #   5)      5*      5+      5-      53      54      55      