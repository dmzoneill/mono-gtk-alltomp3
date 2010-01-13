using System;
using System.IO;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	static int count;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		// create a DirectoryInfo object
        DirectoryInfo di = new DirectoryInfo("/media/mp3s");
    
        // And pass it to the recursive printing routine
        MainWindow.getDirsFiles(di);
		Console.WriteLine(MainWindow.count);
	}
	
    public static void getDirsFiles(DirectoryInfo d)
        {

            FileInfo [] files;
            files = d.GetFiles("*.*");

            foreach (FileInfo file in files)
            {

                String fileName = file.FullName;
                String fileSize = file.Length.ToString();
                String fileExtension =file.Extension;
                String fileCreated = file.LastWriteTime.ToString();
			
			    if(fileExtension!=".mp3")
				{
				    if(fileExtension!=".MP3")
				    {
					    if(fileExtension!=".Mp3")
				        {
                	    //Console.WriteLine(fileName + " " + fileSize +  " " + fileExtension + " " + fileCreated);
					    Console.WriteLine( fileExtension );
						file.Delete();
					MainWindow.count++;
					}
				    }
			    }
            }
            
            DirectoryInfo [] dirs = d.GetDirectories("*.*");
            
            foreach (DirectoryInfo dir in dirs)
            {
                //Console.WriteLine("--------->> {0} ", dir.Name);
                getDirsFiles(dir);
            }
            
        }
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}