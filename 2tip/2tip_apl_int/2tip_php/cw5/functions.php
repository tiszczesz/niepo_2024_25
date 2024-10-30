<?php

function NwdRec(int $a, int $b): int
{
    return $b == 0 ? $a : NwdRec($b, $a % $b);
}

