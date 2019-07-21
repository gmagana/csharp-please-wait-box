# C# Minimal example of a "please wait" form that's shown as a background thread executes
## Introduction
This is one of those "this should be simpler than it currently is" things: You have a long process to execute on a C# WinForms app (this pattern also works for WPF), and you want to show a form with a spinner on it that is displayed while your long task executes in a background thread.

![Screen capture](https://github.com/gmagana/csharp-please-wait-box/raw/master/PleaseWaitBoxCapture.png)

I wrote this little demo program to show you how to accomplish just that.

I have two code examples in the project: one is just a straight background execution, and the other is a process that executes in the background but also updates the display periodically, introducing the issue of a non-UI thread that updates the UI.

The idea is that this code be as simple to read as possible, and copy/paste friendly as possible.