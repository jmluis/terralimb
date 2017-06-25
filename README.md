# terralimb
lightweight library to interface with terrarian objects
* Buff: holder of ID, name, time
* Item: holder of ID, name, nick, slots, etc.
* Player: helper functions for decrypting and encrypting player files as well as gathering data
* Constants: Allows for .json loading of serialized (Buff / Item ) classes; allowing for dynamic loading of item lists

> [here is a gist of what dumping to .json would look like for an XNA application that hooks terraria] [gist]

### Requires
* Newtonsoft.Json ~10.0

 [gist]: <https://gist.github.com/ChbShoot/fc0e183f96b48280dd17c9e33f7ae0bd#file-hook-cs>
