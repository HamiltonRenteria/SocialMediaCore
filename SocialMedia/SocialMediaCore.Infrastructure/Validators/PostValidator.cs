using FluentValidation;
using SocialMediaCore.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaCore.Infrastructure.Validators
{
    public class PostValidator : AbstractValidator<PostDTO>
    {
        public PostValidator()
        {
            /*
             * NotNull: No venga vacio el campo.
             * Length: La longitud entre dos valores, no puede ser mayor a la longitud de Base de Datos.
             * LessThan: La fecha sea menos que la fecha actual.
             */

            RuleFor(post => post.Description).NotNull().Length(10, 1000);
            RuleFor(post => post.Date).NotNull().LessThan(DateTime.Now);
        }
    }
}
