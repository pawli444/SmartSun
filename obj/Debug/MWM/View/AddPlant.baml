   M S B A M L   `   `   `  ����  
Projekt IO"    Projekt_IO.MWM.View.AddPlant   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � Title$  Dodaj roślinę��5   	   $	��400��5   	   $	��350��6    � WindowStyle$
 None=�5	   	    � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	   
������  � 	Resources 5         
CustomFont  CloseButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType  	AddButton	 �� CornerRadius
 �� Triggers P� Property P� Value  UploadButton��%  &	        &	 )     &	 �    &	 �    *�5   
   Plus Jakarta Sans)�6;   �� 5   
   " ��6)   .�5      ��  � ��
 ���� 6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 24��6&   �� 5       � ��$ 24��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      F� +����        р�� ��� �    ��� р��     	
���   �$��2��5   #   $��Center=�5   #   $��Center=�5   #   5      5       5"      5#      �� 5%   
   " ��6"   .�5&      ��  � �� �	#FF0D8A6A6+   �� 5'       � ��
 �����6+   �� 5(       � ��$ 45��6'   �� 5)       � ��$ 16(�6)   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� #��z��6!   $	 8��5.   !   ._�5/      �� $��Center=�6/   $��Center=�50   -   51      52      54      
 55      P� 56       �@J�IsMouseOver . . �57      ��  � �� �	#FF0A6B5263   58      5:      �� 5<   
   " ��6%   .�5=      ��  � �� �#DDDDDD6+   �� 5>       � ��$ 40��6'   �� 5?       � �� 5@      �� 5A      " ��6&   .R�5B      �� #��z��6!   $	 8��5C   !   ._�5D      �� $��Center=�6/   $��Center=�5E   -   5F      5G      5I      5J      5K      .��5M      �� -   5        
�������$	 20��5N      ���#1c1c1c$��10q�5Q      ._�5R   
   � $��20q�6    � RowDefinitions 5S      �� 5T      $
��Auto �6    �� 5U      $��* �6    �� 5V      $
��Auto �6    .+�5Z      � $��0��6   .+�5[      �� $��Dodaj roślinę��6   #��[  5\      $��24(�5]      $��SemiBold"�5^      $��Center=�5_      $��0,0,0,20q�5`      �� 5a      -   5        #��[ 5a      $��Right=�5b      $	��Top=�5c      5d      5e      �� 5h      $��1��6   $
��0,20q�6(   $
��Auto=�66   $��Disabled=�6Y   .��5i      �� .+�5j      �� $��*Nazwa rośliny��6    $��0,0,0,5q�5k      $��14(�5l      #��[  5m      �� 5n      $��40��6   ���#F5F5F5$��0q�5p      $
��10,0q�5q      $	��260��5r      $
��Left=�5s      $��0,0,0,20q�5t      �� 5v      $��Zdjęcie��6    $��0,0,0,5q�5w      $��14(�5x      #��[  5y      �� 5z      -   5        #��[ 5z      $��Dodaj z komputera��5{      #��[  5|      $	��200��5~      $��0,0,0,20q�5      �� 5�      $	��150��6   ���#F5F5F5$	 8��5�      $	��260��5�      $��0,0,0,20q�5�      ._�5�      �� -   5         ��Name$ PreviewImage��5�       $��Uniform=�5�       $��10q�5�       5�      5�      5�      �� 5�      -   5        $��2��5�      $��Dodaj��5�      #��[  5�      #��[ 5�      5�      5�      5�      5�      