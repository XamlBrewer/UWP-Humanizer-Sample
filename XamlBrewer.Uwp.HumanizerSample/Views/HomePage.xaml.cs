using Humanizer;
using System;
using System.Collections.Generic;
using System.Globalization;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.HumanizerSample
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }



        //// private List<KeyValuePair<String, String>> Expressions => new List<KeyValuePair<string, string>>
        private List<KeyValuePairOfStrings> Expressions => new List<KeyValuePairOfStrings>
        {
            new KeyValuePairOfStrings("Expression", "Result"),
            new KeyValuePairOfStrings(@"""Can_return_title_Case"".Humanize(LetterCasing.Title)", "Can_return_title_Case".Humanize(LetterCasing.Title)),
            new KeyValuePairOfStrings(@"""Pascal case input string is turned into sentence"".Dehumanize()", "Pascal case input string is turned into sentence".Dehumanize()),
            new KeyValuePairOfStrings(@"""Long text to truncate"".Truncate(10)", "Long text to truncate".Truncate(10)),
            new KeyValuePairOfStrings(@"DateTime.UtcNow.AddHours(-30).Humanize()", DateTime.UtcNow.AddHours(-30).Humanize()),
            new KeyValuePairOfStrings(@"TimeSpan.FromMilliseconds(1299630020).Humanize(3, collectionSeparator: null)", TimeSpan.FromMilliseconds(1299630020).Humanize(3, collectionSeparator: null)),
            new KeyValuePairOfStrings(@"""Man"".Pluralize()", "Man".Pluralize()),
            new KeyValuePairOfStrings(@"""process"".ToQuantity(2)", "process".ToQuantity(2)),
            new KeyValuePairOfStrings(@"""dollar"".ToQuantity(2, ""C2"", new CultureInfo(""en-US"")", "dollar".ToQuantity(2, "C2", new CultureInfo("en-US"))),
            new KeyValuePairOfStrings(@"5.Ordinalize()", 5.Ordinalize()),
            new KeyValuePairOfStrings(@"3501.ToWords()", 3501.ToWords()),
            new KeyValuePairOfStrings(@"21.ToOrdinalWords()", 21.ToOrdinalWords()),
            new KeyValuePairOfStrings(@"""MMXVIII"".FromRoman()", "MMXVIII".FromRoman().ToString())
        };
    }

    /// <summary>
    /// x:Bindable version of KeyValuePair<String, String>
    /// </summary>
    public class KeyValuePairOfStrings
    {
        public KeyValuePairOfStrings()
        { }

        public KeyValuePairOfStrings(string key, string value) : this()
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
