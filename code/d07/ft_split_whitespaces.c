#include <stdlib.h>

char    **ft_split_whitespaces(char *str){
    char **str_2d;
    int i;
    int len;
    int row;
    int str_len;
    int new_len;

    i = 0;
    len = 0;
    row = 0;
    len = 0;
    new_len = 0;
    str_len = 0;

    while(str[str_len] != '\0')
        str_len++;

    while (len <= str_len)
    {
        if (str[len] == ' ' || str[len] == '\t'|| str[len]== '\n' || str[len] == '\0'){
            row++;
        }
        len++;
    }

    str_2d = (char **)malloc(sizeof(char *) * row);

    len = 0;

    while (len <= str_len)
    {   
        new_len = 0;
        while (str[len] != ' ' && str[len] != '\t' && str[len] != '\n' && str[len] != '\0'){
            new_len++;
            len++;
        }
        str_2d[i] = (char *)malloc(sizeof(char) * new_len);
        i++;
        len++;
    }

    row = 0;
    i = 0;
    len = 0; 

    while (row <= str_len)
    {   
        i = 0;
        while (str[row] != ' ' && str[row] != '\t' && str[row] != '\n' && str[row] != '\0'){
            str_2d[len][i] = str[row];
            i++;
            row++;
        }   
        row++;
        len++;
    }
    return str_2d;
}
