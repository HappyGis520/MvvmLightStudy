   M S B A M L   `   `   `  ����G  CMvvmLight003, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MvvmLight003.ViewMvvmLight003.View  5   	   &     MvvmLight003.View.UserInfoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:MvvmLight003.View     5   	     � Title$  UserInfo��5	   	   $	��300��6   $	��300��6'    � DataContext 5   	   ��    Locator �� Source# [   �� Path$ UserInfo�.��5
      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��64 �6   �� 5      $	��180 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Center=�6!   	用户名6A   �� 5   
   $��1��6   $��Center=�6!   姓别6@   �� 5   
   $��2��6   $��Center=�6!   年龄6@   �� 5   
   $��3��6   $��Center=�6!   	手机号6A   �� 5   
   $��0��6   $��1��6   $��Center=�60   ��6K   �� *UserInfo.UserName+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $��1��6   $��1��6    $��Center=�60   ��6L   �� *UserInfo.UserName+6q   �� 5    
   $��2��6   $��1��6   $��Center=�6/   6L   �� 5!   
   $��3��6   $��1��6   $��Center=�6/   6L   5"      5#      