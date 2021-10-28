using AutoMapper;
using AutoMapperDemo.Models;
using AutoMapperDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperDemo.Customizations
{
    public class BmiValueResolver : IValueResolver<User, UserViewModel, double>
    {
        public double Resolve(User source, UserViewModel destination, double destMember, ResolutionContext context)
        {
            return Math.Round(source.Weight / Math.Pow(source.Height, 2));
        }
    }
}
