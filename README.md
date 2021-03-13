# Fast Ferment

This simple mod allows you to adjust the amount of time it takes for a mead base to ferment into a mead. By default the mod makes it take about one second to ferment, but you can change this in the config file.

This is my first Valheim mod so let me know if there are issues!

## Manual Installation
In order to install this mod, `you need to have BepInEx and Harmony installed`. After installing these, place `fastferment.dll` (extract zip) into `(Your Steam games directory)\Valheim\BepInEx\plugins`.

## Customization
To change the fermentation duration, go to the directory `(Your Steam games directory)\Valheim\BepInEx\config` and open `fastferment.cfg` in notepad. Then change the number after the "=" sign. The game sets this value to 2400, but the mod sets it to 1 by default. This seems to be roughly equal to 1 second.

I'm not 100% sure if this number is actually in seconds, as the Valheim wiki suggests that the duration is 3600 seconds. However, you can safely assume it's within the range of 2/3 of a second to a full second.