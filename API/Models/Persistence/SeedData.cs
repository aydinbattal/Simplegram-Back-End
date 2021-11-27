using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Entities;

namespace API.Models.Persistence
{
    public class SeedData
    {
        public async static void Seed(DataContext context)
        {

            if (context.Images.Any())
                return;

            var images = new List<Image>{
                new Image{
                    Url = "https://picsum.photos/id/0/5616/3744",
                    User = new User{
                        Name = "Alejandro Escamilla",
                        Email = "AlejandroEscamilla@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Macbook Air"
                        },
                        new Tag {
                            Text = "Work"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/10/2500/1667",
                    User = new User{
                        Name = "Paul Jarvis",
                        Email = "PaulJarvis@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Nature"
                        },
                        new Tag {
                            Text = "Green"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/100/2500/1656",
                    User = new User{
                        Name = "Tina Rataj",
                        Email = "TinaRataj@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Ocean"
                        },
                        new Tag {
                            Text = "Beach"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1000/5626/3635",
                    User = new User{
                        Name = "Lukas Budimaier",
                        Email = "LukasBudimaier@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Snow"
                        },
                        new Tag {
                            Text = "Clouds"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1001/5616/3744",
                    User = new User{
                        Name = "Danielle MacInnes",
                        Email = "DanielleMacInnes@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Beach"
                        },
                        new Tag {
                            Text = "Dad"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1002/4312/2868",
                    User = new User{
                        Name = "NASA",
                        Email = "NASA@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Blue"
                        },
                        new Tag {
                            Text = "Ocean"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1004/5616/3744",
                    User = new User{
                        Name = "Greg Rakozy",
                        Email = "GregRakozy@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Love"
                        },
                        new Tag {
                            Text = "Snow"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1005/5760/3840",
                    User = new User{
                        Name = "Matthew Wiebe",
                        Email = "MatthewWiebe@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Scarf"
                        },
                        new Tag {
                            Text = "Jacket"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1006/3000/2000",
                    User = new User{
                        Name = "Vladimir Kudinov",
                        Email = "VladimirKudinov@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Dog"
                        },
                        new Tag {
                            Text = "Mountain View"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1008/5616/3744",
                    User = new User{
                        Name = "Benjamin Combs",
                        Email = "BenjaminCombs@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Sleep"
                        },
                        new Tag {
                            Text = "Alone"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1009/5000/7502",
                    User = new User{
                        Name = "Christopher Campbell",
                        Email = "ChristopherCampbell@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Sky"
                        },
                        new Tag {
                            Text = "Man"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/101/2621/1747",
                    User = new User{
                        Name = "Christian Bardenhorst",
                        Email = "ChristianBardenhorst@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Architecture"
                        },
                        new Tag {
                            Text = "Sky"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1010/5184/3456",
                    User = new User{
                        Name = "Samantha Sophia",
                        Email = "SamanthaSophia@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Bible"
                        },
                        new Tag {
                            Text = "Reading"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1011/5472/3648",
                    User = new User{
                        Name = "Roberto Nickson",
                        Email = "RobertoNickson@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Nature"
                        },
                        new Tag {
                            Text = "Kayak"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1012/3973/2639",
                    User = new User{
                        Name = "Scott Webb",
                        Email = "ScottWebb@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Dog"
                        },
                        new Tag {
                            Text = "Green"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1013/4256/2832",
                    User = new User{
                        Name = "Cayton Heath",
                        Email = "CaytonHeath@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Marriage"
                        },
                        new Tag {
                            Text = "Bride"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1015/6000/4000",
                    User = new User{
                        Name = "Alexey Topolyanskiy",
                        Email = "AlexeyTopolyanskiy@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "River"
                        },
                        new Tag {
                            Text = "Mountains"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1016/3844/2563",
                    User = new User{
                        Name = "Philippe Wuyts",
                        Email = "PhilippeWuyts@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Sunset"
                        },
                        new Tag {
                            Text = "Rocks"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1018/3914/2935",
                    User = new User{
                        Name = "Andrew Ridley",
                        Email = "AndrewRidley@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Green"
                        },
                        new Tag {
                            Text = "Pathway"
                        }
                    }

                },
                new Image{
                    Url = "https://picsum.photos/id/1019/5472/3648",
                    User = new User{
                        Name = "Patrick Fore",
                        Email = "PatrickFore@gmail.com"
                    },
                    PostingDate = DateTime.Now,
                    Tags = new List<Tag>{
                        new Tag {
                            Text = "Dark"
                        },
                        new Tag {
                            Text = "Ocean View"
                        }
                    }

                },


            };

            await context.Images.AddRangeAsync(images);


            // var img = new Image
            // {
            //     Url = "https://picsum.photos/id/1023/3955/2094",
            //     User = new User
            //     {
            //         Name = "William Hook",
            //         Email = "WilliamHook@gmail.com"
            //     },
            //     PostingDate = DateTime.Now,
            //     Tags = new List<Tag>{
            //             new Tag {
            //                 Text = "Biking"
            //             },
            //             new Tag {
            //                 Text = "Green"
            //             }
            //         }

            // };
            // await context.Images.AddAsync(img);

            await context.SaveChangesAsync();
        }
    }
}