   M S B A M L   `   `   `  ����E  AProjekt IO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Projekt_IO
Projekt_IO  5   	   C&clr-namespace:Projekt_IO.MWM.ViewModelProjekt_IO.MWM.ViewModel  5   	       Projekt_IO.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Projekt_IO     5   	   <	viewModel&clr-namespace:Projekt_IO.MWM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��600��5
   	   $	��920��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      ,  &Projekt_IO.MWM.ViewModel.MainViewModel  5   
    � 	Resources 5         
CustomFont  MenuButtonStyle �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� CornerRadius �� Padding J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 1     7   *�5   
   Plus Jakarta Sans Regular)�6C   �� 5   
   " 	�6(   .�5      ��  � �� 5      �� 5      "	 	�6&   .R�5      �� $
 Border��6!   $ 15��5   !   $
 10,5q�5   !   
������  . ._�5!      � .+�5"   "   �� $
��Left=�63   $��Center=�6N   $��10,0,0,0q�6i   5#      5$       5%      P� 5&       �@J�IsMouseOver . . �5'   "   �� $ Border��6)    � �� �#90a4ae6S   5(      P� 5)       �@d�	IsChecked$ FalseY�6;   . �5*   "   �� $ Border��6)    � ��
 ���� 6S   5+      5-      5/      �� 50       � �� �#1C160C6+   �� 51       � ��8   6+   �� 52       � ��$ 14(�6)   53      54      .��56      �� -   5          AppBackgroundBrush#���  56      $ 20��57      ._�59   
   �  � ColumnDefinitions 5:      �� 5;      $	��200 �6#   �� 5<       � RowDefinitions 5?      �� 5@      $��75 �6    �� 5A      $��2 �6    �� 5B      �� 5C      $
��Auto �6    .+�5G      �� $��0��6   $��Center=�6&   $��Center=�6A   .+�5H      	� -   5        $��SmartSun��5H        AppForegroundBrush#���  5I      #��[  5J      $��30(�5K       d� 	IsChecked$
 TrueY�5L        SmartSunButtonTheme#��[ 5M      $��Center=�5O      $��Center=�5P      ��5N      �� *SmartSunViewCommand+5Q      5R      �� 5U      $��1��6   $��2��6"     	Separator#���  66   $��1��6_   �� 5X      $��2��6   $	��Top=�6&   $��15,10q�6>   .+�5Y      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $��10,10q�6Q   .+�5Z      ��  
 Image1#���  6   $��20��6>   $��20��6I   $
��10,0q�6U   	� 5[      -   5        $��Ogród��5[   "   #��[ 5]   "   #���  5^   "   $
 TrueY�5_   "   $��Center=�5`   "   $��86��6=   ��5\   "   �� *OgrodViewCommand+5a   "   5b      �� 5d      $ 
Horizontal=�6   $��Center=�66   $��10,10q�6Q   .+�5e      ��  
 Image2#���  6   $��20��6>   $��20��6I   $
��10,0q�6U   	� 5f      -   5        $��Pogoda��5f   "   #���  5h   "   $
 TrueY�5i   "   #��[ 5j   "   $��Center=�5k   "   $��96��6=   ��5g   "   �� *PogodaViewCommand+5l   "   5m      �� 5o      $ 
Horizontal=�6   $��Center=�66   $��10,10q�6Q   .+�5p      ��  
 Image3#���  6   $��20��6>   $��20��6I   $
��10,0q�6U   	� 5q      -   5        $��
Ustawienia��5q   "   #���  5r   "   $
 TrueY�5s   "   #��[ 5u   "   $��Center=�5v   "   $	��109��6=   ��5t   "   �� *UstawieniaViewCommand+5w   "   5x      5y      �� 5|      $��2��6   $��1��5}      $��10q�5~      ��5      �� *CurrentView+�� 5�      $��3��6   $��© 2025 Smart Sun��5�      $��2��5�      $��Center=�5�      $��Center=�5�      $��12(�5�      #���  5�      #��[  5�      $��10q�5�      5�      5�      5�      