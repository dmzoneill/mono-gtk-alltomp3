# AllToMp3

<p align="center">
  <img src=".github/logo.png" alt="mono-gtk-alltomp3 logo" width="128" />
</p>

A small Mono GTK# program written to tidy up an MP3 collection.

## What it does

When it starts, it walks `/media/mp3s` recursively and **deletes every file that
does not have an `.mp3` extension**, then prints how many files it removed. The
folder is hardcoded and nothing is converted, despite the name.

Back up your files before running it.

## Tech

- C# with Mono and GTK#

## Building

Open the `.sln` file in MonoDevelop, or build it with Mono and run the resulting
`.exe` with `mono`. Requires GTK# 2.

## License

Licensed under the Apache License 2.0. See [LICENSE](LICENSE).
