char	**ft_split(char *str, char *charset){
	int i;
	int len;
	int j;
	bool check;

	i = 0;
	len = 0;
	j = 0;

	while(str[i]){
		while(charset[j]){
			if (charset[j] == str[i])
				check = 1;
		}
	
	}
}
