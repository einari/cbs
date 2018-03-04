﻿using System.Collections.Generic;
using Machine.Specifications;
using FluentValidation.Results;
using Domain.StaffUser;
using Moq;
using It = Machine.Specifications.It;

namespace Domain.Specs.StaffUser.SupportPhoneNumbers
{
    [Subject(typeof(ISupportPhoneNumbers))]
    public class when_validating_and_birth_year_is_not_provided
    {
        static SupportBirthYearInputValidator validator;
        static ValidationResult validation_results;
        static Mock<ISupportBirthYear> support_birth_year;

        Establish context = () =>
        {
            validator = new SupportBirthYearInputValidator();
            support_birth_year = new Mock<ISupportBirthYear>();
            support_birth_year.SetupGet(m => m.BirthYear).Returns((int?)null);
        };

        Because of = () => { validation_results = validator.Validate(support_birth_year.Object); };

        It should_be_valid = () => validation_results.ShouldBeValid();    
    }      
}