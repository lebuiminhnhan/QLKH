   M S B A M L   `   `   `  ����J  FQuanLiKhachHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QuanLiKhachHangQuanLiKhachHang  5   	   M+clr-namespace:QuanLiKhachHang.MyUserControlQuanLiKhachHang.MyUserControl  5	   
   !    QuanLiKhachHang.AddCustomer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QuanLiKhachHang     5   	   :uc+clr-namespace:QuanLiKhachHang.MyUserControl     5	   
   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     
CustomerVM � DataContext# [ 5   
    � Title$ Khách hàng��5   	   $	��500��6   $	��900��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      2   ,QuanLiKhachHang.MyUserControl.UserControlBar  
	 � Tag	 6    �� *Title+
 �� ElementName$
 window��6L   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5)      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5*      � $��0 0 0 10q�6   .+�5+      �� -   5        $��5 5 15 5q�5+   g   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên khách hàng��6y    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *HoTen+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5-      $��	5 5 15 -7q�50      $ Giới tính��51      $
��Left=�52      ��5-       �� *
Property+ �� SelectedItem 5.      �� *
GioiTinh+$ TwoWay=�$ PropertyChanged=�56      �� 58      -   5        $��5 5 15 5q�58   f   $
 CMND��6x   #��[ 6�   ��6   �� *CMND+$ TwoWay=�$ PropertyChanged=�6�   �� 59      $��5 5 15 5q�6h   $ Địa chỉ��6z   #��[ 6�   ��6   �� *DiaChi+$ TwoWay=�$ PropertyChanged=�6�   �� 5:      -   5        $��5 5 15 5q�5:   e   $ Điện thoại��6w   #��[ 6�   ��6   �� *SDT+$ TwoWay=�$ PropertyChanged=�6�   �� 5;      $��5 5 15 5q�6g   $ Email��6y   #��[ 6�   ��6   �� *Email+$ TwoWay=�$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5<      $��Center=�6!   $	��100��6�   $��5 5 15 0q�6�   $ 	Năm Sinh��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *	NamSinh+$ TwoWay=�$ PropertyChanged=�6�   5=      5>        5@      $��1��6"   $��5q�6/   .��5A      � .+�5B      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5C      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5D      $��Xóa��6>   $��5q�6M   $	��100��6X   ��6   �� *EditCommand1+6f   5E      5F        5H      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5I      �� $
��Auto=�6   $
��Auto=�6B   .��5J      �� ��6   �� *KhachHangList+$ TwoWay=�$ PropertyChanged=� 6x   �� *SelectedItem+$ TwoWay=� �� View 5K      �� 5L      .P�5M   "   �� $��ID Khách Hàng��61    �� DisplayMemberBinding 6H   �� *MaKH+6p   �� 5N   "   $��Tên Khách Hàng��61    6I   �� *HoTen+6r   �� 5O   "   $��Giới Tính��61    6D   �� *
GioiTinh+6p   �� 5P   "   $��	Năm Sinh��61    6C   �� *	NamSinh+6n   �� 5Q   "   $
��CMND��61    6?   �� *CMND+6g   �� 5R   "   $��Điện Thoại��61    6E   �� *SDT+6l   �� 5S   "   $��Địa Chỉ��61    6B   �� *DiaChi+6l   �� 5T   "   $��Email��61    6@   �� *Email+6i   5U   $   5W      5X      5Y      5Z      5[      5\      