﻿using AutoMapper;
using NewsCollector.Core.Models;
using NewsCollector.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsCollector.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Source, SourceDTO>();
            CreateMap<News, NewsDTO>();
            CreateMap<Keyword, KeywordDTO>();


            // Resource to Domain
            CreateMap<SourceDTO, Source>();
            CreateMap<NewsDTO, News>();
            CreateMap<KeywordDTO, Keyword>();
        }
    }
}
