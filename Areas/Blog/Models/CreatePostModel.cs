using System.ComponentModel.DataAnnotations;
using App.Models.Blog;

namespace App.Areas.Blog.Models
{
       public class CreatePostModel:Post{
           [Display(Name="Chuyên mục Blog")]
           public int[]? CategoryIDs {get;set;}
       }
}