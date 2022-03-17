using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using RegexApp.Models;

namespace RegexApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        string text;
        public string Text
        {
            get => text;
            set => this.RaiseAndSetIfChanged(ref text, value);
        }
        string pattern;

        public string Pattern
        {
            get => pattern;
            set => this.RaiseAndSetIfChanged(ref pattern, value);
        }
        string res;
        public string RegularResult
        {
            get => res;
            set => this.RaiseAndSetIfChanged(ref res, value); 
        }
        public string? FindRegular()=>MyRegex.FindRegexInText(text, pattern);

    }
}
