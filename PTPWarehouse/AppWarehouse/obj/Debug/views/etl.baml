   M S B A M L   `   `   `  ����G  CAppWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AppWarehouse.viewmodelAppWarehouse.viewmodel  5          AppWarehouse.views.etl   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :	ViewModel$clr-namespace:AppWarehouse.viewmodel     5      ���#ffffff$	��300��5
      $	��500��6     � Title$	  etl��5      $��Disabled=�6    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X    � WindowStyle$
 None=�6}   $��1q�6�    J� SnapsToDevicePixels . .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��1* �6   6*   .+�5   
   �� ���	#FF254264$	��104��5      $	��Top=�5      $��0,-3,0,0q�5      �� 5   
   $��0��6   $��	10,0,5,10q�5      .+�5      �� -   5         ��Name$ exitbtn��5      $��Right=�5      $��X��5      $��12��5      $��16��5      ���#ffffff$
��Bold"�5       $��ExtraExpanded&�5!      $��12(�5"       � Cursor$
 Hand��5#      �� 5$      -   5         ��Name$ LogoImg��5%      $;��5/AppWarehouse;component/Resources/logo-perusahaan.png��5&      $	��250��5'      $��50��5(      $
��Left=�5)      �� 5*      $��0,5,0,0q�5+      ���#ffffff$	��ETL��5-      $��20(�5.      51      � 52   
   $��1��53      $��10q�54       56      �� 57      $	��200 �6    6/   �� 58      $
��auto �6    60   .+�5:      �� $��0��5;      $��Center=�5<      $��Bottom=�5=      .+�5>      �� -   5        	 ��Name$	 Etlbtn��5>      $��50��5?      $	��150��5@      ���	#FF254264���#ffffff$��Center=�5C      $��Bottom=�5D      $y�Visible=�5E      .��5F      �� PROSES6(   5G      5H      �� 5I      $��1��6   .+�5J      �� -   5        $ 	proseslbl��5M      $y�Hidden=�5K      $!��Proses ETL, Silahkan tunggu��5L      $��0,0,10,0q�5N      � 5O      -   5        
 �Name$
 	pbLoading��5P      
�������$	��Top=�5T      $y�Hidden=�5U      $	��250��5V       � IsIndeterminate 5Q      �� *	Loading+��5S      Z� 5V      5X      5Y      5Z      5[      