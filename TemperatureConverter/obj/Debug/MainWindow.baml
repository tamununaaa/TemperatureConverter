   M S B A M L   `   `   `  ����O  KTemperatureConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TemperatureConverterTemperatureConverter  5   	   Q-clr-namespace:TemperatureConverter.ViewModelsTemperatureConverter.ViewModels  5   	   %    TemperatureConverter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:TemperatureConverter     5   	   D
viewModels-clr-namespace:TemperatureConverter.ViewModels     5   	     � Icon$E  ?Z:\TemperatureConverter\TemperatureConverter\Resources\logo.png��5   :    � WindowStartupLocation$ CenterScreen=�5      ���#ffeba3 � Title$ Temperature Converter��5	   	   $	��350��6'   $	��525��64   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��0,10,0,0q�6;   $��Bottom=�6M   $��Center=�6h   .+�5      �� $E��?Z:\TemperatureConverter\TemperatureConverter\Resources\logo.png��6   $��60��6]   $��60��6i   �� 5      $��TEMPERATURE CONVERTER��6   $��20(�64   $��5q�6B   $��Center=�6M   5      � 5   
   $��1��6   $��Center=�6   $��25q�69   .+�5      �� $��Celsius��6   $��13(�6&   $
��Left=�64   $��	10,10,0,0q�6O   $	��Top=�6c   �� 5      -   5        $��
txtCelsius��5      $
��Left=�6)   $��23��6D   $��	90,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6�   $	��120��6�   ��6w   �� *	Celsius+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��
Fahrenheit��6   $��13(�6)   $
��Left=�67   $��	10,50,0,0q�6R   $	��Top=�6e   �� 5       -   5        $��txtFahrenheit��5       $
��Left=�6+   $��23��6F   $��	90,50,0,0q�6R   $
 Wrap=�6e   $	��Top=�6�   $	��120��6�   ��6y   �� *
Fahrenheit+$ PropertyChanged=�6�   �� 5"      $��Kelvin��6   $��13(�6%   $
��Left=�63   $��	10,90,0,0q�6N   $	��Top=�6a   �� 5#      -   5        $��	txtKelvin��5#      $
��Left=�6'   $��23��6B   $��	90,90,0,0q�6N   $
 Wrap=�6a   $	��Top=�6�   $	��120��6�   ��6u   �� *Kelvin+$ PropertyChanged=�6�   5$      �� 5&   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5'      �� $��Convert��6   ���#FBB402$��SemiBold"�6<   $
��Left=�6R   $��10,0,0,0q�6m   $��0q�6   $	��Top=�6�   $	��105��6�   $��30��6�   ��6�   �� *ConvertCommand+�� 5(      $��Reset��6   ���#FBB402$��SemiBold"�6:   $��13(�6P   $
��Left=�6^   $��10,0,0,0q�6y   $��0q�6�   $	��Top=�6�   $	��105��6�   $��30��6�   ��6�   �� *ResetCommand+5)      5-      5.      