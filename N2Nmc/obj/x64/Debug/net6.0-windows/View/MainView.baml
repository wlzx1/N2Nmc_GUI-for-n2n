   M S B A M L   `   `   `  ����@  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:N2NmcN2Nmc  5   	   S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5bS9clr-namespace:HandyControl.Controls;assembly=HandyControlHandyControl.Controls 5   	       n2nmc.View.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:N2Nmc     5   	   Hhc9clr-namespace:HandyControl.Controls;assembly=HandyControl     5   	     � Title$  N2Nmc QQ群：856112671��5   	   $	��570��6%   $	��920��62    � WindowStartupLocation$ CenterScreen=�6>    � Icon$ /img/logo13.ico��6c    � WindowStyle$
 None=�6z    � AllowsTransparency$
 True��6�   
������ .��5      ��  �� CornerRadius$ 10��6   $��	0,0,10,10q�6    J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      	Direction$	 300Q�6-   	   Opacity$		 0.5Q�6=   
   ShadowDepth$
 7Q�6K      
BlurRadius$ 5Q�6[   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��114* �6#   �� 5      $	��11* �6#   �� 5      $	��57* �6#   .+�5$      �� -   5        ���#035cac$ 	10,10,0,0��5$   *   $��	0,0,0,520q�6C   $��3��6y   ._�5%      � -   5         �Name$
 grid��5%      $��40��6&   $	��Top=�62   .+�5'      �� -   5         ��Name$ guanbi��5'      
������ $��Right=�6G   $��0,5,10,0q�6c   $	��Top=�6u   $��30��6�   $��30��6�   .��5(      �� ._�5)      F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��6N   $��Center=�6b   $��Center=�6}   5*      5+      �� 5,      -   5        $ 
zuixiaohua��5,      
������ $��Right=�6K   $��0,5,50,0q�6g   $	��Top=�6y   $��30��6�   $��30��6�   .��5-      �� ._�5.      F� ���Ѐ� ��� р���� 	
�������$��2��6C   $��Center=�6W   $��Center=�6r   5/      50      51      52      �� 57      $��Hidden=�6   $
��Left=�6@   $��2��6[   $��	275,0,0,0q�6k   .��58      �� !  HandyControl.Controls.Growl   GrowlParent$
 True��6   $��Bottom=�69   $��
0,10,10,10q�6T   59      �� 5:      $ 	0,0,10,10��6   
�������$��0,40,0,0q�6E   $��3��6W   ._�5>      � $
��Left=�6   $	��910��62    5?      �� 5E      $
��Auto �6+   �� 5G      $
��102* �6+   �� 5H      $	��73* �6+   �� 5I      $
��675* �6+   .+�5M      �� $��0��6!   
������ .+�5N      �� -   5        $ page1to��5N   !   "  HandyControl.Controls.Poptip   Content$ 联机大厅��62      	Placement$
 Left=�6K   $��60��6f   $��60��6r   ���#d3d3d3.��5O      ��  �� Orientation$ Vertical=�6)   .+�5P   "   �� $��/img/lj.png��6(   $��40��6=   $��40��6I   5Q      5R      �� 5S      -   5        $ page2to��5S   !   $ 创建房间��62   $
 Left=�6K   $��60��6�   $��60��6�   ���#d3d3d3.��5T      �� $ Vertical=�6)   .+�5U   "   �� $��/img/cjf.png��6(   $��40��6>   $��40��6J   5W      5X      �� 5Y      -   5        $ page3to��5Y   !   $ 快速联机��62   $
 Left=�6K   $��60��6�   $��60��6�   ���#d3d3d3.��5Z      �� $ Vertical=�6)   .+�5[   "   �� $��/img/kslj.png��6(   $��40��6?   $��40��6K   5\      5]      �� 5^      -   5        $ page4to��5^   !   $ 	日志框��62   $
 Left=�6J   $��60��6   $��60��6�   ���#d3d3d3.��5_      �� $ Vertical=�6)   .+�5`   "   �� $��/img/rzfw.png��6(   $��40��6?   $��40��6K   5a      5b      �� 5j      -	   5        $��40��5j   !   $��Stretch=�6-   $��	0,230,0,0q�6I   ���#d3d3d3.��5k      �� $ Vertical=�6)   .+�5l   "   �� $��/img/sz.png��6(   $��20��6=   $��20��6I   5m      5n      5o      �� 5r      -
   5         ��Name$ mainContent��5r   5   $��1��6%   $��3��6J   ���#f2f2f2.��5t       � -   5          �Name$ Framez��5t       $�� ��60     � NavigationUIVisibility$ Hidden=�6;   ���#f5f6f76[   5u      5y      5z      5      5�      5�      