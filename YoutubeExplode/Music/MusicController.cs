using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace YoutubeExplode.Music
{
    internal class MusicController
    {
        protected HttpClient Http { get; }

        public MusicController(HttpClient http) => Http = http;
    }
}
