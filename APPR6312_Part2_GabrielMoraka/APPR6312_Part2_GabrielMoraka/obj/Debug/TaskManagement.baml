   M S B A M L   `   `   `  ����W  SAPPR6312_Part2_GabrielMoraka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:APPR6312_Part2_GabrielMorakaAPPR6312_Part2_GabrielMoraka  5   	   1    +APPR6312_Part2_GabrielMoraka.TaskManagement   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:APPR6312_Part2_GabrielMoraka     5   	     � Title$  TaskManagement��5   	   $	��600��6!   $	��800��6.   .��5	      � ���#23dbd8 � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   ���#e9edda.+�5      �� $��Task Efforts Manager��6   $��16(�64   $
��Bold"�6B   $��Center=�6T   �� 5      -   5        $��Refresh��5      $
��10,0q�6'   $	��100��65   6A   �� 5      -   5        $��Logout��5      $
��10,0q�6&   $	��108��64   6@   5      �� 5   
   $��1��6   .@�5      �� $��Browse Tasks��6   .��5      �� ���#e9edda.+�5      �� $��Available Tasks��6    $��14(�67   $
��Bold"�6E   $��10q�6W   ���#d9eb9d6c   �� 5      -   5        $��TasksListView��5      $��10q�64   ��5      �� 5       .R�5!   "   �� .+�5"   &   �� $
��Bold"�6J   ��60   �� *
TaskName+6J   �� 5#   &   $
��Wrap=�6Q   ��60   �� *TaskDescription+6Q   5$   #   5%      5'      5(      5)      �� 5,      $��Assign Tasks��6   .��5-      �� ���#e9edda.+�5.      �� $��Assign Task��6    $��14(�63   $
��Bold"�6A   $��10q�6S   ���#d9eb9d6_   �� 5/      -   5        $��TasksComboBox��5/      $��10q�64   $	��300��6@    �� DisplayMemberPath$ TaskName��6L   �� 50      -   5        $��VolunteersComboBox��50      $��10q�69   $	��300��6E   $ VolunteerName��6Q   �� 51      -   5        $��Assign��51      $��10q�6.   $	��100��6:   6F   52      53      �� 56      $��Manage Schedules��6   .��57      �� ���#e9edda.+�58      �� $��Task Schedule��6    $��14(�65   $
��Bold"�6C   $��10q�6U   ���#d9eb9d6a   &   System.Windows.Controls.DataGrid  59      -   5        $��TasksDataGrid��59      $��10q�64      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Task Name��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
TaskName+  5<      $ Assigned To��61    6F   �� *
AssignedTo+5>      5?      5@      �� 5C      $!��Communicate with Volunteers��6   .��5D      �� ���#e9edda.+�5E      �� $��Send Message��6    $��14(�64   $
��Bold"�6B   $��10q�6T   ���#d9eb9d6`   �� 5F      -   5        $��VolunteersMessageComboBox��5F      $��10q�6@   $	��300��6L   $ VolunteerName��6X   �� 5G      -	   5        $��MessageTextBox��5G      $��10q�64   $	��300��6@   $	��100��6L    �� TextWrapping$
 Wrap=�6Y    �� AcceptsReturn . 6m   �� 5H      -
   5        $��Send Message��5H      $��10q�64   $	��100��6@   6L   5I      5J      5K      �� 5N   
   -   5        	 ��Name$	 TextBlockName��5N   N   $��31��6   $
��Left=�6    $��	508,7,0,0q�6;   $	��Top=�6f   $��15(�6~   $��ExtraCondensed&�6�   $	��211��6�   5O      5P      