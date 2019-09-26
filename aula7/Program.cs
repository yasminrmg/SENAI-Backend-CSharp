using System;
using System.Drawing;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criação do documento
                Document exemploDoc = new Document(); 
            #endregion

            #region 
                //Adiciona uma seção com nome secaoCapa ao documento
                //Cada secao pode ser entendida como uma pagina do Documento
                Section secaoCapa = exemploDoc.AddSection();

            #endregion

            #region Criar um paragrafo
                //Cria um paragrafo com o nome titulo e adiciona a secao secaoCapa
                //os paragrafos sao necessarios para insercao de textos, imagens, tabelas e etc
                Paragraph titulo = secaoCapa.AddParagraph();
            #endregion

            #region Adiciona texto ao paragrafo
                //Adiciona o texto Exemplo de titulo ao paragrafo titulo
                titulo.AppendText("Exemplo de título\n\n");
            #endregion

            #region Formatar paragrafo
                // Através da propriedade HorizontalAlignment, é possivel alinhar o parágrafo
                titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

                //Cria um estilo com o nome estilo01 e adiciona ao documento
                ParagraphStyle estilo01 = new ParagraphStyle(exemploDoc);

                //Adiciona um nome ao estilo01
                estilo01.Name = "cor do titulo";

                //Definir a cor do titulo
                estilo01.CharacterFormat.TextColor = Color.DarkBlue;

                //Define que o texto será em negrito
                estilo01.CharacterFormat.Bold = true;

                //Adiciona o estilo01 ao Documento exemploDoc
                exemploDoc.Styles.Add(estilo01);

                //Aplica o estilo01 ao paragrafo titulo
                titulo.ApplyStyle(estilo01.Name);

                #region Trabalhar com Tabulacao
                    //Adiciona paragrafo textoCapa a secaoCapa
                    Paragraph textoCapa = secaoCapa.AddParagraph();
                    
                    // Adiciona um texto ao paragrafo com tabulacao
                    textoCapa.AppendText("\tEste é um exemplo de texto com tabulção\n");

                    //adiciona um novo paragrafo textocapa2 com concatenacao
                    Paragraph textoCapa2 = secaoCapa.AddParagraph();

                    textoCapa2.AppendText("\t Basicamente, entao, uma secao representa uma pagina do documento e os paragrafos dentro de uma mesma secao,"+" obviamente, aparecem na mesma pagina");
                #endregion


                #region Inserir Imagem
                    //adiciona um texto ao paragrafo imagemCapa
                    Paragraph imagemCapa = secaoCapa.AddParagraph();

                    //adiciona um texto ao paragrafo imagemCapa
                    imagemCapa.AppendText("\n\n\tAgora vamos inserir uma imagem ao documento\n\n");

                    //acentraliza horizontalmente o paragrafo imagemCapa
                    imagemCapa.Format.HorizontalAlignment = HorizontalAlignment.Center;

                    //adiciona uma imagem com o nome imagemExemplo ao paragrafo imagemCapa
                    DocPicture imagemExemplo = imagemCapa.AppendPicture(Image.FromFile(@"saida\img\logo_csharp.png"));

                    //Define uma largura e uma altura para a imagem
                    imagemExemplo.Width = 300;
                    imagemExemplo.Height = 300;
                #endregion

                #region Adicionar nova secao
                    //Adiciona uma nova secao
                    Section secaoCorpo = exemploDoc.AddSection();

                    //Adiciona um paragrafo a secao secaoCorpo
                    Paragraph paragrafoCorpo1 = secaoCorpo.AddParagraph();

                    //cria um paragrafo
                    paragrafoCorpo1.AppendText("\tEste é um exemplo de um paragrafo criado em uma nova secao."+"\tComo foi criada uma nova seção, perceba que este texto aparece em uma nova pagina.");
                #endregion

                #region Adicionar uma tabela
                    //Adiciona uma tabela a secao secaoCorpo
                    Table tabela = secaoCorpo.AddTable(true);

                    //Cria o cabecalho da tabela
                    String[] cabecalho = {"Item", "Descricao", "Quantidade", "Preço Unit.", "Preço"};

                    String[][] dados = {
                        new String[]{"Cenoura","Vegetal muito nutritivo","1","R$ 4,00", "R$ 4,00"},    
                        new String[]{"Batata","Vegetal muito consumido","2","R$ 5,00", "R$ 10,00"},    
                        new String[]{"Alface","Vegetal utilizado desde 500 a.C.","1","R$ 1,50", "R$ 1,50"},    
                        new String[]{"Tomate","Tomate é uma fruta","2","R$ 6,00", "R$ 12,00"}
                    };

                    //adiciona as celulas na tabela
                    tabela.ResetCells(dados.Length + 1, cabecalho.Length);
                    
                    //Adiciona uma linha na posicao [0] do vetor de linhas
                    //E define que esta linha é o cabecalho
                    TableRow Linha1 = tabela.Rows[0];
                    Linha1.IsHeader = true;

                    //define a altura da linha
                    Linha1.Height = 23;

                    //Formatação do cabecalho
                    Linha1.RowFormat.BackColor = Color.AliceBlue;

                    //percorre as colunas do cabecalho
                    for (int i = 0; i < cabecalho.Length; i++)
                    {
                        Paragraph p = Linha1.Cells[i].AddParagraph();
                        Linha1.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        p.Format.HorizontalAlignment = HorizontalAlignment.Center;

                        //formatacao dos dados do cabecalho
                        TextRange TR = paragrafoCorpo1.AppendText(cabecalho[i]);
                        TR.CharacterFormat.FontName = "Calibri";
                        TR.CharacterFormat.FontSize = 14;
                        TR.CharacterFormat.TextColor = Color.Teal;
                        TR.CharacterFormat.Bold = true;
                    }

                    for (int r = 0; r < dados.Length; r++)
                    {
                        TableRow LinhaDados = tabela.Rows[r+1];

                        LinhaDados.Height = 20;

                        for (int c = 0; c < dados[r].Length; c++)
                        {
                            //Alinha as celulas 
                            LinhaDados.Cells[c].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

                            //Preencher os dados nas linhas
                            Paragraph p2 = LinhaDados.Cells[c].AddParagraph();

                            TextRange TR2 = p2.AppendText(dados[r][c]);

                            //Formata celulas
                            p2.Format.HorizontalAlignment=HorizontalAlignment.Center;
                            TR2.CharacterFormat.FontName = "Calibri";
                            TR2.CharacterFormat.FontSize = 12;
                            TR2.CharacterFormat.TextColor = Color.Brown;
                        }
                    }
                    
                #endregion

                #region Salvar arquivo
                    //Salva o arquivo em .Docx
                    //Utiliza o método SaveToFile para salvar o arquivo no formato desejado
                    //assim como no word, caso ja exista um arquivo com este nome, é substituido
                    exemploDoc.SaveToFile(@"saida\exemplo_arquivo_word.docx", FileFormat.Docx);

                #endregion
                #endregion

        }
    }
}