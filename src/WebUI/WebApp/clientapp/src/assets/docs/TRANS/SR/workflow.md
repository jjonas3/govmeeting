<!-- Do not edit this file. It was translated by Google. -->

<p> Испод је функционалан опис главних делова софтвера. </p>
<h2> Индивидуална регистрација </h2>
<ul>
<li> Током регистрације, корисници наводе своју матичну локацију (град, град, село, поштански број итд.). </li>
<li> На основу њихове локације, систем одређује субјекте управљања којима припадају. (држава, држава, жупанија, град / град итд.) </li>
</ul><h2> Регистрација државних органа </h2>
<ul>
<li> Корисник може регистровати било који орган управе којем припада. </li>
<li> Унесене информације ће укључивати: 
<ul>
<li> Вебсите УРЛ </li>
<li> Имена владајућих званичника </li>
<li> УРЛ адреса где се могу пронаћи транскрипти или снимци састанака </li>
</ul></li>
<li> Остали корисници ове локације видеће већ унесене податке. Могу гласати о тачности било које ставке података и уносити алтернативне вредности. </li>
<li> Гласови ће се сакупљати за сваку вредност података. Вредности са највише гласова постају званичне вредности. <a href="https://github.com/govmeeting/govmeeting/issues/62">Гитхуб број 62</a> </li>
</ul><h2> Увези снимке или транскрипте </h2>
<ul>
<li> Систем ће редовно преузимати постојеће интернетске снимке или транскрипте са локација наведених у регистрацији државне власти. </li>
<li> Корисници такође имају могућност слања снимака или транскрипата. </li>
<li> Многа места не пружају транскрипте ни записе са својих састанака. Говмеетинг ће пружити паметну апликацију коју корисници могу да користе за лично снимање и учитавање снимка састанка. <a href="https://github.com/govmeeting/govmeeting/issues/18">Гитхуб број 18</a> </li>
</ul><h2> Предрадња постојећих транскрипата </h2>
<ul>
<li> Претворите транскрипте у обичан текст. Често се постојећи транскрипти налазе у другим форматима као што је ПДФ. Они се претварају у обичан текст тако да се лакше обрађују. </li>
<li> Издвојите информације као што су називи звучника и секција. </li>
</ul><h2> Преписујте снимке помоћу препознавања говора </h2>
<ul>
<li> Претворите снимке у примарне формате веб видео записа (мп4, огг и вебм.) Што их чини приступачнијим на свим врстама уређаја. </li>
<li> Издвојите и спојите аудио записе ако их је више. </li>
<li> Пренесите аудио датотеку у Гоогле Цлоуд стораге да бисте се припремили за транскрипцију. </li>
<li> Позовите асинхрони Гоогле Спеецх АПИ да бисте аутоматски препознали глас. </li>
<li> Извршите препознавање промене звучника. За то постоји Гоогле АПИ. </li>
<li> Додајте идентификацију звучника. Ово ће користити софтвер за обраду говора на серверу. </li>
<li> Ставите информације у ЈСОН формат ради даље обраде. </li>
<li> Поделите видео, аудио и датотеке транскрипта на 3 минуте радне сегменте тако да више волонтера може истовремено радити на лекторирању. </li>
</ul><h2> Проверено читање преписаног текста [Ручни корак] </h2>
<ul>
<li> Исправни текст за грешке. Омогућите кориснички интерфејс за брзо исправљање грешака. </li>
<li> Тачне информације као што су називи звучника и секција. </li>
</ul>
<p> Говмеетинг покушава да обраду учини што је могуће аутоматском. Али рачунари још увек нису тако паметни као што бисмо желели. Људи су и даље потребни да исправе своје грешке. Али сваким даном су рачунари све паметнији и тај посао би требао бити све мање и мање. </p>
<h2> Додавање ознака броја [Ручни корак] </h2>
<ul>
<li> Један од најважнијих послова је правилно додавање тагова или метаподатака у транскрипт. То је оно што омогућава: 
<ul>
<li> информација која се лако налази. </li>
<li> транскрипт који се брзо индексира и прегледа </li>
<li> упозорења која треба да постави корисник о одређеним проблемима </li>
</ul></li>
<li> Имена проблема треба да додељују људи, а не рачунари. То је најбољи начин да се осигура њихово значење. </li>
<li> Важно је да се обезбеди веома једноставан за употребу и брз кориснички интерфејс. </li>
</ul>
<p> У будућности можда овај корак првенствено може да уради и рачунар. Али није све лоше што треба неки ручни рад волонтера из заједнице. Помаже уједињавању људи ради заједничког разлога. Ако је ово мали град од 35.000, не би требало бити толико тешко уписати десетак или тако да се сваки месец даје кратко време. </p>
<h2> Популацијска база података </h2>
<p> Подаци се стављају у релацијску базу података тако да се њима може брзо приступити користећи више критеријума. </p>
<h2> Подаци су сада доступни за употребу </h2>
<ul>
<li> Сада је доступан транскрипт који може претраживати и претраживати </li>
<li> Сажетак питања о којима се расправља на састанку шаље се онима који га захтевају. </li>
<li> Упозорења се шаљу о одређеним питањима онима који га траже. </li>
</ul><h2> Договорен је виртуални састанак. </h2>
<ul>
<li> Дневни ред се ствара на основу питања на стварном састанку. </li>
<li> Позивнице се шаљу члановима заједнице. </li>
<li> У позивницу су укључени и захтеви за могуће додатне тачке дневног реда. </li>
<li> Када се добију одговори, гласачким листићем се шаље онима који ће присуствовати. На овом гласању чланови могу гласати о предложеним новим тачкама дневног реда. </li>
<li> За неколико дана одржава се виртуелни састанак. </li>
</ul><h2> Управљање током рада </h2>
<p> Неке од горњих корака процеса рада аутоматски обавља рачунар, а неке ручно обављају волонтери. На радном току постоје места на којима стварна особа треба да провери да ли је у реду да настави: </p>

<ul>
<li> Проверите да ли су УРЛ-ови за преузимање преписа и снимака важећи. </li>
<li> Проверите да ли је садржај преузетих датотека валидан. </li>
<li> Уверите се да је излаз из предрадње изгледа валидан. </li>
<li> Проверите да ли је претварање говора у текст валидно. </li>
<li> Проверите да ли је лекторирање транскрипта изгледало завршено. </li>
<li> Проверите да ли је додавање ознака у транскрипт завршено. </li>
<li> Проверите да ли су коначни подаци транскрипта потпуни и валидни. </li>
</ul>
<p> Мора постојати начин да се права једног или више регистрованих корисника локације ставе на положај "менаџера". </p>

<ul>
<li> Менаџери би били обавештени кад год се одлука донесе у току рада. </li>
<li> Тада се менаџер може пријавити и дати или одбити одобрење за наставак рада. </li>
</ul>
