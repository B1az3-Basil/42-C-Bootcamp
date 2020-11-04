void    ft_putchar(char a);

void    main(int argv, char **argc){
    int i;
    int j;

    i = 0;
    j = 1;

    while(j != argv){
        i = 0;
        while (argc[j][i] != '\0')
        {
            ft_putchar(argc[j][i]);
            i++;
        }
        ft_putchar('\n');
        j++;
    }
   
        
}