   M S B A M L   `   `   `  ���� l  hSystem.Windows.Controls.DataVisualization.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  > :C4Z, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:C4ZC4Z    C4Z.TableWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     �dvc{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     #localclr-namespace:C4Z       � Title$  Table��$	��450��$	��800��.���  � ColumnDefinitions ��  � RowDefinitions �� .+��� .@��� $��Event��.���  �� �� $��0.75* �.+�&   System.Windows.Controls.DataGrid  -     Name$ dgEvents��$��2 2 2 2q�   
IsReadOnly .    AutoGenerateColumns .  ����  �� Path$ Data.Events�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Ikonica��	   CellTemplate	 �� .R��� $��28��$��Uniform=����� *	Ikonica+0  *System.Windows.Controls.DataGridTextColumn  $ Naziv��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *Naziv+  $ Oznaka��
 �� *Oznaka+  $
 Opis��
 �� *Opis+� $��1�� �� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� �� $
��Auto �.+��� -    ��Name$ tbSearchEvent��$��2 2 0 2q�$��0��$��0���� -   $��0 2 0 2q�$��1��$��0��.���� $��21��$!��/Images/basic_magnifier.png���� -   $��0 2 2 2q�$��2��$��0��.���� $��21��$��/Images/arrows_remove.png��>   8System.Windows.Controls.DataVisualization.Charting.Chart  $��2 2 2 2q�$��3��$��1��   Series. B   <System.Windows.Controls.DataVisualization.Charting.PieSeries  � $��2��$��3�� �� �� �� .+��� -   $��2 2 2 2q�$��0��.��Search�� -   $��2 2 2 2q�$��1��.��Edit�� -   $��2 2 2 2q�$��2��.��Delete�� $
��Type��.���  �� �� $��0.75* �.+�  -   $ dgTypes��$��2 2 2 2q� .  .  ���� $ 
Data.Types�   $ Ikonica��	 �� .R��� $��28��$��Uniform=����� *	Ikonica+  $ Naziv��
 �� *Naziv+  $ Oznaka��
 �� *Oznaka+  $
 Opis��
 �� *Opis+� $��1�� �� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� �� $
��Auto �.+��� -	   $ tbSearchType��$��2 2 0 2q�$��0��$��0���� -
   $��0 2 0 2q�$��1��$��0��.���� $��21��$!��/Images/basic_magnifier.png���� -   $��0 2 2 2q�$��2��$��0��.���� $��21��$��/Images/arrows_remove.png��  $��2 2 2 2q�$��3��$��1��.   � $��2��$��3�� �� �� �� .+��� -   $��2 2 2 2q�$��0��.��Search�� -   $��2 2 2 2q�$��1��.��Edit�� -   $��2 2 2 2q�$��2��.��Delete�� $	��Tag��.���  �� �� $��0.75* �.+�  -   $ dgTags��$��2 2 2 2q� .  .  ���� $ 	Data.Tags�   $
 Boja��	 �� .R�� $��28������ *Boja+  $ Oznaka��
 �� *Oznaka+  $
 Opis��
 �� *Opis+� $��1�� �� �� $
��Auto ��� $
��Auto � �� $
��Auto ��� �� $
��Auto �.+��� -   $ tbSearchTag��$��2 2 0 2q�$��0��$��0���� -   $��0 2 0 2q�$��1��$��0��.���� $��21��$!��/Images/basic_magnifier.png���� -   $��0 2 2 2q�$��2��$��0��.���� $��21��$��/Images/arrows_remove.png��  $��2 2 2 2q�$��3��$��1��.   � $��2��$��3�� �� �� �� .+��� -   $��2 2 2 2q�$��0��.��Search�� -   $��2 2 2 2q�$��1��.��Edit�� -   $��2 2 2 2q�$��2��.��Delete