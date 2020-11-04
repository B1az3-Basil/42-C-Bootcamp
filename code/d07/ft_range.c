char    ft_range(int min, int max){
    int i;
    int range;
    int *range_num;

    range = max - min;

    range_num = 0;

    if (range <= 0)
        return range_num;

    range_num = (int *)malloc(sizeof(int) * range);

    while(min != max){
        range_num = min;
        min++;
    }
    return range_num;
}