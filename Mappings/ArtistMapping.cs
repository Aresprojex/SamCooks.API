using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamCooks.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamCooks.API.Mappings
{
    public class ArtistMapping : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            // Seed default artist data into database
            var artists = new List<Artist>
            {
                new Artist
                {
                    Id = Guid.Parse("e7d58c75-18bc-4868-b54d-0a1fdf8fe94d"),
                    Name = "21 Savage",
                    Bio = "21 Savage is a British rapper known for his <i>distinct trap style</i> and introspective lyrics. Born in London, he moved to Atlanta at a young age and emerged as a prominent figure in the hip-hop scene. His music often reflects on his personal experiences, addressing topics like <i>violence</i>, <i>poverty</i>, and <b><span style='color: red';>social injustice</span></b>.",
                    Region = "South",
                    Location = "Atlanta, Georgia"
                },
                new Artist
                {
                    Id = Guid.Parse("d8b86cbe-fd86-4a8b-81f8-800b5e27e8c2"),
                    Name = "3rd Bass",
                    Bio =  "3rd Bass was an American hip-hop group known for their witty and <span class='pir'>socially conscious</span> lyrics. Consisting of MC Serch, Prime Minister Pete Nice, and DJ Richie Rich, they rose to prominence in the late 1980s and early 1990s. Their music often tackled themes of racial inequality, politics, and cultural criticism.",
                    Region = "North",
                    Location = ""
                },
                new Artist
                {
                    Id = Guid.Parse("e3511cd1-8c6c-44fb-908d-1107a4e8e8d9"),
                    Name = "50 Cent",
                    Bio = "50 Cent is an American rapper and actor who gained popularity with his debut album 'Get Rich or Die Tryin'.' Born Curtis Jackson, he rose to prominence in the early 2000s with his gritty lyrics and captivating storytelling. Beyond his music career, 50 Cent has ventured into entrepreneurship and acting, showcasing his versatility and business acumen.",
                    Region = "North",
                    Location = "Queens, New York"
                },
                new Artist
                {
                    Id = Guid.Parse("e4aba257-4e44-4fec-9f36-dabbac9e6078"),
                    Name = "Akinyele",
                    Bio = "Akinyele is a provocative and controversial Hip Hop artist known for pushing boundaries with his explicit lyrics. His debut album 'Vagina Diner' gained attention for its daring content. Akinyele's music often sparks discussions about societal taboos and challenges traditional norms.",
                    Region = "East",
                    Location = "Queens, New York"
                },
                new Artist
                {
                    Id = Guid.Parse("b0577578-89ca-4d61-afab-aac673fa4bfb"),
                    Name = "Beastie Boys",
                    Bio = "Beastie Boys were an American rap/rock group known for their energetic performances and genre-blending music. Consisting of Michael Diamond (Mike D), Adam Horovitz (Ad-Rock), and Adam Yauch (MCA), they emerged in the 1980s as pioneers of hip-hop and alternative music fusion. Their influential career spanned decades, leaving an indelible impact on the music industry.",
                    Region = "North",
                    Location = "Brooklyn, New York"
                },

                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Big Daddy Kane",
                    Bio = "Big Daddy Kane is an American rapper and actor known for his smooth delivery and influential contributions to hip-hop. With his charismatic stage presence and intricate wordplay, he became one of the leading figures in the golden age of hip-hop in the late 1980s and early 1990s. His lyrical prowess and suave style influenced generations of artists.",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Big Pun",
                    Bio = "Big Pun, whose real name was Christopher Rios, was a highly influential Puerto Rican-American rapper known for his exceptional lyricism and impactful storytelling. He left a lasting legacy on the hip-hop community as one of the first Latino rappers to achieve mainstream success. Despite his untimely passing, his contributions to the genre continue to inspire and influence artists to this day.",
                    Location = "Bronx, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Biz Markie",
                    Bio = "Biz Markie was an American rapper, beatboxer, and producer known for his humorous and lighthearted style. With his distinctive baritone voice and playful lyrics, he achieved mainstream success in the late 1980s. Biz Markie's contributions to hip-hop extended beyond his music, as he also served as a DJ and appeared in films and TV shows. Additionally, he subtly made <span class='pir';>political statements</span> in his music, demonstrating a slight bit of activism.",
                    Location = "New York, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Black Eyed Peas",
                    Bio = "Black Eyed Peas is an American musical group known for their eclectic blend of hip-hop, pop, and electronic music. Consisting of will.i.am (William James Adams Jr.), apl.de.ap (Allan Pineda Lindo), Taboo (Jaime Luis Gomez), and Fergie (Stacy Ann Ferguson), The group's music often carries socially conscious messages and promotes positivity and unity.",
                    Location = "Los Angeles, California",
                    Region = "West"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Black Moon",
                    Bio = "Black Moon is an American hip hop group from Brooklyn, New York, formed in the early 1990s. The group consists of members Buckshot, 5 ft, and DJ Evil Dee. Known for their underground sound and <span class='pir'>contribution to the creation of hardcore hip-hop with a focus on social consciousness</span>, they are acclaimed for albums like 'Enta da Stage'.",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Bone Thugs-N-Harmony",
                    Bio = "Bone Thugs-N-Harmony is an American hip-hop group known for their melodic harmonies and rapid-fire delivery. Formed in Cleveland, Ohio, they rose to prominence in the 1990s with hits like 'Tha Crossroads' and '1st of tha Month'. Their unique style and introspective lyrics made them influential figures in the rap scene.",
                    Location = "Cleveland, Ohio",
                    Region = "North"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Busta Rhymes",
                    Bio = "Busta Rhymes is an American rapper, singer, and actor known for his energetic performances and rapid-fire rhymes. With a career spanning several decades, he has released numerous chart-topping hits and collaborated with various artists. Busta Rhymes is celebrated for his dynamic flow and charismatic stage presence.",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Canibus",
                    Bio = "Canibus is an American rapper known for his intricate wordplay and lyrical depth. Emerging in the late 1990s, he gained attention for his technical skills and thought-provoking verses. Canibus's music often explores complex themes and showcases his intellectual approach to hip-hop.",
                    Location = "Jamaica, Queens, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Cardi B",
                    Bio = "Cardi B is an American rapper, songwriter, and actress who rose to fame with her chart-topping debut single 'Bodak Yellow'. Known for her charismatic personality and unapologetic lyrics, she has become one of the most successful female artists in the music industry. Cardi B's bold and confident style has made her a cultural icon.",
                    Location = "New York, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Chance the Rapper",
                    Bio = "Chancelor Bennett, better known by his stage name Chance the Rapper, is an American rapper, singer, songwriter, and record producer. He is known for his eclectic mix of hip hop, gospel, and soul music, as well as his <span class='pir';>socially conscious</span> lyrics.",
                    Location = "Chicago, Illinois",
                    Region = "North"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Childish Gambino",
                    Bio = "Childish Gambino, also known as Donald Glover, is a multi-talented artist who excels in music, acting, writing, and producing. With critically acclaimed albums like 'Awaken, My Love!' and the hit single 'This Is America', he has proven himself as an innovative and socially conscious artist. Childish Gambino's work often explores themes of race, identity, and cultural commentary.",
                    Location = "Stone Mountain, Georgia",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Common",
                    Bio = "Common is an American rapper, actor, and activist known for his introspective and socially conscious lyrics. With a career spanning over three decades, he has released acclaimed albums and collaborated with various artists. Common's music often delves into themes of love, self-reflection, and social issues.",
                    Location = "Chicago, Illinois",
                    Region = "North"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Cypress Hill",
                    Bio = "Cypress Hill is an American hip-hop group...",                    
                    Location = "South Gate, California",
                    Region = "West"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "De La Soul",
                    Bio = "De La Soul is an American hip-hop trio...",                    
                    Location = "Amityville, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Digital Underground",
                    Bio = "Digital Underground was an American hip-hop group...",                    
                    Location = "Oakland, California",
                    Region = "West"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "DJ Jazzy Jeff & The Fresh Prince",
                    Bio = "DJ Jazzy Jeff & The Fresh Prince, consisting of DJ Jazzy Jeff...",                    
                    Location = "Philadelphia, Pennsylvania",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Denzel Curry",
                    Bio = "Denzel Curry is an American rapper and songwriter...",                    
                    Location = "Carol City, Florida",
                    Region = "South"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "DMX",
                    Bio = "DMX, also known as Dark Man X, was a prominent American rapper and actor...",                    
                    Location = "Yonkers, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Don Trip",
                    Bio = "Don Trip (Christopher Donnie Wallace Jr) is a Memphis-based Hip Hop artist...",                    
                    Location = "Memphis, Tennessee",
                    Region = "South"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Doug E. Fresh",
                    Bio = "Doug E. Fresh is an American rapper, beatboxer, and producer...",                    
                    Location = "Barbados, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "DJ Quik",
                    Bio = "DJ Quik is an American rapper, record producer, and DJ...",                    
                    Location = "Compton, California",
                    Region = "West"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Drake",
                    Bio = "Drake is a Canadian rapper, singer, songwriter, and actor...",
                    Location = "Ontario, Canada",
                    Region = "North"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "El-P",
                    Bio = "El-P, whose real name is Jaime Meline, is an American rapper...",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Eminem",
                    Bio = "Eminem, also known as Marshall Mathers or Slim Shady, is an American rapper...",
                    Location = "Detroit, Michigan",
                    Region = "North"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "EPMD",
                    Bio = "EPMD, which stands for Erick and Parrish Making Dollars, is an American hip-hop duo...",
                    Location = "Brentwood New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Eric B & Rakim",
                    Bio = "Eric B & Rakim were an American hip-hop duo known for their groundbreaking contributions...",
                    Location = "Long Island, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Fabolous",
                    Bio = "Fabolous, born John David Jackson, is an American rapper and songwriter from Brooklyn...",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Fat Boys",
                    Bio = "Fat Boys were an American hip-hop trio known for their lighthearted and comedic approach...",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Fearless Four",
                    Bio = "Fearless Four was an American hip-hop group known for their energetic performances...",
                    Location = "New York, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Fugees",
                    Bio = "Fugees, comprised of Wyclef Jean, Lauryn Hill, and Pras Michel, were an American hip-hop...",
                    Location = "South Orange, New Jersey",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Future",
                    Bio = "Nayvadius DeMun Wilburn, better known by his stage name Future, is an American rapper...",
                    Location = "Atlanta, Georgia",
                    Region = "South"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Gang Starr",
                    Bio = "Gang Starr was an American hip-hop duo consisting of Guru and DJ Premier. Known for...",
                    Location = "Brooklyn, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Grand Master Flash and the Furious 5",
                    Bio = "Grandmaster Flash and the Furious Five were an American hip-hop group known for...",
                    Location = "South Bronx, New York",
                    Region = "East"
                },
                new Artist
                {
                    Id = Guid.NewGuid(),
                    Name = "Gunna",
                    Bio = "Gunna, also known as Sergio Giavanni Kitchens, is an American rapper and songwriter...",
                    Location = "Atlanta, Georgia",
                    Region = "South"
                }















            };

            builder.HasData(artists);
        }
    }
}
