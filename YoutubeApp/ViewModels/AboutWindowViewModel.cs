﻿using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;

namespace YoutubeApp.ViewModels;

public partial class AboutWindowViewModel
{
    [RelayCommand]
    private static void OpenGithubPage()
    {
        Process.Start(new ProcessStartInfo("https://github.com/legend2ks/YoutubeDownloader")
            { UseShellExecute = true });
    }

    [RelayCommand]
    private static void OpenGithubPageDonateSection()
    {
        Process.Start(new ProcessStartInfo("https://github.com/legend2ks/YoutubeDownloader/#-support")
            { UseShellExecute = true });
    }
}