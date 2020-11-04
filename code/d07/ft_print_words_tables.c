void	ft_putchar(char a);
char	**ft_split_whitespaces(char *str);

void	ft_print_words_tables(char **tab){
	int i;
	int j;

	i = 0;
	j = 0;

	while (tab[i]){
		j = 0;
		while(tab[i][j]){
			ft_putchar(tab[i][j]);
			j++;
		}
		ft_putchar('\n');
		i++;
	}
}

void main(){
	ft_print_words_tables(ft_split_whitespaces("Hello world!"));
}
