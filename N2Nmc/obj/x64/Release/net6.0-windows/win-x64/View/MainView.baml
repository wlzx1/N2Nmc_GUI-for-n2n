   M S B A M L   `   `   `  ���� @  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:N2NmcN2Nmc  S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5bS9clr-namespace:HandyControl.Controls;assembly=HandyControlHandyControl.Controls     n2nmc.View.MainView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:N2Nmc     Hhc9clr-namespace:HandyControl.Controls;assembly=HandyControl       � Title$  N2Nmc QQ群：856112671��$	��570��$	��920�� � WindowStartupLocation$ CenterScreen=� � Icon$ /img/logo13.ico�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������ .����  �� CornerRadius$ 10��$��	0,0,10,10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   	Direction$	 300Q�	   Opacity$		 0.5Q�
   ShadowDepth$
 7Q�   
BlurRadius$ 5Q�._��  � ColumnDefinitions �� $
��114* ��� $	��11* ��� $	��57* �.+��� -   ���#035cac$ 	10,10,0,0��$��	0,0,0,520q�$��3��._�� -    �Name$
 grid��$��40��$	��Top=�.+��� -    ��Name$ guanbi��
������ $��Right=�$��0,5,10,0q�$	��Top=�$��30��$��30��.���� ._�F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��$��Center=�$��Center=��� -   $ 
zuixiaohua��
������ $��Right=�$��0,5,50,0q�$	��Top=�$��30��$��30��.���� ._�F� ���Ѐ� ��� р���� 	
�������$��2��$��Center=�$��Center=��� $��Hidden=�$
��Left=�$��2��$��	275,0,0,0q�.���� !  HandyControl.Controls.Growl   GrowlParent$
 True��$��Bottom=�$��
0,10,10,10q��� $ 	0,0,10,10��
�������$��0,40,0,0q�$��3��._�� $
��Left=�$	��910�� �� $
��Auto ��� $
��102* ��� $	��73* ��� $
��675* �.+��� $��0��
������ .+��� -   $ page1to��"  HandyControl.Controls.Poptip   Content$ 联机大厅��   	Placement$
 Left=�$��60��$��60�����#d3d3d3.����  �� Orientation$ Vertical=�.+��� $��/img/lj.png��$��40��$��40���� -   $ page2to��$ 创建房间��$
 Left=�$��60��$��60�����#d3d3d3.���� $ Vertical=�.+��� $��/img/cjf.png��$��40��$��40���� -   $ page3to��$ 快速联机��$
 Left=�$��60��$��60�����#d3d3d3.���� $ Vertical=�.+��� $��/img/kslj.png��$��40��$��40���� -   $ page4to��$ 	日志框��$
 Left=�$��60��$��60�����#d3d3d3.���� $ Vertical=�.+��� $��/img/rzfw.png��$��40��$��40���� -	   $��40��$��Stretch=�$��	0,230,0,0q����#d3d3d3.���� $ Vertical=�.+��� $��/img/sz.png��$��20��$��20���� -
    ��Name$ mainContent��$��1��$��3�����#f2f2f2.�� � -     �Name$ Framez��$�� ��  � NavigationUIVisibility$ Hidden=����#f5f6f7