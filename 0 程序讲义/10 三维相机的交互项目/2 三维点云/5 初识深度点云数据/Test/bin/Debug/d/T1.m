s=load('16s.txt');
%0  HipCenter£¨ÍÎ²¿ÖÐÐÄ£©      Spine£¨¼¹Öù£©,      ShoulderCenter    Head,          
%4  ShoulderLeft   ElbowLeft   WristLeft   HandLeft,       
%8  ShoulderRight  ElbowRight  WristRight  HandRight
%12 HipLeft,       KneeLeft,      AnkleLeft,     FootLeft
%16 HipRight,      KneeRight,     AnkleRight,    FootRight
figure; hold on;
plot3(s(1:4,1), s(1:4,2), s(1:4,3),'r*-'); 
plot3(s(5:8,1), s(5:8,2), s(5:8,3),'r*-'); 
plot3(s(9:12,1), s(9:12,2), s(9:12,3),'r*-'); 
plot3(s(13:16,1), s(13:16,2), s(13:16,3),'r*-'); 
plot3(s(17:20,1), s(17:20,2), s(17:20,3),'r*-'); 
d=load('16d.txt');
plot3(d(:,1), d(:,2), d(:,3),'.'); 
