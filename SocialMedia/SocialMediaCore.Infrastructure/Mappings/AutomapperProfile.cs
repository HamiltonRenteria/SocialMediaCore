using AutoMapper;
using SocialMediaCore.Core.DTOs;
using SocialMediaCore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaCore.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDTO>();
            CreateMap<PostDTO, Post>();
        }
    }
}
