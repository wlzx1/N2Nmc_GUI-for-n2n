   M S B A M L   `   `   `  ���� @  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:N2Nmc.View
N2Nmc.View      N2Nmc.View.room   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  $localclr-namespace:N2Nmc.View  -     � Title$
  room��$	��500��$	��400�� � WindowStartupLocation$ CenterScreen=� � Icon$ /img/logo13.ico�� � WindowStyle$
 None=� � AllowsTransparency$
 True��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ Black��   	Direction$	 320Q�   ShadowDepth$ 20Q�	   Opacity$		 0.5Q�.���� 
���   �$��1q�._�� .+�� -   
 �Name$

 grid��
����  �$��40��$	��Top=�.+��� -    ��Name$ guanbi��
������ $��Right=�$��0,5,10,0q�$	��Top=�$��30��$��30��.���� ._�F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��$��Center=�$��Center=��� -   $ 
zuixiaohua��
������ $��Right=�$��0,5,50,0q�$	��Top=�$��30��$��30��.���� ._�F� ���Ѐ� ��� р���� 	
�������$��2��$��Center=�$��Center=��� $��房间列表��
������ $
��Left=�$��10,0,0,0q�7  1HandyControl.Controls.TransitioningContentControl  $��0,45,0,0q�.��&   System.Windows.Controls.DataGrid  -     Name$ DataGridroom��$��0,0,0,64q�   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *StuIda+  $ 名称�� �� *	Community+  $ IP�� �� *
Ip4Address+�� -   $��刷新��$
��Left=�$��329,449,0,0q�$	��Top=��� $
��Left=�$��
10,442,0,0q�$
��Wrap=�$����如果搜不到房主的房间，请使用IP(列表中的IP需要去掉/以后的数字包括/)+房主游戏端口的形式输入到服务器地址中��$	��Top=�$��52��$	��260��