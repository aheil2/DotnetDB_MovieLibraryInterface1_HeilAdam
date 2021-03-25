using System;
using System.Collections.Generic;
using System.IO;

namespace DotnetDB_MovieLibraryInterface_HeilAdam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie Lister!");
            getMenu();
            
        }
        public static void getMenu() {
            string fileM = "movies.csv";
            string fileS = "shows.csv";
            string fileV = "videos.csv";
            string fileJ = "movies.json";
            string choice;
            do {
                Console.Write("1. List Media\n2. Add Media\n3. Exit\nUser choice: ");
                choice = Console.ReadLine();
                if (choice == "1") {
                    string listChoice;
                    do {
                        Console.Write("1. List Movies\n2. List Shows\n3. List Videos\n4. List MoviesJson\n5. Back to Menu\nUser choice: ");
                        listChoice = Console.ReadLine();
                        if (listChoice == "1") {
                            MovieList movieFile = new MovieList(fileM);
                            foreach (Movie m in movieFile.movieList) {
                                Console.WriteLine(m.toString());
                            };
                        }
                        else if (listChoice == "2") {
                            ShowList showFile = new ShowList(fileS);
                            foreach (Show s in showFile.showList) {
                                Console.WriteLine(s.toString());
                            }
                        }
                        else if (listChoice == "3") {
                            VideoList videoFile = new VideoList(fileV);
                            foreach (Video v in videoFile.videoList) {
                                Console.WriteLine(v.toString());
                            }
                        }
                        else if (listChoice == "4") {
                            
                            VideoList videoFile = new VideoList(fileV);
                            foreach (Video v in videoFile.videoList) {
                                Console.WriteLine(v.toString());
                            }
                        }
                    } while (listChoice != "5");
                }
                else if (choice == "2") {
                    string addChoice;
                    do {
                        Console.Write("1. Add Movie\n2. Add Show\n3. Add Video\n4. Back to Menu\nUser choice: ");
                        addChoice = Console.ReadLine();
                        if (addChoice == "1") {
                            Console.Write("Add movie title: ");
                            string newTitle = Console.ReadLine();
                            int count = 0;
                            MovieList movieFile = new MovieList(fileM);
                            foreach (Movie m in movieFile.movieList) {
                                if (m.title == newTitle) {
                                    Console.WriteLine("Movie already exists.\n");
                                    break;
                                }
                                else {
                                    count++;
                                }
                            }
                            var genreList = new List<string>();
                            string anotherGenre;
                            do {
                                Console.Write("Add genre: ");
                                genreList.Add(Console.ReadLine());
                                Console.Write("Add another genre (Y/N): ");
                                anotherGenre = Console.ReadLine().ToUpper();
                            } while (anotherGenre == "Y");
                            string genre = string.Join("|", genreList);
                            StreamWriter sw = new StreamWriter(fileM, true);
                            sw.WriteLine($"{count+1},{newTitle},{genre}");
                            sw.Close();
                            Console.WriteLine($"{newTitle} added to movie list.\n");
                        }
                        else if (addChoice == "2") {
                            Console.Write("Add show Title: ");
                            string newTitle = Console.ReadLine();
                            int count = 0;
                            ShowList showFile = new ShowList(fileS);
                            foreach (Show s in showFile.showList) {
                            if (s.title == newTitle) {
                                Console.WriteLine("Movie already exists.\n");
                                getMenu();
                            }
                            else {
                                count++;
                            }
                        }
                        Console.WriteLine("Add season number: ");
                        int season = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Add episode number: ");
                        int episode = Int32.Parse(Console.ReadLine());
                        var writerList = new List<string>();
                        string anotherWriter;
                        do {
                            Console.Write("Add writer: ");
                            writerList.Add(Console.ReadLine());
                            Console.Write("Add another writer (Y/N): ");
                            anotherWriter = Console.ReadLine().ToUpper();
                        } while (anotherWriter == "Y");
                        string writers = string.Join("|", writerList);
                        StreamWriter sw = new StreamWriter(fileS, true);
                        sw.WriteLine($"{count+1},{newTitle},{season},{episode},{writers}");
                        sw.Close();
                        Console.WriteLine($"{newTitle} added to show list.\n");
                        }
                        else if (addChoice == "3") {
                            Console.Write("Add video Title: ");
                            string newTitle = Console.ReadLine();
                            int count = 0;
                            VideoList videoFile = new VideoList(fileV);
                            foreach (Video v in videoFile.videoList) {
                                if (v.title == newTitle) {
                                    Console.WriteLine("Video already exists.\n");
                                    getMenu();
                                }
                                else {
                                    count++;
                                }
                            }
                            var formatList = new List<string>();
                            string anotherFormat;
                            do {
                                Console.Write("Add format type: ");
                                formatList.Add(Console.ReadLine());
                                Console.Write("Add another format type (Y/N): ");
                                anotherFormat = Console.ReadLine().ToUpper();
                            } while (anotherFormat == "Y");
                            string formats = string.Join("|", formatList);
                            Console.WriteLine("Add length (minutes): ");
                            int length = Int32.Parse(Console.ReadLine());
                            var regionList = new List<string>();
                            string anotherRegion;
                            do {
                                Console.Write("Add region number: ");
                                formatList.Add(Console.ReadLine());
                                Console.Write("Add another region number (Y/N): ");
                                anotherRegion = Console.ReadLine().ToUpper();
                            } while (anotherRegion == "Y");
                            string regions = string.Join("|", regionList);
                            StreamWriter sw = new StreamWriter(fileV, true);
                            sw.WriteLine($"{count+1},{newTitle},{formats},{length},{regions}");
                            sw.Close();
                            Console.WriteLine($"{newTitle} added to show list.\n");
                        }
                    } while (addChoice != "4");
                }
                else {
                    Console.WriteLine("Goodbye.");                }
            } while (choice != "3");
        }
    }
}
