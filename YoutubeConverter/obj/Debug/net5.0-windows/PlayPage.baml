   M S B A M L   `   `   `  ����K  GYoutubeConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:YoutubeConverterYoutubeConverter  5          YoutubeConverter.PlayPage   5      \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:YoutubeConverter     5        N� Title$  PlayPage��5	       N� 
Background 5      �� 5   
    �� ImageSource$  images\play_background.jpg��6    j� Stretch$ UniformToFill=�6>   6X   .��5      �� $��Center=�6    � 	Resources 5   
    �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth	   	Direction
   Color   Opacity   
BlurRadius �� 
TargetType �� CornerRadius �� Padding �� Triggers P� Property P� Value��%�  '��       '�� �     �� 5      " ��6   .�5      ��  �@J�Effect 5        5      $ 4Q�5      $		 330Q�5      $
 Black��5      $	 0.5Q�5      $ 4Q�5      5      5      �� 5!      " ��6   .�5"      ��  � ��
 �  ��6/   �� 5#       � ��
 �����6/   �� 5$       � ��$ MV Boli)�6/   �� 5%       � ��$ 0,0,0,15q�6+   �� 5&       � ��$ 28(�6-   �� 5'       �@J�Effect 5(        5)      $ 4Q�5*      $		 330Q�5+      $
 Black��5,      $	 0.5Q�5-      $ 4Q�5.      50      �� 51       � �� 52      �� 53      " ��6*   .R�54      �� 
�������$��2q�69   $ 10��6M   $ 	10,1,10,1q�6_   #��z��6s   ._�55   "   �� $��Center=�63   $��Center=�6P   56      57      59       5:      P� 5;       �@J�IsMouseOver$
 True��65   . �5<      ��  � �� �	#FFFF323267   5=      5?      5@      .+�5B   
   �� -   5         ��Name$ video_title��5B      $��Video Title��5C      $��Stretch=�5D      $��Center=�5E      $��Center=�5F      $��50(�5G      $��MV Boli)�5H      
�������5I      �� 5J   
   -   5        $ 	lblStatus��5J      $��Not playing...��5K      $��Center=�5L      $��32(�5M      $��MV Boli)�5N      
������ 
�������5P      � 5Q   
   $��Center=�6   .+�5R      �� -   5        $��btnPlay��5R      .��6;   Play6A   �� 5S      -   5        $��btnPause��5S      $��
15,0,15,15q�6<   .��6P   Pause6W   �� 5T      -   5        $��btnStop��5T      .��6;   Stop6A   5U      �� 5V   
   -   5        $��btnBack��5V      $��Center=�5X      $��Center=�5Y      .��6,   Convert Another6=   5Z      5[      