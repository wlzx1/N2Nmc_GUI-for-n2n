   M S B A M L   `   `   `  ����@  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:N2Nmc.View
N2Nmc.View  5   	       N2Nmc.View.room   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   $localclr-namespace:N2Nmc.View  5   	   -   5          � Title$
  room��5	   	   $	��500��6   $	��815��6#    � WindowStartupLocation$ CenterScreen=�6/    � Icon$ /img/logo13.ico��6T    � WindowStyle$
 None=�6k    � AllowsTransparency$
 True��6~   
������  J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5   
      Color$ Black��6      	Direction$	 320Q�6)      ShadowDepth$ 20Q�69   	   Opacity$		 0.5Q�6J   .��5      �� 
���   �$��1q�6!   
 �� CornerRadius$
 10��65   ._�5   
   � .+�5      �� 
�������$
 10��6(   ._�5      �� -   5        $��刷新��5      $
��Left=�6&   $��329,449,0,0q�6A   $	��Top=�6V   6n   5      �� 5      -   5        $
 	10,10,0,0��5      ���#035cac$��	0,0,0,453q�6C   ._�5      � -   5         �Name$
 grid��5      $��40��6&   $	��Top=�62   .+�5      �� -   5         ��Name$ guanbi��5      
������ $��Right=�6G   $��0,5,10,0q�6c   $	��Top=�6u   $��30��6�   $��30��6�   .��5      �� ._�5      F� +����@B     � -1 -1�@B  -1� -1    	
�������$��2��6N   $��Center=�6b   $��Center=�6}   5      5      �� 5      -   5        $ 
zuixiaohua��5      
������ $��Right=�6K   $��0,5,50,0q�6g   $	��Top=�6y   $��30��6�   $��30��6�   .��5      �� ._�5      F� ���Ѐ� ��� р���� 	
�������$��2��6C   $��Center=�6W   $��Center=�6r   5      5      �� 5       $��房间列表��6   
������ $
��Left=�6E   $��10,0,0,0q�6`   5!      5"      �� 5#      ���#cbcbcb$��
380,45,0,0q�6*   $
 0,0,10,0��6>   ._�5$      � .+�5%      �� -   5         ��Name$ messageTextBox��5%      $
��Left=�66   $��
19,413,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��321��6�   �� 5&      -   5        $��发送��5&      $
��Left=�6*   $��359,413,0,0q�6E   $	��Top=�6Z   $��60��6r   6}   �� 5'      ���#f4f4f4$��15,15,15,50q�62   $
 10��6G   ._�5(      �� -	   5         ��Name$ TextBlock_Chat��5(   $   $
��Wrap=�6<   $��24,24,24,24q�6P   �� 6f    � Language$ zh-cn�6j   $!�开发中：暂时不可用��6{   �� 6�   �� 6�   $ zh-cn�6�   6�   5)      5*      5+      7  1HandyControl.Controls.TransitioningContentControl  5,      $��
0,45,353,0q�6-   .��5-      &   System.Windows.Controls.DataGrid  -
   5          Name$ DataGridroom��5-      $��	0,0,81,64q�61      AutoGenerateColumns$ False��6D      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ 编号��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *StuIda+6T     50      $ 名称��6-    69   �� *	Community+  51      $ IP��6-    6:   �� *
Ip4Address+53      55      �� 56      $
��Left=�6   $��
10,442,0,0q�63   $
��Wrap=�6G   $i��c如果搜不到房主的房间，请使用IP+房主游戏端口的形式输入到服务器地址中��6[   $	��Top=�6�   $��52��6�   $	��260��6�   57      58      5;      