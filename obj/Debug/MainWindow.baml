   M S B A M L   `   `   `  ����S  OLogicielGestionCommandes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LogicielGestionCommandesLogicielGestionCommandes  5   	   )    #LogicielGestionCommandes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LogicielGestionCommandes     5   	   -   5          � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ 
MainWindow��5   	   $	��450��6   $	��650��6)   .��5      � .+�5   
   �� 
����  �6   �� 5   
   
������$��75��5      $��20q�5      $	��Top=�5       �� CornerRadius$ 50��5      ._�5      �� $$��Logiciel Gestion des Commandes��6   $��35(�5      $��20,0,0,0q�5      
�������$��Center=�5      5      �� 5   
   -   5        $��Quitter��5      $	��140��5      $��50��5      $��Bottom=�5      $��Right=�5      $��10q�5      $��Quitter��5      $��25(�5!      5"      � 5$   
    � ColumnDefinitions 5%      �� 5&      $	��325 �6#   �� 5'      $	��325 �6#    � RowDefinitions 5)      �� 5*      $	��100 �6    �� 5+      $��* �6    �� 5,      $��* �6    �� 5-      $��60 �6    .+�5/      �� -   5        $��Client��5/      $	��300��50      $	��130��51      $��Clients��52      $��0��6#   $��1��63   
�������
����  �$��30(�55      58      �� 59      -   5        $
��comd��59      $	��300��5:      $	��130��5;      $��	Commandes��5<      $��1��5=      $��1��6!   
�������
����  �$��30(�5@      5C      �� 5D      -   5        $
��Prod��5D      $	��300��5E      $	��130��5F      $��Produits��5G      $��0��5H      $��2��6!   
�������
����  �$��30(�5L      5N      �� 5O      -   5        $��detComd��5O      $	��300��5P      $	��130��5Q      $��Details Commandes��5R      
�������
����  �$��30(�5U      $��1��5W      $��2��6!   5Y      5[      5^      5_      