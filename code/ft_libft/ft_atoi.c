
int    ft_atoi(char *str){
    int i = 0;
    int num = 0;
    int len = 0;

    while (str[len] != '\0')
    {
        len++;
    }
    

    while (str[i] != '\0')
    {
        num += str[i] - '0';
        if (len == 1){
            return num;
        }
        
        if (len > 1){
            num *= 10;
        }
        len--;
        i++;
    }

    return 0;
}
