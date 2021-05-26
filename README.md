# PreEmptive Protection - Dotfuscator Community Samples

This repo contains samples that demonstrate configuring [PreEmptive Protection - Dotfuscator Community](https://www.preemptive.com/products/dotfuscator/overview) for various types of .NET applications. 
For instructions on installing Dotfuscator Community, see [Install Dotfuscator Community](https://docs.microsoft.com/en-us/visualstudio/ide/dotfuscator/install).

The samples in this repo are each organized into their own directory.
For sample-specific instructions, refer to the the README in each sample's directory.

## Samples in this repo

The following samples are available in this repo:

* [DotfuscatorCommunitySample](DotfuscatorCommunitySample) demonstrates using [Tamper check](https://www.preemptive.com/dotfuscator/ce/docs/help/checks_tamper.html) and [Debug Check](https://www.preemptive.com/dotfuscator/ce/docs/help/checks_debug.html) to protect an app.

This repo has tags that correspond to the Visual Studio version and the earliest Dotfuscator Community version the samples are compatible with. 

## Samples in other repos

### Xamarin 

Samples for integrating and configuring Dotfuscator protection for Xamarin apps can be found in the following repos:

* [protected-bugsweeper](https://github.com/preemptive/protected-bugsweeper) demonstrates integrating Dotfuscator into the build process for a Xamarin app and then enhancing the protection with Tamper Check and configured responses.

* [protected-TodoAzureAuth](https://github.com/preemptive/Protected-TodoAzureAuth) accompanies [Detect and Respond to Rooted Android Devices from Xamarin Apps](https://msdn.microsoft.com/en-US/magazine/mt846653). 
  This sample demonstrates protecting a Xamarin app with Root Checks and the different methods for responding to a rooted Android device.

    * **Note**: This sample's repository has been archived.
      While the sample still demonstrates how to use Dotfuscator Community to detect a rooted Android device, the ability to save and restore to-do list items is no longer supported.

### Checks

Samples for protecting applications with [Checks](https://www.preemptive.com/dotfuscator/pro/userguide/en/protection_checks_overview.html) can be found in the following repos:

* [protected-adventureworks](https://github.com/preemptive/protected-adventureworks) provides an example of protecting a WPF app with Dotfuscator's Runtime Checks.

* [dot-check-sample](https://github.com/preemptive/dot-check-sample) is a WPF application designed to demonstrate use cases and patterns for Dotfuscator's [anti-debug protections](https://www.preemptive.com/dotfuscator/pro/userguide/en/protection_checks_debug.html).

### Dotfuscator Professional

If you are using Dotfuscator Professional, see the [Dotfuscator Pro Samples](https://github.com/preemptive/dotfuscator-pro-samples) repo.
