# OnTheCounter
- A C# console app that allows you to automatically count in online chat rooms (specifically Discord)
- Made this in <1 hour as a small project just to practice my very basic C# skills
- I use this sometimes in the [FreeXR](https://github.com/FreeXR/) Discord server
- The name was inspired by [MindTheGapps](https://gitlab.com/MindTheGapps)
- Coded mostly by me, with slight help from GitHub Copilot for debugging
## Modes
### Slow Mode
This mode that automatically waits a second between sending counting messages. Best for use in something like Discord as it might detect it as spam and try to slow you down. Also could be better for platforms like Chatzy where there is often a delay when sending messages.
### Normal Mode
This mode counts normally with no delay (aside from the default 50 ms delay to make sure the number is typed properly.
## Code
> The program begins by creating a single `InputSimulator` instance used
> for all keyboard events. In `Main`, it collects three inputs from the
> user: the starting number, how many numbers to send, and whether slow
> mode is enabled. After a five-second delay, it branches into either
> `SlowMode` or `NormalMode` based on the user’s choice. Both counting
> methods use a `for` loop that iterates from the starting number up to
> the specified amount. Each loop cycle sends the current number as text
> using `sim.Keyboard.TextEntry()`, then triggers an Enter key press
> with `KeyPress(VirtualKeyCode.RETURN)`. The difference between the two
> methods is their timing: slow mode adds an extra one-second pause
> between messages, while normal mode only includes a short half-second
> delay to ensure the keystrokes register properly. Once the loop
> completes, each mode prints a confirmation message before exiting.

— ChatGPT
## Disclaimer
This tool simulates keyboard input and can be interpreted as automated messaging in platforms like Discord. Automated actions may violate platform Terms of Service. Use responsibly and at your own discretion.
