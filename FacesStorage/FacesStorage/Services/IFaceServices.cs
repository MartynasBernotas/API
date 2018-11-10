using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacesStorage.Models;

namespace FacesStorage.Services
{
    public interface IFaceServices
    {
        PersonFaces Add(PersonFaces faces);

        string Login(PersonFaces faces);

        Dictionary<string,PersonFaces>Get();
    }
}
