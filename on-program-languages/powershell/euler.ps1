#Measure-Command {
    $max = 10000000 - 1 
    $sum = 0

    1..$max | 
    ? { (( $_ % 3 ) -eq 0) -or (($_ % 5) -eq 0) } | 
    % { $sum += $_ } 

    $sum 
#}
