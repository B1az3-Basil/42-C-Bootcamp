char    *ft_strupcase(char *str) { 
    int i;

    i = 0;
    while(str[i] != '\0'){
        if (65 <= str[i] && str[i] <= 90){
            i++;
            continue;
        }
            
        str[i] = str[i] - 32;
        i++;
    }
    return str;
} 
  