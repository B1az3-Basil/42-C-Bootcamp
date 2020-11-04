void    ft_putchar(char a);

void    main(int argv, char **argc){
    int i;

    i = 0;
    while (argc[0][i] != '\0')
    {
        ft_putchar(argc[0][i]);
        i++;
    }
        
}