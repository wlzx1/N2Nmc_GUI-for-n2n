   M S B A M L   `   `   `  ����@  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:N2Nmc.View
N2Nmc.View  5   	       N2Nmc.View.room   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   $localclr-namespace:N2Nmc.View  5   	   -   5          � Title$
  room��5	   	   $	��500��6   $	��400��6#    � WindowStartupLocation$ CenterScreen=�6/    � Icon$ /img/logo13.ico��6T    � WindowStyle$
 None=�6k    � AllowsTransparency$
 True��6~   
������� J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ Black��6      	Direction$	 320Q�6)      ShadowDepth$ 20Q�69   	   Opacity$		 0.5Q�6J   .��5      �� 
���   �$��1q�6!   ._�5   
   � .+�5      � -   5        
 �Name$

 grid��5      
����  �$��40��63   $	��Top=�6?   .+�5      �� -   5         ��Name$ guanbi��5      
������ $��Right=�6C   $��0,5,10,0q�6_   $	��Top=�6q   $��30��6�   $��30��6�   .��5      �� ._�5      F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��6J   $��Center=�6^   $��Center=�6y   5      5      �� 5      -   5        $ 
zuixiaohua��5      
������ $��Right=�6G   $��0,5,50,0q�6c   $	��Top=�6u   $��30��6�   $��30��6�   .��5      �� ._�5      F� ���Ѐ� ��� р���� 	
�������$��2��6?   $��Center=�6S   $��Center=�6n   5      5      �� 5      $��房间列表��6   
������ $
��Left=�6A   $��10,0,0,0q�6\   5      7  1HandyControl.Controls.TransitioningContentControl  5      $��0,45,0,0q�6-   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridroom��5      $��0,0,0,64q�61      AutoGenerateColumns$ False��6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *StuIda+6T     5       $ 名称��6-    69   �� *	Community+  5!      $ IP��6-    6:   �� *
Ip4Address+5#      5%      �� 5&      -   5        $��刷新��5&      $
��Left=�6"   $��329,449,0,0q�6=   $	��Top=�6R   6j   �� 5'      $
��Left=�6   $��
10,442,0,0q�63   $
��Wrap=�6G   $����如果搜不到房主的房间，请使用IP(列表中的IP需要去掉/以后的数字包括/)+房主游戏端口的形式输入到服务器地址中��6[   $	��Top=�6�   $��52��6�   $	��260��6�   5(      5)      5,      