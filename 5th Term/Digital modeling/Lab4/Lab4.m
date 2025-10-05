    tic;
    % заданные параметры
    ts = [13e3; 21e3; 6e3; 13e3; 17e3; 25e3; 17e3; 13e3; 16e3; 8e3];
    Tz = 6e3;
    N = 9e4;
    r = {[1,2,5,9], [1,3,5,9], [1,3,6,9], [1,3,6,10], [1,3,7,10], [1,4,7,10], [1,4,8,10]};
    count = 0;
    T = zeros(N, 1);
    for k = 1:N
        % генерация времен отказов компонентов
        t = exprnd(ts);
        tmin = zeros(length(r), 1);
        % расчет минимального времени для каждого пути
        for j = 1:length(r)
            components = r{j};
            tmin(j) = min(t(components));
        end
        % время отказа системы
        T(k) = max(tmin);
        % проверка на соответствие Tz
        if T(k) >= Tz
            count = count + 1;
        end
    end
    % расчёт
    P = count / N;
    Sr = mean(T);
    Med = median(T);
    [h, a] = hist(T, 137);
    [~, nmax] = max(h);
    if nmax == 1
        Mod = a(1) / 2;
    else
        Mod = (a(nmax-1) + a(nmax)) / 2;
    end
    % гистограмма
    hist(T, 137);
    title('Гистограмма времени наработки на отказ');
    xlabel('Время');
    ylabel('Частота');
    Tm = toc;

