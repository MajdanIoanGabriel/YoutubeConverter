   M S B A M L   `   `   `  ����K  GYoutubeConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:YoutubeConverterYoutubeConverter  5      "    YoutubeConverter.ConvertPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:YoutubeConverter     5        N� Title$  ConvertPage��5	       N� 
Background 5      �� 5   
    �� ImageSource$$ \images\convert_background.png��6    j� Stretch$ UniformToFill=�6B   6\   .��5      �� $��Center=�6   $��	200,0,0,0q�6,    � 	Resources 5   
    �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth	   	Direction
   Color   Opacity   
BlurRadius �� 
TargetType �� CornerRadius �� Padding �� Triggers P� Property P� Value ��Name��%�  '��       '�� �     '�� �    �� 5      " ��6   .�5      ��  �@J�Effect 5        5      $ 4Q�5      $		 330Q�5      $
 Black��5      $	 0.5Q�5      $ 4Q�5      5      5      �� 5       " ��6   .�5!      ��  � �� �	#FFCF20216/   �� 5"       � ��
 �����6/   �� 5#       � ��$ MV Boli)�6/   �� 5$       � ��$ 0,0,0,15q�6+   �� 5%       � ��$ 28(�6-   �� 5&       �@J�Effect 5'        5(      $ 4Q�5)      $		 330Q�5*      $
 Black��5+      $	 0.5Q�5,      $ 4Q�5-      5/      �� 50       � �� 51      �� 52      " ��6*   .R�53      �� 
�������$��2q�69   $ 10��6M   $ 	10,1,10,1q�6_   #��z��6s   ._�54   "   �� $��Center=�63   $��Center=�6P   55      56      58       59      P� 5:       �@J�IsMouseOver$
 True��65   . �5;      ��  � �� �	#FFD94B4B67   5<      5>      �� 5@      " ��6   .�5A      ��  �@J�Effect 5B        5C      $ 4Q�5D      $		 330Q�5E      $
 Black��5F      $	 0.5Q�5G      $ 4Q�5H      5J      �� 5K       � �� 5L      �� 5M      " ��6*   .R�5N      �� 
�������$��2q�69   $ 10��6M   #��z��6_   ._�5O   "   �� $ PART_ContentHost��6/   $|�false��6I   $��Hidden=�6[   $��Hidden=�6�   5P      5R      5T      5V      5W      .+�5Y   
   �� -   5         ��Name$ label_yt��5Y      $��Youtube MP3 Converter��5Z      $��Center=�5[      $��Center=�5\      $��Center=�5]      $��70(�5^      $��MV Boli)�5_      
�������$
��Bold"�5`   #   �� 5b   
   -   5        $ 
label_here��5b      $��Insert link here��5c      $��Center=�5d      $	��780��5e      $��Center=�5f      $��Center=�5g      $��32(�5h      $��MV Boli)�5i      
�������5j      �� 5k   
   -   5         ��Name$ Input��5k       �� TextWrapping$
 Wrap=�5l       �� TextAlignment$
 Left=�5m      $��2q�5n      $��160,0,160,15q�5o       �� MaxLines$ 1��5p      $��Center=�5q      $��Center=�5r      
�������
������� �� SelectionBrush �	#FFFFA7A7 �� SelectionTextBrush
 �  ��$��MV Boli)�5x      $��28(�5y      $��Stretch=�5z      $��Center=�5{      ��5s      Z� .��5{   -   5|      �� 5}   
   -   5         ��Name$ Convert��5}      $��Convert!��5~      $��Center=�5�      $��Center=�5�      5�      5�      