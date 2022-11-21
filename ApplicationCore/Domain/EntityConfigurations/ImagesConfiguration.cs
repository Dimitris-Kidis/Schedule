using ApplicationCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain.EntityConfigurations
{

    public class ImagesConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {

            var images = new List<Image>() {
                    new Image()
                    {
                        Id = 1,
                        UserId = 1,
                        ImageTitle = "https://typostorage.blob.core.windows.net/avatars/avatar0.png",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 2,
                        UserId = 2,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=JtJaspHm&id=25BA92485437ADD293D9BBF75B532069F59D5076&thid=OIP.JtJaspHmOW0-1H3eitKsjAAAAA&mediaurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.26d25ab291e6396d3ed47dde8ad2ac8c%3Frik%3DdlCd9WkgU1v3uw%26riu%3Dhttp%253a%252f%252finaga-api.or.id%252fasset%252fbackend%252fupload%252ftheboard%252fBoD_no_photo_f2.jpg%26ehk%3DAJFE9VB1TP75iGSvo8dy3R7n%252f5U0gR0eb9p0xdoLR2M%253d%26risl%3D%26pid%3DImgRaw%26r%3D0&exph=520&expw=474&q=avatars+for+sites+woman&simid=608054944566876018&form=IRPRST&ck=0AEC1786E5825A9BBB8A870A4320126E&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_FbkxL9bA*cp_AD984D00405C718B3A6D04AD566BE045*mid_1999E3C273B3A08BFCB743F2AC51C281B030F9C9*simid_608014030705879451*thid_OIP.FbkxL9bAzFsI4gYWt1AU5AAAAA&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 3,
                        UserId = 3,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=0m3pRsk%2B&id=FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714&thid=OIP.0m3pRsk-byuSMJLki7OR4AHaIP&mediaurl=https%3A%2F%2Fwww.justwomanthings.com%2Fwp-content%2Fuploads%2F2017%2F10%2Ffavicon.png&exph=664&expw=597&q=avatars+for+sites+woman&simid=608018377213875942&form=IRPRST&ck=EAD721E1E55EB3116BF38FD907D672D5&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_JtJaspHm*cp_0AEC1786E5825A9BBB8A870A4320126E*mid_25BA92485437ADD293D9BBF75B532069F59D5076*simid_608054944566876018*thid_OIP.JtJaspHmOW0-1H3eitKsjAAAAA&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.d26de946c93e6f2b923092e48bb391e0%3Frik%3DFBcetPTVnM9B3g%26pid%3DImgRaw%26r%3D0&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 4,
                        UserId = 4,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=tvgdD7R%2B&id=DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4&thid=OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Fpeppyicons%2F512%2Fwomen_red-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8C0B660E5459F765CCA7B23AACD5864B&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_0m3pRsk%252B*cp_EAD721E1E55EB3116BF38FD907D672D5*mid_FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714*simid_608018377213875942*thid_OIP.0m3pRsk-byuSMJLki7OR4AHaIP&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.b6f81d0fb47e74317d8dcc5471db7e98%3Frik%3D1BB9znSCiPjbgA%26pid%3DImgRaw%26r%3D0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 5,
                        UserId = 5,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=k5drJ44P&id=EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36&thid=OIP.k5drJ44P_6vXHJjKuuTaYwHaHW&mediaurl=https%3a%2f%2flaunchwebsitedesign.com%2fwp-content%2fuploads%2f2017%2f09%2fjosh-d-avatar.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.93976b278e0fffabd71c98cabae4da63%3frik%3dNgy07nZ1xa834Q%26pid%3dImgRaw%26r%3d0&exph=656&expw=661&q=avatars+for+sites&simid=607992242342948935&FORM=IRPRST&ck=9F5B9425E6390AD08E36568A701BC0A8&selectedIndex=0&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 6,
                        UserId = 6,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=QXxS8HEX&id=652F714CDD9E207902418767156C2A75B8F1DB60&thid=OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Fjetflat-2-people%2F60%2F005_036_woman_girl_user_human_avatar-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8227DE09D92787ADB2D381C3EA426A63&selectedindex=7&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_tvgdD7R%252B*cp_8C0B660E5459F765CCA7B23AACD5864B*mid_DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4*thid_OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.417c52f07117a1e9175cb468d41cf03c%3Frik%3DYNvxuHUqbBVnhw%26pid%3DImgRaw%26r%3D0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 7,
                        UserId = 7,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=2n8TROKP&id=74C616EF6C56DCEDEF60D9B50077E10BA10320B0&thid=OIP.2n8TROKPogruE84yLS6_AwHaHa&mediaurl=https%3A%2F%2Fwww.cashygo.in%2Fstatic%2Fweb%2Fimages%2Fexecutive.png&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.da7f1344e28fa20aee13ce322d2ebf03%3Frik%3DsCADoQvhdwC12Q%26pid%3DImgRaw%26r%3D0&exph=512&expw=512&q=avatars+for+sites&form=IRPRST&ck=299DBFCAFF10B3D5A73A91EF93153F1D&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_k5drJ44P*cp_9F5B9425E6390AD08E36568A701BC0A8*mid_EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36*simid_607992242342948935*thid_OIP.k5drJ44P!_6vXHJjKuuTaYwHaHW&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 8,
                        UserId = 8,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=iN2B0esp&id=A38E6B6419DCB48C099DF633ED08A32D6677EC8C&thid=OIP.iN2B0espKShXbt0BZmC_mwHaHa&mediaurl=https%3A%2F%2Fyt3.ggpht.com%2Fa%2FAATXAJwd0xEzFWMgYTJxhEzDgR2jsBhr38rVVYLGrA%3Ds900-c-k-c0xffffffff-no-rj-mo&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.88dd81d1eb292928576edd016660bf9b%3Frik%3DjOx3Zi2jCO0z9g%26pid%3DImgRaw%26r%3D0&exph=900&expw=900&q=avatars+for+sites&form=IRPRST&ck=89EE8126ADA32A92A48F04A90093C618&selectedindex=10&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_2n8TROKP*cp_299DBFCAFF10B3D5A73A91EF93153F1D*mid_74C616EF6C56DCEDEF60D9B50077E10BA10320B0*thid_OIP.2n8TROKPogruE84yLS6!_AwHaHa&vt=0&sim=11&iss=VSI&simid=608019931989018767&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 9,
                        UserId = 9,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=gUWziU4q&id=575E4366F81F16B6E1150B93A05A24C28C951F88&thid=OIP.gUWziU4qIlj65_ptewq-9gHaJH&mediaurl=https%3A%2F%2Fwww.netclipart.com%2Fpp%2Fm%2F324-3244180_clean-madurai-housekeeping-services-lady-icon-png.png&exph=1132&expw=920&q=avatars+for+sites+woman&form=IRPRST&ck=AA7620D583CFF2F9185EFFFBE6F8C2B1&selectedindex=22&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.8145b3894e2a2258fae7fa6d7b0abef6%3Frik%3DiB%252bVjMIkWqCTCw%26pid%3DImgRaw%26r%3D0&simid=607994102039707919",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 10,
                        UserId = 10,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=gQAod8xN&id=5C062313C68BB599A936E6DD7A9AC1661166D13A&thid=OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&mediaurl=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F74%2Fda%2F07%2F74da07214279d76f9809b9c3943f23e6.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=9E1ECE6649A7EFDF03D173C8E6E75746&selectedindex=11&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.81002877cc4d4ce2736f0e2fe58d621b%3Frik%3DOtFmEWbBmnrd5g%26pid%3DImgRaw%26r%3D0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 11,
                        UserId = 11,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=ovgXQqWa&id=AB355EFFA65C532F535225C443639DD144DF6333&thid=OIP.ovgXQqWaC82lHgt2V2vxvQHaHa&mediaurl=https%3A%2F%2Fvectorified.com%2Fimage%2Fminimalist-vector-25.jpg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.a2f81742a59a0bcda51e0b76576bf1bd%3Frik%3DM2PfRNGdY0PEJQ%26pid%3DImgRaw%26r%3D0&exph=600&expw=600&q=avatars+for+sites&form=IRPRST&ck=10855C420BF2DC89C6C6AA947D217B5C&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_iN2B0esp*cp_89EE8126ADA32A92A48F04A90093C618*mid_A38E6B6419DCB48C099DF633ED08A32D6677EC8C*simid_608019931989018767*thid_OIP.iN2B0espKShXbt0BZmC!_mwHaHa&vt=0&sim=11&iss=VSI&simid=607995094195911121&ajaxhist=0&ajaxserp=0",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 12,
                        UserId = 12,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=GSoBhvI8&id=1D47E63784BA983FC0BEA2430B49F43EFFAA5424&thid=OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Ffamous-character-vol-2-flat%2F48%2FAvatar_Famous_Characters-08-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=4379DFD07D7557F3593324DBE13D5E6F&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_gQAod8xN*cp_9E1ECE6649A7EFDF03D173C8E6E75746*mid_5C062313C68BB599A936E6DD7A9AC1661166D13A*thid_OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.192a0186f23ca4d080a7d13818024523%3Frik%3DJFSq%252fz70SQtDog%26pid%3DImgRaw%26r%3D0&simid=608047059002875774",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 13,
                        UserId = 13,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=UTiUwZi%2B&id=6DB608234240B457D5271CE6F4F7EE64990AE485&thid=OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&mediaurl=https%3A%2F%2Fcdn3.iconfinder.com%2Fdata%2Ficons%2Favatars-collection%2F256%2F35-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=1BEDCB9CA70115141BE0AF964A1B7F0E&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_GSoBhvI8*cp_4379DFD07D7557F3593324DBE13D5E6F*mid_1D47E63784BA983FC0BEA2430B49F43EFFAA5424*simid_608047059002875774*thid_OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.513894c198bee425a7c4db4bea3ba4e1%3Frik%3DheQKmWTu9%252fTmHA%26pid%3DImgRaw%26r%3D0&simid=608055017578107125",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    },
                    new Image()
                    {
                        Id = 14,
                        UserId = 14,
                        ImageTitle = "https://www.bing.com/images/search?view=detailV2&ccid=xcUOt8Fa&id=FA221020C09F8D44E5FA6469ABDE90A35E306CC5&thid=OIP.xcUOt8FaKZgLEY3G3O0VlgHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Favatars-2-7%2F128%2F47-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=F8412316D65B44228F183A4F546C0D97&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_UTiUwZi%252B*cp_1BEDCB9CA70115141BE0AF964A1B7F0E*mid_6DB608234240B457D5271CE6F4F7EE64990AE485*simid_608055017578107125*thid_OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.c5c50eb7c15a29980b118dc6dced1596%3Frik%3DxWwwXqOQ3qtpZA%26pid%3DImgRaw%26r%3D0&simid=608043257958332659",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "Seed"
                    }
                };


            //builder.HasData(images);
        }
    }
}
