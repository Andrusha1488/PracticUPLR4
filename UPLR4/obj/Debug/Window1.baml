   M S B A M L   `   `   `  ����@  <UPLR4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UPLR4UPLR4  5   	       UPLR4.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:UPLR4     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��780* �6   �� 5      $	��13* �6   �� 5      $��7* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ OrdersDataGrid��5        5   
   -   5        $ CustomerDataGrid��5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��1��6f   .+�5       �� -   5        $)��#Предыдущая таблица��5       62   �� 5!      -   5        $'��!Следующая таблица��5!      61   5"      �� 5$   
   -   5        $��
Найти��5$      $��0��68   $	��Top=�6E   $��Center=�6]   $��	0,216,0,0q�6z   �� 5%   
   -   5         ��Name$ NameTbxS��5%      $��
Поиск��6$   $��0��62   $��Center=�6?   �� 5'   
   -   5        $ 	NameTbxS2��5'      $��
Поиск��6%   $��0��63   $��Center=�6@   5)      5*      