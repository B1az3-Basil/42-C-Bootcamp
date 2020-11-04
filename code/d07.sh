#!/bin/sh

gcc -c "ft_libft/ft_putchar.c"
gcc -c "ft_libft/ft_putnbr.c"
gcc -c "ft_libft/ft_swap.c"
gcc -c "ft_libft/ft_strlen.c"
gcc -c "ft_libft/ft_strcmp.c"
gcc -c "ft_libft/ft_putstr.c"
gcc -c "ft_libft/ft_strlowcase.c"
gcc -c "ft_libft/ft_strupcase.c"

ar rc libft.a ft_putchar.o ft_putnbr.o ft_putstr.o ft_strcmp.o ft_strlen.o ft_strupcase.o ft_swap.o ft_strlowcase.o
rm *.o
ranlib libft.a
