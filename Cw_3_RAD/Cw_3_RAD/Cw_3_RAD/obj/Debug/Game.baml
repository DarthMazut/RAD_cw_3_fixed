   M S B A M L   `   `   `  ����C  ?Cw_3_RAD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Cw_3_RADCw_3_RAD  5   	       Cw_3_RAD.Game   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cw_3_RAD     5   	   -   5          �Name$  	xe_Window��5   	    � Title$ Crazy Button Clicker��5   	   $	��500��6&   $	��900��63    � Icon$8 2img/Hopstarter-Keriyo-Emoticons-Smiley-upset-4.ico��6?    � WindowStyle$
 None=�6z    � 
ResizeMode$ CanMinimize=�6�    � AllowsTransparency .  J� Opacity$ 1Q�6�    � 	Resources 5
         Storyboard_Close_ToRed �� 
TargetName	 �� TargetProperty	
 �� To g� Duration  Storyboard_Close_ToWhite  Storyboard_Minimize_ToBlue  Storyboard_Minimize_ToWhite  Storyboard_Minimize_Window	 W� To  Storyboard_Restore_Window��%�  &	        &	 �     &	 >    &	 �    &	 |    &	 �    �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $	 Background.Color�5      $
 PaleVioletRedX�5      $ 0:0:0.3D�6$   5      �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $	 Background.Color�5      $
 WhiteX�5      $ 0:0:0.3D�6   5      �� 5   
   .��5      �� $$ xe_TitleBar_TextBlock_Minimize��5      $	 Background.Color�5      $
 SkyBlueX�5       $ 0:0:0.3D�6   5"      �� 5$   
   .��5%      �� $$ xe_TitleBar_TextBlock_Minimize��5&      $	 Background.Color�5'      $
 WhiteX�5(      $ 0:0:0.3D�6   5*      �� 5,   
   .��5-      W� $ 	xe_Window��5.      $	 Opacity�5/      $ 0X�50      $ 0:0:0.3D�6   52      �� 54   
   .��55      W� $ 	xe_Window��56      $	 Opacity�57      $ 1X�58      $ 0:0:0.3D�6   5:      5<      .��5A      � -   5         �Name$ xe_MainGrid��5A      $��Hidden=�6     � RowDefinitions 5B   
   �� 5C      $��30 �6   �� 5D      .+�5G   
   � -   5        $ xe_Grid_TitleBar��5G      $��0q�6Y    � ContextMenu 5H      �� 5I      .@�5J      m� -   5        $��Losuj kolor��5J       m� Icon 5K      �� 5L      $��img/colours.png��6$   5N      5O      ��5Q      �� 5R       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 5S      V� 5T      .~�5U      ��  �� Angle$	 270Q�6.    �� CenterY$	 0.5Q�6:    �� CenterX$	 0.5Q�6H   T� 5V      5W      .��5Y      �  � Color$ Yellow��6#    � Offset$ 0Q�62   � 5Z      $ White��6#   $	 0.9Q�61   5[      .+�5]      �� -   5         ��Name$ xe_TitleBar_label_Title��5]      $��Crazy Button Clicker��65   $
��Left=�6T   $��5,0,0,0q�6o   $��Center=�6�   $��25��6�   $	��124��6�   �� 5^      -   5         ��Name$$ xe_TitleBar_TextBlock_Minimize��5^      $��Right=�6@   $��0,0,25,0q�6\   $
��Wrap=�6n   $��__��6�   $��Center=�6�   $��25��6�   $��25��6�    �� Padding$ 6,1,0,0q�6�   $��16(�6�   
������� � ToolTip$ Minimalizuj��6g  �� 5_      -   5        $! xe_TitleBar_TextBlock_Close��5_      $��Right=�6=   $��X��6Y   $��Center=�6b   $��25��6}   $��25��6�   $ 8,1,0,0q�6�   $��16(�6�   
�������$ Zamknij��64  5`      �� 5a   
   -   5         ��Name$ xe_Button_Back��5a      $
��Left=�6)   $��40��6D   $��	10,10,0,0q�6P   $	��Top=�6c   $	��100��6{   $��1��6�   .��5b      � -	   5         �Name$ xe_Wroc_WrapPanel��5b      .+�5c      �� $��img/Back_img.png��6   $��0,0,5,0q�62   �� 5d      -
   5        $ xe_Wroc_Labelka��5d      $��Center=�61   $��Center=�6N   $��16(�6i   $��Comic Sans MS)�6w   .��6�   Wróć6�   5e      5f      A� 5g   
   -   5         A�Name$ xe_Elipse_ClickLefts��5g      $
��Left=�60   $	��150��6K   $��
175,75,0,0q�6X   $��1��6l   $	��Top=�6y   $	��150��6�     J� RenderTransformOrigin$  
0.687,0.72&�6�   ��5h      
� 5i      .��5j      � $ 	#FF002EFF��6#   $ 0Q�65   � 5k      $ White��6#   $ 1Q�61   5l      5n      �� 5o   
   -   5        $ xe_Label_Pozostalo��5o      $��
Pozostało��6,   $
��Left=�6@   $��
200,25,0,0q�6[   $��1��6o   $	��Top=�6|   $��21.333(�6�   $��Comic Sans MS)�6�   �� 5p   
   -   5        $ xe_Label_NumberLeft��5p      $
��#Num��6-   $
��Left=�6<   $��
175,75,0,0q�6W   $��1��6k   $	��Top=�6x   $��32(�6�   $��Center=�6�   $��Center=�6�   $	��150��6�   $	��150��6�   
���   �6�   �� 5q   
   -   5        $ xe_Label_Klikniec��5q      $��
Kliknięć��6+   $
��Left=�6>   $��210,225,0,0q�6Y   $��1��6n   $	��Top=�6{   $��Center=�6�   $��Center=�6�   $��21.333(�6�   $��Comic Sans MS)�6�   �� 5r   
   -   5        ! ��Name$! xe_Rectangle_TIPP��5r      $
��Left=�6/   $	��150��6J   $��	20,0,0,20q�6W   $��1��6j   $��Bottom=�6w   $	��450��6�   $��3��6�   ���	#FFFF8B00���	#FFFFD0A26�   �� 5t   
   -   5        " ��Name$" xe_ScrollViewer��5t      $��1��60   $
��Auto=�6=   $��	20,0,0,20q�6`   $��10q�6s   $
��Left=�6�   $��Bottom=�6�   $	��150��6�   $	��486��6�   .��5u      �� -   5        $ xe_TextBlock_TIPP��5u      $��0q�63   $��1��6>   $
��Wrap=�6K   $��Segoe Print)�6_   ���	#FF0C00FF$ 0q�6�   $	��429��6�   $
��Left=�6�   WSKAZÓWKA:�� 5w      �� 5x      ��Kliknij "Start" w prawym dolnym rogu i obserwuj komunikaty pokazujące się na zielonym kwadracie powyżej. Gdy kwadrat zmieni kolor na czerwony kliknij ponownie przycisk poniżej - tym razem pokaże się na nim ikona "Crazy Button Clicker". Od momentu zmiany koloru kwadratu, aż do kliknięcia przez Ciebie przycisku poniżej czas jest mierzony. Czas jest mierzony z dokładnością do 1 ms, aczkolwiek metoda OnTimerTick ma rozdzielczość koło 30-40 ms, co jest dość denerwujące, bo podobno w WPF timer miałbyć dokładniejszy niż w WinForms, ale nie ważne... Powyżej tego textu znajduje się licznik z ilością kliknięć do końca gry. Po zakończonej grze możesz wpisać się na listę najlepszych wyników podając swój nick. Miłej gry i powodzenia!5z      5{      �� 5|   
   -   5        $ 	xe_BUTTON��5|      $��Right=�6$   $��	0,0,20,20q�6@   $��1��6S   $��Bottom=�6`   $	��315��6{   $	��100��6�   $��Comic Sans MS)�6�   $��48(�6�   .��5}      � -   5        $ xe_BUTTON_WrapPanel��5}      $��Center=�65   $��Center=�6R   .+�5~      �� -   5        # ��Name$# xe_BUTTON_face_img��5~      $8��2img/Hopstarter-Keriyo-Emoticons-Smiley-upset-4.ico��64   �� 5      -   5        $ xe_BUTTON_Label_text��5      $��32(�66   $��Center=�6D   $��Center=�6h   .��6�   Start6�   5�      ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67    5�      V� 5�      .~�5�      �� $	 -45Q�6.   $	 0.5Q�6:   $	 0.5Q�6H   5�      .��5�      � $ 	#FF23FF00��6#   $ 0Q�65   � 5�      $ 	#FFCCF1C0��6#   $ 1Q�65   5�      5�      �� 5�   
   -   5        $! xe_DUZY_ZIELONY_KWADRAT��5�      
������$��Right=�6G   $	��300��6c   $��	0,25,27,0q�6p   $��1��6�   $	��Top=�6�   $	��300��6�   �� 5�   
   -   5        $ ��Name$$ xe_KWADRAT_border��5�      $	��300��6C   $��	0,25,27,0q�6O   $��1��6b   $��Right=�6o   $	��Top=�6�   $	��300��6�   ��6,   Z� ._�5�      �� -   5        $ xe_KWADRAT_textBlock��5�      $��Center=�66   $��1��6S   $
��Wrap=�6`   $*��$UWAGA - tu pojawią się komunikaty!��6t   $��Center=�6�   $��Comic Sans MS)�6�   $
 10,5q�6�   $��21.333(�6�   $��0q�6�   5�      5�      5�      