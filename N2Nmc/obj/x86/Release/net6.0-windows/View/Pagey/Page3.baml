   M S B A M L   `   `   `  ���� @  <N2Nmc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:n2nmc.View.Pageyn2nmc.View.Pagey      n2nmc.View.Pagey.Page3   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:n2nmc.View.Pagey     S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol    N� Title$  Page3��.��+  %HandyControl.Controls.DialogContainer  .u�7  1HandyControl.Controls.TransitioningContentControl  .��� 
�������.+��� -    ��Name$ TextBox1��$
��Left=�$��	70,60,0,0q� �� TextWrapping$
 Wrap=�$��TextBox��$	��Top=�$	��120���� -    ��Name$ duqu2��$
��duqu��$
��Left=�$��
70,110,0,0q�$	��Top=��� -   $ xieru2��$��xieru��$
��Left=�$��147,110,0,0q�$	��Top=��� -   $ shanchu2��$��shanchu��$
��Left=�$��243,110,0,0q�$	��Top=��� -   $!��判断进程是否在运行��$
��Left=�$��
70,160,0,0q�$	��Top=��� -   $��	获取pid��$
��Left=�$��295,170,0,0q�$	��Top=��� -   $ log_text��$	��log��$
��Left=�$��126,196,0,0q�$	��Top=��� .+��� ${�False��$	��456��$��5q��� $	��123��$	��168���� $��Hidden=�$��Right=�.���� !  HandyControl.Controls.Growl   GrowlParent$
 True��$	��Top=�$��
0,10,10,10q��� -   $ cmdshi��$��cmd实时回显��$��
66,259,0,0q�$	��Top=�$
��Left=��� -	   $ OutputTextBox��$
 Wrap=�$��TextBox��$��184,259,221,26q�d�    ToggleButtonLoading#��[  $��1��$	��180��$��559,125,0,0q�$
��Left=�$	��Top=� d� 	IsChecked �� *IsUploading+ �� Mode$ TwoWay=��� -
   $��载入房间窗口��$
��Left=�$��
52,326,0,0q�$	��Top=�