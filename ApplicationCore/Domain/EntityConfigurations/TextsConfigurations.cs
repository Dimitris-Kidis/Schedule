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
    public class TextsConfigurations : IEntityTypeConfiguration<Text>
    {
        public void Configure(EntityTypeBuilder<Text> builder)
        {

            var texts = new List<Text>()
            {
                new Text()
                {
                    Id = 1,
                    TextContent = "this is a simple found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho",
                    Level = 4,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 2,
                    TextContent = "this is a simple paragraph that is meant to be nice and easy to type which is why there will be mommas no periods or any capital letters so i guess this means that it cannot really be considered a paragraph but just a series of run on sentences this should help you get faster at typing as im trying not to use too many difficult words in it although i think that i might start making it hard by including some more difficult letters I'm typing pretty quickly so forgive me for any mistakes i think that i will not just tell you a story about the time i went to the zoo and found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho",
                    Level = 5,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 3,
                    TextContent = "Orice persoana are dreptul la învăţătură. Invăţămîntul trebuie să fie gratuit, cel puţin în ceea ce priveşte invăţămîntul elementar şi general. Invăţămîntul elementar trebuie să fie obligatoriu. Invăţămîntul tehnic şi profesional trebuie să fie la îndemîna tuturor, iar învăţămîntul superior trebuie să fie de asemenea egal, accesibil tuturora, pe bază de merit.",
                    Level = 4,
                    Language = "Romanian",
                    Author = "Author3",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 4,
                    TextContent = "Fiecare om are dreptul la ocrotirea intereselor morale şi materiale care decurg din orice lucrare ştiinţifică, literară sau artistică al cărei autor este.",
                    Level = 3,
                    Language = "Romanian",
                    Author = "Author3",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 5,
                    TextContent = "Părinţii au dreptul de prioritate în alegerea felului de învăţămînt pentru copiii lor minori.",
                    Level = 2,
                    Language = "Romanian",
                    Author = "Author3",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 6,
                    TextContent = "Everyone has the right to education. Education shall be free, at least in the elementary and fundamental stages. Elementary education shall be compulsory. Technical and professional education shall be made generally available and higher education shall be equally accessible to all on the basis of merit.",
                    Level = 5,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 7,
                    TextContent = "Everyone has the right freely to participate in the cultural life of the community, to enjoy the arts and to share in scientific advancement and its benefits.",
                    Level = 3,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 8,
                    TextContent = "Parents have a prior right to choose the kind of education that shall be given to their children.",
                    Level = 2,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 9,
                    TextContent = "Reading and comprehension are very important in Romanian. Once you're done with Romanian Reading, you might want to check the rest of our Romanian lessons here: Learn Romanian. Don't forget to bookmark this page.",
                    Level = 4,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 10,
                    TextContent = "The links above are only a small sample of our lessons, please open the left side menu to see all links.",
                    Level = 1,
                    Language = "English",
                    Author = "Author1",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 11,
                    TextContent = "Колобок полежал, полежал, взял да и покатился — с окна на лавку, с лавки на пол, по полу к двери, прыг через порог — да в сени, из сеней на крыльцо, с крыльца на двор, со двора за ворота, дальше и дальше.",
                    Level = 4,
                    Language = "Russian",
                    Author = "Author2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 12,
                    TextContent = "Затрещал теремок, упал набок и весь развалился. Еле-еле успели из него выскочить мышка-норушка, лягушка-квакушка, зайчик-побегайчик, лисичка-сестричка, волчок-серый бочок — все целы и невредимы.",
                    Level = 5,
                    Language = "Russian",
                    Author = "Author2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 13,
                    TextContent = "Волку делать нечего. Пошел он в кузницу и велел себе горло перековать, чтоб петь тонюсеньким голосом. Кузнец ему горло перековал. Волк опять побежал к избушке и спрятался за куст.",
                    Level = 3,
                    Language = "Russian",
                    Author = "Author2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                },
                new Text()
                {
                    Id = 14,
                    TextContent = "Три медведя — сказка о девочке, которая заблудилась в лесу и попала в домик медведей. Там она повела себя очень невоспитанно: без разрешения поела из каждой чашки, посидела на каждом стульчике, полежала в каждой кроватке, что очень разозлило вернувшихся домой медведей. Сказка представлена в изложении Л.Н. Толстого.",
                    Level = 5,
                    Language = "Russian",
                    Author = "Author2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Seed"
                }
            };

            //builder.HasData(texts);
        }
    }
}

