   M S B A M L   `   `   `  ����@  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:N2NmcN2Nmc  5   	       n2nmc.View.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:N2Nmc     5   	   S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	     � Title$  N2Nmc QQ群：856112671��5   	   $	��560��6%   $	��910��62    � WindowStartupLocation$ CenterScreen=�6>    � Icon$ /img/logo13.ico��6c    � WindowStyle$
 None=�6z    � AllowsTransparency$
 True��6�   
�������.��5      � .+�5   
   � -   5         �Name$
 grid��5      
����  �$��40��6/   $	��Top=�6;   .+�5      �� -   5         ��Name$ guanbi��5      
������ $��Right=�6?   $��0,5,10,0q�6[   $	��Top=�6m   $��30��6�   $��30��6�   .��5      �� ._�5      F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��6F   $��Center=�6Z   $��Center=�6u   5      5      �� 5      -   5        $ 
zuixiaohua��5      
������ $��Right=�6C   $��0,5,50,0q�6_   $	��Top=�6q   $��30��6�   $��30��6�   .��5      �� ._�5      F� ���Ѐ� ��� р���� 	
�������$��2��6;   $��Center=�6O   $��Center=�6j   5      5       5!      � 5'   
   $��0,40,0,0q�6    � ColumnDefinitions 5(      �� 5)      $
��Auto �6#   �� 5+      $��3* �6#   �� 5,      $	��22* �6#   .+�51      �� $��0��6   
�������.+�52      �� -   5        "  HandyControl.Controls.Poptip   Content$ 联机大厅��52      	   	Placement$
	 Left=�62   $��60��6M   $��60��6Y   .��53      �� 
 �� Orientation$
 Vertical=�6!   .+�54      �� $��/img/lj.png��6    $��40��65   $��40��6A   55      56      �� 57      -   5        $ 创建房间��57      $
	 Left=�62   $��60��6g   $��60��6s   .��58      �� $
 Vertical=�6!   .+�59      �� $��/img/cjf.png��6    $��40��66   $��40��6B   5;      5<      �� 5=      -   5        $ 快速联机��5=      $
	 Left=�62   $��60��6g   $��60��6s   .��5>      �� $
 Vertical=�6!   .+�5?      �� $��/img/kslj.png��6    $��40��67   $��40��6C   5@      5A      �� 5B      -   5        $ 	日志框��5B      $
	 Left=�61   $��60��6f   $��60��6r   .��5C      �� $
 Vertical=�6!   .+�5D      �� $��/img/rzfw.png��6    $��40��67   $��40��6C   5E      5F      �� 5N      -   5        $��40��5N      $��Stretch=�6%   $��	0,230,0,0q�6A   .��5O      �� $
 Vertical=�6!   .+�5P      �� $��/img/sz.png��6    $��20��65   $��20��6A   5Q      5R      5S      �� 5V      -	   5         ��Name$ mainContent��5V   -   $��1��6   $��2��6B   .��5X       � -
   5          �Name$ Framez��5X      $�� ��6(     � NavigationUIVisibility$ Hidden=�63   5Y      5\      �� 5`   
   $��Hidden=�6   $��Right=�6<   .��5a      �� !  HandyControl.Controls.Growl   GrowlParent$
 True��6   $��Bottom=�65   $��
0,10,10,10q�6P   5b      5g      5h      