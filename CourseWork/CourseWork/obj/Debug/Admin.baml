   M S B A M L   `   `   `  ����E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CourseWork
CourseWork  5   	       CourseWork.Admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CourseWork     5   	     � Title$  Admin��5   	   $
��Auto��6   $
��Auto��6%   .��5	      � $��	0,-6,24,0q�6    � ColumnDefinitions 5
   
   �� 5      $
��395* �6   �� 5      $
��459* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $
��Left=�6   $��	37,35,0,0q�6.   $	��Top=�6A   $	��120��6Y   $��21��6e   �� 5   
   $
��Left=�6   $��	37,22,0,0q�6/   $
��Wrap=�6B   $��	TextBlock��6V   $	��Top=�6g   $��13��6   $��47��6�   �� 5   
   $
��Left=�6   $	��437��6,   $��	37,61,0,0q�69   $	��Top=�6L   $	��704��6d   $��2��6p   .+�5      ��  �� Left$	 142��6   $
��Wrap=�6*   $��	TextBlock��6>   
 �� Top$ 12��6O   �� 5      $��22��6   $	 142��6"    �� TextWrapping$
 Wrap=�64   $��TextBox��6H   $ 30��6W   $	��120��6g   �� 5      $��Button��6   $
��Left=�6&   $	��Top=�6A   $��74��6Y   $	 604��6d   $ 30��6v    J� RenderTransformOrigin$ 3.547,0.975&�6�   $��22��6�   &   System.Windows.Controls.DataGrid  5      $
��Auto��6   $ 10��6%   $ 70��66   $
��Auto��6F      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6G   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6[   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *	FirstName+6[     5      $ 	Last Name��6F   $		 100 6Y   
 6)   �� *
LastName+6Y     5      $ 
Patronymic��6H   $		 100 6\   
 6)   �� *
Patronymic+6\     5      $ Adress��6D   $		 100 6T   
 6)   �� *Adress+6T     5      $ Phone Number��6I   $		 100 6_   
 6)   �� *PhoneNumber+6_     5       $ Email��6C   $		 100 6R   
 6)   �� *Email+6R     5!      $ Regular��6E   $	 80 6V   
 6)   �� *	Regular+6V     5"      $ Discount ID��6H   $	 80 6]   
 6)   �� *
DiscountID+6]   5%      �� 5&      $ 10��6   $
��Wrap=�6)   $��	TextBlock��6=   $ 12��6N   �� 5'      $��22��6   $ 10��6"   $
 Wrap=�63   $��TextBox��6G   $ 30��6V   $	��120��6f   �� 5(      $��CheckBox��6   $	 292��6*   $ 34��6<   5,      5-      5.      