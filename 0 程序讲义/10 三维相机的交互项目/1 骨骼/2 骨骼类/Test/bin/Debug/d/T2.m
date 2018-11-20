d=load('16d.txt');
figure; hold on;
for i=1:size(d,1)
    plot3(d(i,1), d(i,2), d(i,3),'.','Color',d(i,5:7)/255 ); 
end

