char    *ft_strstr(char *str, char *to_find){
    int i;
    int index;
    char *return_str;

    i = 0;
    index = 0;

    while (str[i] != '\0'){
        if (str[i] == to_find[index]){
            if (index == 0){
                return_str = &str[i];
            }
            index++;
        }

        else if (to_find[index] != '\0' && index > 0){
            return '\0';
        }

        if (to_find[index] == '\0'){
            return return_str;
        } 
        i++;
    }
    return '\0';
}

