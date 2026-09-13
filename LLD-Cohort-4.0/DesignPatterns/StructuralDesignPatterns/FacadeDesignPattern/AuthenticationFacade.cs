using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Authentication;

namespace LLD_Cohort_4._0.DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    internal class AuthenticationFacade
    {
        PasswordValidator _passwordValidator;
        OtpService _otpService;
        TokenService _tokenService;
        AuditLogger _auditLogger;
        public AuthenticationFacade()
        {
            _passwordValidator = new PasswordValidator();
            _otpService = new OtpService();
            _tokenService = new TokenService();
            _auditLogger = new AuditLogger();
        }
        public String Login(String username, String password, String otp)
        {
            if (!_passwordValidator.Validate(username, password))
            {
                throw new AuthenticationException("Invalid credentials provided!");
            }
            if (!_otpService.VerifyOtp(username, otp))
            {
                throw new AuthenticationException("Invalid OTP!");
            }
            String token = _tokenService.GenerateToken(username);
            _auditLogger.LogLogin(username);
            return token;

        }
    }
}
