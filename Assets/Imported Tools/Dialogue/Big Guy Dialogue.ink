INCLUDE globals.ink

{bigGuyTalkCount == 0: -> main | -> done}

=== main ===
~ bigGuyTalkCount = 1
#speaker:Big Guy #portrait:big_guy_neutral
Hm? There are other people here? An Ice Creamian and a Cakius, what a comedic duo.
So, you guys are here for the <i>Secret Treasures</i> too, huh?
Heh, it's no use. Word around here is that the recipe for [ <i>Ice Cream Cake</i> ] is just up ahead but it's blocked off.
What a shame. I could've seen you two fuse.
->END

=== done ===
#speaker:Big Guy #portrait:big_guy_neutral
Hm? You're still here? 
->END