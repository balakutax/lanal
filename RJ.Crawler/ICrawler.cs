using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RJ.Crawler
{
    public interface ICrawler
    {
        Task<string> GetContentByUriAsync(Uri uri);

        string GetContentByUri(Uri uri);
    }
}
