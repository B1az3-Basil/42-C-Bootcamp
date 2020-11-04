#include <stdlib.h>

char    *ft_strdup(char *src){
    int len;
    int i;
    char *str;

    len = 0;
    i = 0;

    while(src[len])
        len++;
    
    str = (char *)malloc(sizeof(char) * len);

    while (str[i])
    {
        str[i] = src[i];
        i++;
    }
    return str;
}