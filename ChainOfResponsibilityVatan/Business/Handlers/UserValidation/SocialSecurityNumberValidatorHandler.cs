using Chain_of_Responsibility_First_Look.Business.Exceptions;
using Chain_of_Responsibility_First_Look.Business.Models;
using Chain_of_Responsibility_First_Look.Business.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility_First_Look.Business.Handlers.UserValidation
{
    public class SocialSecurityNumberValidatonHandler: Handler<User>
    {
        private SocialSecurityNumberValidator socialSecurityNumberValidator = new SocialSecurityNumberValidator();

        public override void Handle(User user)
        {
            if (!socialSecurityNumberValidator.Validate(user.SocialSecurityNumber, user.CitizenshipRegion))
            {
                throw new UserValidationException("SocialSecurityNumber");
            }
            base.Handle(user);
        }
    }
}
