   M S B A M L   `   `   `  ����F  BWpfApp_lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfApp_lab4WpfApp_lab4  5   	       WpfApp_lab4.Edit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfApp_lab4     5   	     � Title$
  Edit��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
   
   � $��10,16,-10,-6q�6    � ColumnDefinitions 5      �� 5      $	��21* �6#   �� 5      $
��693* �6#   �� 5      $	��16* �6#   �� 5      $	��70* �6#   .+�5      �� -   5         ��Name$ btn_save��5      $��Edit ��6'   $
��Left=�67   $��
62,341,0,0q�6R   $	��Top=�6f   $��37��6~   $��66��6�   $��1��6�   �� 5      -   5         ��Name$ textBox2��5      $
��Left=�6)   $��
216,71,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��1��6�   �� 5      -   5        $ textBox1��5      $
��Left=�6*   $��	62,71,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��1��6�   �� 5      -   5        $ textBox3��5      $
��Left=�6(   $��216,153,0,0q�6C   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��1��6�   �� 5      $��І'мя��6   $
��Left=�6#   $��	62,48,0,0q�6>   $	��Top=�6Q   $��1��6i   �� 5      $��Прізвище��6   $
��Left=�6'   $��
216,48,0,0q�6B   $	��Top=�6V   $��1��6n   �� 5      $#��День Народження��6   $
��Left=�6.   $��
379,48,0,0q�6I   $	��Top=�6]   $��1��6u   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DateOf��5      $
��Left=�6)   $��
379,71,0,0q�6D   $	��Top=�6X   $��26��6p   $	��111��6|   $��1��6�   �� 5      -   5         ��Name$ 	comboBox1��5      $
��Left=�6*   $��
62,153,0,0q�6E   $	��Top=�6Y   $	��120��6q   $��1��6}   �� 5      $��Тип гуртка��6   $
��Left=�6)   $��
62,131,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ -5.785,-1.254&�6p   $��1��6�   �� 5      $(��"Оплата - грн/місяць��6   $
��Left=�62   $��216,131,0,0q�6M   $	��Top=�6b   $ -0.411,0.294&�6z   $��1��6�   �� 5      $4��.Інформація про Викладача��6   $
��Left=�67   $��9,10,0,0q�6R   $	��Top=�6d   $��24��6|   $	��173��6�   $��1��6�   �� 5      -   5        $ 
bnt_Cancel��5      $��Cancel��6)   $
��Left=�6:   $��582,341,0,0q�6U   $	��Top=�6j   $��38��6�   $��68��6�   $��1��6�   6�   �� 5      $%��Адрес проведення��6   $
��Left=�6/   $��379,131,0,0q�6J   $	��Top=�6_   $ 0.574,-0.268&�6w   $��1��6�   �� 5      -   5        $ textBox4��5      $
��Left=�6(   $��379,153,0,0q�6C   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��1��6�   �� 5       $5��/Кількість занять                ��6   $
��Left=�6?   $��544,131,0,0q�6Z   $	��Top=�6o   $��1��6�   �� 5!      -	   5        $ textBox5��5!      $
��Left=�6(   $��544,153,0,0q�6C   $
 Wrap=�6Z   $	��Top=�6n   $	��120��6�   $��1��6�   �� 5"      -
   5        $ textBox6��5"      $
��Left=�6(   $��379,198,0,0q�6C   $
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��1��6�   �� 5#      $#��Кількість учнів��6   $
��Left=�6.   $��379,176,0,0q�6I   $	��Top=�6^   $��1��6v   5%      5'      5(      