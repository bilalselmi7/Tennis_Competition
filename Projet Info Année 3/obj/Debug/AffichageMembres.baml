   M S B A M L   `   `   `  ����O  KProjet Info Année 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Projet_Info_Année_3Projet_Info_Année_3  5   	   +    %Projet_Info_Année_3.AffichageMembres   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Projet_Info_Année_3     5   	     � Title$  AffichageMembres��5   	   $	��550��6"   $	��800��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��0 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6$   $��36(�61   $��Le Club de Tennis DeVinci��6?   $��2��6`   �� 5   
   -   5        $��lvUsers��5   P   $��3��6   $��6��6#   $��9.667,10,218.333,9.667q�60   ��6_   �� *items1+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5       �� 5!      .P�5"      �� $	��Nom��6%    �� Width$ 60��62    �� DisplayMemberBinding 6=   �� *Nom+$ TwoWay=��� 5#      $��Prenom��6%   $ 60��65    6@   �� *Nom+$ TwoWay=��� 5$      $	��Age��6%   $ 60��62    6=   �� *Age+$ TwoWay=��� 5%      $
��Mail��6%   $ 60��63    �� CellTemplate 5&      �� 5'      .R�5(   "   �� $��	Underline{�6O   
����  �	 � Cursor$
	 Hand��6}   ��6,   �� *Mail+$ TwoWay=�6}   5)      5+      �� 5,      $��Adresse��6%   $ 50��66    6A   �� *Age+$ TwoWay=�5-      50      �� 52   
   -   5        
 ��Name$
 OuvrirMembre��52      $��Menu Principal��6'   $��7��6@   $��10,267,193.333,9.667q�6M   $��2��6~   $��1��6�   �� 54   
   -   5        $��
Sélection��54      $
��Left=�6%   $��10.333,3,0,0q�6@   $	��Top=�6V   $��75��6n   $��2��6�   $��25��6�   $��7��6�    J� RenderTransformOrigin$ 0.542,0.439&�6�   �� 55   
   -   5        $	��Fin��55      $
��Left=�6   $��10.333,204,0,0q�6:   $	��Top=�6R   $��75��6j   $��2��6�   $��25��6�   $��7��6�   �� 56   
   -   5        $��Ajoute��56      $
��Left=�6"   $��10.333,33,0,0q�6=   $	��Top=�6T   $��75��6l   $��2��6�   $��37��6�   $��7��6�   59      5:      