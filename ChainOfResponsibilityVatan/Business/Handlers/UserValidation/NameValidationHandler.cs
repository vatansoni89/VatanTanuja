using Chain_of_Responsibility_First_Look.Business.Exceptions;
using Chain_of_Responsibility_First_Look.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility_First_Look.Business.Handlers.UserValidation
{
    class NameValidationHandler: Handler<User>
    {
        public override void Handle(User user)
        {
            if (user.Name.Length < 4)
            {
                throw new UserValidationException("Name");
            }
            base.Handle(user);
        }
    }
}
