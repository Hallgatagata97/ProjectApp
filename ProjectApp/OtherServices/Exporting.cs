using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjectApp.Context;
using ProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp.OtherServices
{
    public class Exporting
    {
        ProjectContext context = new ProjectContext();
        MessageBoxes ms = new MessageBoxes();
        ServiceRepository sRepos;
        CompanyRepository cRepos;
        ProjectRepository pRepos;
        public Exporting(ProjectContext context)
        {
            this.context = context;
            this.ms = new MessageBoxes();
            this.sRepos = new ServiceRepository(context);
            this.cRepos = new CompanyRepository(context);
            this.pRepos = new ProjectRepository(context);
        }

        public void toPdf(DataGridView dgv, string headerText, string type, float[] columnWidth, bool isContext)
        {
            
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF fájl|*.pdf";
                save.Title = "Mentés";
                save.ShowDialog();
            try
            {
                using (FileStream stream = new FileStream(save.FileName, FileMode.OpenOrCreate))
                {
               
                    var errorText = new Paragraph("Nincs listázható adat!")
                    {
                        SpacingBefore = 30f,
                        SpacingAfter = 30f
                    };

                    var doc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);

                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f
                    };

                    var headerTable = new PdfPTable(new[] { 1f, 2f })
                    {
                        HorizontalAlignment = Element.ALIGN_LEFT,
                        WidthPercentage = 75,
                        DefaultCell = { MinimumHeight = 22f },
                    };

                    //Set header
                    iTextSharp.text.Font fh = FontFactory.GetFont("Century Gothic", 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));

                    var header = new Paragraph(headerText, fh);
                    header.Alignment = Element.ALIGN_CENTER;

                    //HeaderTable settings
                    headerTable.AddCell("Frissítés dátuma");
                    headerTable.AddCell(" " + DateTime.Now.ToShortDateString());
                    headerTable.AddCell(type + " száma");
                    headerTable.AddCell(" " + dgv.Rows.Count.ToString());

                    //add to Pdf (header & headertable)
                    doc.Add(header);
                    doc.Add(spacer);
                    doc.Add(headerTable);
                    doc.Add(spacer);

                    //DataTable settings
                    var columntCount = dgv.ColumnCount; //serviceDgv.ColumnCount;

                    //0, 0 a vége, mert A törlés, módosítás nem kell, hogy látszódjon

                    var table = new PdfPTable(columnWidth)
                    {
                        HorizontalAlignment = Element.ALIGN_LEFT,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }
                    };

                    var cell = new PdfPCell(new Phrase(type))
                    {
                        Colspan = columntCount,
                        HorizontalAlignment = 1,
                        MinimumHeight = 30f

                    };
                    //add headerCell To Table
                    table.AddCell(cell);



                    //create and fill columns
                    dgv.Columns
                        .OfType<DataGridViewColumn>()
                        .ToList()
                        .ForEach(c => table.AddCell(c.HeaderText));

                    if (isContext)
                    {
                        
                        doc.Add(errorText);
                        doc.Close();
                    }
                    else
                    {
                        
                        //create and fill rows
                        dgv.Rows
                        .OfType<DataGridViewRow>()
                        .ToList()
                        .ForEach(r =>
                        {
                            var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                            cells.ForEach(c => table.AddCell(c.Value.ToString()));
                        });

                        doc.Add(table);
                        doc.Close();
                    }
                    
                }
               
            }
            catch
            {

                ms.WarningMessage("Fájlnév megadása kötelező!");
            }



        }
    }
}
