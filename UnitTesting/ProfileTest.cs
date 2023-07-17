using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting
{
    [TestClass]
    public class ProfileTest
    {
        [TestMethod]
        public void AddProfile()
        {
            // Arrange
            BLL.BLLProfile profile = new BLL.BLLProfile();
            BE.PROFILE profile2 = new BE.PROFILE();
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.COMPOSITEPRIVILEGE composite = new BE.COMPOSITEPRIVILEGE("TEST");
            bLLPrivilege.Add(composite);
            profile2.profileName = "Test Profile";
            profile2.cp = composite;
            int existing = profile.List().Count;
            // Act
            profile.Add(profile2);
            int existing2 = profile.List().Count;
            // Assert
            Assert.AreEqual(existing + 1, existing2);
            bLLPrivilege.Remove(composite);
            profile2 = BLL.BLLProfile.GetProfile(profile2.profileName);
            profile.Remove(profile2);
        }

        [TestMethod]
        public void RemoveProfile()
        {
            // Arrange
            BLL.BLLProfile profile = new BLL.BLLProfile();
            BE.PROFILE profile2 = new BE.PROFILE();
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.COMPOSITEPRIVILEGE composite = new BE.COMPOSITEPRIVILEGE("TEST");
            bLLPrivilege.Add(composite);
            profile2.profileName = "Test Profile";
            profile2.cp = composite;
            
            // Act
            profile.Add(profile2);
            int existing = profile.List().Count;
            bLLPrivilege.Remove(composite);
            profile2 = BLL.BLLProfile.GetProfile(profile2.profileName);
            profile.Remove(profile2);
            int existing2 = profile.List().Count;

            // Assert
            Assert.AreEqual(existing - 1, existing2);
        }

        [TestMethod]
        public void AssignProfile()
        {
            // Arrange
            BLL.BLLProfile profile = new BLL.BLLProfile();
            BE.PROFILE profile2 = new BE.PROFILE();
            BLL.BLLPrivilege bLLPrivilege = new BLL.BLLPrivilege();
            BE.COMPOSITEPRIVILEGE composite = new BE.COMPOSITEPRIVILEGE("TEST");
            DAL.MP_USER mP_USER = new DAL.MP_USER();
            BE.USER user2 = mP_USER.GetUserByEmail("mpocztaruk@gmail.com");
            bLLPrivilege.Add(composite);
            profile2.profileName = "Test Profile";
            profile2.cp = composite;
            // Act
            profile.Add(profile2);
            profile2 = BLL.BLLProfile.GetProfile(profile2.profileName);
            profile.EditProfile(profile2, user2);

            // Assert
            bLLPrivilege.Remove(composite);
            profile2 = BLL.BLLProfile.GetProfile(profile2.profileName);
            profile.Remove(profile2);
        }
    }
}
