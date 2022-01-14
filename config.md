
 ## Prioriteti za emisiju/film/seriju
 
|Prioritet  | h  | opis | primjer
|--|--|--|--|
|9  | 0 |  mora poceti odmah kad je zadana | |
|8  | +- 20 sec |  (1 reklama moguca) | Dnevnik |
|7  | +- 5 min |  (blok  reklama moguc) | Kviz|

  
## Globalni termini

	Ako je prioritet emisije/filma/serije < 7, termin se generira u odabranom 
	dobu dana umjesto da se kao gore definira tocno vrijme emitiranja
	
|Doba dana| Prioritet   | opis | primjer
|--|--|--|--|
|Radnidan::jutro  | 4 |   | |
|Radnidan::dan| 3 |  | |
|Radnidan::vecer| 5 | počinje u 20:00h | |
|Noc| 1 | 01:00 - 06:00  |  |
|Vikend::dan| 5 |   |  |
|Vikend::vecer| 6 | počinje u 20:00h  |  |



  
## Vrsta reklame
Za reklame, bira se prioritet,te se cijena automatski generira ovisno o tome
gdje je reklama ubacena.

|Prioritet  | Preferirani termin  | opis 
|--|--|--|
|9  | DA/Ima prioritet | ide bilogdje (ako termin filma/emisije to dopusta) |  
|8  | DA/Ima manji prioritet |  isto/manja cijena | |
|7  | DA | limit na duzinu |
|6,5,4,3..  | NE |  bira se  Doba dana umjesto termina |

	Ukoliko za reklame istog prioriteta nema mjesta u tom terminu, toj reklami se
	snizava prioritet prije odredivanja cijene i bira novi termin.


 ## Cijena reklame

Jednom kada se odredi koje reklame su ubacene u koji termin,cijene pojedinih reklama se
odreduju:
 
		 for(za svaku emisiju koja omeduje taj termin)
			 S +=(prioritet_emisije*gledanost) 
		 S *= Prioritet_reklame
		 
		 Pametnije racunanje cijene?? 
		 Uvesti varijablu za popularnost termina/broj postojecih reklama u terminu?
	 
