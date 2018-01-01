# IPTVTocomSat
IPTV TocomSat es un programa sencillo de consola, que toma una lista de URLs de un txt llamado IPTV.txt
que debe de ubicarse en el mismo lugar donde se extraiga el programa.
Luego, el programa Toma las lineas donde existan URLs y crea un archivo llamado lista con el formato requerido por los receptores.

# Ejemplo

Si tenemos una lista como la siguiente:

http://url1.com/canalcualquiera

http://url2.com/canalcualquiera2

http://url3.com/canalcualquiera3

http://url4.com/canalcualquiera4

El programa crea el archivo lista.txt con el formato correcto admitido por el receptor, teniendo
la siguiente forma:

[Tocom_URL_LIST]

NAME= Canal 0; URL=http://url1.com/canalcualquiera;

NAME= Canal 1; URL=http://url2.com/canalcualquiera2;

NAME= Canal 2; URL=http://url3.com/canalcualquiera3;

NAME= Canal 3; URL=http://url4.com/canalcualquiera4;

# Ejemplo 2

Tambien podemos tener una lista con el siguiente formato:

#EXTINF:-1,Internacional:Canal cualquiera

http://unaruta.com/Canales/canal.m3u8

#EXTINF:-1,Internacional:Canal cualquiera 2

http://unaruta.com/Canales/canal2.m3u8

#EXTINF:-1,Internacional:Canal cualquiera 3

http://unaruta.com/Canales/canal2.m3u8

Y el programa generara el archivo lista con el formato siguiente:

[Tocom_URL_LIST]

NAME= Canal 0; URL=http://unaruta.com/Canales/canal.m3u8;

NAME= Canal 1; URL=http://unaruta.com/Canales/canal2.m3u8;

NAME= Canal 2; URL=http://unaruta.com/Canales/canal2.m3u8;

# Ejemplo 2

Receptores que aceptan este formato:

TocomSat Combate HD

TocomSat Phoenix IPTV

TocomBox Goool HD

TocomBox Goool HD Plus

TocomBox Zeus IPTV
