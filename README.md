# Grande.Pluralization

A simple pluralization engine for .Net.

> Some people, when confronted with a pluralization problem, think "I know, I'll use regular expressions." Now they have two problems.
A poor paraphrasing of Jamie Zawinski

## How do I use it?

Simply.  Just reference Grande.Pluralizer.dll in your project, add the namespace Grande.Pluralization, and you're off to the races.

    int count = 4;
    string result = string.Format("I can see {0} {1}.", count, Pluralizer.Pluralize(count, "light"));
	// "I can see 4 lights"
	count = 1;
    string result = string.Format("I can see {0} {1}.", count, Pluralizer.Pluralize(count, "light"));
	// "I can see 1 light"
	
Or, use extension methods.

    int count = 4;
    string result = string.Format("I can see {0} {1}.", count, "light".Pluralize(count));
	// "I can see 4 lights"
	
## How does it work?

Regex, mostly.  See the Pluralizations field in Pluralizer.cs for more info.
	
## What if I find a bug?

File a bug here on GitHub.  I'll fix it.  Or fix it yourself, and issue a pull request.  
In the mean time, you can override your results like this:

    Pluralizer.Pluralize(count, singular, plural);
	
	string result = Pluralizer.Pluralize(5, "box", "boxen");
	// Will return "boxen" instead of "boxes."
	
## Upcoming features

- Copula generator (What's a [copula](http://en.wikipedia.org/wiki/Copula_\(linguistics\)), you ask?  tl,dr: In English, it's "is" and "are."
- Optionally include the count in the result (This may become the default):
    var result = "chairman".Pluralize(4, PluralizationOptions.PrependNumber);
	// "4 chairmen"
- Globalization (using pluginable language sets)