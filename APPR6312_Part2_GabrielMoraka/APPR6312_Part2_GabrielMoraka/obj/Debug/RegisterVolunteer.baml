   M S B A M L   `   `   `  ����W  SAPPR6312_Part2_GabrielMoraka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:APPR6312_Part2_GabrielMorakaAPPR6312_Part2_GabrielMoraka  5   	   4    .APPR6312_Part2_GabrielMoraka.RegisterVolunteer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:APPR6312_Part2_GabrielMoraka     5   	     � Title$  RegisterVolunteer��5   	   $	��394��6#   $	��552��60   .��5	      � ���#23dbd8$��10,14,10,10q�6    .+�5
   
   �� -   5        $��textBlockHeading��5
   M   $��23��6   $
��Left=�6    $��10,5,0,0q�6;   $��Register as a Volunteer:��6e   $	��Top=�6�   $	��191��6�   $��17(�6�   $��ExtraCondensed&�6�   � 5   
   $��
31,67,29,0q�6   
�������$	��277��66   $	��Top=�6C    � RowDefinitions 5      �� 5      $
��252* �6    .+�5      �� -   5         ��Name$ errormessage��5   T   $��34��6   $��Center=�6$   $��	0,161,0,0q�6A   $	��Top=�6k   $	��282��6�    J� OpacityMask
 �  �����	#FFE5572C6�   �� 5      -   5        $��textBlockFirstname��5   R   $��23��6   $
��Left=�6$   $��	67,20,0,0q�6?   $��First Name:��6l   $	��Top=�6   $	��110��6�   �� 5      -   5        $��textBlockLastName��5   R   $��23��6   $
��Left=�6$   $��	67,50,0,0q�6?   $��
Last Name:��6k   $	��Top=�6}   $	��110��6�   �� 5      -   5        $��textBlockcell��5   R   $��20��6   $
��Left=�6$   $��	67,78,0,0q�6?   $��Cell Phone:��6g   $	��Top=�6z   $	��110��6�   �� 5      -   5        $��textBlockskill��5   S   $��20��6   $
��Left=�6$   $��
67,110,0,0q�6?   $��	Password:��6i   $	��Top=�6z   $	��110��6�   �� 5      -   5        $��textBoxFirstName��5   Q   $��23��6   $
��Left=�6"   $��
183,20,0,0q�6=   $	��Top=�6i   $	��222��6�   �� 5      -   5        $��textBoxLastName��5   Q   $��23��6   $
��Left=�6"   $��
183,50,0,0q�6=   $	��Top=�6h   $	��222��6�   �� 5      -	   5        $��Submit��5   d   $��Register��6   $��23��6(   $
��Left=�64   $��183,215,0,0q�6O   $	��Top=�6r   $��70��6�   6�   �� 5       -
   5        $��button2��5    a   $��Reset��6   $��23��6%   $
��Left=�61   $��259,215,0,0q�6L   $	��Top=�6p   $��70��6�   6�   �� 5!      -   5        $��button3��5!   `   $
��Back��6   $��23��6$   $��Right=�60   $��
0,215,60,0q�6L   $	��Top=�6o   $��70��6�   6�   �� 5"      -   5         ��Name$ textBoxcellphone��5"   Q   $��24��6   $
��Left=�6"   $��
184,78,0,0q�6=   $	��Top=�6k   $	��222��6�   G� 5#      -   5         G�Name$ textBoxpassword��5#   V   $��24��6   $
��Left=�6&   $��184,106,0,0q�6A   $	��Top=�6o   $	��222��6�   �� 5&      -   5        $��Login��5&   S   $��40��6   $
��Left=�6$   $��
10,207,0,0q�6?   $	��Top=�6`   $��12(�6x   $��Italic$�6�    �� Padding$ 5q�6�    J� RenderTransformOrigin$ 0.486,0.477&�6�   $	��167��6�   Already have an acount�� 5(      	click on �� 5+      �� 5,      -   5        $��14(�5,   -   $��Normal$�6;   .�6N   Login6U   5-      50      52      53      54      