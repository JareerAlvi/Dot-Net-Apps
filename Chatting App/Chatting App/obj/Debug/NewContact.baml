   M S B A M L   `   `   `  ����G  CChatting App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Chatting_AppChatting_App  5   	       Chatting_App.NewContact   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Chatting_App     5   	     � Title$  Chatting App��5   	   $	��450��5	   	   $	��657��6    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ 	CanResize=�5   	    � AllowsTransparency . ���	#FF232121 � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� $��1q�6   
�������._�5   
   �  J� RenderTransformOrigin$ 0.478,0.505&�6   $��0,0,-1,0q�63   .+�5      ]� -   5        ���	#FF2C504F$��30��5   /   $	��Top=�6;   .+�5      �� $�� Chatting App��6   
�������$��Center=�6D   $
��Bold"�6_   $��14(�6q   $
��10,0q�6   �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   ��5      �� 5       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5      � 	 � Color$	 Black��6+   � 5      $	 White��6+   
 � Offset$
 1Q�69   5      .+�5      �� -   5        $��40��5      $��30��6(   $	��─��64   6@   �� 5      -   5        $��40��5      $��30��6(   $��X��64   
���  ��
�������6d   5      5       � 5#      $��170,107,183,99q�6    � ColumnDefinitions 5$      �� 5%      $	��75* �6'   �� 5&      $
��227* �6'   .+�5(      ��  �� CornerRadius$ 10��6   
������� �� Padding$ 20q�6>   $
��Left=�5)      $	��300��5*      $��1,-21,0,-45q�6   $��2��62   ._�5+      �� $��Center=�6!   $��Center=�6>   5,      �� 5-      -   5         ��Name$ 	lbWarning��5-      ���	#FFFF1010$
��Bold"�6F   $��52,210,50,10q�6X   $ 0.48,-0.562&�6n   $��2��6�   �� 5.      -   5         ��Name$ 
btnConfirm��5.      ���#2980B9
�������$
��Bold"�5/   A    � Cursor$
 Hand��50      $	��Add��6)   $��31,162,122,45q�68   $ 0.541,0.343&�6O   $��1��6s   6�   �� 51      -   5        $ 	lbHeading��51      $��New Contact��6/   $��22(�6B   $
��Bold"�6P   ���#2C3E50$
��Left=�52   1   $��
10,0,0,213q�6L   $��1��6`   �� 53      -   5         ��Name$ txtContactNumber��53      $��52,103,50,109q�64   $��5q�54      ���#2980B9$��2q�6<    �� 	MaxLength$ 11��6Q   
�������$��2��6�   �� 55      $��Contact-No:��6   
���   �$
��Bold"�6B   $��2��6T   $��52,82,50,144q�6h   56      �� 58      -   5        $ lb_Name��58      $��Name:��6)   
���   �$
��Bold"�6I   $��221,247,234,185q�6[   $y�Hidden=�6t   �� 59      -	   5        $ txtName��59      $��221,263,234,155q�6(   $��5q�5:      ���#2980B9$��2q�63   $y�Hidden=�6G   5;      5<      5=      