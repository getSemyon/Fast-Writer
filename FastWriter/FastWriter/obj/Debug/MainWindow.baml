   M S B A M L   `   `   `  ����E  AFastWriter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FastWriter
FastWriter  5   	       FastWriter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:FastWriter     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�6.    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)    � AllowsTransparency . 
������ '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CornerRadius$ 25��6/      CaptionHeight$ 0Q�6A   .��5      �� ���#524E4F$
��auto��5      $
��auto��6    �� CornerRadius$ 25��5      	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$
 #000000��6      Opacity$	 0.5Q�5   #      	Direction$ 90Q�5   #      ShadowDepth$ 2Q�5   #   ._�5   
   �  � RowDefinitions 5      �� 5      $��40 �6    �� 5       � ColumnDefinitions 5       �� 5!      �� 5"      .+�5%      �� ���	#FF373435$ 	25,25,0,0��6,   $��2��6E   ._�5&      �  5'      �� 5(      �� 5)      .+�5,      o� $
��Left=�6   $
��12,8q�66   .@�5-      m� $��Start��6#   $��24��62   m� 5.      $��Setting��6#   $��24��64   .@�5/      m� $��Disane��6'   $��24��67   m� 50      $��Text Generating��6'   $��24��6@   51      52      �� 54      $
��auto��6#   �� 56       �� Orientation$ 
Horizontal=�6!   $��Right=�6:   $��0 0 30 0q�6V   $��1��6h   .+�57      �� -   5         ��Name$ btnMinimize��57   !   $	��—��66   $��40��6B   $��40��6M   
������ 
������ 
�������59      �� 5:      -   5        $ btnMaximazi��5:   !   $��#��66   $��40��6B   $��40��6M   
������ 
������ 
�������5<      �� 5=      -   5        $ btnClose��5=   !   $��X��63   $��40��6?   $��40��6J   
������ 
������ ���#FF00005?      5@      5A      5B      �� 5D      -   5        $��
PresedText��5D      $��1��6&   $��0��63   $��50��6C   
�������$�� ��6a   $��Lucida Console)�6l   $��36(�6�   $��Right=�6�   $��Center=�6�   $��5,5,0,5q�6�   �� 5E      -   5        $��
TextTaping��5E      $��1��6&   $��1��63   $��50��6C   
�������$�� ��6f   $��Lucida Console)�6q   $��36(�6�   $��Center=�6�   $��0,5,5,5q�6�   5F      5G      5H      