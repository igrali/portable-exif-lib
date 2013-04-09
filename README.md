portable-exif-lib
=================

Portable EXIF library for Windows 8, Windows Phone and Silverlight.

Based completely on [ExifLib - A Fast Exif Data Extractor for .NET 2.0+](http://www.codeproject.com/Articles/36342/ExifLib-A-Fast-Exif-Data-Extractor-for-NET-2-0) created by [Simon McKenzie](http://www.codeproject.com/Members/SimonMcKenzie) and released on Code Project under [Code Project Open License](http://www.codeproject.com/info/cpol10.aspx).

Modified to take a stream in constructor and created as a portable library so it can easily be used in Windows Phone, Windows 8 and Silverlight projects.

##### Windows 8

```csharp

var picker = new FileOpenPicker();
picker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
picker.ViewMode = PickerViewMode.Thumbnail;
picker.FileTypeFilter.Add(".jpg");
picker.FileTypeFilter.Add(".jpeg");

var file = await picker.PickSingleFileAsync();
var stream = await file.OpenAsync(FileAccessMode.Read);
var jpegInfo = ExifReader.ReadJpeg(stream.AsStream());

```

##### Windows Phone 8

```csharp

private void Button_Click(object sender, RoutedEventArgs e)
{
  var task = new PhotoChooserTask();
  task.Completed += task_Completed;
  task.Show();
}

void task_Completed(object sender, PhotoResult e)
{
  var jpeginfo = ExifReader.ReadJpeg(e.ChosenPhoto);
  this.DataContext = jpeginfo;
}

```




