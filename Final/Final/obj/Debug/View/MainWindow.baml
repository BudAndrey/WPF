   M S B A M L   `   `   `  ����@  <Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:FinalFinal  5   	   1clr-namespace:Final.ViewModelFinal.ViewModel  5   	       Final.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Final     5   	   ,vmclr-namespace:Final.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��14* �6   .+�5   
   �� $��1��6   $
��auto��6a   ��6   �� *Cars+ �� SelectedItem 6<   �� *SelectedCar+��5      �� 5      .R�5      �  5      �� 5      $��2* �6/   �� 5       5      �� 5      �� 5       .+�5"      �� $��2��6!   $��2��65   
���   �$��1q�6Z   �� 5$       �� Orientation$ 
Horizontal=�6%   .+�5%      �� $��0,0,10,0q�6(   ��6:   �� *Title+�� 5&      ��6(   �� *Model+5'      �� 5(      $��1��6%   $ 
Horizontal=�62   .+�5)      �� $��0,0,10,0q�6>   ��6(   �� *Year+6>   �� 5*      
������$��12��68   $	��100��6D    �� RadiusX$ 5��6g    �� RadiusY$ 5��6s   ��6P   �� *Color+6s   5+      �� 5,      $��1��6    $��2��60   $	��100��6]   $��40��6i   ��6A   �� *
ImageUrl+6i   5-      5.      50      �� 52   
   $ 
Horizontal=�6   $��1��6.   .+�53      ��  �� Orientation$ 
Horizontal=�6   $	��100��6.   $
��Left=�6:   $��1��6U    � Maximum$
 1300Q�6~   	 � Minimum$		 100Q�6�   
 � Value
 6e   �� *Slider+6�   �� 54      .��55      �� $ 
Horizontal=�6   .+�56      	� $��Light��6"    d� 	IsChecked$
 TrueY�62   ��6C   �� *LightViewCommand+	� 57      $
��Dark��6"   ��61   �� *DarkViewCommand+58      59      5:      �� 5;   
   $ 
Horizontal=�6   .+�5<      �� $
��Left=�6   $��80��60   ��6;   �� *SaveCommand+.��6\   Save6b   �� 5=      $
��Left=�6   $��80��60   $��10(�6[   ��6;   �� *LoadCommand+.��6i   Load6o   o� 5>      $
��Left=�6   $��
0,0,0,-0.2q�6/   $��0,4,0,0q�6C   .@�5?      m� $
��CRUD��6   .@�5@      m� $��Create��6    m� Command 6/   �� *CreateCommand+m� 5A      $��Update��6    6/   �� *UpdateCommand+m� 5B      $��Delete��6    6/   �� *RemoveCommand+5C      m� 5D      $
��Sort��6   .@�5E      m� $��Sort by Title��6    66   �� *SortTitleCommand+m� 5F      $��Sort by Model��6    66   �� *SortModelCommand+m� 5G      $��Sort by Year��6    65   �� *SortYearCommand+m� 5H      $��Sort by Color��6    66   �� *SortColorCommand+5I      5J      5K      �� 5L   
   $��1��6   $��1��6&   ��66   �� *CurrentView+6X   5M      5N      