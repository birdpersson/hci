   M S B A M L   `   `   `  ���� >  :C4Z, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:C4Z.ValidationC4Z.Validation  clr-namespace:C4ZC4Z      C4Z.EventWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,valclr-namespace:C4Z.Validation     #localclr-namespace:C4Z       � Title$  Event��$	��600��$	��450��.����  �� Padding$ 10q�._��  � DataContext �� *Event+ � ColumnDefinitions �� $��* ��� $
��0.1* ��� $��* � � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��0.8* ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��2 2 2 2q�$��0��$��0��
Oznaka*:�� $��2 2 2 2q�$��0��$��1��	Naziv*:�� $��2 2 2 2q�$��0��$��2��Opis:�� $��2 2 2 2q�$��0��$��3��Tip*:�� $��2 2 2 2q�$��0��$��4��
Ikonica:�� $��2 2 2 2q�$��0��$��6��Posecenost dogadjaja:�� $��2 2 2 2q�$��0��$��7��Humanitarnog karaktera:�� $��2 2 2 2q�$��0��$��8��$"Cena troskova za odrzavanje (USD):�� $��2 2 2 2q�$��0��$��9��	Drzava:�� $��2 2 2 2q�$��0��$��10��Grad:�� $��2 2 2 2q�$��0��$��11��Mesto odrzavanja dogadjaja:�� $��2 2 2 2q�$��0��$��12��Istorija datuma odrzavanja:�� $��2 2 2 2q�$��0��$��13��%#Datum odrzavanja za sledecu godinu:�� -    ��Name$
 tbID��$��2 2 2 2q�$��2��$��0��$��Stretch=�.������  �� Path$ Oznaka� �� UpdateSourceTrigger$ PropertyChanged=� �� ValidationRules *  $C4Z.Validation.EventIDValidationRule  ,  &System.Windows.Controls.ValidationRule	   ValidationStep$	 RawProposedValue=�.���� -   $ tbName��$��2 2 2 2q�$��2��$��1��$��Stretch=�.������ $ Naziv�$ PropertyChanged=� '  !C4Z.Validation.NameValidationRule  $	 RawProposedValue=�.���� $��2 2 2 2q�$��2��$��2��$��Stretch=�.���� ���� *Opis+�� -   
 ��Name$
 cbType��$��2 2 2 2q�$��2��$��3��$��Stretch=����� $ Types� �� RelativeSource ��  �� AncestorType" � �� SelectedValue �� *Tip+���� .R��� ���� *Naziv+� $��64��$��2 2 2 2q�$��2��$��4��$��Stretch=� �� $��* ��� $��* �.+��� -   $��imgIcon��$��2 2 2 2q�$��Uniform=�$��0������ *	Ikonica+�� $��2 2 2 2q�$��1��.+��� -   $��2 2 2 2q�.��Choose�� -   $��2 2 2 2q�.��	Discard�� -    ��Name$ UnchosenTags��$��2 2 2 2q�$��0��$��5��
����������� *Tags+ �� " ����� .R���  �� Orientation$ 
Horizontal=�.+�� $��2 2 2 2q�$��20������ *Boja+�� ���� *Oznaka+�� $��1��$��5��$��Center=�.+��� -   .��>�� -	   .��<�� -
   $ 
ChosenTags��$��2 2 2 2q�$��2��$��5������ *Tags+���� .R��� $ 
Horizontal=�.+�� $��2 2 2 2q�$��20������ *Boja+�� ���� *Oznaka+�� $��2 2 2 2q�$��2��$��6��$��Stretch=� �� SelectedIndex �� *
Posecenost+.@��� .��	Do 1000�� .��	1000-5000�� .��
5000-10000�� .��Preko 10000�� $��2 2 2 2q�$ 
Horizontal=�$��2��$��7��$��Stretch=�.+�	� $��2 2 2 2q� d� 	IsChecked �� *Humanitarna+.��Da	� $��2 2 2 2q�$
 TrueY�.��Ne�� $��2 2 2 2q�$��2��$��8��$��Stretch=����� *Cena+�� $��2 2 2 2q�$��2��$��9��$��Stretch=����� *Drzava+�� $��2 2 2 2q�$��2��$��10��$��Stretch=����� *Grad+�� $��2 2 2 2q�$��2��$��11��$��Stretch=����� *Mesto+�� $��2 2 2 2q�$��2��$��12��$��Stretch=�$)��#ToDo: Change so it binds with graph��(  "System.Windows.Controls.DatePicker  $��2 2 2 2q�$��2��$��13��$��Stretch=�   SelectedDate �� *Datum+�� -    ��Name$ btnOK��$��2 2 2 2q�$��0��$��14��{�.  .��Ok�� -   $��2 2 2 2q�$��2��$��14��.��Cancel