data = [normrnd(7,6,1,36), normrnd(8,6,1,36), normrnd(9,6,1,36), normrnd(7,6,1,36), normrnd(8,6,1,36), normrnd(9,6,1,36)];
groups = repelem({'Группа 1', 'Группа 2', 'Группа 3', 'Группа 4', 'Группа 5', 'Группа 6'}, 1, 36);

[p, tbl, stats] = anova1(data, groups);