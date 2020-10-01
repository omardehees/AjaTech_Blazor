using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Blazored.SessionStorage;
using AKSoftware.Localization.MultiLanguages;
using Microsoft.JSInterop;
using System.Diagnostics;

namespace AjaTech_Blazor.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly ILanguageContainerService _LanguageContainer;
        private readonly ISessionStorageService _sessionStorage; 
        private readonly IJSRuntime _IJSRuntime;

        public LoginModel(SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger,
            UserManager<IdentityUser> userManager,
            ISessionStorageService sessionStorage,
            ILanguageContainerService LanguageContainer,
            IJSRuntime IJSRuntime

            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _LanguageContainer = LanguageContainer;
            _sessionStorage = sessionStorage;
            _IJSRuntime = IJSRuntime;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
            [Required]
            public string Language { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {

            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            ///////////////////////////////////////////////////////
            //Input.Language = "Ar";
            //Debug.WriteLine(">> " + Input.Language.ToString());

            //if (Input.Language == "En")
            //{
            //    _LanguageContainer.SetLanguage(System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            //}
            //if (Input.Language == "Ar")
            //{
            //    _LanguageContainer.SetLanguage(System.Globalization.CultureInfo.GetCultureInfo("ar-EG"));
            //}
            //Debug.WriteLine(">> " + Input.Language.ToString());

            ///////////////////////////////////////////////////////

            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/?Language=") + Input.Language;  //Url.Content("~/");//  "/SetLanguage?language=" + Input.Language;   //

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.UserName, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {

                    if (Input.Language == "En")
                    {
                        _LanguageContainer.SetLanguage(System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                    }
                    if (Input.Language == "Ar")
                    {
                        _LanguageContainer.SetLanguage(System.Globalization.CultureInfo.GetCultureInfo("ar-EG"));
                    }
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
