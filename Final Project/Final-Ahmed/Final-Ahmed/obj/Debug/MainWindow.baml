   M S B A M L   `   `   `  ����F  BFinal-Ahmed, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Final_AhmedFinal_Ahmed  5   	       Final_Ahmed.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Final_Ahmed     5   	     � Title$  
MainWindow��5   	   $	��470��6   $	��525��6)   .��5
      � 
�������.+�5   
   �� -   5         ��Name$ imgPhoto��5      $
��Left=�6"   $	��200��6=   $��
306,52,0,0q�6J   $	��Top=�6^   $	��200��6v    � ToolTip$ Picture��6�   �� 5   
   -   5         ��Name$ lblError��5      $�� ��6"   $
��Left=�6-   $��306,257,0,0q�6H   $	��Top=�6]   
���  ��6u   �� 5   
   -   5        $ 
lblDBCount��5      $��Games in Database: 0��6$   $
��Left=�6C   $��	10,10,0,0q�6^   $	��Top=�6q   �� 5   
   -   5        $ lblTitle��5      $��Title:��6"   $
��Left=�63   $��
58,151,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ lblYear��5      $��Year:��6!   $
��Left=�61   $��
58,177,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ lblDev��5      $��Developers:��6    $
��Left=�66   $��
21,208,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ lblImage��5      $��Image:��6"   $
��Left=�63   $��
49,326,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ 	lblRating��5      $��Rating:��6#   $
��Left=�65   $��
46,236,0,0q�6P   $	��Top=�6d   �� 5   
   -	   5        $ lblPlatform��5      $��	Platform:��6%   $
��Left=�69   $��
37,263,0,0q�6T   $	��Top=�6h   �� 5   
   -
   5        $ lblGenre��5      $��Genre:��6"   $
��Left=�63   $��
49,292,0,0q�6N   $	��Top=�6b   �� 5   
   -   5         ��Name$ txtTitle��5      $
��Left=�6$   $��23��6?   $��110,151,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��140��6�   $ Enter Video Game Title��6�   �� 5   
   -   5        $ txtYear��5      $
��Left=�6#   $��23��6>   $��110,180,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $��90��6�   $ Enter Video Game Year��6�   �� 5   
   -   5        $ txtDev��5      $
��Left=�6"   $��23��6=   $��110,208,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   $' !Enter Game Developers Studio Name��6�   �� 5   
   -   5         ��Name$ 	cboRating��5      $
��Left=�6&   $��110,236,0,0q�6A   $	��Top=�6V   $��52��6n   $  Choose the Rating for Game��6y   6�   �� 5   
   -   5         ��Name$ stkPlatform��5       �� Orientation$ 
Horizontal=�6*   $
��Left=�6C   $��26��6^   $��110,266,0,0q�6j   $	��Top=�6   $	��184��6�   .+�5      	� -   5        	 	�Name$	 radPS4��5      $	��PS4��6*   $
��Left=�68   $��84��6S   $��21��6^   $ 
Select PS4��6j   $	��0,2q�6   
 d� 	IsChecked$

 TrueY�6�   	� 5       -   5        $	 radXbox1��5       $��Xbox One��6,   $
��Left=�6?   $��84��6Z   $��21��6e   $	��0,2q�6q   $ Select Xbox One��6~   5!      �� 5#   
   -   5        $ cboGenre��5#      $
��Left=�6%   $��110,292,0,0q�6@   $	��Top=�6U   $	��155��6m   $ Choose Game Genre��6y   6�   �� 5%   
   -   5        $ txtImage��5%      $
��Left=�6$   $��23��6?   $��110,326,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   $B <Enter Image File Name with Extension stored in Images Folder��6�   �� 5'   
   -   5         ��Name$ btnSave��5'      $��	Save Game��6"   $
��Left=�66   $��136,367,0,0q�6Q   $	��Top=�6f   $��75��6~   $ Save Game in Library��6�   6�   �� 5(   
   -   5        $ btnClear��5(      $��Clear��6#   $
��Left=�63   $��229,367,0,0q�6N   $	��Top=�6c   $��75��6{   $ Clear the Form��6�   6�   �� 5)   
   -   5        $ 	btnDelete��5)      $��Delete��6$   $
��Left=�65   $��329,367,0,0q�6P   $	��Top=�6e   $��75��6}   $ Delete from Library��6�   6�   �� 5+   
   -   5        $ cboGamesList��5+      $
��Left=�6)   $��
386,10,0,0q�6D   $	��Top=�6X   $	��120��6p   $&  Select Game from Library to View��6|   $��Visible=�6�   6�   �� 5-   
   -   5        $ lblViewGame��5-      $��View Game Mode:��6%   $
��Left=�6?   $��
274,10,0,0q�6Z   $	��Top=�6n   �� 5/   
   -   5        $ lblInfo��5/      $��Video Games Library��6!   $
��Left=�6?   $��	36,52,0,0q�6Z   $	��Top=�6m   $��Aharoni)�6�   $
��Bold"�6�   $��20(�6�   �� 50   
   -   5        $ lblInfo2��50      $M��GView Games from our Database
Or Add a new Video Game to our Library.
��6"   $
��Left=�6�   $��	36,72,0,0q�6�   $	��Top=�6�   $��45��6�   �� 51   
   -   5        $ lblInfo3��51      $&�� By Faizan Ahmed & Miguel Ramirez��6"   $
��Left=�6Q   $��
36,108,0,0q�6l   $	��Top=�6�   $
��Bold"�6�   �� 52   
   -   5        $ lblInfo4��52      $K��EPlease Restart App in order to View New Changes made in Games Library��6"   $
��Left=�6r   $��
49,394,0,0q�6�   $	��Top=�6�   $
��Bold"�6�   54      55      