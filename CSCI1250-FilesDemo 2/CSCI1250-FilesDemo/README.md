# CSCI 1250 Files and try/catch: Demo Projects

Instructor copy for the lecture deck `CSCI1250-Files-and-Exceptions.pptx`. Each folder is a complete .NET 10 console project, the same SDK students installed in Lab 01. Open a terminal **in that folder** and type `dotnet run`. Every output in the deck, the speaker notes, and the demo script came from running these.

| Folder | Slides | What it shows |
| --- | --- | --- |
| `CounterAmnesia` | 2 | A counter with no memory. Every run prints run number 1. |
| `CounterRemember` | 3, 23 | The same counter, saved in `runs.txt`. Ships with `runs.txt` holding `0`. Delete `runs.txt` to see the crash the exercise fixes. |
| `CounterFixed` | 24 | The exercise answer. Ships with no `runs.txt`, so the first run prints `No count yet. Starting from zero.` |
| `Step1Read` | 8, 9 | Prints the folder it is looking in, then reads `hours.txt` and reports the total, average, and best day. |
| `Step2Write` | 13, 16, 17 | Adds `report.txt` (Write) and `history.txt` (Append). Run it twice and compare the two files. Rename `hours.txt` to see the crash on slide 17. |
| `Step3Recover` | 18 to 22 | The finished program with both try blocks. Break it three ways: rename `hours.txt`, type `two` on line 5, or change `LOG_FILE` to `"data/hours.txt"`. |

## Resetting Between Sections

- `CounterRemember/runs.txt` back to a single `0`.
- Delete `runs.txt` from `CounterFixed`.
- Delete `report.txt` and `history.txt` from `Step2Write` and `Step3Recover`.
- Put `Step3Recover/hours.txt` back to the seven clean numbers: 2.5, 1.75, 0, 3.25, 2, 4, 1.5.

## A Note on the Play Button

Run from the terminal, these programs look for their files in the project folder. The VS Code play button can run them from a different folder, which makes `hours.txt` look missing. Check on the classroom machine before class; the first line of `Step1Read` tells you where it is looking.
