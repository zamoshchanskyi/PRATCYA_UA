   M S B A M L   `   `   `  ����E  AChatClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ChatClient
ChatClient  5   	       ChatClient.ListVacancy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ChatClient     5   	   -   5        $	��600��5      $	��800��6'   ���	#FF1E1E1E.��5      �   � RowDefinitions  5   
   �� 5      $	��600 �6    � ColumnDefinitions 5   
   �� 5      $	��800 �6   .+�5   
   �� ���	#FFADFF00$
��Left=�5      $	��569��5      ���	#FF65656E$	��Top=�5      $	��264��5      �� 5   
   -   5         ��Name$ bt_PersonalWorker��5      $'��!Особистий кабінет��5      $
��Left=�5      $��40��5      $��	0,117,0,0q�6   $	��Top=�5      $	��263��5      6   �� 5    
   -   5        $ bt_SearchVacancies��5!      $!��Пошук вакансій��5"      $
��Left=�5#      $��40��5$      $��	0,157,0,0q�6   $	��Top=�5%      $	��263��5&      6   �� 5'   
   -   5        $ bt_DialoguesWorker��5(      $��Мої діалоги��5)      $
��Left=�5*      $��40��5+      $��	0,197,0,0q�6   $	��Top=�5,      $	��263��5-      6   �� 5.   
   -   5        $ bt_MainWindow��5/      $��
Вийти��50      $
��Left=�51      $��40��52      $��	0,519,0,0q�6   $	��Top=�53      $	��263��54      ���	#FFE4E4E0���	#FF1E1E1E55   $   �� 57   
   $��Меню��6   $
��Left=�58      $��38��59      $��0,74,0,0q�6   $	��Top=�5:      $	��126��5;      $��26(�6   $
��Bold"�6*   �� 5<   
   $�� PRATCYA.UA��6   $
��Left=�5=      $��59��5>      $��0,10,0,0q�6   $	��Top=�5?      $	��243��5@      $��35(�6   $
��Bold"�5A      ���	#FF1E1E1E���	#FFADFF005C      �� 5D   
   $'��!Доступні вакансії��6   $
��Left=�5E      $��55��5F      $��
295,10,0,0q�6   $	��Top=�5G      $	��330��5H      $��35(�6   ���	#FFE4E4E2$
��Bold"�5I   '   �� 5K   
   $
��Left=�6   $	��100��5L      $��
655,12,0,0q�6!   $	��Top=�5M      $	��110��6,   ��5N      �� 5O       �� ImageSource$ LOGO.png��6   5Q      �� 5S   
   -   5         ��Name$ lb_NameSurname��5T      $�� ��5U      $
��Left=�5V      $��25��5W      $��
295,70,0,0q�6   $	��Top=�5X      $	��195��5Y      ���	#FF1E1E1E
�������5Z   $   �� 5[   
   -   5        $ 	lb_LoginW��5\      $�� ��5]      $
��Left=�5^      $��25��5_      $��	0,494,0,0q�6   $	��Top=�5`      $	��263��5a      ���	#FF1E1E1E
�������5b   $   &   System.Windows.Controls.DataGrid  5e   
   -   5          Name$ dataGridVacancy��5f         AutoGenerateColumns .  $
��Left=�5h      $	��420��5i      $��295,117,0,0q�6    $	��Top=�5j      $	��470��5k         Columns 5l      0  *System.Windows.Controls.DataGridTextColumn  5m      -	   5        datagridPosition��,  &System.Windows.Controls.DataGridColumn   Header$ Посада��5m   ?   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6Y   �� *
position+  5n      -
   5        datagridSalary��$# Заробітня плата��5n   =   $	 * 6V   
 6`   �� *salary+  5o      -   5        datagridEmployment��$! Тип зайнятості��5o   A   $	 * 6Y   
 6c   �� *
employment+  5p      -   5        datagridCity��$ 
Місто��5p   ;   $	 80 6J   
 6U   �� *city+4  .System.Windows.Controls.DataGridTemplateColumn  5r      $	 80 6)      CellTemplate 5s      �� 5t      .R�5u      �� $ bt_Podrobici��5v   !   -   5        $��20��5y   %   $��Подробиці��5z   %   ��5x   %   �� 5z   %   5{      5}      5      5�      5�      