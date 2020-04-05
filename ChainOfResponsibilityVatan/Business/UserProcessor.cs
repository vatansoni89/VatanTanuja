using Chain_of_Responsibility_First_Look.Business.Handlers.UserValidation;
using Chain_of_Responsibility_First_Look.Business.Models;
using Chain_of_Responsibility_First_Look.Business.Validators;

namespace Chain_of_Responsibility_First_Look.Business
{
    public class UserProcessor
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidator
            = new SocialSecurityNumberValidator();

        public bool Register(User user)
        {
            //Applied chain of respo.
            try
            {
                var handler = new SocialSecurityNumberValidatorHandler();
                handler.SetNext(new NameValidationHandler())
                    .SetNext(new AgeValidationHandler())
                    .SetNext(new CitizanshipRegionValidationHandler());

                handler.Handle(user);
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}
