   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseltHome   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � ��5
   
   �� 5       �� ImageSource$ IC816740.jpeg��6   67    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��3��6    $��Bottom=�6-   ��6H   ��  �� Path$ LastChecked��� 5   
   $��1��6   ��6    ��  �� RelativeSource ��  �� AncestorType" �$ MainCaptionText�6�   �� 5   
   $��35��6    �� Padding$ 5q�6   ���#4E87D4$��1��6>   $��1��6N   ._�5      �� $��Center=�6   
�������.��6D   Names6K   5      �� 5   
   -   5         ��Name$ peopleListBox��5      $��1��6)   $��2��69   ��6F   ��  �� " �$ ExpenseDataSource���5      �� 5      .R�5      �� ��6   �� $
 Name�6=   5       5"      �� 5#   
   -   5        $��0,10,0,0q�5#      $��1��6#   $��3��63   $	��125��6@   $��25��6L   $��Right=�6X   ��6�   �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�6�   5$      5%      