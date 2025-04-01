using ComposicaoNotaFiscal;
ItemNotaFiscal it1 =new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(21);
NotaFiscal notaFiscal = new NotaFiscal(1,"01/04/2025");
notaFiscal.AdicionarItens(it1);
notaFiscal.AdicionarItens(it2);
notaFiscal.MostrarAtributos();


notaFiscal = null; // retirar a referencia de memoria
GC.Collect();// forçãr a chamada do destrutor




