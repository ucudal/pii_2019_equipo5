using System;

namespace RazorPagesIgnis.Areas.Identity.Data
{
    public static class IdentityData
    {
        public const string AdminUserName = "admin@correo.com";

        public const string AdminName = "Admin";

        public const string AdminMail = "admin@correo.com";

        public static DateTime AdminDOB = new DateTime(1978, 9, 25);

        public const string AdminPassword = "Abece.123";

        public const string AdminRoleName = "Administrator";

        public static string[] NonAdminRoleNames = new string[] { "Cliente", "Técnico" };
    }
}
