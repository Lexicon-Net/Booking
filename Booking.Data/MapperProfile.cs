﻿using AutoMapper;
using Booking.Core.Entities;
using Booking.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<GymClass, GymClassesViewModel>();

            CreateMap<GymClass, GymClassesViewModel>()
                .ForMember(dest => dest.Attending, from => from.MapFrom(
                   (src, dest, _, context) => src.AttendingMembers.Any(a => a.ApplicationUserId == context.Items["UserId"].ToString())));
        }
    }
}
