<%@ Control Language="C#" EnableViewState="false" AutoEventWireup="false" Inherits="CKFinder.Settings.ConfigFile" %>
<%@ Import Namespace="CKFinder.Settings" %>
<script runat="server">
    public override bool CheckAuthentication()
    {
        if (Page.User.Identity.IsAuthenticated) //Eðer kullanýcý giriþi yapýlmýþ ise
            return true;
        else
            return false;
    }
    public override void SetConfig()
    {
        LicenseName = "localhost";
        LicenseKey = "5VBE9GN17YX398KRHPBAG6LHU8HYKYMJ";
        BaseUrl = "/Uploads/";
        BaseDir = HttpContext.Current.Server.MapPath("~/Uploads/");
        //BaseUrl = "/ckfinder/userfiles/";
        //BaseDir = HttpContext.Current.Server.MapPath("~/ckfinder/userfiles/");
        Plugins = new string[] {
    };
        PluginSettings = new Hashtable();
        PluginSettings.Add("ImageResize_smallThumb", "90x90" );
        PluginSettings.Add("ImageResize_mediumThumb", "120x120" );
        PluginSettings.Add("ImageResize_largeThumb", "180x180" );
        PluginSettings.Add("Watermark_source", "logo.gif" );
        PluginSettings.Add("Watermark_marginRight", "5" );
        PluginSettings.Add("Watermark_marginBottom", "5" );
        PluginSettings.Add("Watermark_quality", "90" );
        PluginSettings.Add("Watermark_transparency", "80" );
        Thumbnails.Url = BaseUrl + "_thumbs/";
        if ( BaseDir != "" ) {
            Thumbnails.Dir = BaseDir + "_thumbs/";
        }
        Thumbnails.Enabled = true;
        Thumbnails.DirectAccess = false;
        Thumbnails.MaxWidth = 100;
        Thumbnails.MaxHeight = 100;
        Thumbnails.Quality = 80;
        Images.MaxWidth = 1600;
        Images.MaxHeight = 1200;
        Images.Quality = 80;
        CheckSizeAfterScaling = true;
        //DisallowUnsafeCharacters = true;
        //CheckDoubleExtension = true;
        ForceSingleExtension = true;
        HtmlExtensions = new string[] { "html", "htm", "xml", "js" };
        HideFolders = new string[] { ".*", "CVS" };
        HideFiles = new string[] { ".*" };
        SecureImageUploads = true;
        RoleSessionVar = "CKFinder_UserRole";
        AccessControl acl = AccessControl.Add();
        acl.Role = "*";
        acl.ResourceType = "*";
        acl.Folder = "/";
        acl.FolderView = true;
        acl.FolderCreate = true;
        acl.FolderRename = true;
        acl.FolderDelete = true;
        acl.FileView = true;
        acl.FileUpload = true;
        acl.FileRename = true;
        acl.FileDelete = true;
        DefaultResourceTypes = "";
        ResourceType type;
        type = ResourceType.Add( "Files" );
        type.Url = BaseUrl + "files/";
        type.Dir = BaseDir == "" ? "" : BaseDir + "files/";
        type.MaxSize = 0;
        type.AllowedExtensions = new string[] { "7z", "aiff", "asf", "avi", "bmp", "csv", "doc", "docx", "fla", "flv", "gif", "gz", "gzip", "jpeg", "jpg", "mid", "mov", "mp3", "mp4", "mpc", "mpeg", "mpg", "ods", "odt", "pdf", "png", "ppt", "pptx", "pxd", "qt", "ram", "rar", "rm", "rmi", "rmvb", "rtf", "sdc", "sitd", "swf", "sxc", "sxw", "tar", "tgz", "tif", "tiff", "txt", "vsd", "wav", "wma", "wmv", "xls", "xlsx", "zip" };
        type.DeniedExtensions = new string[] { };
        type = ResourceType.Add( "Images" );
        type.Url = BaseUrl + "images/";
        type.Dir = BaseDir == "" ? "" : BaseDir + "images/";
        type.MaxSize = 0;
        type.AllowedExtensions = new string[] { "bmp", "gif", "jpeg", "jpg", "png" };
        type.DeniedExtensions = new string[] { };
        type = ResourceType.Add( "Flash" );
        type.Url = BaseUrl + "flash/";
        type.Dir = BaseDir == "" ? "" : BaseDir + "flash/";
        type.MaxSize = 0;
        type.AllowedExtensions = new string[] { "swf", "flv" };
        type.DeniedExtensions = new string[] { };
    }
</script>
