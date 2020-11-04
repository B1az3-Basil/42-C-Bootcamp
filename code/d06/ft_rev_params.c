void    ft_putchar(char a);

void    main(int argv, char **argc){
    int len;
    int j;

    len = 0;
    j = 1;

    while(j != argv){
        len = 0;
        while (argc[j][len] != '\0')
            len++;
        
        len--;
        while (len != -1){
          ft_putchar(argc[j][len]);
          len--;
        }
        ft_putchar('\n');
        j++;
    }       
}