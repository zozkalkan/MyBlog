using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JusttBlogg.Models
{
    public class Post
    {
        public int postId { get; set; }

        public string postTitle { get; set; }

        public string postContent { get; set; }

        public DateTime postDate { get; set; }

        public string createdBY { get; set; }

        public string Preview { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<PhotoPath> PhotoPaths { get; set; }
    }
        public class Photo
        {
            public int PhotoId { get; set; }
            [StringLength(255)]
             public String PhotoName { get; set; }
            [StringLength(100)]
             public string ContentType { get; set; }
             public byte[] Content { get; set; }
             public PhotoType PhotoType { get; set; }
             public int postId { get; set; }
             public virtual Post post { get; set; }


             public object FileType { get; set; }
        }
        public class PhotoPath
        {
            
            public int PhotoPathId { get; set; }
            
            [StringLength(100)]
            public string PhotoName { get; set; }
            
            public PhotoType PhotoType { get; set; }
            public int postId { get; set; }
            public virtual Post post { get; set; }
        }
        public enum PhotoType
        {
            Image = 1,Photo
        }








    
}