function count = lab3()
N = 7090;
count = zeros(6, 1);
 
for j = 1:N
    r = rand;
    if r <= 0.4
        a = 1;
    elseif r <= 0.4 + 0.288
        a = 2;
    elseif r <= 0.4 + 0.288 + 0.05
        a = 3;
    elseif r <= 0.4 + 0.288 + 0.05 + 0.19
        a = 4;
    elseif r <= 0.4 + 0.288 + 0.05 + 0.19 + 0.03
        a = 5;
    else a = 6;
    end
    count(a, 1) = count(a, 1) + 1;
end  
