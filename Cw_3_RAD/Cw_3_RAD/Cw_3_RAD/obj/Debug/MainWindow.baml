   M S B A M L   `   `   `  ����C  ?Cw_3_RAD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Cw_3_RADCw_3_RAD  5   	       Cw_3_RAD.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cw_3_RAD     5   	   -   5          �Name$  xe_MainWindow��5   	    � Title$ Crazy Button Clicker��5   	   $	��500��6&   $	��700��63    � WindowStyle$
 None=�6?    � Icon$8 2img/Hopstarter-Keriyo-Emoticons-Smiley-upset-4.ico��6R    � 
ResizeMode$ CanMinimize=�6�    � AllowsTransparency .  J� Opacity$ 1Q�6�    � 	Resources 5
         Storyboard_Close_ToRed �� 
TargetName	 �� TargetProperty	
 �� To g� Duration  Storyboard_Close_ToWhite  Storyboard_Minimize_ToBlue  Storyboard_Minimize_ToWhite  Storyboard_Minimize_Window	 W� To  Storyboard_Restore_Window  Storyboard_Logo_Rotate W� From g� RepeatBehavior   Storyboard_Highscore_TabOpen W� EasingFunction4  .System.Windows.Media.Animation.ExponentialEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode ! Storyboard_Highscore_TabClose 	 Storyboard_About_TabOpen 
 Storyboard_About_TabClose  Storyboard_Settings_TabOpen   Storyboard_Settings_TabClose��%!	  &	        &	 �     &	 >    &	 �    &	 |    &	 �    &	 |    &	     &	 �    &		 �    &	
 Z    &	     &	 �    �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $	 Background.Color�5      $
 PaleVioletRedX�5      $ 0:0:0.3D�6$   5      �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $	 Background.Color�5      $
 WhiteX�5      $ 0:0:0.3D�6   5      �� 5   
   .��5      �� $$ xe_TitleBar_TextBlock_Minimize��5      $	 Background.Color�5      $
 SkyBlueX�5       $ 0:0:0.3D�6   5"      �� 5$   
   .��5%      �� $$ xe_TitleBar_TextBlock_Minimize��5&      $	 Background.Color�5'      $
 WhiteX�5(      $ 0:0:0.3D�6   5*      �� 5,   
   .��5-      W� $ xe_MainWindow��5.      $	 Opacity�5/      $ 0X�50      $ 0:0:0.3D�6   52      �� 54   
   .��55      W� $ xe_MainWindow��56      $	 Opacity�57      $ 1X�58      $ 0:0:0.3D�6   5:      �� 5<   
   .��5=      W� $
 Dupa��5>      $	 Angle�5?      $ 0X�5@      $	 360X�6   $ 0:0:5D�6#   $ Forever��64   5B      �� 5D   
   .��5E      W� $ xe_SideBar_Grid_Highscore��5F      $	 Width�5G      $	 467X�5H      $ 0:0:0.6D�6    5I        5J      $ 	EaseInOut=�6&   5L      5M      �� 5O   
   .��5P      W� $ xe_SideBar_Grid_Highscore��5Q      $	 Width�5R      $ 0X�5S      $ 0:0:0.6D�6    5T        5U      $ 	EaseInOut=�6&   5X      5Y      �� 5[   
   .��5\      W� $ xe_SideBar_Grid_About��5]      $	 Width�5^      $	 467X�5_      $ 0:0:0.6D�6    5`        5a      $ 	EaseInOut=�6&   5c      5d      �� 5f   
   .��5g      W� $ xe_SideBar_Grid_About��5h      $	 Width�5i      $ 0X�5j      $ 0:0:0.6D�6    5k        5l      $ 	EaseInOut=�6&   5o      5p      �� 5r   
   .��5s      W� $ xe_SideBar_Grid_Settings��5t      $	 Width�5u      $	 467X�5v      $ 0:0:0.6D�6    5w        5x      $ 	EaseInOut=�6&   5z      5{      �� 5}   
   .��5~      W� $ xe_SideBar_Grid_Settings��5      $	 Width�5�      $ 0X�5�      $ 0:0:0.6D�6    5�        5�      $ 	EaseInOut=�6&   5�      5�      5�      .��5�      � -   5         �Name$ xe_GridMain��5�       � ColumnDefinitions 5�   
   �� 5�      �� 5�      $��2* �6    � RowDefinitions 5�   
   �� 5�      $��25 �6   �� 5�      �� 5�      $��30 �6   ��5�   
   �� 5�       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5�      �  � Color$ White��6    � Offset$	 0.8Q�6-   � 5�      $ 	#FF787878��6   $ 1Q�61   5�      .+�5�   
   � -   5        $ xe_GridTitleBar��5�      $��2��6(    � ContextMenu 5�      �� 5�      .@�5�      m� -   5        $��Losuj kolor��5�       m� Icon 5�      �� 5�      $��img/colours.png��6$   5�      5�      ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67    �� RelativeTransform 5�      V� 5�      .~�5�      ��  �� Angle$	 270Q�6.    �� CenterY$	 0.5Q�6:    �� CenterX$	 0.5Q�6H   T� 5�      5�      .��5�      � $ Yellow��6#   $ 0Q�62   � 5�      $ White��6#   $	 0.9Q�61   5�      .+�5�      �� -   5         ��Name$ xe_TitleBar_label_Title��5�      $��Crazy Button Clicker��65   $
��Left=�6T   $��5,0,0,0q�6o   $��Center=�6�   $��25��6�   $	��124��6�   �� 5�      -   5          ��Name$$  xe_TitleBar_TextBlock_Minimize��5�      $��Right=�6@   $��0,0,25,0q�6\   $
��Wrap=�6n   $��__��6�   $��Center=�6�   $��25��6�   $��25��6�   ! �� Padding$! 6,1,0,0q�6�   $��16(�6�   
�������" � ToolTip$" Minimalizuj��6g  �� 5�      -   5        $!  xe_TitleBar_TextBlock_Close��5�      $��Right=�6=   $��X��6Y   $��Center=�6b   $��25��6}   $��25��6�   $! 8,1,0,0q�6�   $��16(�6�   
�������$" Zamknij��64  5�      �� 5�   
   -   5        # ��Name$# xe_SideMenu_Button_Graj��5�      $
��Graj��62   $
��Left=�6A   $��	10,10,0,0q�6\   $��1��6o   $	��Top=�6|   $	��200��6�   $��60��6�   $��29.333(�6�   $��Segoe Print)�6�   $��Center=�6�   $��Center=�6�   $��1q�6  6m  �� 5�   
   -	   5        $ xe_SideBar_Label_Logo��5�      $��Crazy Button Clicker��6/   $��Center=�6N   $��	0,175,0,0q�6k   $��1��6~   $��Center=�6�   $��Comic Sans MS)�6�   $��32(�6�   $��1��6�   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67    5�      V� 5�      .~�5�      �� $	 0.5Q�6.   $	 0.5Q�6<   -
   5        Dupa��$ 0Q�5�   X   5�      .��5�      � $	 Red��6#   $ 0Q�6/   � 5�      $ 	#FFA522FF��6#   $ 1Q�65   � 5�      $
 Lime��6#   $	 0.5Q�60   � 5�      $ Yellow��6#   $
 0.25Q�62   � 5�      $ 	#FF00AEFF��6#   $
 0.75Q�65   5�      5�      �� 5�   
   -   5        $ ��Name$$ xe_SideBar_Image_Logo��5�      $��Center=�6/   $	��128��6L   $��0q�6Y   $��1��6d   $��Center=�6q   $	��128��6�   $��1��6�   $8��2img/Hopstarter-Keriyo-Emoticons-Smiley-upset-4.ico��6�   �� 5�   
   -   5        $"# xe_SideMenu_Button_Highscore��5�      $��	Highscore��67   $
��Left=�6K   $��	10,80,0,0q�6f   $��1��6y   $	��Top=�6�   $	��200��6�   $��60��6�   $��29.333(�6�   $��Segoe Print)�6�   $��Center=�6�   $��Center=�6  $��1q�6'  6�  �� 5�   
   -   5        $ # xe_SideMenu_Button_Options��5�      $��Opcje��65   $
��Left=�6E   $��
10,150,0,0q�6`   $��1��6t   $	��Top=�6�   $	��200��6�   $��60��6�   $��29.333(�6�   $��Segoe Print)�6�   $��Center=�6�   $��Center=�6�   $��1q�6"  6t  �� 5�   
   -   5        $# xe_SideMenu_Button_About��5�      $��O aplikacji��63   $
��Left=�6I   $��
10,220,0,0q�6d   $��1��6x   $	��Top=�6�   $	��200��6�   $��60��6�   $��29.333(�6�   $��Segoe Print)�6�   $��Center=�6�   $��Center=�6  $��1q�6&  6|  �� 5�   
   -   5        $# xe_SideMenu_Button_Exit��5�      $��Wyjście��62   $
��Left=�6D   $��
10,290,0,0q�6_   $��1��6s   $	��Top=�6�   $	��200��6�   $��60��6�   $��29.333(�6�   $��Segoe Print)�6�   $��Center=�6�   $��Center=�6�   $��1q�6!  6g  � 5�   
   -   5        $ xe_SideBar_Grid_Highscore��5�      $��1��62   $��0q�6B   $��1��6M   $��0��6Z   $��Right=�6d   ���	#FFFFBD87.+�5�      �� -   5        $# xe_Highscore_Button_Back��5�      $��Schowaj��67   $
��Left=�6I   $��	10,10,0,0q�6d   $	��Top=�6w   $��75��6�   $��25��6�   6�   �� 5�      -   5        % ��Name$% xe_Highscore_ListView��5�      $
��Left=�66   $	��320��6Q   $��	35,50,0,0q�6^   $	��Top=�6q   $	��400��6�   & �� SelectionMode$& Single=�6�   ' �� View' 5�      �� 5�      .P�5�      �� $
��Nick��6)   ( �� Width$	( 150��67   ) �� DisplayMemberBinding) 6D   �� *nick+�� 5�      $��Wynik��6)   $( 60��68   ) 6C   �� *score+�� 5�      $
��Data��6)   $	( 190��67   ) 6D   �� *date+5�      5�      �� 5�      -   5        $# xe_Highscore_Clear��5�      $��Resetuj wyniki��61   $
��Left=�6J   $��
307,0,0,10q�6e   $��Bottom=�6y   $	��150��6�   $��50��6�   $��Comic Sans MS)�6�   $��18.667(�6�   61  5�      �� 5�   
   -   5        $ xe_StatusBar_Label_Hint��5�      $�� ��61   $
��Left=�6<   $��10,0,0,0q�6W   $��2��6i   $��30��6v   $��2��6�   � 5�   
   -   5        $ xe_SideBar_Grid_About��5�      $��1��6.   $��Right=�6>   $��0q�6Z   $��1��6e   $��0��6r   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ 	#FF6191F9��6#   $ 0Q�65   � 5�      $ White��6#   $ 1Q�61   5�      .+�5�      �� -   5        $$ xe_About_Image_logo��5�      $
��Left=�61   $	��100��6L   $��	55,0,0,19q�6Y   $��Bottom=�6l   $	��100��6�   $��img/WIiNoM_small.png��6�   �� 5�      -   5        $  xe_About_TextBlock_WiiNoM��5�      $
��Left=�6;   $��
185,0,0,30q�6V   $
��Wrap=�6j   $1��+Wydział Informatyki i Nauki o Materiałach��6~   $��Bottom=�6�   $	��245��6�   $��72��6�   
���  ��$��24(�6�   $��Comic Sans MS)�6  �� 5�      -   5        $  	textBlock��5�      $
��Left=�6+   $��	35,60,0,0q�6F   $
��Wrap=�6Y   $	��Top=�6m   $	��250��6�   $	��395��6�   $��16(�6�   $��Times New Roman)�6�   mkAplikacja stworzona na przedmiot "Programowanie w środowiskach RAD" jako jeden z projektów na zaliczenie.�� 5�      �� 5�      ��Celem aplikacji jest mierzenie refleksu użytkownika. Oprócz tego apka daje możliwość dostosowania procesu mierzenia refleksu do indywidualnych preferencji użytkownika oraz zapisanie swojego wyniku łącznie z datą. Poza tym, aplikacja ma fikuśne animacje przy otwieraniu zakładek w głównym oknie oraz kolor tekstu przy głównym logo jest animowany. W ogóle apka ma masę fajnych rzeczy, długo by wymieniać... :)�� 5�      �� 5�      Zapraszam do korzystania.5�      �� 5�      -   5        $# xe_About_Button_Back��5�      $��Schowaj��63   $
��Left=�6E   $��	10,10,0,0q�6`   $	��Top=�6s   $��75��6�   $��25��6�   6�   5�      � 5�   
   -   5        $ xe_SideBar_Grid_Settings��5�      $��1��61   $��Right=�6A   $��0q�6]   $��1��6h   $��0��6u   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ 	#FFF566E2��6#   $ 0.016Q�65   � 5�      $ White��6#   $ 1Q�61   5�      .+�5�      �� -   5        $# xe_Settings_Back��5�      $��Schowaj��6/   $
��Left=�6A   $��	10,10,0,0q�6\   $	��Top=�6o   $��75��6�   $��25��6�   6�   �� 5�      -   5        $# xe_Settings_ApplyChanges��5�      $��
Zatwierdź��67   $
��Left=�6K   $��
307,0,0,10q�6f   $��Bottom=�6z   $	��150��6�   $��50��6�   $��Comic Sans MS)�6�   $��18.667(�6�   6(  �� 5�      -   5        * ��Name$* xe_border_Ile��5�      $��3q�6,   
����iA�+ �� CornerRadius$+ 3��6X   $	��126��6i   $��39��6u   $
��Left=�5�      $��Center=�6)   $��256,109,0,297q�6D   ._�5�      �� -   5        , ��Name$, xe_Settings_TextBox_Ile��5�      $
��Left=�6;   $��35��6V   $��0q�6b   - �� TextWrapping$
- Wrap=�6m   $	��Top=�6�   $	��120��6�   . �� MaxLines$. 1��6�   $��Consolas)�6�   $��16(�6�   $��3,0,0,0q�6�   $��Center=�6�   $��0q�6  
�������$��Center=�6c  5      �� 5     -   5        $ xe_Settings_Label_Ile��5     $��Ile kliknięć:��63   $
��Left=�6K   $��
91,112,0,0q�6f   $	��Top=�6z   $��16(�6�   $��Comic Sans MS)�6�   �� 5     -    5        $* xe_border_Bufor��5     $��3q�6.   
����iA�$+ 3��6Z   $	��126��6k   $��39��6w   $
��Left=�5     $��Center=�6)   $��256,177,0,229q�6D   ._�5     �� -!   5        $, xe_Settings_TextBox_Bufor��5     $
��Left=�6=   $��35��6X   $��0q�6d   $
- Wrap=�6o   $	��Top=�6�   $	��120��6�   $. 1��6�   $��Consolas)�6�   $��16(�6�   $��3,0,0,0q�6�   $��Center=�6�   $��0q�6  
�������$��Center=�6f  5     �� 5     -"   5        $ xe_Settings_Label_Bufor��5     $��Bufor [ms]:��65   $
��Left=�6K   $��
91,180,0,0q�6f   $	��Top=�6z   $��16(�6�   $��Comic Sans MS)�6�   �� 5     -#   5        $* xe_border_Okres��5     $��3q�6.   
����iA�$+ 3��6Z   $	��126��6k   $��39��6w   $
��Left=�5     $��Center=�6)   $��256,247,0,159q�6D   ._�5	     �� -$   5        $, xe_Settings_TextBox_Okres��5	     $
��Left=�6=   $��35��6X   $��0q�6d   $
- Wrap=�6o   $	��Top=�6�   $	��120��6�   $. 1��6�   $��Consolas)�6�   $��16(�6�   $��3,0,0,0q�6�   $��Center=�6�   $��0q�6  
�������$��Center=�6g  5
     �� 5     -%   5        $ xe_Settings_Label_Okres��5     $��Okres [ms]:��65   $
��Left=�6K   $��
91,250,0,0q�6f   $	��Top=�6z   $��16(�6�   $��Comic Sans MS)�6�   �� 5     -&   5        $! xe_Settings_Label_Komunikat��5     $'��!Wprowadzone dane są niepoprawne!��69   $
��Left=�6d   $��
10,395,0,0q�6   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   
���  ��6�   5     �� 5  
   -'   5        $  xe_StatusBar_Label_Version��5     $
��v0.9��64   $��1��6C   $��Right=�6S   $��0,0,5,0q�6o   $��2��6�   $��30��6�   5     5     