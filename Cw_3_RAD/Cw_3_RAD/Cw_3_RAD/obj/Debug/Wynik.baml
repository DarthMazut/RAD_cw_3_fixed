   M S B A M L   `   `   `  ����C  ?Cw_3_RAD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Cw_3_RADCw_3_RAD  5   	       Cw_3_RAD.Wynik   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Cw_3_RAD     5   	   -   5          �Name$  	xe_Window��5   	    � Title$ Twój wynik��5   	   $	��300��6   $	��500��6)    � 
ResizeMode$ NoResize=�65    � Icon$8 2img/Hopstarter-Keriyo-Emoticons-Smiley-upset-4.ico��6K    � WindowStyle$
 None=�6�    � 	Resources 5
         Storyboard_Close_ToRed �� 
TargetName �� TargetProperty	 �� To	 g� Duration  Storyboard_Close_ToWhite��%R  &	        &	 �     �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $ Background.Color�5      $ PaleVioletRedX�5      $	 0:0:0.3D�6$   5      �� 5   
   .��5      �� $! xe_TitleBar_TextBlock_Close��5      $ Background.Color�5      $ WhiteX�5      $	 0:0:0.3D�6   5      5      .��5       �� 
����  �$��2q�6    ._�5!      � -   5        
 �Name$
 xe_MainGrid��5!       � RowDefinitions 5"   
   �� 5#      $��30 �6   �� 5$      .+�5&   
   � -   5        $
 xe_Grid_TitleBar��5&      $��0q�6Y    � ContextMenu 5'      �� 5(      .@�5)      m� -   5        $��Losuj kolor��5)       m� Icon 5*      �� 5+      $��img/colours.png��6$   5-      5.      ��50      �� 51       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 52      V� 53      .~�54      ��  �� Angle$	 270Q�6.    �� CenterY$	 0.5Q�6:    �� CenterX$	 0.5Q�6H   T� 55      56      .��58      �  � Color$ Yellow��6#    � Offset$ 0Q�62   � 59      $ White��6#   $	 0.9Q�61   5:      .+�5<      �� -   5         ��Name$ xe_TitleBar_label_Title��5<      $��Koniec gry - Twój wynik��65   $
��Left=�6W   $��5,0,0,0q�6r   �� 5=      -   5         ��Name$! xe_TitleBar_TextBlock_Close��5=      $��Right=�6=   $��X��6Y   $��Center=�6b   $��25��6}   $��25��6�    �� Padding$ 8,1,0,0q�6�   $��16(�6�   
������� � ToolTip$ Zamknij��64  $��0,0,5,0q�6F  5>      �� 5?   
   -   5         ��Name$ xe_Button_ZapiszWynik��5?      $��Zapisz wynik��60   $��Right=�6G   $��	0,0,10,10q�6c   $��1��6v   $��Bottom=�6�   $	��120��6�   $��40��6�   $��Comic Sans MS)�6�   $��16(�6�   6�   �� 5@   
   -   5        $ xe_Label_name��5@      $��Podaj swój nick:��6'   $
��Left=�6B   $��
10,172,0,0q�6]   $��1��6q   $	��Top=�6~   �� 5A   
   -	   5        $ xe_Button_NieZapisuj��5A      $��Nie tym razem��6/   $
��Left=�6G   $��241,216,0,0q�6b   $��1��6w   $	��Top=�6�   $	��120��6�   $��40��6�   6�   �� 5B   
   -
   5         ��Name$ xe_TextBox_name��5B      $
��Left=�6+   $��23��6F   $��109,175,0,0q�6R   $��1��6g    �� TextWrapping$
 Wrap=�6t   $��ERROR -CTOR FAIL��6�   $	��Top=�6�   $	��381��6�   ���	#FF8F2C47���	#FFF7E388$��0,2,0,0q�6�   6+  �� 5C   
   -   5        $ xe_Label_Wyniki��5C      $��Twoje wyniki [ms]:��6)   $
��Left=�6F   $��	10,10,0,0q�6a   $��1��6t   $	��Top=�6�    J� RenderTransformOrigin$ -0.263,0.269&�6�   $��14.667(�6�   �� 5E   
   $��1��6   
����ح�$��10,40,316,103q�65   ._�5F      �� -   5         ��Name$ xe_ScrollViewer��5F      $��1q�64   ���	#FFA7CFF7.��5G      �� -   5        $ xe_TextBlock_wyniki��5G      Jezeli widzisz ten napis�� 5H   /   Cos poszlo nie tak... ;(5J      5K      5L      �� 5M   
   -   5        $ xe_Wynik_Sredni��5M      $��Średni czas:��6)   $
��Left=�6@   $��
297,40,0,0q�6[   $��1��6o   $	��Top=�6|   $��Comic Sans MS)�6�   $��21.333(�6�   �� 5N   
   -   5        $ xe_WYNIK��5N      $��ERROR - CTOR FAIL��6"   $
��Left=�6>   $��
245,88,0,0q�6Y   $��1��6m   $	��Top=�6z   $	��245��6�   $��79��6�   $��Segoe Print)�6�   $��26.667(�6�   $��Center=�6�   $��Center=�6�   ���	#FFFF3FCB6  5P      5Q      5R      