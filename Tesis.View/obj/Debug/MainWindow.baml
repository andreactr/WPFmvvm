   M S B A M L   `   `   `  ����J  FTesis.ViewModel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:Tesis.ViewModel;assembly=Tesis.ViewModelTesis.ViewModel  5   	   E ATesis.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Tesis.View
Tesis.View 5   	      Tesis.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   L	viewmodel6clr-namespace:Tesis.ViewModel;assembly=Tesis.ViewModel     5   	   *localclr-namespace:Tesis.View     5   	     � Title$  
MainWindow��5	   	   $	��400��6   $	��500��6)    � 	Resources 5      #   Tesis.ViewModel.MainViewModel   MainViewModel��%   &	          5   
   6:   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��40 �6   6+   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6+   �� 5      6   .+�5   
   �� $��0��6   $��0��6    $
��Name��6-   $��15(�6<   $
��Left=�6J   �� 5   
   $��1��6   $��0��6"   $��15(�6/   $
��Left=�6=   $	��270��6p   ��6Y   �� *Name+6p   �� 5   
   $��0��6   $��1��6    $��15(�6-   $	��Age��6<   $
��Left=�6J   �� 5   
   $��1��6   $��1��6"   $��15(�6/   $
��Left=�6=   $	��270��6o   ��6Y   �� *Age+6o   �� 5   
   $��0��6   $��2��6    $��15(�6-   $��Email��6;   $
��Left=�6K   �� 5   
   $��1��6   $��2��6"   $��15(�6/   $
��Left=�6=   $	��270��6q   ��6Y   �� *Email+6q   �� 5!   
   
������ $��0��6*   $��2��6:   $��3��6N   $
��Left=�6[   $��15(�6v   $	��100��6�   ��6�   �� *CreateCommand+.��5"      ��  �� Orientation$ 
Horizontal=�6   .+�5#      �� $��IMG/add.png��6   $��Uniform=�6-   �� 5$      $
�� Add��6   $��15(�6(   $��Center=�66   5%      5&      �� 5'   
   
������ $��0��6*   $��2��6:   $��3��6N   $��Center=�6[   $��15(�6x   $	��100��6�   ��6�   �� *ClearCommand+.��5(      �� $ 
Horizontal=�6   .+�5)      �� $��IMG/Update.jpg��6   $��Uniform=�60   �� 5*      $�� Clear��6   $��15(�6*   $��Center=�68   5+      5,      �� 5-   
   
������ $��0��6*   $��2��6:   $��3��6N   $��Right=�6[   $	��100��6w   ��6�   �� *DeleteCommand+.��5.      �� $ 
Horizontal=�6   .+�5/      �� $��IMG/delete.jpg��6   $��Uniform=�60   �� 50      $�� Delete��6   $��15(�6+   $��Center=�69   51      52      &   System.Windows.Controls.DataGrid  54   
   -   5        $��DG��55      $��0��54      $��2��6#   $��4��67   $��Center=�6D      
IsReadOnly .    SelectionMode$ Extended=�55   <   ��6   �� *People+	 �� SelectedItem	 56      �� *PersonSelected+
 J� InputBindings
 57      d� 58       d� MouseAction$ LeftDoubleClicke�59       �� Command 5:      �� *DoubleClickCommand+ �� CommandParameter 5;      �� *PersonSelected+5=      5>      5?      