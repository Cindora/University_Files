figure();
plot(Nqueue(:,1),Nqueue(:,2));
xlabel('t');
ylabel('N queue');
grid on;

figure();
plot(Lenqueue(:,1),Lenqueue(:,2));
xlabel('t');
ylabel('Len queue');
grid on;


figure();
plot(Wserver(:,1),Wserver(:,2));
xlabel('t');
ylabel('W server');
grid on;
