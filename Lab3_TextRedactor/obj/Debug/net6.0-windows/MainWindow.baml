   M S B A M L   `   `   `  ����J  FLab3_TextEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Lab3_TextEditorLab3_TextEditor  5   	        Lab3_TextEditor.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Lab3_TextEditor     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   `� .�5      c� $
��10 0q�6   .@�5      �� -   5         �� 
IsEditable$
 True��5       �� SelectedIndex$ 0��6-   $��5q�6?   $
��10 5q�6J   .@�5      �� Arial6'   �� 5      Times New Roman61   �� 5      	Verdana6)   5      �� 5      -   5        $
 True��5      $ 1��6-   $��5q�6?   $
��10 5q�6J   .@�5      �� 106$   �� 5      126$   �� 5      366$   5      �� 5      �� 5      -   5        
�������$��2q�5   ,   $��3q�6@   $��5q�6L   .��5       �� $!��Resources/icon-boldText.png��6   $��25��6B   5!      �� 5"      -   5        
�������$��2q�5"   ,   $��3q�6@   $��5q�6L   .��5#      �� $#��Resources/icon-italicText.png��6   $��25��6D   5$      �� 5%      -   5        
�������$��2q�5%   ,   $��3q�6@   $��5q�6L   .��5&      �� $&�� Resources/icon-underlineText.png��6   $��25��6G   5'      �� 5)      �� 5+      $	��5 2q�6   .+�5,      �� Цвет текста:6.   	� 5-      -   5         d� 	IsChecked$
 TrueY�5-   "   .��5.      �� Чёрный6,   5/      	� 50      -   5        .��51      �� 
���  ��Красный6>   52      53      54      55      �� 57   
   -   5         ��Name$ textBox��57      $��1��6#   $��15 10 15 20q�60   59      5:      