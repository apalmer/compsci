$max    = 10000000 - 1

#function calculate {
#    param($max)

    $threes = 3 * ([math]::Floor($max / 3))*([math]::Floor($max / 3) + 1) / 2
    $fives = 5 * ([math]::Floor($max / 5))*([math]::Floor($max / 5) + 1) / 2
    $fifteens = 15 * ([math]::Floor($max / 15))*([math]::Floor($max / 15) + 1) / 2

    $threes + $fives - $fifteens

#}

#calculate $max

#"Result: $result"