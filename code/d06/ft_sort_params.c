void    ft_putchar(char a);

void    main(int argv, char **argc){
    int len;
    int j;
    char temp;

    len = 0;
    j = 1;

    while(j != argv){
        len = 0;
        while (argc[j][len]){
            if (argc[j][len] > argc[j][len + 1]){
                temp = argc[j][len];
                argc[j][len + 1] = argc[j][len];
                argc[j][len] = temp;
            }
            len++;
        }
        argc[j][len] = '\0';
        len = 0;
        while (argc[j][len]){
            ft_putchar(argc[j][len]);
            len++;
        }
        ft_putchar('\n');
        j++;
    }       
}