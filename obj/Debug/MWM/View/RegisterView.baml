   M S B A M L   `   `   `  ����E  AProjekt IO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Projekt_IO
Projekt_IO  5   	   C&clr-namespace:Projekt_IO.MWM.ViewModelProjekt_IO.MWM.ViewModel  5   	   &     Projekt_IO.MWM.View.RegisterView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   *localclr-namespace:Projekt_IO     5   	   <	viewModel&clr-namespace:Projekt_IO.MWM.ViewModel     5   	     � Title$  RegisterView��5	   	   $	��600��5
   	   $	��920��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      ,  &Projekt_IO.MWM.ViewModel.MainViewModel  5   
    � 	Resources 5         
CustomFont  RoundedTextBox �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� CornerRadius ��Name  RoundedPasswordBox  RegisterButton �� Triggers P� Property P� Value��%�  &	        &	 )     &	 �    &	 {    *�5   
   Plus Jakarta Sans)�6;   �� 5   
   " ��6'   .�5      ��  � �� �	#FFF5F1EE6+   �� 5       � ��$ 45��6'   �� 5       � ��$	 0,5q�6'   �� 5       � ��$
 15,0q�6(   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      "	 ��6&   .R�5       �� #��z��6!   $
 8��5!   !   $��0q�5"   !   ._�5#      �� $ PART_ContentHost��6+   5$      5%      5'      5(      �� 5*   
   " G�6+   .�5+      ��  � �� �	#FFF5F1EE6+   �� 5,       � ��$ 45��6'   �� 5-       � ��$	 0,5q�6'   �� 5.       � ��$
 15,0q�6(   �� 5/       � ��$ Center=�69   �� 50       � �� 51      �� 52      "	 G�6&   .R�53      �� #��z��6!   $
 8��54   !   $��0q�55   !   ._�56      �� $ PART_ContentHost��6+   57      58      5:      5;      �� 5=   
   " ��6'   .�5>      ��  � �� �#D3D3D36+   �� 5?       � �� �#1C160C6+   �� 5@       � ��$ 1q�60   �� 5A       � �� �#D3D3D36,   �� 5B       � ��$ 45��6'   �� 5C       � ��$ 16(�6)   �� 5D       � �� 5E      �� 5F      "	 ��6&   .R�5G      �� #��z��6!   $
 20��5H   !   ._�5I      �� $��Center=�6/   $��Center=�5J   -   5K      5L      5N       5O      P� 5P       �@J�IsMouseOver . . �5Q      ��  � �� �#ab989663   5R      5T      5U      .��5W      �� -   5        
�������$
 20��5X      ._�5Z   
   � $��30q�6   .+�5[      �� .+�5]      �� $��SmartSun��6   $��20(�5^      #��[  5_      $��Center=�5`      $��	0,30,0,50q�5a      �� 5c      $��Witaj!��6   #��[  5d      $��28(�5e      $
��Bold"�5f      $��Center=�5g      $��0,0,0,20q�5h      �� 5k      $��E-mail��6   #��[  5l      $��0,0,0,5q�5m      $��14(�5n      �� 5o      -   5         ��Name$ EmailBox��5o      #��[ 5p      #��[  5q      $��16(�5r      $��0,0,0,15q�5s      �� 5u      $��Hasło��6   #��[  5v      $��0,0,0,5q�5w      $��14(�5x      G� 5y      -   5         G�Name$ PasswordBox��5y      #��[ 5z      #��[  5{      $��0,0,0,15q�5|      $��16(�5}      �� 5      $��Potwierdź hasło��6   #��[  5�      $��0,0,0,5q�5�      $��14(�5�      G� 5�      -   5        $ ConfirmPasswordBox��5�      #��[ 5�      #��[  5�      $��0,0,0,55q�5�      $��16(�5�      �� 5�      -   5        $��Zarejestruj się��5�      #��[ 5�      #��[  5�      $��0,0,0,25q�5�      $��15(�5�      ���#D3D3D3$	��200��5�      �� 5�       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5�      �� #��[  6    $��14(�6I   $��Center=�6W   �� 5�      $�Masz już konto? ��6   5�      �� 5�      -   5        $��Zaloguj się��5�      #��[ 5�      #��[  5�      
������ 
������ ���#ab9896 � Cursor$
 Hand��5�      $��14(�5�      $��Center=�5�      5�      5�      5�      5�      5�      