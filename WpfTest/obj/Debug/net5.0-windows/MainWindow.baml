   M S B A M L   `   `   `  ����B  >WpfTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfTestWpfTest  5          WpfTest.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.4.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      !localclr-namespace:WpfTest  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$	  GPT��5	      $
��1200��5
      $	��800��5       � 	Resources 5         
solidColor �� Color��%)   &	        �� 5   
   $ Green��6-   5      .��5      � $��10,10,10,10q�6    � ColumnDefinitions 5    
   �� 5!      $	��200 �6   �� 5"      .+�5%   
   � $��0��6   .+�5^      R� ��6   �� *	MenuItems+��5_      �� 5`       �� ItemsSource 6/   �� *
Children+.R�5b      �� -   5        $��40��5c       �� Orientation$ 
Horizontal=�5e      .+�5f      �� $��24��5g   !   $��24��5h   !   $��10,0,0,0q�5i   !   $��Center=�5j   !   $��/Images/HR.png��5k   !   �� 5l      $��10,0,0,0q�5m   !   $��Center=�5n   !   ��5o   !   �� *Title+5p      5q      5t      5u      &   HandyControl.Controls.TabControl  5w   
   -   5          Name$ 
tabControl��5x      $��1��5y         IsAnimationEnabled$
 True��5z         IsDraggable$
 True��5{      	   IsScrollable$
	 True��5|      
   IsTabFillEnabled$
 False��5}       �� SelectedIndex$ 0��5         ShowCloseButton$
 True��5�      ��5~      �� *
TabPages+��5�      �� 5�      .R�5�      �  5�      �� 5�      $��40 �6/   �� 5�      .+�5�      �� $��0��5�      $��20��5�      $��20��5�      $��Center=�5�      $��Center=�5�      $��/Images/HR.png��5�      &   HandyControl.Controls.SimpleText  5�      $��1��5�      $
��Left=�5�      $��Center=�5�         Text 5�      �� *
headerName+5�      5�       �� ContentTemplate 5�      �� 5�      .R�5�       �   � NavigationUIVisibility$ Hidden=�6     � Source 6<   �� *Uri+5�      5�      5�      5�      