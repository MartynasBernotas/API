using FacesStorage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacesStorage.Services
{
    public class FaceServices : IFaceServices
    {
        private readonly Dictionary<string, PersonFaces> _faces;

        public FaceServices()
        {
            _faces = new Dictionary<string, PersonFaces>();
        }

        public PersonFaces Add(PersonFaces faces)
        {   foreach(var Name in _faces)
            {
                if (faces.Name.Equals(Name))
                {
                    return null;
                }
            }
            _faces.Add(faces.Name, faces);
            return faces;
        }

        public Dictionary<string, PersonFaces> Get()
        {
            return _faces;
        }

        public string Login(PersonFaces faces)
        {
            string answer = "user not found";
            foreach (var PersonFaces in _faces)
            {
                if (faces.Name.Equals(PersonFaces.Value.Name))
                {
                    answer = "Incorrect password";
                    if (faces.Password.Equals(PersonFaces.Value.Password))
                    {
                        answer = "Login succesful";
                    }

                }

            }
            return answer;
        }
    }
}
