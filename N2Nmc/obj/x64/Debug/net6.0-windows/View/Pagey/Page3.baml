   M S B A M L   `   `   `  ����@  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:n2nmc.View.Pageyn2nmc.View.Pagey  5          n2nmc.View.Pagey.Page3   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:n2nmc.View.Pagey     5      S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5        N� Title$  Page3��5      .��5      +  %HandyControl.Controls.DialogContainer  .u�5   
   7  1HandyControl.Controls.TransitioningContentControl  .��5      � ���#f5f6f7.+�5      �� -   5         ��Name$ TextBox1��5      $
��Left=�6,   $��	70,60,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $��TextBox��6n   $	��Top=�6}   $	��120��6�   �� 5      -   5         ��Name$ duqu2��5      $
��duqu��6(   $
��Left=�67   $��
70,110,0,0q�6R   $	��Top=�6f   6~   �� 5      -   5        $ xieru2��5      $��xieru��6)   $
��Left=�69   $��147,110,0,0q�6T   $	��Top=�6i   6�   �� 5      -   5        $ shanchu2��5      $��shanchu��6+   $
��Left=�6=   $��243,110,0,0q�6X   $	��Top=�6m   6�   �� 5      -   5        $!��判断进程是否在运行��5      $
��Left=�6-   $��
70,160,0,0q�6H   $	��Top=�6\   6t   �� 5      -   5        $��	获取pid��5      $
��Left=�6)   $��295,170,0,0q�6D   $	��Top=�6Y   6q   �� 5      -   5        $ log_text��5      $	��log��6+   $
��Left=�69   $��126,196,0,0q�6T   $	��Top=�6i   6�   �� 5      .+�5      �� ${�False��6   $	��456��6/   $��5q�6=   �� 5      $	��123��6   $	��168��6+   5      �� 5      $��Hidden=�6   $��Right=�6D   .��5      �� !  HandyControl.Controls.Growl   GrowlParent$
 True��6!   $	��Top=�6=   $��
0,10,10,10q�6U   5      �� 5       -   5        $ cmdshi��5       $��cmd实时回显��6)   $��
66,259,0,0q�6;   $	��Top=�6O   $
��Left=�6g   6�   �� 5!      -	   5        $ OutputTextBox��5!      $
 Wrap=�61   $��TextBox��6E   $��184,259,221,26q�6T   d� 5"         ToggleButtonLoading#��[  6   $��1��6{   $	��180��6�   $��559,125,0,0q�6�   $
��Left=�6�   $	��Top=�6�    d� 	IsChecked 6L   �� *IsUploading+ �� Mode$ TwoWay=�6�   �� 5#      -
   5        $��载入房间窗口��5#      $
��Left=�6*   $��
52,326,0,0q�6E   $	��Top=�6Y   6q   �� 5$      -   5        $��获取游戏端口��5$      $
��Left=�6*   $��184,224,0,0q�6E   $	��Top=�6Z   6r   5%      5&      5'      5(      