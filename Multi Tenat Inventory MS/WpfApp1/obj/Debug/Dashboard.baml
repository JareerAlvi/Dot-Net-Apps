   M S B A M L   `   `   `  ����  WpfApp1    IMS.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Tenant Dashboard��5   	   $	��500��6"   $	��900��6/    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ 	CanResize=�6.   ���#2C3E50.��5      � $��20q�6   .+�5	   
   ��  �� CornerRadius$ 10��6   
������� �� Padding$ 15q�66   ._�5
      �� 
�������$��14(�6,   $��SemiBold"�6:   .@�5      �� $��📦 Products��6   .��5      � $��10q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgProducts��5   #      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��65   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *	ProductID+  5   "   $
	 Name��65   
 6C   �� *Name+  5   "   $	 Quantity��65   
 6G   �� *
Quantity+  5   "   $	 Price��65   
 6D   �� *Price+5      5      5      �� 5      $��Inventory Report��6   .��5      �� $
��Auto=�6#   .��5      �� 
�������$��30q�64   $ 20q�6@   $ 10��6M   ���#2980B9$��1q�6u   ._�5      �� .+�5   "   �� $��Inventory Overview��6,   $��20(�6F   $
��Bold"�6T   ���#2C3E50$��0,0,0,20q�6{   �� 5   "   $	��0,5q�6-   .+�5    &   �� $��Total Products:��60   $
��Bold"�6G   �� 5!   &   -   5         ��Name$ txtTotalProducts��5!   0   ���#2980B96J   5"   #   �� 5$   "   $	��0,5q�6-   .+�5%   &   �� $��In Stock Products:��60   $
��Bold"�6J   �� 5&   &   -   5        $ 
txtInStock��5&   0   ���#27AE606D   5'   #   �� 5)   "   $	��0,5q�6-   .+�5*   &   �� $��Out of Stock Products:��60   $
��Bold"�6N   �� 5+   &   -   5        $ txtOutOfStock��5+   0   ���#C0392B6G   5,   #   �� 5.   "   $	��0,5q�6-   .+�5/   &   �� $��Low Stock (< 10):��60   $
��Bold"�6L   �� 50   &   -   5        $ txtLowStock��50   0   ���#F39C126E   51   #   �� 53   "   $	��0,5q�6-   .+�54   &   �� $��Total Quantity in Stock:��60   $
��Bold"�6P   �� 55   &   -   5        $ txtTotalQuantity��55   0   ���#8E44AD6J   56   #   �� 58   "   $	��0,5q�6-   .+�59   &   �� $#��Average Quantity per Product:��60   $
��Bold"�6U   �� 5:   &   -   5        $ txtAverageQuantity��5:   0   ���#16A0856L   5;   #   5<      5=      5>      5?      �� 5@      $��🧾 Orders��6   .��5A      � $��10q�6    � RowDefinitions 5B      �� 5C      $��* �6,   �� 5D      $
��Auto �6,   .+�5G        -   5        $ dgOrders��5G   #    .  $��0��5H      ���#2980B9$��1q�5I   !      RowBackground �#ECF0F1   AlternatingRowBackground �#D6EAF8 .    HeadersVisibility$ Column=�5K         SelectionMode$ Single=�5L         SelectionUnit$ FullRow=�6"    5M        5N   "   $	 Order ID��65   
 6G   �� *	OrderID+  5O   "   $	 
Product ID��65   
 6I   �� *	ProductID+  5P   "   $	 Quantity��65   
 6G   �� *
Quantity+  5Q   "   $	 
Order Date��65   
 6I   �� *	OrderDate+ �� StringFormat$ d��5S      �� 5U      -	   5        $��Create Order��5U   !   $��1��68   $	��140��6E   $��40��6Q   ���#27AE60
�������$
��Bold"�5V   I   $��0,15,0,0q�5W   !   $��Right=�63    � Cursor$
 Hand��5X   !   5Y      5Z      �� 5[      -
   5         ��Name$ tabUsers��5[   ,   $��
👥 Users��6   $y�	Collapsed=�6>   .��5\      � $��10q�6   .+�5]        -   5        $ dgUsers��5]   #    . ���#2980B9$��1q�5^   9    �#ECF0F1 �#D6EAF85_   ;   5`      5a      5b      5c      5d      5e      