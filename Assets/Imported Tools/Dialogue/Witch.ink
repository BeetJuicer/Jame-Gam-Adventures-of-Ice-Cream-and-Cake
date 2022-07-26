INCLUDE globals.ink

{witchTalkCount == 0: -> main | -> done}

=== main ===
~ witchTalkCount = 1
What are you still doing here?#speaker:Witch #portrait:witch_neutral 
->END

=== done ===
Don't dawdle.  #speaker:Witch #portrait:witch_neutral
->END