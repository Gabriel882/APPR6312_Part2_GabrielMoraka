   M S B A M L   `   `   `  ����W  SAPPR6312_Part2_GabrielMoraka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:APPR6312_Part2_GabrielMorakaAPPR6312_Part2_GabrielMoraka  5   	   0    *APPR6312_Part2_GabrielMoraka.ManageProfile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:APPR6312_Part2_GabrielMoraka     5   	     � Title$  ManageProfile��5   	   $	��450��6   $	��460��6,   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Profile Management��6   $��20(�6.   $
��Bold"�6<   $��Center=�6N   $��0,0,0,20q�6k   $��0��6}   �� 5   
   $��Current Name:��6   $��	0,34,0,28q�6)   $��2��6<   �� 5   
   -   5         ��Name$ NameTextBox��5      $��0,7,0,8q�6'   $��1��68   �� 5   
   $��Current Username:��6   $��	0,30,0,27q�6-   $��1��6@   $��3��6M   �� 5   
   -   5        $ UsernameTextBox��5      $��0,11,0,4q�6+   $��3��6=   �� 5   
   $��New Password:��6   $��	0,30,0,26q�6)   $��3��6<   $��2��6I   G� 5   
   -   5         G�Name$ NewPasswordBox��5      $��0,11,0,4q�6.   $��4��6@   �� 5    
   $��Confirm Password:��6   $��	0,29,0,21q�6-   $��4��6@   $��2��6M   G� 5!   
   -   5        $ ConfirmPasswordBox��5!      $��0,13,0,2q�62   $��5��6D   �� 5#   
    �� Orientation$ 
Horizontal=�6   $��6��6.   $��30,79,10,49q�6;   .+�5$      �� -   5         ��Name$ UpdateButton��5$      $��Update Profile��6+   $	��120��6D   $��0,0,10,0q�6P   $��40��6b   6n   �� 5%      -   5        $ DeleteAccountButton��5%      $��Delete Account��62   $	��113��6K   $��40��6W   6c   �� 5&      -   5        $
��Back��5&      $��40��6&   $��55��62   6=   5'      �� 5)   
   -   5         ��Name$ StatusMessage��5)      $��
0,20,0,150q�6+   
��� � �$��6��6R   50      51      