   M S B A M L   `   `   `  ����V  RaplikacjaDoZmianyKartWTalii, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:aplikacjaDoZmianyKartWTaliiaplikacjaDoZmianyKartWTalii  5   	   ,    &aplikacjaDoZmianyKartWTalii.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:aplikacjaDoZmianyKartWTalii     5   	     � Title$  	Two Decks��5   	   $	��450��6   $	��400��6(    � 	Resources 5
      &   aplikacjaDoZmianyKartWTalii.Deck   leftDeck  	rightDeck��%:   &	        &	        5   
   6     5   
   6   5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 
deck1Label��5      $��Deck _1��6$   $��Center=�66   $��Center=�6S   $��10,0,0,0q�6n    �� Target 6�   ��  �� ElementName$ leftDeckListBox�� �� Mode$ OneWay=��� 5   
   -   5        $ 
deck2Label��5      $��1��6$   $��Deck _2��64   $��Center=�6F   $��Center=�6c   $��10,0,0,0q�6~    6�   �� $ rightDeckListBox��$ OneWay=��� 5   
   -   5         ��Name$ leftDeckListBox��5      $��1��6+   �� 5   
   -   5        $ rightDeckListBox��5      $��1��6,   $��1��6<   �� 5    
   -   5        	 ��Name$	 shuffleLeftDeck��5       $��_Shuffle��6*   $��Center=�6=   $��2��6Z   $��Center=�6g   $	��180��6�   $��10,10,10,10q�6�   �� 5!   
   -   5        $	 clearRightDeck��5!      $��1��6)   $��_Clear��69   $��Center=�6J   $��2��6g   $��Center=�6t   
 J� RenderTransformOrigin$
 0.56,-0.102&�6�   $	��180��6�   �� 5"   
   -   5        $	 resetLeftDeck��5"      $��_Reset��6(   $��Center=�69   $��3��6V   $��Center=�6c   $	��180��6~   $��10,10,10,10q�6�   �� 5#   
   -   5        $	 sortRightDeck��5#      $��1��6(   $��Sor_t��68   $��Center=�6H   $��3��6e   $��Center=�6r   $	��180��6�   $��10,10,10,10q�6�   5%      5&      