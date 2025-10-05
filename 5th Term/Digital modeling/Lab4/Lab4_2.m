
    tic;
    Nop = 9;        % количество вариантов параметров
    Nb = 10;         % количество компонентов
    Tz = 6e3;       % заданное время работы
    N = 10e4;        % количество симуляций
    ts = zeros(Nop, Nb);
    for j = 1:Nop
        ts(j, :) = [13e3; 21e3; 6e3; 5e3*j; 17e3; 25e3; 17e3; 13e3; 16e3; 8e3];
    end
    r = {[1,2,5,9], [1,3,5,9], [1,3,6,9], [1,3,6,10], [1,3,7,10], [1,4,7,10], [1,4,8,10]};
    len = length(r);
    P = zeros(Nop,1);
    Sr = zeros(Nop,1);
    Med = zeros(Nop,1);
    Mod = zeros(Nop,1);
    T_all = zeros(N, Nop);  % время наработки на отказ для каждой симуляции и варианта
    for i = 1:Nop
        count = 0;
        T = zeros(N,1);
        for k = 1:N
            t = exprnd(ts(i, :)');
            tmin = zeros(len,1);
            for m = 1:len
                tmin(m) = min(t(r{m}));
            end
            T(k) = max(tmin);
            if T(k) >= Tz
                count = count + 1;
            end
        end
        P(i) = count / N;
        Sr(i) = mean(T);
        Med(i) = median(T);
        [h, a] = hist(T, 137);
        [~, nmax] = max(h);
        if nmax == 1
            Mod(i) = a(1) / 2;
        else
            Mod(i) = (a(nmax-1) + a(nmax)) / 2;
        end
        T_all(:,i) = T;
    end
    figure;
    plot(5e3*(1:Nop), P, '-o');
    xlabel('Время наработки на отказ \tau_8');
    ylabel('Вероятность работы системы P');
    title('Зависимость вероятности работы системы от \tau_8');
    grid on;
    Tm = toc;

