   M S B A M L   `   `   `  ����D  @CovidStat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CovidStat	CovidStat  5   	       CovidStat.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CovidStat     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ 
MainWindow��5   	   $
��1024��6   $
��1280��6*    � WindowStyle$
 None=�67   .��5      � ���#282828 � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   � $��0��6   $	��100��6   $	��Top=�6)   $��0,0,0,20q�6A   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�64   .+�5      �� $
��Left=�6   $��80��63   $��	20,0,15,0q�6>   $��	virus.png��6Q   �� 5      $��Center=�6   $��0q�68   .+�5      �� 
�������$��Gilroy)�63   $
��Bold"�6G   $��30(�6Y   
COVID-196q   �� 5      
�������$��Gilroy)�63   $��0,-5,0,0q�6G   $��15(�6Y   	STATISTIC6r   5      5      5       � 5"   
   $��1��6   $��0,0,0,10q�6   .+�5#      �� $��Center=�6   $��Center=�66   .+�5$      � $��0,0,0,20q�6   .+�5%      �� .+�5&      ��  �� TextAlignment$ Center=�6$   
�������$��Gilroy)�6R   $
��Bold"�6f   $��20(�6x   Total6�   �� 5'      -   5         ��Name$ totalConfirmed��5'   $   $ Center=�6<   
�������$��Gilroy)�6f   $
��Bold"�6z   $��30(�6�   36.0000.0006�   5(      5)      � 5*      $��0,0,0,20q�6   .+�5+      �� .+�5,      �� $ Center=�6$   
�������$��Gilroy)�6R   $
��Bold"�6f   $��20(�6x   	Recovered6�   �� 5-      -   5        $ totalRecovered��5-   $   $ Center=�6<   
�������$��Gilroy)�6f   $
��Bold"�6z   $��30(�6�   
2500.0006�   5.      5/      � 50      $��0,0,0,20q�6   .+�51      �� .+�52      �� $ Center=�6$   
�������$��Gilroy)�6R   $
��Bold"�6f   $��20(�6x   Deaths6�   �� 53      -   5        $ totalDeaths��53   $   $ Center=�69   
�������$��Gilroy)�6c   $
��Bold"�6w   $��30(�6�   	100.0006�   54      55      56      57      � 59   
   $��2��6   $��0,0,0,20q�6    5:      �� 5;      $
��Auto �6    60   �� 5<      $
��Auto �6    60   �� 5=      $��* �6    6-   .+�5@      � $��0��6   $��Center=�6    $��Center=�6=   $��0,0,0,10q�6X    � ColumnDefinitions 5A      �� 5B      6)   �� 5C      6)   �� 5D      6)   .+�5G      �� $��0��6   $ 
Horizontal=�6-   $��0,0,30,0q�6F   .+�5H      �� -   5        	 ��Name$	 field_Country��5H      $��Gilroy)�65   $
��Bold"�6I   
�������)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Country name��5I       % !MaterialDesignFloatingHintTextBox#��[ 5J      $��0,0,10,0q�5K      �� 5L      -   5         ��Name$ btn_Country��5L       # MaterialDesignRaisedLightButton#��[ 62   $��30��6k   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��6w    � ToolTip$8 2MaterialDesignRaisedLightButton with Round Corners��5M      .��5N      �� $
��Find��6$   5O      5P      �� 5R      $��1��6   $ 
Horizontal=�6-   $��0,0,30,0q�6F   .+�5S      �� -   5        $	 field_Minus��5S      $��Gilroy)�63   $
��Bold"�6G   
�������$
 Minus (Total)��5T      #��[ 5U      $��0,0,10,0q�5V      �� 5W      -   5        #��[ 5W      $��30��6V   $ 5��6b   $8 2MaterialDesignRaisedLightButton with Round Corners��5X      .��5Y      �� -   5        $ 	btn_Minus��5Y   $   $
��Find��67   5Z      5[      �� 5]      $��2��6   $ 
Horizontal=�6-   $��0,0,30,0q�6F   .+�5^      �� -	   5        $	 
field_Plus��5^      $��Gilroy)�62   $
��Bold"�6F   
�������$
 Plus (Total)��5_      #��[ 5`      $��0,0,10,0q�5a      �� 5b      -
   5        #��[ 5b      $��30��6V   $ 5��6b   $8 2MaterialDesignRaisedLightButton with Round Corners��5c      .��5d      �� -   5        $ btn_Plus��5d   $   $
��Find��66   5e      5f      5h      � 5j      $��1��6   .+�5k      � $��Center=�6   $��Stretch=�62   $��
50,0,50,10q�6P    5l      �� 5m      6-   �� 5n      6-   �� 5o      6-   �� 5p      6-   �� 5q      6-   �� 5r      6-   �� 5s      6-   .+�5v      �� $��0��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   	Country6�   �� 5w      $��1��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   Total6�   �� 5x      $��2��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   New Confirmed6�   �� 5y      $��3��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   Total Deaths6�   �� 5z      $��4��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   
New Deaths6�   �� 5{      $��5��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   Total Recovered6�   �� 5|      $��6��6    $
��Wrap=�60   $ Center=�6D   
�������$��Gilroy)�6r   $
��Bold"�6�   $��15(�6�   New Recovered6�   5}      5~      �� 5�      $��2��6   .��5�      �� -   5         ��Name$ GridStackPanel��5�   :   $��0��6   $��0��6*   $
��Auto��6R   5�      5�      5�      5�      5�      