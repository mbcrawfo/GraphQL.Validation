﻿using FluentValidation;

public class ComplexInputValidator :
    AbstractValidator<ComplexInput>
{
    public ComplexInputValidator()
    {
        RuleFor(_ => _.Inner!)
            .NotEmpty()
            .SetValidator(new ComplexInputInnerValidator());

        RuleFor(_ => _.Items)
            .NotEmpty()
            .ForEach(i => i.SetValidator(new ComplexInputListItemValidator()));
    }
}