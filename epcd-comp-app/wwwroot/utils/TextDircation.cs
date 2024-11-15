namespace epcd_comp_app.wwwroot.utils;

public class TextDircation
{
    public string diraction;

    public TextDircation()
    {
        if (Thread.CurrentThread.CurrentCulture.Name == "en")
        {
            diraction = "ltr";
        }
        else
        { 
            diraction = "rtl";
        }
    }
    
    
}