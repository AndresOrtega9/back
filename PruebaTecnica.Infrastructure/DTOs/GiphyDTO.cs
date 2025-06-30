using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Infrastructure.DTOs
{
    public class GiphyDTO
    {
        public class GiphyRespuesta
        {
            public List<GifDatos> data { get; set; } = new();
        }

        public class GifDatos
        {
            public GifImagen images { get; set; } = new();
        }

        public class GifImagen
        {
            public GifOriginal original { get; set; } = new();
        }

        public class GifOriginal
        {
            public string url { get; set; } = string.Empty;
        }
    }
}
