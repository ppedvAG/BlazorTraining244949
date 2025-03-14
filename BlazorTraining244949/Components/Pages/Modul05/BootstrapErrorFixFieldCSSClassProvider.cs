using Microsoft.AspNetCore.Components.Forms;

namespace BlazorTraining244949.Components.Pages.Modul05
{
    public class BootstrapErrorFixFieldCSSClassProvider : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
          var isInvalid=  editContext.GetValidationMessages(fieldIdentifier).Any();
                return isInvalid ? "is-invalid" : "is-valid";
        }
    }
}
