
using System.ComponentModel.DataAnnotations;

namespace SlackSharp.WebApi.Errors
{
    public enum SlackWarning
    {
        ///<summary>The method was called via a POST request, and recommended practice for the specified Content-Type is to include a charset parameter. However, no charset was present. Specifically, non-form-data content types (e.g. text/plain) are the ones for which charset is recommended.</summary>
        [Display(Name = "missing_charset")]
        MissingCharset,

        ///<summary>The method was called via a POST request, and the specified Content-Type is not defined to understand the charset parameter. However, charset was in fact present. Specifically, form-data content types (e.g. multipart/form-data) are the ones for which charset is superfluous.</summary>
        [Display(Name = "superfluous_charset")]
        SuperfluousCharset,
    }
}