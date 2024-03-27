// See https://aka.ms/new-console-template for more information
using System;
static void Main(string[] args)
{
    string judul = "Tutorial Design By Contract - Ghifari";
    SayaTubeVideo sayaTubeVideo = new SayaTubeVideo(judul);
    Random rand = new Random();
    int min = 1;
    int max = 10000000;
    sayaTubeVideo.IncreasePlayCount(rand.Next(min, max + 1));
    sayaTubeVideo.PrintVideoDetails();

}
