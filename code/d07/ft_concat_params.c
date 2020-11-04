#include <stdlib.h>

char    *ft_concat_params(int argc, char **argv){
    char *str;
    int i;
    int j;
    int len;
    int a;

    i = 0;
    j = 0;
    len = 0;

    while(i != argc){
        j = 0;
        while (argv[i][j]){
            len++;
            j++;
        }
        len++;
        i++;
    }

    str = (char *) malloc(sizeof(char) * len);

    i = 0;
    a = 0;
    j = 0;

    while (i != argc){
        a = 0;
        while (argv[i][a]){
            str[j] = argv[i][a];
            j++;
            a++;
        }
        str[j] = '\n';
        j++;
        i++;
    }
    return str;
}
