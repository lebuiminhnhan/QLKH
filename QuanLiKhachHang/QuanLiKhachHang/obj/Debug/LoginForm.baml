   M S B A M L   `   `   `  ����J  FQuanLiKhachHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QuanLiKhachHangQuanLiKhachHang  5   	   M+clr-namespace:QuanLiKhachHang.MyUserControlQuanLiKhachHang.MyUserControl  5   	       QuanLiKhachHang.LoginForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QuanLiKhachHang     5   	   :uc+clr-namespace:QuanLiKhachHang.MyUserControl     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5        $��loginWindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStyle$
 None=�5   	     MaterialDesignFont#���  5        LoginVM � DataContext# [ 5   	    � Title$ Đăng nhập��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��500��6@   $	��400��6M   $	��400��6o   $	��500��6~    � 
ResizeMode$ NoResize=�6�    � Icon$ user.png��6�   ��6Y   Z� ��5      �� 5   
    �� EndPoint$ 0.5,1&�6   	 �� 
StartPoint$	 0.5,0&�6/   .��5      � 
 � Color$
 	#FFC31717��6    � Offset$ 0Q�6-   � 5      $
 White��6   $ 0.472Q�6)   � 5      $
 	#FF4EF3E4��6   $ 0.979Q�6-   � 5      $
 White��6   $ 0.776Q�6)   5      .��5      �  � RowDefinitions 5   
   �� 5!      $
��auto �6   6,   �� 5"      6   .+�5%   
   � $��0��6   $��Center=�6   .+�5&      ��   MaterialDesignRaisedButton#���  5'      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�5(      .��66   Siêu thị VinMart Trà Vinh5*      5+      �� 5,   
   -   5         ��Name$ BtnThoat��5,      $��40��5-      $	��100��5.      #��[ 5/      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   Value$ -1Q�50         IsIndicatorVisible .    IsIndeterminate . $��Thoát��53      $��
0,364,80,0q�54      ���	#FFC31717$��1��60   $��Right=�6T   $	��Top=�6p   �� 55   
    �� 	IsDefault . $��40��57      $	��100��58      #��[ 5;      $ -1Q�5<       .  . $��Đăng nhập��5?      $��	80,0,0,64q�5@      $��1��6   $��Bottom=�6&   $
��Left=�6A   ��59      �� *LoginCommand+��5:      ��  �� ElementName$ loginWindow��5@   A   �� 5A   
   $	��200��5B      $��50��5C      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tài khoản��5E       % !MaterialDesignFloatingHintTextBox#��[ 5F      $��100,189,100,221q�5G      ���	#DD000000$
��Bold"�5I      $��18(�6$   ���	#89000000$��1��5K      ��5D      �� *
UserName+5K      G� 5M   
   -   5         G�Name$ FloatingPasswordBox��5Q      $	��200��5N      $��50��5O      $ Mật khẩu��5S       ) %MaterialDesignFloatingHintPasswordBox#��[ 5T      $��100,255,100,155q�5U      ���	#DD000000$
��Bold"�5V      $��18(�6   ���	#89000000$��1��5X      .  (System.Windows.Interactivity.Interaction   Triggers 5Z      /  )System.Windows.Interactivity.EventTrigger  5[         	EventName$ PasswordChanged��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5\      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *PasswordChangedCommand+   CommandParameter 5]   $   �� $ FloatingPasswordBox��5^      5`      �� 5e   
   $��115,4,115,0q�6   $	��170��6%   $	��170��61   $��user.png��6>   $
��Fill=�6P   $	��Top=�6_   $��1��6w   5g      5h      