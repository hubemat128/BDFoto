namespace HMatuszewski.PhotoAlbum
{
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AlbumView : Form
    {
        public AlbumView(string album)
        {
            InitializeComponent();

            // Initialize myListView.
            PhotoList.Dock = DockStyle.Fill;
            PhotoList.View = View.Tile;

            // Initialize the tile size.
            PhotoList.TileSize = new Size(200, 100);

            // Initialize the item icons.
            ImageList = new ImageList();

            if (album == "PreImportedPhotos")
            {
                var root = Application.StartupPath;
                var preImported = Path.Combine(root, "PreImportedPhotos");

                var images = Directory.EnumerateFiles(preImported).ToList();


                foreach (var image in images)
                {
                    var renFace = Image.FromFile(image);
                    ImageList.Images.Add(renFace);
                    PhotoList.Items.Add(new ListViewItem(new[] {Path.GetFileName(image)}, PhotoList.Items.Count));
                }


                ImageList.ImageSize = new Size(100, 100);
                PhotoList.LargeImageList = ImageList;

                // Add column headers so the subitems will appear.
                PhotoList.Columns.AddRange(new[]
                    {new ColumnHeader()});
            }
           


        }
    }
}