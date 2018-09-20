using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FrontEndTests.Utilities
{
    public class MockValidation
    {
        /// <summary>
        /// Method that allows us to check and affect the validity of the model
        /// state of a given razor page
        /// </summary>
        /// <param name="pageModel">PageModel you want to check</param>
        public static void CheckValidation(PageModel pageModel)
        {
            var validationContext = new ValidationContext(pageModel, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(pageModel, validationContext, validationResults, true);
            foreach (var validationResult in validationResults)
            {
                pageModel.ModelState.AddModelError(validationResult.MemberNames.ToString(),
                    validationResult.ErrorMessage);
            }
        }
    }
}
