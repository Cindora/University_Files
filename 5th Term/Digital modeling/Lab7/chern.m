    P0 = ones(1,6)/6;
    Tm = 101;
    A = [0.3 0.6 0.1 0   0   0;
     0   0.9 0.1 0   0   0;
     0   0.5 0.5 0   0   0;
     0   0.1 0   0.4 0.3 0.2;
     0   0   0   0.4 0.1 0.5;
     0.2 0   0   0   0   0.8];
    z = rand;
    Pos = cumsum(P0);
    k = 1;
    while z > Pos(k)
        k = k + 1;
    end
    State(1) = k;
    for ks = 2:Tm
        p = A(State(ks-1), :);
        ps = cumsum(p);
        z = rand;
        k = 1;
        while z > ps(k)
            k = k + 1;
        end
        State(ks) = k;
    end
    t = 0:Tm-1;
    figure();
    
    stairs(t, State)
xlabel('t');
    ylabel('State');
