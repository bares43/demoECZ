using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinDemoECZ.ViewModels {
    public class MainPageViewModel : BaseViewModel {

        public ObservableCollection<Item> Items { get; set; }

        public MainPageViewModel() {
            Items = new ObservableCollection<Item> {
                new Item {
                    Content = @"
Ahoj, <br>
dnes jsem porovnávala seznamy hráčů v XPS a na webu, aby to bylo všude <strong>stejné</strong>. Prosím ještě jednou o kontrolu, kdyby vám tam někdo chyběl nebo naopak přebýval.<br>
+ jsem doplňovala veškeré zdravotní prohlídky a dodatky k přihlášce, které mám u sebe.  Pokud doma ještě některé máte, domluvíme se na předání.<br>
<br>
Díky a užívejte poslední dny tohoto roku :-)
"},
                new Item {
                    Content = @"
Ahoj trenéři,<br>
tento email rozešlete mezi rodiče svých svěřenců. V příloze máte tabulku s obsazenými čísly. Při objednávkách dejte pozor, aby se čísla neopakovala!<br>
<br>
Připravujeme pro vás velkou objednávku klubových věcí.<br>
Například pokud nový člen touží po vlastním dresu nebo stávajícímu členovi nevyhovuje velikost či jako rodiče máte zájem o klubové věci, se kterými byste jezdili fandit na zápasy, tak kontaktujte trenéra. Na dresu je možné mít příjmení a vámi zvolené číslo, které již nebude obsazené.<br>
<br>
Nabízíme možnost objednání těchto věcí:<br>
<br>
Dres (černý, bílý) - 400 Kč<br>
Dresové kraťasy (černé, bílé, růžové) - 300 Kč<br>
Zápasové štulpny - 150 Kč<br>
Tréninkové triko (modré - pouze doprodej, černé) - 400 Kč<br>
Čelenka - 50 Kč<br>
Tepláková souprava (mikina na zip + tepláky) - 1000 Kč<br>
             - možnost kombinace různých velikostí mikiny a tepláků<br>
             - možné objednat pouze mikinu (650 Kč) nebo pouze tepláky (550 Kč)<br>
<br>
Objednávky zasílejte formou  počet, druh oblečení, barva, velikost + číslo (dres, kraťasy, teplákové soupravy)<br>
Konec objednávek 26.11.2017.
" },
                new Item {
                    Content = @"
Ahoj, <br>
dnes jsem porovnávala seznamy hráčů v XPS a na webu, aby to bylo všude <strong>stejné</strong>. Prosím ještě jednou o kontrolu, kdyby vám tam někdo chyběl nebo naopak přebýval.<br>
+ jsem doplňovala veškeré zdravotní prohlídky a dodatky k přihlášce, které mám u sebe.  Pokud doma ještě některé máte, domluvíme se na předání.<br>
<br>
Díky a užívejte poslední dny tohoto roku :-)
"},
                new Item {
                    Content = @"
Ahoj trenéři,<br>
tento email rozešlete mezi rodiče svých svěřenců. V příloze máte tabulku s obsazenými čísly. Při objednávkách dejte pozor, aby se čísla neopakovala!<br>
<br>
Připravujeme pro vás velkou objednávku klubových věcí.<br>
Například pokud nový člen touží po vlastním dresu nebo stávajícímu členovi nevyhovuje velikost či jako rodiče máte zájem o klubové věci, se kterými byste jezdili fandit na zápasy, tak kontaktujte trenéra. Na dresu je možné mít příjmení a vámi zvolené číslo, které již nebude obsazené.<br>
<br>
Nabízíme možnost objednání těchto věcí:<br>
<br>
Dres (černý, bílý) - 400 Kč<br>
Dresové kraťasy (černé, bílé, růžové) - 300 Kč<br>
Zápasové štulpny - 150 Kč<br>
Tréninkové triko (modré - pouze doprodej, černé) - 400 Kč<br>
Čelenka - 50 Kč<br>
Tepláková souprava (mikina na zip + tepláky) - 1000 Kč<br>
             - možnost kombinace různých velikostí mikiny a tepláků<br>
             - možné objednat pouze mikinu (650 Kč) nebo pouze tepláky (550 Kč)<br>
<br>
Objednávky zasílejte formou  počet, druh oblečení, barva, velikost + číslo (dres, kraťasy, teplákové soupravy)<br>
Konec objednávek 26.11.2017.
"
                }
            };
        }
    }

    public class Item {
        public string Content { get; set; }
    }

}
