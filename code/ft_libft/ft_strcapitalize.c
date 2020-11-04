char    *ft_strcapitalize(char *str){
    int i;

    i = 0;

    while (str[i] != '\0'){
        if ('a' <= str[i] && str[i] <= 'z' && str[i - 1] >= 0 && !(48 <= str[i - 1] && str[i - 1] <= 57 || 
        'A' <= str[i - 1] && str[i - 1] <= 'Z' || 'a' <= str[i - 1] && str[i - 1] <= 'z')){
             str[i] = str[i] - 32;
        }
        
        else if ('A' <= str[i] && str[i] <= 'Z'){
            str[i] = str[i] + 32;
        }
        
        
        i++;
    }
    return str; 
}
