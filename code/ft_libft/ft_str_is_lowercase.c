
int     ft_str_is_lowercase(char *str){
    int i;
    char a; 

    a = 'n';
    i = 0;
    while (str[i] != '\0'){
        if (str[i] >= 0 && !(str[i] <= 'z' && str[i] >= 'a'))
            a = 'y';
        i++;
    }
        
    if (a == 'y' || i == 0)
        return 1;

    else
        return 0;
    
}


