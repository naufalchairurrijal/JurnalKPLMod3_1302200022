// See https://aka.ms/new-console-template for more information
using JurnalMod3Kpl_1302200022;

KodeBuah buah = new KodeBuah();

Console.WriteLine(KodeBuah.NamaBuah.Apel);
Console.WriteLine(buah.Kode(KodeBuah.NamaBuah.Apel));

Console.WriteLine(KodeBuah.NamaBuah.Aprikot);
Console.WriteLine(buah.Kode(KodeBuah.NamaBuah.Aprikot));

Console.WriteLine(KodeBuah.NamaBuah.Alpukat);
Console.WriteLine(buah.Kode(KodeBuah.NamaBuah.Alpukat));

Console.WriteLine(KodeBuah.NamaBuah.Pisang);
Console.WriteLine(buah.Kode(KodeBuah.NamaBuah.Pisang));


PosisiKarakterGame StatusKarakter = new PosisiKarakterGame();
Console.WriteLine(StatusKarakter.currentState);

StatusKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
StatusKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolS);