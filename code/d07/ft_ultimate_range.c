char    ft_range(int **range, int min, int max){
    int i;
    int range_;
    int *range_num;

    range_ = max - min;

    range_num = 0;

    if (range_ <= 0){
        *range = 0;
        return range_num;
    }
        

    range_num = (int *)malloc(sizeof(int) * range_);

    while(min != max){
        range_num = min;
        min++;
    }

    *range = range_num;
    return range_num;
}