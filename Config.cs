using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace api
{
    class Config
    {
        public static void setup()
        {
            Console.WriteLine("Setting up...");
            Directory.CreateDirectory("SaveData\\Profile\\");
            if (!(File.Exists("SaveData\\avatar.txt")))
            {
                File.Create("SaveData\\avatar.txt");
            }
            if (!(File.Exists("SaveData\\Profile\\username.txt")))
            {
                File.WriteAllText("SaveData\\Profile\\username.txt", "loser with no user");
            }
            if (!(File.Exists("SaveData\\profileimage.png")))
            {
                File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/2e4b2a2b-521c-4707-b16f-645b22f8c479/dfmosun-003ff67c-2e4c-48ae-a83a-5873209dd47f.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzJlNGIyYTJiLTUyMWMtNDcwNy1iMTZmLTY0NWIyMmY4YzQ3OVwvZGZtb3N1bi0wMDNmZjY3Yy0yZTRjLTQ4YWUtYTgzYS01ODczMjA5ZGQ0N2YuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.Blln_ahbLc9cc2CJhrTQ3BsCJmN4HZV86PUQdNmxWf8"));
            }
            Console.WriteLine("Done!");
            Console.Clear();
        }
        public static gamesesh.GameSessions.SessionInstance localGameSession;
        public static Objective[][] dailyObjectives = new Objective[][]
        {
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            }
        };

    }
}
