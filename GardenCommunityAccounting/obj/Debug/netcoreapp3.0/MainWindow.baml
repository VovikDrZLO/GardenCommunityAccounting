   M S B A M L   `   `   `  ����T  PGardenCommunityAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GardenCommunityAccountingGardenCommunityAccounting  5   	   *    $GardenCommunityAccounting.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GardenCommunityAccounting     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��373��6+   $��	28,28,0,0q�68   $	��Top=�6K   $	��495��6c   $��/Resources/Map.jpg��6o   �� 5   
   -   5         ��Name$ 
LookupsBtn��5      $��Довідники��6%   $
��Left=�69   $��
574,28,0,0q�6T   $	��Top=�6h   $��30��6�   $	��169��6�   �� 5   
   -   5        $ IncomingDocumentsBtn��5      $��Надходження��60   $
��Left=�6F   $��
574,76,0,0q�6a   $	��Top=�6u   $��30��6�   $	��169��6�    � ContextMenu 5      �� 5      -   5         ��Name$ 
IncomDocCM��5       �� HasDropShadow$
 True��6c   ��62   ��  �� Path$ IncomeDocumentTypes���5      �� 5       �� 
TargetType" m�6    .�5      ��  �� Property �@m�Command �� Value 68   �� 	 �� RelativeSource	 �� 
 �� AncestorType"
 ��$- 'PlacemantTarget.DataContext.ItemChanged��� 5       �@m�CommandParameter 6A   ��  �� ElementName$ IncomeDocumentTypes��$ Id�5      5      5      �� 5   
   -   5        $ AutgoingDocumentsBtn��5      $��Витрати��6/   $
��Left=�6A   $��574,124,0,0q�6\   $	��Top=�6q   $��30��6�   $	��169��6�   �� 5   
   -   5        $ 
ReportsBtn��5      $��
Звіти��6%   $
��Left=�65   $��574,173,0,0q�6P   $	��Top=�6e   $��30��6}   $	��169��6�   �� 5   
   -   5        $ AdminBtn��5      $��Адмінка��6#   $
��Left=�65   $��574,217,0,0q�6P   $	��Top=�6e   $��30��6}   $	��169��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        2   ,GardenCommunityAccounting.DatePickerCalendar   IsMonthYear$
 True��5      4   .GardenCommunityAccounting.DatePickerDateFormat   
DateFormat$ 	MMMM-yyyy��5      $
��Left=�5      $��574,267,0,0q�6(   $	��Top=�6=   $��30��6U   $	��169��6a      Text$ 	MMMM-yyyy��5      5       5"      5#      