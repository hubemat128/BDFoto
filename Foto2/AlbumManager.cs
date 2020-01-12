using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMatuszewski.PhotoAlbum
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;

    public partial class AlbumManager : Form
    {
        private BindingList<Album> _albums = new BindingList<Album>();

        public AlbumManager()
        {
            InitializeComponent();
       

        }

        private void AlbumManagerLoaded(object sender, EventArgs e)
        {
            AlbumList.DataSource = _albums;

            LoadPreImportedPhotos();


        }

        private void LoadPreImportedPhotos()
        {
            _albums.Add(new Album(){Name = "PreImportedPhotos"});
            _albums.Add(new Album(){Name = "Empty Head"});
            AlbumList.Refresh();
        }


        private void AlbumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SelectAlbum_Click(object sender, EventArgs e)
        {
            var albumView =  new AlbumView(AlbumList.SelectedItem.ToString());
            albumView.Show();
        }
    }

    public class Album
    {
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }
}
