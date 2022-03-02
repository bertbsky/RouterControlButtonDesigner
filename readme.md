This project allows designing a custom IO button style for the RouterControl in DataMiner Cube.
* Extract Cube.zip in the /lib/ folder.
* Place all custom styles and templates in CustomTheme.xaml. This is the exact same content as in the "Edit custom theme" dialog.
* Edit the `<Button>` tags in MainWindow.xaml if you add custom attributes or change the default `Style` attribute.
* Edit the column data in ViewModel/Main.cs to match with the expected row data from the source table.