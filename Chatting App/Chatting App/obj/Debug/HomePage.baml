   M S B A M L   `   `   `  ����  Chatting App    Chatting_App.HomePage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Chatting App��5   	   $	��450��5   	   $	��700��6    � WindowStyle$
 None=�5   	    � 
ResizeMode$ 	CanResize=�5   	    � AllowsTransparency . ���	#FF232121 � WindowStartupLocation$ CenterScreen=�5
   	   .��5      �� $��1q�6   
�������._�5   
   �  � RowDefinitions 5      �� 5      $��30 �6    �� 5      $��* �6    .+�5      ]� -   5        ���	#FF2C504F$��0��5   /   .+�5      �� $��  Chatting App��6   
�������$��Center=�6E   $
��Bold"�6`   $��14(�6r   $	��5,0q�6�   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        $��40��5      $	��─��6(   64   �� 5      -   5        $��40��5      $	��☐��6(   64   �� 5      -   5        $��40��5      $��X��6(   
���  ��
�������6X   5      5      � 5!      $��1��6    � ColumnDefinitions 5"      �� 5#      $	��250 �6'   �� 5%      $��* �6'   .+�5*      �� $��0��6   ���	#FF2C2C2C$��5,5,5,38q�6D   .+�5+      �� $��Contacts��6    
�������$
��Bold"�6C   $��16(�6U   $��10q�6c   �� 5,      -   5        $��ContactList��5,      ���	#FF2C2C2C
�������$��
10,0,10,10q�6[   5-      �� 5.      -   5         ��Name$ btnAddContact��5.      $��Add a Contact+��64   
�������$
��Bold"�6`   ���	#FF2C504F���	#FF2C504F$��30��5/   L   $��10q�6X   50      51      � 54      $��1��6   ���	#FF1E1E1E 55      �� 56      $
��Auto �6(   �� 58      $��* �6(   �� 5:      $
��Auto �6(   .+�5?      �� -   5        $��	ChatTitle��5?       $��0��5@      $��Select a contact��5A      
�������$
��Bold"�5C      $��16(�5D      $��10q�5E      �� 5H      -   5        $��ChatArea��5H   #   $��1��5I      $��
10,0,10,10q�5J      $y�Hidden=�5K      .��5L      �� -	   5        $��MessagesPanel��5L   %   5M      � 5P      -
   5        $��MessageInputGrid��5T      $��2��5P      $��40��5Q      $��
10,0,10,10q�5R       5U      �� 5V      $��* �6/   �� 5W      $
��Auto �6/   .+�5Z      �� -   5        	 ��Name$	 MessageBox2��5Z   "   $��0��5[      $��30��5\      $��Center=�5]      $��0,0,10,0q�5^      
 �� TextWrapping$

 Wrap=�5_      $��Center=�5`      $��14(�5a      $y�Hidden=�6    �� 5c      -   5        $ btnSend��5c   !   $��1��5d      $��80��5e      $��30��5f      $
��Send��5g      ���	#FF2C504F
�������$
��Bold"�5j      $y�Hidden=�5k   '   5l      5m      �� 5n      -   5        $ 	btnLogout��5n      $��Log out��6,   
�������$
��Bold"�6Q   ���	#FF2C504F���	#FF2C504F$��10,385,162,3q�5p      6/   5r      5s      5t      5u      