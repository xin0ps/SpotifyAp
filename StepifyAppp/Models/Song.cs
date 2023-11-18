using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepifyAppp.Models
{

    public class Track
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string DurationTime { get; set; }
        public string ImageUrl { get; set; }
        public string PreviewUrl { get; set; }

        public Track(string name, string artist, string album, string imageUrl, string previewUrl, string duration)
        {
            DurationTime = duration;
            Name = name;
            Artist = artist;
            Album = album;
            ImageUrl = imageUrl;
            PreviewUrl = previewUrl;
        }

    }

}
