using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BLL
{
   public class BLLProfile
    {
        DAL.MP_PROFILE dalp;

        public BLLProfile()
        {
            dalp = new DAL.MP_PROFILE(); 
        }
        public List<BE.PROFILE> List()
        {
            List<BE.PROFILE> profiles = dalp.List();
            return profiles;
        }
        public void Add(BE.PROFILE profile)
        {
            dalp.Insert(profile);
        }
        public void Remove(BE.PROFILE profile)
        {
            dalp.Delete(profile);
        }

        public void EditProfile (BE.PROFILE profile, BE.USER user)
        {
            dalp.AssignProfile(profile, user);
        }

        public static BE.PROFILE GetProfile(string name)
        {
            DAL.MP_PROFILE dalp = new DAL.MP_PROFILE();
            return dalp.GetByName(name);
        }
    }
}
