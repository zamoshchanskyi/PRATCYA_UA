   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.CreateVacancy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	   -   5        $	��600��5      $	��800��6(   ���	#FF1E1E1E.��5      �   J� RenderTransformOrigin$  0.5,0.5&�6    � RowDefinitions 5   
   �� 5      $	��600 �6    � ColumnDefinitions 5   
   �� 5      $��22 �6   �� 5      $��25 �6   �� 5      $��35 �6   �� 5      $	��718 �6   .+�5   
   �� ���	#FFADFF00$
��Left=�5      $	��569��5      ���	#FF65656E$	��Top=�5      $	��264��5      $��4��6    �� 5   
   -   5         ��Name$ bt_PersonalEmployer��5      $'��!Особистий кабінет��5      $
��Left=�5      $��40��5       $��	0,117,0,0q�6   $	��Top=�5!      $	��263��5"      $��4��5#   /   �� 5$   
   -   5        $ bt_CreateVacancy��5%      $'��!Створити вакансію��5&      $
��Left=�5'      $��40��5(      $��	0,157,0,0q�6   $	��Top=�5)      $	��263��5*      $��4��5+   ,   �� 5,   
   -   5        $ bt_DialoguesEmployer��5-      $��Мої діалоги��5.      $
��Left=�5/      $��40��50      $��	0,197,0,0q�6   $	��Top=�51      $	��263��52      $��4��53   0   �� 54   
   -   5        $ bt_MainWindow��55      $��
Вийти��56      $
��Left=�57      $��40��58      $��	0,519,0,0q�6   $	��Top=�59      $	��263��5:      ���	#FFE4E4E0���	#FF1E1E1E$��4��5<      �� 5=   
   $)��#Створення вакансії��6   $
��Left=�5>      $��55��5?      $��
213,10,0,0q�6   $	��Top=�5@      $	��340��5A      $��35(�6   $��3��6*   ���	#FFE4E4E2$
��Bold"�5B   '   �� 5D   
   $
��Left=�6   $	��100��5E      $��573,0,0,488q�6!   $��Bottom=�5F      $	��110��6/   $��3��6;   ��5G      �� 5H       �� ImageSource$ LOGO.png��6   5J      �� 5L   
   -   5         ��Name$ tb_Position��5M      $
��Left=�5N      $��22��5O      $��213,145,0,0q�6    �� TextWrapping$
 Wrap=�5P      $�� ��6!   $	��Top=�5Q      $	��306��5R      $��3��6   �� 5S   
   -   5        $ 	tb_Salary��5T      $
��Left=�5U      $��22��5V      $��213,197,0,0q�6   $
 Wrap=�5W      $�� ��6!   $	��Top=�5X      $	��306��5Y      $��3��6   �� 5Z   
   -   5        $ tb_Description��5[      $
��Left=�5\      $	��147��5]      $��213,252,0,0q�6   $
 Wrap=�5^      $�� ��6!   $	��Top=�5_      $	��306��5`      $��3��6   �� 5a   
   -	   5        $ tb_City��5b      $
��Left=�5c      $��22��5d      $��213,427,0,0q�6   $
 Wrap=�5e      $�� ��6!   $	��Top=�5f      $	��306��5g      $��3��6   �� 5h   
   -
   5        $ tb_Employment��5i      $
��Left=�5j      $��22��5k      $��213,482,0,0q�6   $
 Wrap=�5l      $�� ��6!   $	��Top=�5m      $	��306��5n      $��3��6   �� 5p   
   $��Посада��6   $
��Left=�5q      $��28��5r      $��213,117,0,0q�6   $	��Top=�5s      $	��306��5t      $��3��6   
�������6,   �� 5u   
   $��Опис��6   $
��Left=�5v      $��28��5w      $��213,224,0,0q�6   $	��Top=�5x      $	��306��5y      $��3��6   
�������6,   �� 5z   
   $#��Заробітня плата��6   $
��Left=�5{      $��28��5|      $��213,172,0,0q�6   $	��Top=�5}      $	��306��5~      $��3��6   
�������6,   �� 5   
   $��
Місто��6   $
��Left=�5�      $��28��5�      $��213,399,0,0q�6   $	��Top=�5�      $	��306��5�      $��3��6   
�������6,   �� 5�   
   $!��Тип зайнятості��6   $
��Left=�5�      $��28��5�      $��213,454,0,0q�6   $	��Top=�5�      $	��306��5�      $��3��6   
�������6,   �� 5�   
   -   5         ��Name$ lb_NameSurname��5�      $�� ��5�      $
��Left=�5�      $��25��5�      $��
213,74,0,0q�6   $	��Top=�5�      $	��195��5�      ���	#FF1E1E1E
�������$��3��5�      �� 5�   
   -   5        $ lb_Login��5�      $�� ��5�      $
��Left=�5�      $��25��5�      $��	1,494,0,0q�6   $	��Top=�5�      $	��262��5�      ���	#FF1E1E1E
�������$��4��5�      �� 5�   
   -   5        $ 
bt_CreateV��5�      $��Створити��5�      $
��Left=�5�      $��27��5�      $��289,525,0,0q�6   $	��Top=�5�      $	��153��5�      $��3��5�      ���	#FFADFF006   �� 5�   
   $�� PRATCYA.UA��6   $
��Left=�5�      $��59��5�      $��0,10,0,0q�6   $	��Top=�5�      $	��243��5�      $��35(�6   $
��Bold"�5�      ���	#FF1E1E1E���	#FFADFF00$��4��5�   '   �� 5�   
   $��Меню��6   $
��Left=�5�      $��38��5�      $��0,74,0,0q�6   $	��Top=�5�      $	��126��5�      $��26(�6   $
��Bold"�6*   $��4��6<   5�      5�      