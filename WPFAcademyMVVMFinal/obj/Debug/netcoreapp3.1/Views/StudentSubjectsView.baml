   M S B A M L   `   `   `  ����N  JWPFAcademyMVVMFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPFAcademyMVVMFinal.ViewsWPFAcademyMVVMFinal.Views  5      O,clr-namespace:WPFAcademyMVVMFinal.ViewModelsWPFAcademyMVVMFinal.ViewModels  5      3    -WPFAcademyMVVMFinal.Views.StudentSubjectsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:WPFAcademyMVVMFinal.Views     5      C
ViewModels,clr-namespace:WPFAcademyMVVMFinal.ViewModels     5      .��5      � ���	#FFE5E5E5  � DataContext  5   
   =   7WPFAcademyMVVMFinal.ViewModels.StudentSubjectsViewModel  5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��MENÚ GESTIÓN��6   $��0��6'   $��0��64   $��Center=�6F   $��0,0,0,0q�6c   $	��Top=�6t   $
��Bold"�6�   �� 5   
   $��
DNI Alumno��6   $��1��6%   $��0��62   $
��Left=�6B   $��15,0,0,0q�6]   $	��Top=�6o   �� 5    
   $��1��6-   $��0��6:   $
��Left=�6J   $��	140,0,0,0q�6e   $	��Top=�6y   $	��190��6�   $��25��6�   ��6   �� *	DniMGVM+6�   �� 5!   
   $��Buscar Alumno��6<   $��1��6T   $
��Left=�6a   $��	346,0,0,0q�6|   $��Center=�6�   $��25��6�   $
��Bold"�6�   $��2��6�   ��6   �� *FindStudentCommand+6�   �� 5"   
   $��Nombre Alumno��6   $��3��6(   $
��Left=�65   $��15,7,0,0q�6P   $	��Top=�6b    J� RenderTransformOrigin$ -1.013,0.561&�6z   $��2��6�   �� 5#   
   $��3��6,   $
��Left=�69   $��	140,5,0,0q�6T   $	��Top=�6g   $	��190��6   $��25��6�   $��3��6�   $ 	0.5,1.162&�6�   ${�False��6�   ��6   �� *
NameMGVM+6�   �� 5$   
   $��Añadir Asignaturas��6   $��5��6-   $��1��6:   $
��Left=�6J   $��20,0,0,0q�6e   $	��Top=�6w   $��Normal"�6�   �� 5%   
   $��Asignaturas��6   $��5��6&   $��0��63   $
��Left=�6C   $��18,5,0,0q�6^   $	��Top=�6p   � 5'   
   ���	#FFE5E5E5$��6��6&   $��0��63   $��0,0,30,5q�6C   $��3��6U   .+�5(      &   System.Windows.Controls.DataGrid  -   5          Name$ SubjectsMGVMDataGrid��5(      $��20,20,-15,45q�6�   ��65   �� *SubjectListMGVM+ �� SelectedItem 6]   �� *CurrentSubjectMVM+6�   �� 5)      $��Ver Asignaturas��6   $��0��60   $
��Left=�6m   $��	20,0,0,10q�6�   $��Bottom=�6�   $��10(�6�   $ 0.895,0.422&�6�   ��6@   �� *GetSubjectsMGVMCommand+6�   �� 5*      $��AñadirAsignatura��6   $��0��60   $
��Left=�6n   $��
230,0,0,10q�6�   $��Bottom=�6�   $��10(�6�   $	��120��6�   $ 0.542,-0.561&�6�   ��6@   �� *AddSubjectToListVMCommand+6�   5+      � 5-   
   ���	#FFE5E5E5$��5��6&   $��1��63   $��	0,28,85,5q�6D   $��3��6W    5.      �� 5/      $	��40* �6#   �� 50      $	��23* �6#   .+�52        -   5        $# SubjectsToStudentMGVMDataGrid��52      $��20,26,-65,45q�6�      AutoGenerateColumns$ False��6�   $��2��6�   ��6>   �� *SubjectsByStudentList+ 6l   �� *CurrentStudentSubjectMVM+   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Asignaturas��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *Subject.Name+6b   56      �� 57      $��Borrar Asignatura��6   $
��Left=�6_   $��
135,0,0,10q�6z   $��Bottom=�6�   $ 0.379,-0.251&�6�   $��10(�6�   $	��130��6�   $��2��6�   ��61   �� *DelSubjectToListVMCommand+6�   58      �� 5;   
   $��Error��6   $��1��6    $
��Left=�60   $��84,1,0,0q�6K   $��1��6]   $	��Top=�6j   $��2��6�     5<   
   $��1��6   $��125,10,10,16q�6F   $��5��6\   ��6#   �� *
ErrorsList+6\   5>      5?      