   M S B A M L   `   `   `  ����F  BProj6-Ahmed, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Proj6_AhmedProj6_Ahmed  5   	       Proj6_Ahmed.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Proj6_Ahmed     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lblText��5
      $U��OAdd Movies to the Collection(s) and 
Create an XML Document for Organized Data��6!   $
��Left=�6�   $��
149,14,0,0q�6�   $	��Top=�6�   $��44��6�   $	��283��6�   $
��Bold"�6�   �� 5   
   -   5        $ lblName��5      $��Name: ��6!   $
��Left=�62   $��
149,63,0,0q�6M   $	��Top=�6a   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��23��6>   $��
202,63,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�    � ToolTip$ Enter Movie Name��6�   �� 5   
   -   5        $ lblGenre��5      $��Genre: ��6"   $
��Left=�64   $��
149,89,0,0q�6O   $	��Top=�6c   �� 5   
   -   5         ��Name$ 	cboGenres��5      $
��Left=�6&   $��
202,93,0,0q�6A   $	��Top=�6U   $	��133��6m   $ Select Movie Genre��6�   �� 5   
   -   5        $ lblPlot��5      $��Plot: ��6!   $
��Left=�62   $��149,120,0,0q�6M   $	��Top=�6b   �� 5   
   -   5        $ txtPlot��5      $
��Left=�6#   $��59��6>   $��202,130,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��202��6�   $ Enter Movie Plot��6�   �� 5   
   -   5        $ 	lblRating��5      $��Rating:��6#   $
��Left=�65   $��149,189,0,0q�6P   $	��Top=�6e   �� 5   
   -	   5        $ 	cboRating��5      $
��Left=�6&   $��202,194,0,0q�6A   $	��Top=�6V   $	��154��6n   $ Select Movie Rating��6�   �� 5   
   -
   5        $ txtYear��5      $
��Left=�6#   $��23��6>   $��202,235,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $��74��6�   $ Enter Movie Year��6�   �� 5   
   -   5        $ lblYear��5      $
��Year��6!   $
��Left=�60   $��149,235,0,0q�6K   $	��Top=�6`   �� 5   
   -   5         ��Name$ 	btnSubmit��5      $	��Add��6$   $
��Left=�62   $��149,277,0,0q�6M   $	��Top=�6b   $��75��6z   $ Add Data to XML��6�   6�   �� 5   
   -   5        $ lblCount��5      $��Movies Count: 0��6"   $
��Left=�6<   $��
10,110,0,0q�6W   $	��Top=�6k   $ Movie(s) in List & XML��6�   �� 5   
   -   5        $ button��5      $��Clear��6!   $
��Left=�61   $��247,277,0,0q�6L   $	��Top=�6a   $��75��6y   $ Reset the Form��6�   6�   �� 5   
   -   5         ��Name$ imgReel��5      $
��Left=�6!   $	��100��6<   $	��Top=�6I   $	��100��6a   $��Images/reel.jpg��6m   $��	10,10,0,0q�6�   �� 5   
   -   5        $ imgPop��5      $
��Left=�6    $	��100��6;   $��407,210,0,0q�6H   $	��Top=�6]   $	��100��6u   $��Images/pop.png��6�   �� 5   
   -   5        $ lblError��5      $�� ��6"   $
��Left=�6-   $��
10,141,0,0q�6H   $	��Top=�6\   
���  ��6t   5      5      