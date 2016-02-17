using System.ComponentModel.DataAnnotations;

namespace SlackSharp.WebApi.Errors
{
    public enum SlackError
    {
        ///<summary>Team is being migrated between servers.</summary>
        [Display(Name = "migration_in_progress")]
        MigrationInProgress,

        ///<summary>No authentication token provided.</summary>
        [Display(Name = "not_authed")]
        NotAuthed,

        ///<summary>Invalid authentication token.</summary>
        [Display(Name = "invalid_auth")]
        InvalidAuth,

        ///<summary>Authentication token is for a deleted user or team.</summary>
        [Display(Name = "account_inactive")]
        AccountInactive,
    
        ///<summary>The method was passed a PHP-style array argument (e.g. with a name like foo[7]). These are never valid with the Slack API.</summary>
        [Display(Name = "invalid_array_arg")]
        InvalidArrayArg,
    
        ///<summary>The method was called via a POST request, but the charset specified in the Content-Type header was invalid. Valid charset names are: utf-8 iso-8859-1.</summary>
        [Display(Name = "invalid_charset")]
        InvalidCharset,
    
        ///<summary>The method was called via a POST request with Content-Type application/x-www-form-urlencoded or multipart/form-data, but the form data was either missing or syntactically invalid.</summary>
        [Display(Name = "invalid_form_data")]
        InvalidFormData,
    
        ///<summary>The method was called via a POST request, but the specified Content-Type was invalid. Valid types are: application/json application/x-www-form-urlencoded multipart/form-data text/plain.</summary>
        [Display(Name = "invalid_post_type")]
        InvalidPostType,
        
        ///<summary>The method was called via a POST request and included a data payload, but the request did not include a Content-Type header.</summary>
        [Display(Name = "missing_post_type")]
        MissingPostType,
            
        ///<summary>The method was called via a POST request, but the POST data was either missing or truncated.</summary>
        [Display(Name = "request_timeout")]
        RequestTimeOut
    }
}