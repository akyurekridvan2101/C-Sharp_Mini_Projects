## Prime Numbers Finder

This simple C# application aims to find prime numbers up to the upper limit value entered by the user. In the project, square root is used for prime number checking.

## Why Use Square Root?

The reasons for preferring the use of square root in determining prime numbers are as follows:

### Performance Benefits

Using square root for prime number checking provides performance benefits, especially when working with large numbers. Generally, using square root to determine whether a number is prime is faster than checking its exact divisors.

### Reduction in the Number of Divisors to Be Checked

Using square root to check divisors of a number allows for checking fewer divisors than looking up to the square of the number. This contributes to a faster execution of the algorithm.

### Reduction in Memory Usage

Using square root reduces the number of divisors to be checked, optimizing memory usage. This advantage becomes more significant, especially when working with very large numbers.

For these reasons, the use of square root for prime number checking has been preferred to enhance performance and achieve a more effective algorithm.

## Example Usage

```bash
Enter an upper limit: 1000

Prime numbers between 1 and 1000:

2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 101 103 107 109 113 127 131 137 139 149 151 157 163 167 173 179 181 191 193 197 199 211 223 227 229 233 239 241 251 257 263 269 271 277 281 283 293 307 311 313 317 331 337 347 349 353 359 367 373 379 383 389 397 401 409 419 421 431 433 439 443 449 457 461 463 467 479 487 491 499 503 509 521 523 541 547 557 563 569 571 577 587 593 599 601 607 613 617 619 631 641 643 647 653 659 661 673 677 683 691 701 709 719 727 733 739 743 751 757 761 769 773 787 797 809 811 821 823 827 829 839 853 857 859 863 877 881 883 887 907 911 919 929 937 941 947 953 967 971 977 983 991 997
```

