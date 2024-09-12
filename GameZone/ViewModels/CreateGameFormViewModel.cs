

namespace GameZone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
   

        //Must make a validate 
        [AllowedExtensions(FileSettings.AllowedExtensions),
            MaxSizeFile(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}
