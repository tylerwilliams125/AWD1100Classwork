using Microsoft.VisualBasic.ApplicationServices;

namespace FinalProject2
{
    public partial class frmMainPage : Form
    {
        BookContext bookData;
        List<Book> bookList;
      private int pageIndex = 0;

        private int itemsPerPage = 5;

        string[] authors = { "Select an Author", "Boichi","Gege Akutami", "Eiichiro Oda"  };

        string[] images =
        {
         
            "C:\\Users \\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\01-Ken.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\02-DrStone.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\03-Origin_(manga)_1.png",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\04-Jujutsu_Kaisen_0_Cover.png",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\05-Volume_8.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\06-Volume_1.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\07-Volume_4.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\08-Volume_5.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\09-Volume_7.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\10-Volume_14.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\11-Volume_17.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\12-Volume_22.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\13-Volume_85.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\14-Volume_86.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\15-Volume_87.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\16-Volume_88.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\17-Volume_89.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\18-Volume_90.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\19-Volume_91.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\20-Volume_92.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\21-Volume_93.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\22-Volume_94.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\23-Volume_95.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\24-Volume_96.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\25-Volume_97.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\26-Volume_98.jpg",
            "C:\\Users\\DANTE\\Desktop\\AWD1100Classwork\\Final\\FinalProject2\\FinalProject2\\BookCovers\\27-Volume_99.jpg"
,



        };
        public frmMainPage()
        {
            bookData= new BookContext();
            InitializeComponent();
        }



        private void btnSplash_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSplash splash = new frmSplash();
            splash.Show();

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isValid = CheckForNoInput();

            if (isValid)
            {
                CheckForTooMuchInput();
            }

            else
            {
                return;  
            }

            if (isValid)
            {
                if (txtSearch.Text.Trim() != "")
                {
                    PerformTitleOrISBNCheck();
                }

                else
                {
                    PerformAuthorCheck();
                }
            }
        }

        private bool CheckForNoInput()
        {
            bool retVal = true;

            if ((txtSearch.Text.Trim() == "") &&
                (cboAuthor.SelectedIndex <= 0)) 
            {
                DialogResult dialog = MessageBox.Show ("You Must Enter a Book name or ISBN or Select an Author", "NO SEARCH VALUE PROVIDED");
                retVal = false;
            
            }
            return retVal;
        }
        private bool CheckForTooMuchInput()
        {
            bool retVal = true;

            if ((txtSearch.Text.Trim() != "") &&
                (cboAuthor.SelectedIndex > 0))
            {
                DialogResult dialog = MessageBox.Show("You Cannot us both the text box and combobox to look for a book",
                    "TOO MANY SEARCH VALUES");

                txtSearch.Text = "";
                cboAuthor.SelectedIndex = 0;
                retVal = false;

            }
            return retVal;
        }

       private void PerformTitleOrISBNCheck()
        {
            string firstFour = txtSearch.Text.Substring(0, 4);

            if (firstFour != "978-")
            {
                DialogResult dialog = MessageBox.Show("Not a Valid ISBN", "INVALID ISBN");
                txtSearch.Text = "";
                txtSearch.Focus();
                return;
            }
 
            bookList = bookData
                        .Books
                        .Where(e => e.Isbn == txtSearch.Text)
                        .Select(e => e)
                        .Skip(pageIndex * itemsPerPage)
                        .Take(itemsPerPage)
                       
                         .ToList();

            dgvBooks.DataSource = bookList.ToList();
        }

        private void PerformAuthorCheck()
        {
            string selectedAuthor = cboAuthor.Text;
            bookList = bookData
                .Books
                .Where(e => e.AuthorName== selectedAuthor)
                .Select(e => e)
                .Skip(pageIndex * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            
            dgvBooks.DataSource = bookList.ToList();
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                pageIndex =- 0;
           
            }

            if (pageIndex > 1)
            {
                pageIndex =+ 1;

            }



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)dgvBooks.Rows.Count / itemsPerPage);

            if (pageIndex < totalPages - 1)
            {
                pageIndex = 1;
                
            }

            if (pageIndex < totalPages - 2)
            {
                pageIndex = 2;
             
            }
        }

      



        

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            FillUpComboBox();
        }

        private void FillUpComboBox()
        {
            foreach (string author in authors)
            {
                cboAuthor.Items.Add(author);
            }
            cboAuthor.SelectedIndex = 0;
        }


        private void fillUpGlobalVariables()
        {
            string? id = dgvBooks.SelectedRows[0].Cells[0].Value.ToString();
            string? isbn = dgvBooks.SelectedRows[0].Cells[1].Value.ToString();
            string? authorName = dgvBooks.SelectedRows[0].Cells[3].Value.ToString();
            string? bookName = dgvBooks.SelectedRows[0].Cells[2].Value.ToString();
            string? publishYear= dgvBooks.SelectedRows[0].Cells[4].Value.ToString();
            int? idInt = Int32.Parse(id);
            string? img = images[(int)idInt];

            frmDetails Details = new frmDetails();
            Details.isbn = isbn;
            Details.authorName = authorName;
            Details.bookName = bookName;
            Details.publishYear = publishYear;
            Details.img = img;
            Details.Show();

        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp help = new frmHelp();
            help.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            fillUpGlobalVariables();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
             "Do You Really Want To Exit The Program?", "EXIT NOW?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        
       
    }   

}