player-uuid-requirement = It do {$inverted ->
    [true]{" "} not
    *[other]{""}
} belong to you

player-sponsortier-requirement = You must have a subscription {$inverted ->
    [true]{" "} lower
    *[other]{""} higher
} than {$tier} level