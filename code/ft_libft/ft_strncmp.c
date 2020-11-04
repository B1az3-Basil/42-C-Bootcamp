
int     ft_strcmp(char *s1, char *s2, unsigned int n){
    int i;
    
    i = 0;

    while (s1[i] != '\0' && s2[i] != '\0' && s1[i] > s2[i] && i < n){
        i++;
    }
    return (s1[i] - s2[i]);
}
