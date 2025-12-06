clear; clc;

N = 500;
numPlots = 6;

lineStyles = {'-','--','-.',':','-','--'};
lineColors = lines(numPlots);

figure(1); hold on;
title('Экспоненциальное распределение µ = 1');
xlabel('X'); ylabel('Y');
axis equal;

for k = 1:numPlots
    U = [0 0];
    MasU = U;
    SumA = 0;

    for j = 1:N
        l = exprnd(1);
        dA = unifrnd(-pi, pi);
        SumA = SumA + dA;

        x = l * cos(SumA);
        y = l * sin(SumA);

        U = U + [x y];
        MasU = [MasU; U];
    end

    plot(MasU(:,1), MasU(:,2), ...
         'LineStyle', lineStyles{k}, ...
         'Color', lineColors(k,:), ...
         'LineWidth', 1.3, ...
         'DisplayName', ['Траектория ', num2str(k)]);
end

legend show;

figure(2); hold on;
title('Нормальное распределение µ = 2, sigma = 0.2');
xlabel('X'); ylabel('Y');
axis equal;

for k = 1:numPlots
    U = [0 0];
    MasU = U;
    SumA = 0;

    for j = 1:N
        l = abs(normrnd(1, 0.5));  % новый закон
        dA = unifrnd(-pi, pi);
        SumA = SumA + dA;

        x = l * cos(SumA);
        y = l * sin(SumA);

        U = U + [x y];
        MasU = [MasU; U];
    end

    plot(MasU(:,1), MasU(:,2), ...
         'LineStyle', lineStyles{k}, ...
         'Color', lineColors(k,:), ...
         'LineWidth', 1.3, ...
         'DisplayName', ['Траектория ', num2str(k)]);
end

legend show;
