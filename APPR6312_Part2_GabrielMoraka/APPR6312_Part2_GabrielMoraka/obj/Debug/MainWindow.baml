   M S B A M L   `   `   `  ����W  SAPPR6312_Part2_GabrielMoraka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:APPR6312_Part2_GabrielMorakaAPPR6312_Part2_GabrielMoraka  5   	   -    'APPR6312_Part2_GabrielMoraka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:APPR6312_Part2_GabrielMoraka     5   	     � Title$  
MainWindow��5      $	��394��6   $	��552��6(   .��5	      � ���#23dbd8$��10,14,10,10q�6    .+�5
   
   �� -   5        $��textBlockHeading��5
   M   $��23��6   $
��Left=�6    $��10,5,0,0q�6;   $��Registration:��6e   $	��Top=�6z   $	��110��6�   $��17(�6�   $��ExtraCondensed&�6�   �� 5   
   -   5        $��440,5,12,308q�5      $��Login��6'    � Cursor$
 Hand��67   ��5      �� 5       �� 
TargetType" ��6"   .R�5      �� $��	Underline{�6    �� 5      5      5      ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value �#00000063    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  � ��
 �  ��6;   5      5      5      � 5    
   $��
31,0,29,23q�6   
�������$	��264��66   $��Bottom=�6C   	 � RowDefinitions	 5!      �� 5"      $
��252* �6    .+�5%      �� -   5        
 ��Name$
 errormessage��5%   Q   $��20��6   $
��Left=�6$   $��67,0,0,0q�6?   $	��Top=�6h   $	��266��6�    J� OpacityMask
 �  �����	#FFE5572C6�   �� 5&      -   5        $��textBlockFirstname��5&   R   $��23��6   $
��Left=�6$   $��	67,20,0,0q�6?   $��First Name:��6l   $	��Top=�6   $	��110��6�   �� 5'      -   5        $��textBlockLastName��5'   R   $��23��6   $
��Left=�6$   $��	67,50,0,0q�6?   $��
Last Name:��6k   $	��Top=�6}   $	��110��6�   �� 5(      -   5        $��textBlockUserName��5(   R   $��23��6   $
��Left=�6$   $��	67,80,0,0q�6?   $��UserName��6k   $	��Top=�6{   $	��110��6�   �� 5)      -   5        $��textBlockPassword��5)   S   $��23��6   $
��Left=�6$   $��
67,107,0,0q�6?   $��	Password:��6l   $	��Top=�6}   $	��110��6�   �� 5*      -   5        $��textBlockConfirmPwd��5*   S   $��23��6   $
��Left=�6$   $��
67,136,0,0q�6?   $��ConfirmPassword:��6n   $	��Top=�6�   $	��110��6�   $��2��6�   �� 5-      -	   5        $��textBoxFirstName��5-   Q   $��23��6   $
��Left=�6"   $��
183,20,0,0q�6=   $	��Top=�6i   $	��222��6�   �� 5.      -
   5        $��textBoxLastName��5.   Q   $��23��6   $
��Left=�6"   $��
183,50,0,0q�6=   $	��Top=�6h   $	��222��6�   �� 5/      -   5        $��textBoxUserName��5/   Q   $��23��6   $
��Left=�6"   $��
183,80,0,0q�6=   $	��Top=�6h   $	��222��6�   G� 51      -   5        $��passwordBox1��51   V   $��23��6   $
��Left=�6&   $��183,107,0,0q�6A   $	��Top=�6j   $	��222��6�   G� 53      -   5        $��passwordBoxConfirm��53   V   $��23��6   $
��Left=�6&   $��183,136,0,0q�6A   $	��Top=�6p   $	��222��6�   �� 55      -   5        $��Submit��55   b   $��Submit��6   $��23��6&   $
��Left=�62   $��183,204,0,0q�6M   $	��Top=�6p   $��70��6�   6�   �� 56      -   5        $��button2��56   a   $��Reset��6   $��23��6%   $
��Left=�61   $��259,204,0,0q�6L   $	��Top=�6p   $��70��6�   6�   �� 57      -   5        $��button3��57   b   $��Cancel��6   $��23��6&   $��Right=�62   $��
0,204,60,0q�6N   $	��Top=�6q   $��70��6�   6�   58      59      5:      